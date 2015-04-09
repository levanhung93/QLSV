using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class SinhVienThucTap : UserControl
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng SinhVienAttribute
        /// </summary>
        SinhVienAttribute svAttribute = new SinhVienAttribute();
        /// <summary>
        /// khởi tạo đối tượng SinhVienController
        /// </summary>
        SinhVienController svController = new SinhVienController();

        #endregion Field

        #region Constructor
        public SinhVienThucTap()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBtnThemSVClick(object sender, EventArgs e)
        {
            LockCombobox();
            LoadMaSinhVien();
        }

        private void OnCboSinhVienSelecdIndexChanged(object sender, EventArgs e)
        {
            svAttribute.MaSV = _cboMaSinhVien.Text;
            foreach (DataRow item in svController.GetFullSinhVien(svAttribute).Rows)
            {
                _txtTenSinhVien.Text = item["TenSV"].ToString();
                _txtNgaySinhSV.Text = item["Ngay"].ToString();
                _txtThangSinhSV.Text = item["Thang"].ToString();
                _txtNamSinhSV.Text = item["Nam"].ToString();
                _txtLop.Text = item["TenLop"].ToString();
                _txtKhoaHoc.Text = item["KhoaHoc"].ToString();
                _txtGioiTinhSV.Text = item["GioiTinh"].ToString();
                _txtDiachiSV.Text = item["DiaChi"].ToString();
                _txtDienThoaiSV.Text = item["DienThoai"].ToString();
                _txtEmailSV.Text = item["Email"].ToString();
            }
        }

        private void OnSinhVienThucTapLoad(object sender, EventArgs e)
        {
            _dgvSinhVien.DataSource = svController.ShowSinhVien();
            _txtTongBanGhi.Text = _dgvSinhVien.Rows.Count.ToString();
        }

        private void OnBtnLuuSVClick(object sender, EventArgs e)
        {
            svAttribute.MaSV = _cboMaSinhVien.Text;
            svAttribute.TenSV = _txtTenSinhVien.Text;
            svAttribute.NgaySinh = Int32.Parse(_txtNgaySinhSV.Text);
            svAttribute.ThangSinh = Int32.Parse(_txtThangSinhSV.Text);
            svAttribute.NamSinh = Int32.Parse(_txtNamSinhSV.Text);
            svAttribute.GioiTinh = _txtGioiTinhSV.Text;
            svAttribute.Lop = _txtLop.Text;
            svAttribute.KhoaHoc = _txtKhoaHoc.Text;
            svAttribute.DiaChi = _txtDiachiSV.Text;
            svAttribute.DienThoai = _txtDienThoaiSV.Text;
            svAttribute.Email = _txtEmailSV.Text;
            svController.InsertSinhVien(svAttribute);
            svController.InsertTaiKhoan(svAttribute);
            OnSinhVienThucTapLoad(sender, e);
        }
        #endregion Event

        #region Method
        /// <summary>
        /// thực hiện việc load Mã sinh viên lên _cboMaSinhVien
        /// </summary>
        public void LoadMaSinhVien()
        {
            _cboMaSinhVien.DataSource = svController.LoadMaSinhVien(svAttribute);
            _cboMaSinhVien.DisplayMember = "MaSV";
            _cboMaSinhVien.ValueMember = "MaSV";
        }

        public void LockCombobox()
        {
            _cboMaSinhVien.Enabled = true;
        }
        #endregion Method

    }
}

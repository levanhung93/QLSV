using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class GiaoVienHuongDan : UserControl
    {
        #region Field

        /// <summary>
        /// khởi tạo đối tượng gvAttribute
        /// </summary>
        GiaoVienAttribute gvAttribute = new GiaoVienAttribute();

        /// <summary>
        /// khởi tạo đối tượng gvController
        /// </summary>
        GiaoVienController gvController = new GiaoVienController();

        #endregion Field

        #region Constructor
        public GiaoVienHuongDan()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBtnThemGVClick(object sender, EventArgs e)
        {
            LockCombobox();
            LoadGiaoVien();
        }

        private void OnCboMaGiaoVienSelectedIndexChanged(object sender, EventArgs e)
        {
            gvAttribute.MaGV = _cboMaGiaoVienHD.Text;
            foreach (DataRow item in gvController.GetFullGiaoVien(gvAttribute).Rows)
            {
                _txtTenGiaoVienHD.Text = item["TenGV"].ToString();
                _txtNgaySinhGV.Text = item["Ngay"].ToString();
                _txtThangSinhGV.Text = item["Thang"].ToString();
                _txtNamSinhGV.Text = item["Nam"].ToString();
                _txtGioiTinhGV.Text = item["GioiTinh"].ToString();
                _txtDiachiGV.Text = item["DiaChi"].ToString();
                _txtDienThoaiGV.Text = item["DienThoai"].ToString();
                _txtEmailGV.Text = item["Email"].ToString();
            }
        }

        private void OnGiaoVienHuongDanLoad(object sender, EventArgs e)
        {
            _dgvGiaoVien.DataSource = gvController.ShowGiaoVien();
            _txtTongBanGhi.Text = _dgvGiaoVien.Rows.Count.ToString();
        }

        private void OnBtnLuuGVClick(object sender, EventArgs e)
        {
            gvAttribute.MaGV = _cboMaGiaoVienHD.Text;
            gvAttribute.TenGV = _txtTenGiaoVienHD.Text;
            gvAttribute.NgaySinh = Int32.Parse(_txtNgaySinhGV.Text);
            gvAttribute.ThangSinh = Int32.Parse(_txtThangSinhGV.Text);
            gvAttribute.NamSinh = Int32.Parse(_txtNamSinhGV.Text);
            gvAttribute.GioiTinh = _txtGioiTinhGV.Text;
            gvAttribute.DiaChi = _txtDiachiGV.Text;
            gvAttribute.DienThoai = _txtDienThoaiGV.Text;
            gvAttribute.Email = _txtEmailGV.Text;
            gvController.InsertGiaoVien(gvAttribute);
            gvController.InsertTaiKhoan(gvAttribute);
            OnGiaoVienHuongDanLoad(sender, e);
        }
        #endregion Event

        #region Method

        public void LockCombobox()
        {
            _cboMaGiaoVienHD.Enabled = true;
        }

        /// <summary>
        /// hàm thực hiện việc load mã giáo viên lên _cboGiaoVien
        /// </summary>
        public void LoadGiaoVien()
        {
            _cboMaGiaoVienHD.DataSource = gvController.LoadGiaoVien();
            _cboMaGiaoVienHD.DisplayMember = "MaGV";
            _cboMaGiaoVienHD.ValueMember = "MaGV";
        }
        #endregion Method
    }
}

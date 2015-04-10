using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QuanLySinhVien.Common;

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

        private void _btnXoaGV_Click(object sender, EventArgs e)
        {
            if(_cboMaGiaoVienHD.Text=="")
            {
                MessageDialog messageDialog = new MessageDialog(@"Bạn chưa chọn thông tin cần xóa!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            else
            {
                gvAttribute.MaGV = _cboMaGiaoVienHD.Text;
                MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn muốn xóa?", MessageDialog.DialogType.YesNo);
                messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                {
                    if (result == MessageDialog.DialogResultType.Yes)
                    {
                        gvController.DeleteGiaoVienHD(gvAttribute);
                        MessageDialog messageDialog1 = new MessageDialog(@"Xóa thành công!", MessageDialog.DialogType.Ok);
                        messageDialog1.ShowDialog();
                    }
                };
                messageDialog.ShowDialog();
                Refresh();
                OnGiaoVienHuongDanLoad(sender, e);
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

        private int _dong;

        private void DSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _dong = e.RowIndex;
            _cboMaGiaoVienHD.Text = _dgvGiaoVien.Rows[_dong].Cells[0].Value.ToString();
            _txtTenGiaoVienHD.Text = _dgvGiaoVien.Rows[_dong].Cells[1].Value.ToString();
            _txtNgaySinhGV.Text = _dgvGiaoVien.Rows[_dong].Cells[2].Value.ToString();
            _txtThangSinhGV.Text = _dgvGiaoVien.Rows[_dong].Cells[3].Value.ToString();
            _txtNamSinhGV.Text = _dgvGiaoVien.Rows[_dong].Cells[4].Value.ToString();
            _txtGioiTinhGV.Text = _dgvGiaoVien.Rows[_dong].Cells[7].Value.ToString();
            _txtDiachiGV.Text = _dgvGiaoVien.Rows[_dong].Cells[5].Value.ToString();
            _txtDienThoaiGV.Text = _dgvGiaoVien.Rows[_dong].Cells[6].Value.ToString();
            _txtEmailGV.Text = _dgvGiaoVien.Rows[_dong].Cells[8].Value.ToString();
        }
        private void _btnTimKiemGiaoVienHD_Click(object sender, EventArgs e)
        {
            string tenGV = _txtTimKiemGiaoVienHD.Text;
            _dgvGiaoVien.DataSource = gvController.SearchGiaoVienHD(tenGV);
            _txtTongBanGhi.Text = _dgvGiaoVien.Rows.Count.ToString();

            if (_dgvGiaoVien.Rows.Count > 0)
            {
                _cboMaGiaoVienHD.Text = _dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
                _txtTenGiaoVienHD.Text = _dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
                
            }
            else
            {
                    MessageDialog messageDialog1 = new MessageDialog(@"Không tìm thấy", MessageDialog.DialogType.Ok);
                    messageDialog1.ShowDialog();
            }
            
            
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

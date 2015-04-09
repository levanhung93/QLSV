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
    public partial class DeTaiThucTap : UserControl
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng detaiAttribute
        /// </summary>
        DeTaiThucTapAttribute detaiAttribute = new DeTaiThucTapAttribute();

        /// <summary>
        /// khởi tạo đối tượng detaiController
        /// </summary>
        DeTaiThucTapController detaiController = new DeTaiThucTapController();

        /// <summary>
        /// khởi tạo đối tượng gvController
        /// </summary>
        GiaoVienController gvController = new GiaoVienController();

        /// <summary>
        /// khởi tạo đối tượng gvAttribute
        /// </summary>
        GiaoVienAttribute gvAttribute = new GiaoVienAttribute();

        /// <summary>
        /// khởi tạo biến _luu, nếu _luu==true thì thực hiện lưu thông tin đề tài được thêm mới, nếu _luu==false thì thực hiện lưu thông tin đề tài được thay dổi
        /// </summary>
        Boolean _luu = true;
        #endregion Field

        #region Constructor
        public DeTaiThucTap()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBtnThemDeTaiClick(object sender, EventArgs e)
        {
            UnLockTextBox();
            LoadGiaoVien();
        }

        private void OnCboMaGiaoVienHDSelectedIndexChanged(object sender, EventArgs e)
        {
            gvAttribute.MaGV = _cboMaGiaoVienHD.Text;
            foreach (DataRow item in gvController.GetFullGiaoVien(gvAttribute).Rows)
            {
                _txtTenGiaoVienHD.Text = item["TenGV"].ToString();
            }
        }

        private void OnBtnLuuDeTaiClick(object sender, EventArgs e)
        {
            detaiAttribute.MaDeTai = _txtMaDeTai.Text;
            detaiAttribute.TenDeTai = _txtTenDeTai.Text;
            detaiAttribute.MaGiaoVienHD = _cboMaGiaoVienHD.Text;
            if (_luu==true)
            {
                detaiController.InsertDeTai(detaiAttribute);
                MessageDialog messageDialong = new MessageDialog(@"Thêm đề tài thành công!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
            }
        }
        #endregion Event

        #region Method
        /// <summary>
        /// hàm load mã giáo viên hướng dẫn
        /// </summary>
        public void LoadGiaoVien()
        {
            _cboMaGiaoVienHD.DataSource = gvController.LoadGiaoVien();
            _cboMaGiaoVienHD.DisplayMember = "MaGV";
            _cboMaGiaoVienHD.ValueMember = "MaGV";
        }
        
        /// <summary>
        /// hàm mở khóa text
        /// </summary>
        public void UnLockTextBox()
        {
            _txtTenDeTai.Enabled = true;
            _cboMaGiaoVienHD.Enabled = true;
        }
        #endregion Method

    }
}

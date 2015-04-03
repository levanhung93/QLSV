using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    public partial class DangNhap : Form
    {
        #region Field 
        /// <summary>
        /// Biến đánh dấu lần chạy đầu tiên
        /// </summary>
        private bool _isFirstRun = true;
        private bool _isMousePress = false;
        private Point _lastPoint;
        #endregion Field

        #region Method
        public DangNhap()
        {
            InitializeComponent();
        }
        #endregion Method

        #region Event
        private void OnCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnDangNhapClick(object sender, EventArgs e)
        {
            if (_txtTenDangNhap.Text == "admin" && _txtMatKhau.Text == "1")
            {
                if (_isFirstRun)
                {
                    _isFirstRun = false;
                    Thread thread = new Thread(InitDatabase);
                    thread.Start();
                }
                MainStuden.userName = _txtTenDangNhap.Text;
                MainStuden studen = new MainStuden();
                studen.Show();
                this.Hide();
            }
        }

        private void OnHuyClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.White;
        }

        private void OnPanelDangNhapMouseDown(object sender, MouseEventArgs e)
        {
            _isMousePress = true;
            _lastPoint = e.Location;
        }

        private void OnPanelDangNhapMouseUp(object sender, MouseEventArgs e)
        {
            _isMousePress = false;
        }

        private void OnPanelDangNhapMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMousePress)
            {
                //quyết định cho form chui ra ngoài màn hình
                Point currentPoint = e.Location;
                Point mainLocation = this.Location;
                int scaleX = currentPoint.X - _lastPoint.X;
                int scaleY = currentPoint.Y - _lastPoint.Y;
                this.Location = new Point(mainLocation.X + scaleX, mainLocation.Y + scaleY);
            }
        }
        private void InitDatabase()
        {
            DatabaseCore.CreateDatabase();
        }
        #endregion Event

    }
}

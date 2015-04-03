using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class _frmThayDoiMatKhau : Form
    {
        public _frmThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void OnLblThayDoiMKClick(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.White;
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }
    }
}

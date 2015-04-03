namespace QuanLySinhVien.GUI
{
    partial class _frmThayDoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblClose = new System.Windows.Forms.Label();
            this._pnlThayDoiMatKhau = new System.Windows.Forms.Panel();
            this._btnHuyThayDoi = new System.Windows.Forms.Label();
            this._btnThayDoi = new System.Windows.Forms.Label();
            this._txtMatKhauCu = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._pnlThayDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblClose
            // 
            this._lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClose.Location = new System.Drawing.Point(506, 4);
            this._lblClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._lblClose.Name = "_lblClose";
            this._lblClose.Size = new System.Drawing.Size(52, 28);
            this._lblClose.TabIndex = 1;
            this._lblClose.Text = "X";
            this._lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblClose.Click += new System.EventHandler(this.OnLblThayDoiMKClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCloseMouseMove);
            // 
            // _pnlThayDoiMatKhau
            // 
            this._pnlThayDoiMatKhau.BackgroundImage = global::QuanLySinhVien.Properties.Resources.login;
            this._pnlThayDoiMatKhau.Controls.Add(this._lblClose);
            this._pnlThayDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlThayDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this._pnlThayDoiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this._pnlThayDoiMatKhau.Name = "_pnlThayDoiMatKhau";
            this._pnlThayDoiMatKhau.Size = new System.Drawing.Size(561, 36);
            this._pnlThayDoiMatKhau.TabIndex = 7;
            // 
            // _btnHuyThayDoi
            // 
            this._btnHuyThayDoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnHuyThayDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnHuyThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnHuyThayDoi.Location = new System.Drawing.Point(326, 225);
            this._btnHuyThayDoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnHuyThayDoi.Name = "_btnHuyThayDoi";
            this._btnHuyThayDoi.Size = new System.Drawing.Size(125, 39);
            this._btnHuyThayDoi.TabIndex = 18;
            this._btnHuyThayDoi.Text = "Hủy";
            this._btnHuyThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnThayDoi
            // 
            this._btnThayDoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnThayDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThayDoi.Location = new System.Drawing.Point(133, 225);
            this._btnThayDoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnThayDoi.Name = "_btnThayDoi";
            this._btnThayDoi.Size = new System.Drawing.Size(125, 39);
            this._btnThayDoi.TabIndex = 14;
            this._btnThayDoi.Text = "Thay đổi";
            this._btnThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtMatKhauCu
            // 
            this._txtMatKhauCu.Location = new System.Drawing.Point(231, 119);
            this._txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhauCu.Name = "_txtMatKhauCu";
            this._txtMatKhauCu.PasswordChar = '*';
            this._txtMatKhauCu.Size = new System.Drawing.Size(273, 22);
            this._txtMatKhauCu.TabIndex = 17;
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.Location = new System.Drawing.Point(231, 75);
            this._txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(273, 22);
            this._txtTenDangNhap.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập";
            // 
            // _txtMatKhauMoi
            // 
            this._txtMatKhauMoi.Location = new System.Drawing.Point(231, 163);
            this._txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhauMoi.Name = "_txtMatKhauMoi";
            this._txtMatKhauMoi.PasswordChar = '*';
            this._txtMatKhauMoi.Size = new System.Drawing.Size(273, 22);
            this._txtMatKhauMoi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu mới";
            // 
            // _frmThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 291);
            this.Controls.Add(this._txtMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._btnHuyThayDoi);
            this.Controls.Add(this._btnThayDoi);
            this.Controls.Add(this._txtMatKhauCu);
            this.Controls.Add(this._txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pnlThayDoiMatKhau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_frmThayDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThayDoiMatKhau";
            this._pnlThayDoiMatKhau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.Panel _pnlThayDoiMatKhau;
        private System.Windows.Forms.Label _btnHuyThayDoi;
        private System.Windows.Forms.Label _btnThayDoi;
        private System.Windows.Forms.TextBox _txtMatKhauCu;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtMatKhauMoi;
        private System.Windows.Forms.Label label3;
    }
}
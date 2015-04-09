﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class GiaoVienController
    {
        /// <summary>
        /// hàm load mã giáo viên lên _cboGiaoVien
        /// </summary>
        /// <param name="gvAttribute"></param>
        /// <returns></returns>
        public DataTable LoadGiaoVien()
        {
            string query = "SELECT MaGV FROM GIAOVIEN";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm lấy toàn bộ thông tin giáo viên theo mã giáo viên được chọn từ _cboGiaoVien
        /// </summary>
        /// <param name="gvAttribute"></param>
        /// <returns></returns>
        public DataTable GetFullGiaoVien(GiaoVienAttribute gvAttribute)
        {
            string query = "SELECT * FROM GIAOVIEN WHERE MaGV='" + gvAttribute.MaGV + "'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm thực hiện thêm giáo viên vào GIAOVIENHUONGDAN
        /// </summary>
        /// <param name="gvAttribute"></param>
        public void InsertGiaoVien(GiaoVienAttribute gvAttribute)
        {
            string query = "INSERT INTO GIAOVIENHUONGDAN VALUES ('" + gvAttribute.MaGV + "','" + gvAttribute.TenGV + "','" +gvAttribute.NgaySinh + "', '" + gvAttribute.ThangSinh + "','" + gvAttribute.NamSinh + "','" + gvAttribute.DiaChi + "','" + gvAttribute.DienThoai + "','" + gvAttribute.GioiTinh + "','" + gvAttribute.Email + "') ";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm thực hiện thêm tài khoản, mật khẩu và quyền cho giáo viên
        /// </summary>
        /// <param name="gvAttribute"></param>
        public void InsertTaiKhoan(GiaoVienAttribute gvAttribute)
        {
            string query = "INSERT INTO TAIKHOAN VALUES ('" + gvAttribute.MaGV + "','" + gvAttribute.MaGV + "','GV')";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm hiển thị thông tin giáo viên hướng dẫn lên _dgvGiaoVien
        /// </summary>
        /// <returns></returns>
        public DataTable ShowGiaoVien()
        {
            string query = "SELECT * FROM GIAOVIENHUONGDAN ";
            return DatabaseCore.GetDatatable(query);
        }
    }
}
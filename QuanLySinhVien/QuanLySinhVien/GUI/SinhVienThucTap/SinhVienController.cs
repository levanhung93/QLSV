using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class SinhVienController
    {
        /// <summary>
        /// hàm load mã sinh viên lên _cboMaSinhVien
        /// </summary>
        /// <param name="svAttribute"></param>
        /// <returns></returns>
        public DataTable LoadMaSinhVien(SinhVienAttribute svAttribute)
        {
            string query = "SELECT MaSV FROM SINHVIEN";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// Hàm lấy toàn bộ tin liên quan đến sinh viên khi đã được chọn mã sinh viên từ _cboMaSinhVien
        /// </summary>
        /// <param name="svAttribute"></param>
        /// <returns></returns>
        public DataTable GetFullSinhVien(SinhVienAttribute svAttribute)
        {
            string query = "SELECT * FROM SINHVIEN,LOP,KHOAHOC WHERE MaSV='" + svAttribute.MaSV + "' AND SINHVIEN.MaLop=LOP.MaLop AND LOP.MaKhoa=KHOAHOC.MaKhoa";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm thực hiện thêm sinh viên vào bảng SINHVIENTHUCTAP
        /// </summary>
        /// <param name="svAttribute"></param>
        public void InsertSinhVien(SinhVienAttribute svAttribute)
        {
            string query = "INSERT INTO SINHVIENTHUCTAP VALUES ('" + svAttribute.MaSV + "','" + svAttribute.TenSV + "','" + svAttribute.NgaySinh + "', '" + svAttribute.ThangSinh + "','" + svAttribute.NamSinh + "','" + svAttribute.DiaChi + "','" + svAttribute.DienThoai + "','" + svAttribute.GioiTinh + "','" + svAttribute.Email + "','" + svAttribute.Lop + "') ";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm thực hiện thêm tài khoản. mật khẩu. quyền cho sinh viên
        /// </summary>
        /// <param name="svAttribute"></param>
        public void InsertTaiKhoan(SinhVienAttribute svAttribute)
        {
            string query = "INSERT INTO TAIKHOAN VALUES ('" + svAttribute.MaSV + "','" + svAttribute.MaSV + "','SV')";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm hiển thị thông tin sinh viên thực tập lên _dgvSinhVien
        /// </summary>
        /// <returns></returns>
       public DataTable ShowSinhVien()
        {
            String query = "SELECT MaSV, TenSV, Ngay, Thang, Nam, GioiTinh, DiaChi, DienThoai, TenLop, KhoaHoc, Email FROM SINHVIENTHUCTAP,LOP,KHOAHOC WHERE SINHVIENTHUCTAP.MaLop=LOP.MaLop AND LOP.MaKhoa=KHOAHOC.MaKhoa";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm xóa thông tin sinh viên thực tập khỏi danh sách
        /// </summary>
        /// <param name="svAttribute"></param>
       public void DeleteSinhVienTT(SinhVienAttribute svAttribute)
       {
           string query = "DELETE FROM SINHVIENTHUCTAP WHERE MaSV='" + svAttribute.MaSV + "'";
           DatabaseCore.ExecuteQuery(query);
       }


    }
}

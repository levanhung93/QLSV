using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QuanLySinhVien.Common
{
    partial class DatabaseCore
    {
        #region Method
        /// <summary>
        /// thực hiện câu lệnh tạo các bảng dữ liệu
        /// </summary>
        private static void ExecuteCreateDatabase()
        {
            CreateSinhVien();
            CreateGiaoVien();
            CreateLop();
            CreateKhoaHoc();
            CreateDeTai();
            CreateDiem();
            CreateDiaDiemThucTap();
            CreateSinhVienDT();
            CreateTaiKhoan();
        }

        /// <summary>
        /// thực hiện tạo bảng SinhVien
        /// </summary>
        private static void CreateSinhVien()
        {
            string query = "CREATE TABLE SINHVIEN (MaSV VARCHAR(10),TenSV NVARCHAR(50),Ngay INT,Thang INT,Nam INT,DiaChi NVARCHAR(200),DienThoai NCHAR(11),GioiTinh NVARCHAR(5),Email NVARCHAR(200),MaLop VARCHAR(10) )";
            ExecuteQuery(query);

           Random ranDom = new Random();
            chuoi ch = new chuoi();
            for (int i = 0; i < 300; i++)
            {
                string MaSV = "SV" + i.ToString("0000");
                string TenSV = "SV NAME " + i.ToString("0000");
                int Ngay = ranDom.Next(0,32);
                int Thang = ranDom.Next(0,13);
                int Nam = ranDom.Next(1945,ch.NamSinh() + 1);
                string DiaChi = ch.RandomString(10, true);
                string  DienThoai = ranDom.Next(999999999).ToString("00");
                int GioiTinh = ranDom.Next(2);
                string Email = ch.RandomString(10, true)+"@gmail.com";
                string MaLop = "LOP" + i.ToString("0000");
               query = string.Format("INSERT INTO SINHVIEN (MaSV, TenSV, Ngay, Thang, Nam, DiaChi, DienThoai, GioiTinh, Email, MaLop) VALUES ('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}','{8}','{9}')",
                    MaSV,
                    TenSV,
                    Ngay,
                    Thang,
                    Nam,
                    DiaChi,
                    DienThoai,
                    GioiTinh,
                    Email,
                    MaLop);
                DatabaseCore.ExecuteQuery(query);
            }
        }

        /// <summary>
        /// thực hiện tạo bảng GiaoVienHD
        /// </summary>
        private static void CreateGiaoVien()
        {
            string query = "CREATE TABLE GIAOVIEN (MaGV VARCHAR(10),TenGV NVARCHAR(50),Ngay INT,Thang INT,Nam INT,DiaChi NVARCHAR(200),DienThoai NCHAR(11),GioiTinh NVARCHAR(5),Email NVARCHAR(200))";
            ExecuteQuery(query);

           Random ranDom = new Random();
            chuoi ch = new chuoi();
            for (int i = 0; i < 300; i++)
            {
                string MaGV = "GV" + i.ToString("0000");
                string TenGV = "GV NAME " + i.ToString("0000");
                int Ngay = ranDom.Next(0, 32);
                int Thang = ranDom.Next(0, 13);
                int Nam = ranDom.Next(1945, ch.NamSinh() + 1);
                string DiaChi = ch.RandomString(10, true);
                string DienThoai = ranDom.Next(999999999).ToString("00");
                int GioiTinh = ranDom.Next(2);
                string Email = ch.RandomString(10, true) + "@gmail.com";
                string MaLop = "LOP" + i.ToString("0000");
                query = string.Format("INSERT INTO GIAOVIEN (MaGV, TenGV, Ngay, Thang, Nam, DiaChi, DienThoai, GioiTinh, Email) VALUES ('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}','{8}')",
                     MaGV,
                     TenGV,
                     Ngay,
                     Thang,
                     Nam,
                     DiaChi,
                     DienThoai,
                     GioiTinh,
                     Email);
                DatabaseCore.ExecuteQuery(query);
            }
        }

        /// <summary>
        /// thực hiện tạo bảng Lop
        /// </summary>
        private static void CreateLop()
        {
            string query = "CREATE TABLE LOP (MaLop VARCHAR(10),TenLop NVARCHAR(50),MaKhoa VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng KhoaHoc
        /// </summary>
        private static void CreateKhoaHoc()
        {
            string query = "CREATE TABLE KHOAHOC (MaKhoa VARCHAR(10),KhoaHoc NVARCHAR(50))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng DeTai
        /// </summary>
        private static void CreateDeTai()
        {
            string query = "CREATE TABLE DETAI (MaDT VARCHAR(10),TenDT NVARCHAR(1000),MaGV VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng Diem
        /// </summary>
        private static void CreateDiem()
        {
            string query = "CREATE TABLE DIEM (MaSV VARCHAR(10),Diem1 FLOAT, Diem2 FLOAT, Diem3 FLOAT,DiemTB FLOAT, DiemBaoVe FLOAT, DiemTongKet FLOAT, LanThucTap INT, GhiChu NVARCHAR(50))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng DiaDiemThucTap
        /// </summary>
        private static void CreateDiaDiemThucTap()
        {
            string query = "CREATE TABLE DIADIEMTHUCTAP (MaSV VARCHAR(10),TenDiaDiem NVARCHAR(200),DiaChi NVARCHAR(200),DienThoai NCHAR(11),Email NVARCHAR(200))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng SinhVien_DeTai
        /// </summary>
        private static void CreateSinhVienDT()
        {
            string query = "CREATE TABLE SINHVIEN_DETAI (MaSV VARCHAR(10),MaDeTai VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng TaiKhoan
        /// </summary>
        private static void CreateTaiKhoan()
        {
            string query = "CREATE TABLE TAIKHOAN (TaiKhoan NVARCHAR(200),MatKhau NVARCHAR(200),Quyen NVARCHAR(50))";
            ExecuteQuery(query);
        }

        #endregion Method
    }
}

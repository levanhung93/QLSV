using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class DeTaiThucTapController
    {
        /// <summary>
        /// hàm thêm thông tin đề tài vào csdl
        /// </summary>
        /// <param name="detaiAttribute"></param>
        public void InsertDeTai(DeTaiThucTapAttribute detaiAttribute)
        {
            string query = "INSERT INTO DETAI VALUES ('" + detaiAttribute.MaDeTai + "',N'" + detaiAttribute.TenDeTai + "','" + detaiAttribute.MaGiaoVienHD + "')";
            DatabaseCore.ExecuteQuery(query);
        }
    }
}

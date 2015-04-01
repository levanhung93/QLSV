using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Common
{
    class chuoi
    {
        DateTime toDay = DateTime.Now;
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

       public int  NamSinh()
        {
            int Nam = toDay.Year;
            return Nam;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaTro.DAO
{
  public  class login
    {
        public static login instance;
       
        public static login Instance
        {
            get { if (instance == null) instance = new login(); return  instance; }
            private set  => instance = value;
        }
        public static bool logintest(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
          

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = "SELECT * FROM nhanVien WHERE MaNV LIKE N'" + userName + "' AND MatKhau = N'" + hasPass + "' ";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public static bool loginadmin(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = "SELECT * FROM nhanVien WHERE MaNV LIKE N'" + userName + "' AND MatKhau = N'" + hasPass + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

    }
}

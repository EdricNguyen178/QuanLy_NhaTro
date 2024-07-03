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
    public class DataProvider
    {
        DataSet ds = new DataSet();
        SqlDataAdapter dt;
        SqlConnection SQLcon = new SqlConnection("Data Source = EDRICNGUYEN\\SQLEXPRESS; Initial Catalog = QL_NHATRO; User ID = sa; Password = 123");
        private static DataProvider instance;
      
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }

            
        }

     

        
        private static string connectionSTR = "Data Source = EDRICNGUYEN\\SQLEXPRESS; Initial Catalog = QL_NHATRO; User ID = sa; Password = 123";
     
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public int ADDNV(String Ma,String Ten,String SDT,String ChucVu,String Luong,String MatKhau,byte[] anh)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(MatKhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            int test = 0;
            try
            {
                String query= "SET dateformat DMY; INSERT INTO nhanVien values('"+Ma+"',N'"+Ten+"','"+SDT+"',N'"+ChucVu+"','"+Luong+"','"+ hasPass + "',@img,'true')";
                if (SQLcon.State == ConnectionState.Closed)
                {
                    SQLcon.Open();
                }
                SqlCommand com = new SqlCommand();
                com.Connection = SQLcon;
                com.CommandText = query;
                com.Parameters.Add(new SqlParameter("@img", anh));
                com.ExecuteNonQuery();
                if (SQLcon.State == ConnectionState.Open)
                {
                    SQLcon.Close();
                }

                return test = 1;
            }
            catch (Exception)
            {
                return test = 0;
            }
        }
        public int UPDATENV(String Ma, String Ten, String SDT, String ChucVu, String Luong, byte[] anh)
        {
            int test = 0;
            try
            {
                String query = "UPDATE nhanVien SET TenNV =N'" + Ten + "',ChucVu = N'" + ChucVu + "',Luong ='" + Luong + "',SĐT ='" + SDT + "',anh = @img Where MaNV ='" + Ma + "'";
                if (SQLcon.State == ConnectionState.Closed)
                {
                    SQLcon.Open();
                }
                SqlCommand com = new SqlCommand();
                com.Connection = SQLcon;
                com.CommandText = query;
                com.Parameters.Add(new SqlParameter("@img", anh));
                com.ExecuteNonQuery();
                if (SQLcon.State == ConnectionState.Open)
                {
                    SQLcon.Close();
                }

                return test = 1;
            }
            catch (Exception)
            {
                return test = 0;
            }
        }
        
        public int  UPDATESQL(String query)
        {
            int test = 0;
            try
            {
                if (SQLcon.State == ConnectionState.Closed)
                {
                    SQLcon.Open();
                }
                SqlCommand com = new SqlCommand();
                com.Connection = SQLcon;
                com.CommandText = query;
                com.ExecuteNonQuery();           
                if (SQLcon.State == ConnectionState.Open)
                {
                    SQLcon.Close();
                }
                
                return test=1;
            }
            catch (Exception)
            {
                return test=0;
            }
        }
    }

}

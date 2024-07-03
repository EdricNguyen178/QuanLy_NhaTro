using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class TKHoaDon : Form
    {
        long tongtien = 0;
        public TKHoaDon()
        {
            InitializeComponent();
        }
       
        private void TKHoaDon_Load(object sender, EventArgs e)
        {
            loadHD("SELECT * FROM HoaDon");
            label1.Text += tongtien.ToString();
            loadcombobox();
        }
        private void loadcombobox()
        {    
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhongTro");
            foreach (DataRow item in result.Rows)
            {
                CB_MaP.Items.Add(item[0]);
            } 
        }
        private void loadHD(String a)
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery(a);
            foreach (DataRow item in result.Rows)
            {
                dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString(), item[7].ToString(), item[8].ToString(), item[9].ToString());
                tongtien += long.Parse(item[9].ToString());
            }
        }
        private void CB_MaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHD("SELECT * FROM HoaDon where MaPhong = '" + CB_MaP.Text + "'");
        }

        private void CB_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHD("SELECT * FROM HoaDon where MONTH (NgayLapHD) = '" + CB_thang.Text + "'");
        }

        private void txt_Nam_TextChanged(object sender, EventArgs e)
        {
            loadHD("SELECT * FROM HoaDon where year (NgayLapHD) like '%" + txt_Nam.Text + "%'");
        }
    }
}

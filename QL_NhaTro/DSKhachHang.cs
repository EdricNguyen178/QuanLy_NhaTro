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
    public partial class DSKhachHang : Form
    {
        public DSKhachHang()
        {
            InitializeComponent();
        }
        private void loadDATA(String a )
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang where TenKH like N'%"+a+ "%'");
            foreach (DataRow item in result.Rows)
            {     
                    dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString());
            }

        }
        private void loadKH(String a, Boolean kt)
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang where TenKH like N'%" + a + "%' and TrangThai = '" + kt + "'");
            foreach (DataRow item in result.Rows)
            {
                dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString());
            }

        }
        private void DSKhachHang_Load(object sender, EventArgs e)
        {
            loadDATA("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadDATA(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (comboBox1.Text== "Tất Cả")
            { loadDATA(""); }    
            if((comboBox1.Text== "Đang Ở"))
            { loadKH("", true); }
            if(comboBox1.Text== "Đã Trả Phòng")
            { loadKH("", false); }    
            
        }
    }
}

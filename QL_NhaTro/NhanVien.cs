using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class NhanVien : Form
    {
        String Ma = "";
        public NhanVien()
        {
            InitializeComponent();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadNV("");
        }
        private void loadNV(String Ten )
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM nhanVien Where TenNV like N'%"+Ten+ "%' and trangThai = 'true'");
            foreach (DataRow item in result.Rows)
            {
                byte[] anh = (byte[])(item[6]);              
                MemoryStream ms = new MemoryStream(anh);   
                dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), Image.FromStream(ms));                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadNV(textBox1.Text);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(Ma =="")
            {
                MessageBox.Show("Chọn Nhân Viên Cần Xóa Trước ", "Thông Báo ");
            }    else
            {
                DialogResult dlr = MessageBox.Show("chắc chứ  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    int test = DataProvider.Instance.UPDATESQL("UPDATE nhanVien SET trangThai ='false' Where MaNV ='" + Ma + "'");
                    if (test == 1)
                    {
                        MessageBox.Show("thành công", "thông báo");
                        loadNV("");
                        Ma = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "thông báo");
                    }
                }
            }    

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(Ma=="")
            {
                MessageBox.Show("Chọn Nhân Viên Cần thay đỏi Trước ", "Thông Báo ");
            }    else
            {
                DoiTTNV ch = new DoiTTNV();
                DoiTTNV.MVN = Ma;
                ch.ShowDialog();
                loadNV("");
            }    
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThemNV tnv = new ThemNV();
            tnv.ShowDialog();
            loadNV("");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            NVDaNghi NVN = new NVDaNghi();
            NVN.ShowDialog();
            loadNV("");
        }
    }
    
}

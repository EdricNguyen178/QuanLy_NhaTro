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
    public partial class HopDongHetHan : Form
    {
        String mhd = "";
        public HopDongHetHan()
        {
            InitializeComponent();
        }

        private void HopDongHetHan_Load(object sender, EventArgs e)
        {
            loadHD();
        }
        private void loadHD()
        {
            DateTime hethan = DateTime.Now;
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM hopDong where TinhTrang='false' ");
            foreach (DataRow item in result.Rows)
            {
                String a = item[2].ToString();
                int m = int.Parse(item[3].ToString());
                DateTime s = DateTime.Parse(a);
                hethan = s.AddMonths(+m);
                    dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), s.ToString("dd/MM/yyyy"), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString(), item[7].ToString(), hethan.ToString("dd/MM/yyyy"));
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                mhd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CB_Thang.Text != "")
            {
                if (mhd != "")
                {
                        int test = DataProvider.Instance.UPDATESQL("SET dateformat DMY;UPDATE hopDong SET NgayLap='" + DateTime.Now.ToString("dd/MM/yyy") + "', NgayBatDau='" + DateTime.Now.ToString("dd/MM/yyy") + "',Thoihan='" + CB_Thang.Text.ToString() + "',TinhTrang='true'  Where MaHopDong = '" + mhd + "'");
                        if (test == 1)
                        {
                            MessageBox.Show("thay đỏi  thành công", "thông báo");
                            loadHD();
                        }
                        else
                        {
                            MessageBox.Show("thay đỏi Không thành công", "thông báo");
                        }
                }
                else
                {
                    MessageBox.Show("bạn chưa chọn hợp đồng cần gia hạn", "");
                }
            }
            else
            {
                MessageBox.Show("bạn vui lòng chọn thời gia cần gia hạn ", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

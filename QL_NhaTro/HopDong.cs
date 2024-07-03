using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class HopDong : Form
    {
        String mhd = "";
        DateTime NHH = DateTime.Now;
        public HopDong()
        {
            InitializeComponent();
        }
        private void loadHD()
        {
            DateTime hethan= DateTime.Now;
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM hopDong where TinhTrang='true' ");
            foreach (DataRow item in result.Rows)
            {
                String a = item[2].ToString();
                int m = int.Parse(item[3].ToString());
                DateTime s = DateTime.Parse(a);
                 hethan = s.AddMonths(+m);
                if((DateTime.Now.Year == hethan.Year && DateTime.Now.Month < hethan.Month ) || DateTime.Now.Year<hethan.Year )
                {
                    dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), s.ToString("dd/MM/yyyy"), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString(), item[7].ToString(), hethan.ToString("dd/MM/yyyy"));
                }else
                {
                    int test = DataProvider.Instance.UPDATESQL("UPDATE hopDong SET TinhTrang='false'  Where MaHopDong = '" + item[0].ToString() + "'");

                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)     
            {
                String c = dataGridView1.Rows[i].Cells[8].Value.ToString();
                int  t =  DateTime.Parse(c).Month- DateTime.Now.Month ;
                int n =  DateTime.Parse(c).Year- DateTime.Now.Year;
               
                if (t <=2 && n==0)
                { 
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }

            }

            }
        private void HopDong_Load(object sender, EventArgs e)
        {
            loadHD();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ThemHopDong addHD = new ThemHopDong();
            addHD.ShowDialog();
            loadHD();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(CB_Thang.Text!="")
            {
                if(NHH.ToString() != "" && mhd !="" )
                {
                    DateTime NM = NHH.AddMonths(+ int.Parse(CB_Thang.Text));
                    int n = NHH.Year - DateTime.Now.Year;
                    if (n >= 0)
                    {
                        String thoigianmoi = ((NHH.Month - DateTime.Now.Month + (n * 12) + int.Parse(CB_Thang.Text))).ToString();
                        int test = DataProvider.Instance.UPDATESQL("SET dateformat DMY;UPDATE hopDong SET NgayLap='" + DateTime.Now.ToString("dd/MM/yyy")+ "', NgayBatDau='" + DateTime.Now.ToString("dd/MM/yyy") + "',Thoihan='"+thoigianmoi+"'  Where MaHopDong = '" + mhd + "'");
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
                        MessageBox.Show("Hợp đồng này dã hết hạn bạn vui lòng chọn HD mới", "thông báo");
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                mhd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NHH = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HopDongHetHan t = new HopDongHetHan();
            t.ShowDialog();
      
            loadHD();
        }
    }
}

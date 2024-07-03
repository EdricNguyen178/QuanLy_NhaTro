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
    public partial class ThemLaiKHCu : Form
    {
        public static String maP = "";
        String MKH = "";
        public ThemLaiKHCu()
        {
            InitializeComponent();
        }

        private void ThemLaiKHCu_Load(object sender, EventArgs e)
        {
            label1.Text = maP;
            loadDATA();
        }
        private bool ktKhoa(String ts)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang Where MaKH ='" + ts + "'");
            return result.Rows.Count == 0;
        }
        private void Btn_traPhong_Click(object sender, EventArgs e)
        {
            int a = 0;
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT p.soNguoiDangO,lp.SoNguoiO FROM PhongTro p full outer JOIN LoaiPhong lp on lp.MaLoai=p.MaLoai where p.MaPhong='" + label1.Text + "' ");
            foreach (DataRow item in result.Rows)
            {
                a = Int32.Parse(item[1].ToString()) - Int32.Parse(item[0].ToString());
            }
              if (a > 0)
                {
                    if(MKH!="")
                {
                    DialogResult dlr = MessageBox.Show("bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        int test = DataProvider.Instance.UPDATESQL("UPDATE KhachHang SET MaPhong='" + label1.Text.ToString() + "' , TrangThai ='true' Where MaKH ='" + MKH + "'");
                        test = DataProvider.Instance.UPDATESQL("UPDATE PhongTro SET soNguoiDangO = soNguoiDangO+1 Where MaPhong ='" + label1.Text.ToString() + "'");

                        if (test == 1)
                        {
                            MessageBox.Show("Thêm thành công", "thông báo");
                            loadDATA();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Không thành công", "thông báo");
                        }
                    }
                }else
                {
                    MessageBox.Show("Chưa Chọn Khách Hàng Cần thêm", "thông báo");
                }    
                   
                   

                }
                else
                {
                    MessageBox.Show("Đã Đủ Số Người Ở Tối Đa Trong Phòng ", "Thông báo");
                }
            }
            
        
        private void loadDATA()
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang  where  TrangThai = 'false'");
            foreach (DataRow item in result.Rows)
            {
                    dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MKH = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}

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
    public partial class ThongTinPhong : Form
    {
        public static string a = "";
        String MakhX = "";
        public ThongTinPhong()
        {
            InitializeComponent();
        }
        private void ThongTinPhong_Load(object sender, EventArgs e)
        {
            ThemLaiKHCu.maP = a;
            label1.Text = a;
            loadDATA();

        }
        private void loadDATA()
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang kh full outer JOIN PhongTro p on kh.MaPhong = p.MaPhong  where kh.MaPhong = '"+ label1.Text+ "'");
            foreach (DataRow item in result.Rows)
            {
                if (item[6].ToString() != "False")
                {
                    dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString());
                   

                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("chắc chứ  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int test = DataProvider.Instance.UPDATESQL("UPDATE KhachHang SET TrangThai ='false' Where MaKH ='" + MakhX + "'");
                test = DataProvider.Instance.UPDATESQL("UPDATE PhongTro SET soNguoiDangO = soNguoiDangO-1 Where MaPhong ='" + label1.Text.ToString() + "'");
                if (test == 1)
                {
                    MessageBox.Show("xóa thành công", "thông báo");
                    loadDATA();
                }
                else
                {
                    MessageBox.Show("xóa Không thành công", "thông báo");
                }
            }
        }
        private void Btn_traPhong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("chắc chứ  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int test = DataProvider.Instance.UPDATESQL("UPDATE KhachHang SET TrangThai ='false' Where MaPhong ='" + label1.Text.ToString() + "'");
                 test = DataProvider.Instance.UPDATESQL("UPDATE PhongTro SET soNguoiDangO = 0,HienTrangPhong='false' Where MaPhong ='" + label1.Text.ToString() + "'");
                if (test == 1)
                {
                    MessageBox.Show("trả thành công", "thông báo");
                    loadDATA();
                }
                else
                {
                    MessageBox.Show("trả Không thành công", "thông báo");
                }
            }
        }
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            ThemHD.MaP = label1.Text;
            ThemHD hd = new ThemHD();
            hd.ShowDialog();
       
           
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemKH.MaP = label1.Text;
            ThemKH kh = new ThemKH();
            kh.ShowDialog();
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MakhX = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThemLaiKHCu t = new ThemLaiKHCu();
            t.ShowDialog();
            loadDATA();
        }
    }
}

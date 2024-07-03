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
    public partial class ThemKH : Form
    {
        public static string MaP = "";
        public ThemKH()
        {
            InitializeComponent();
        }
        private void ThemKH_Load(object sender, EventArgs e)
        {
            label1.Text = MaP;
            loadDATA();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadDATA()
        {
            dataGridView1.Rows.Clear();
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang where MaPhong = '" + label1.Text + "'");
            foreach (DataRow item in result.Rows)
            {
                if (item[6].ToString() != "False")
                {
                    dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString());
                }
            }
        }
        private bool ktKhoa(String ts)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang Where MaKH ='"+ts+"'");
            return result.Rows.Count == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT p.soNguoiDangO,lp.SoNguoiO FROM PhongTro p full outer JOIN LoaiPhong lp on lp.MaLoai=p.MaLoai where p.MaPhong='" + label1.Text + "' ");
            foreach (DataRow item in result.Rows)
            {
                a = Int32.Parse(item[1].ToString()) - Int32.Parse(item[0].ToString());
            }
            if (ktKhoa(txt_MaKH.Text))
            {
                
                if (a > 0)
                {
                    DialogResult dlr = MessageBox.Show("bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        int test = DataProvider.Instance.UPDATESQL("SET dateformat DMY; INSERT INTO KhachHang values('" + txt_MaKH.Text + "', N'" + txt_TenKH.Text + "', '" + txt_SDT.Text + "', N'" + txt_NgheNghiep.Text + "', '" + txt_NS.Text + "', '" + label1.Text + "', 'true')");
                        test = DataProvider.Instance.UPDATESQL("UPDATE PhongTro SET soNguoiDangO = soNguoiDangO+1 , HienTrangPhong ='true' Where MaPhong ='" + label1.Text.ToString() + "'");

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
                    txt_MaKH.Text = txt_NgheNghiep.Text = txt_NS.Text = txt_SDT.Text = txt_TenKH.Text = "";
                    loadDATA();
                }
                else
                {
                    MessageBox.Show("Đã Đủ Số Người Ở Tối Đa Trong Phòng ", "Thông báo");
                }
            }else
            {
                MessageBox.Show("trùng mã khách hàng ", "Thông báo");
            }    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

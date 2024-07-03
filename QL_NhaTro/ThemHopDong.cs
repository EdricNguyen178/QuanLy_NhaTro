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
    public partial class ThemHopDong : Form
    {
        int tien = 0; 
        public ThemHopDong()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemHopDong_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy  ");

        }

        public void loadPhong(String query)
        {          
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                CB_Phong.Items.Add(item[0].ToString());
                tien = int.Parse(item[6].ToString());
                label14.Text = "Tiền Cọc = " + tien; 
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Phong.Items.Clear();
            if (comboBox2.Text == "Phòng Máy Lạnh Nhỏ")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP001' and Pt.HienTrangPhong = 'false'");  
            }
            if (comboBox2.Text == "Phòng Máy Lạnh Lớn")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP002' and Pt.HienTrangPhong = 'false' ");
            }
            if (comboBox2.Text == "Phòng lớn")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP003' and Pt.HienTrangPhong = 'false'");
            }
            if (comboBox2.Text == "Phòng nhỏ")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP004' and Pt.HienTrangPhong = 'false'");
            }
        }
        private bool ktKhoa(String ts)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang Where MaKH ='" + ts + "'");
            return result.Rows.Count == 0;
        }
        private bool ktHopDong(String ts)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM hopDong Where MaHopDong ='" + ts + "'");
            return result.Rows.Count == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (ktKhoa(txt_MaKH.Text))
            {

                if (ktHopDong(txt_MHD.Text))
                {
                    if (txt_MaKH.Text == "" && txt_MHD.Text == "" && txt_NgaySinh.Text == "" && txt_Nghe.Text == "" && txt_SDT.Text == "" && txt_tenKH.Text == "" && txt_timeBD.Text == "" && comboBox2.Text == "" && CB_Phong.Text == "" && CB_Thang.Text == "")
                    {
                        MessageBox.Show("Không Được Để Trống Thông Tin", "thông báo");
                    }
                    else
                    {
                        DialogResult dlr = MessageBox.Show("bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            int test = DataProvider.Instance.UPDATESQL("SET dateformat DMY; INSERT INTO KhachHang values('" + txt_MaKH.Text + "', N'" + txt_tenKH.Text + "', '" + txt_SDT.Text + "', N'" + txt_Nghe.Text + "', '" + txt_NgaySinh.Text + "', '" + CB_Phong.Text + "', 'true')");
                            test = DataProvider.Instance.UPDATESQL("SET dateformat DMY; INSERT INTO hopDong values('" + txt_MHD.Text + "','" + toolStripStatusLabel1.Text.ToString() + "','" + txt_timeBD.Text + "'," + CB_Thang.Text + ",'" + tien + "','true','" + txt_MaKH.Text + "','" + CB_Phong.Text + "')");
                            test = DataProvider.Instance.UPDATESQL("UPDATE PhongTro SET soNguoiDangO = soNguoiDangO+1 , HienTrangPhong ='true' Where MaPhong ='" + CB_Phong.Text.ToString() + "'");
           
                            if (test == 1)
                            {
                                MessageBox.Show("Thêm thành công", "thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Thêm Không thành công", "thông báo");
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Trùng Mã Hợp Đồng ", "Thông báo");
                }
            }    else
            {
                MessageBox.Show("Trùng Mã Khách Hàng ", "Thông báo");
            }    
        }
    }
}

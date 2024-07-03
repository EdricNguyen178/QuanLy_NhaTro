using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class ThemNV : Form
    {
        String imgloc = "";
        public ThemNV()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String file = openFileDialog1.FileName;
            if (String.IsNullOrEmpty(file))
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image mypic = Image.FromFile(file);
                imgloc = openFileDialog1.FileName.ToString();
                pictureBox1.Image = mypic;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txt_MatKhau.PasswordChar = '\0';
                txt_KTMatKhau.PasswordChar = '\0';
            }
            if (checkBox1.Checked == false)
            {
                txt_MatKhau.PasswordChar = '●';
                txt_KTMatKhau.PasswordChar = '●';
            }
        }
        private bool ktKhoa(String ts)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM nhanVien Where MaNV ='" + ts + "'");
            return result.Rows.Count == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (imgloc != "")
            {

                if (txt_ChucVu.Text == "" && txt_KTMatKhau.Text == "" && txt_Luong.Text == "" && txt_MaNV.Text == "" && txt_MatKhau.Text == "" && txt_SDT.Text == "" && txt_TenNV.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống ", "Thông báo");
                }
                else
                {
                    if (ktKhoa(txt_MaNV.Text))
                    {
                        if (txt_MatKhau.Text == txt_KTMatKhau.Text)
                        {
                            DialogResult dlr = MessageBox.Show("bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dlr == DialogResult.Yes)
                            {
                                byte[] img = null;
                                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                                BinaryReader br = new BinaryReader(fs);
                                img = br.ReadBytes((int)fs.Length);
                                int test = DataProvider.Instance.ADDNV(txt_MaNV.Text, txt_TenNV.Text, txt_SDT.Text, txt_ChucVu.Text, txt_Luong.Text, txt_MatKhau.Text, img);
                                if (test == 1)
                                {
                                    MessageBox.Show("Thêm thành công", "thông báo");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Không thành công", "thông báo");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("nhập lại mật khẩu sai  ", "Thông báo");
                        }
                    }

                    else
                    {
                        MessageBox.Show("trùng mã Nhân Viên  ", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa Chọn Ảnh", "Thông báo");
            }
            
            }

        private void ThemNV_Load(object sender, EventArgs e)
        {

        }
    }
}

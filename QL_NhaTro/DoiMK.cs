using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class DoiMK : Form
    {
        public static String MaNV = "";
        public DoiMK()
        {
            InitializeComponent();
        }
        private void DoiMK_Load(object sender, EventArgs e)
        {
            
        }
        private void Show1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '●')
            {
                hide1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }
        private void Show2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '●')
            {
                hide2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }
        private void Show3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '●')
            {
                hide3.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }
        private void hide1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                Show1.BringToFront();
                textBox1.PasswordChar = '●';
            }
        }
        private void hide2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                Show2.BringToFront();
                textBox2.PasswordChar = '●';
            }
        }
        private void hide3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                Show3.BringToFront();
                textBox3.PasswordChar = '●';
            }
        }
        private bool KtMKCu()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM nhanVien Where MaNV like '" + MaNV + "' and MatKhau = '"+textBox1.Text+"'");
            return result.Rows.Count == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                if (KtMKCu())
                {
                    if (textBox3.Text == textBox2.Text)
                    {
                        DialogResult dlr = MessageBox.Show("bạn chắc chứ  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            byte[] temp = ASCIIEncoding.ASCII.GetBytes(textBox3.Text);
                            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                            string hasPass = "";


                            foreach (byte item in hasData)
                            {
                                hasPass += item;
                            }
                            int test = DataProvider.Instance.UPDATESQL("UPDATE nhanVien SET MatKhau = '"+ hasPass + "' Where MaNV ='" + MaNV + "'");
                            if (test == 1)
                            {
                                MessageBox.Show("thành công", "thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Không thành công", "thông báo");
                            }
                        }
                    }else
                    {
                        MessageBox.Show("Mật Khẩu Nhập Lại Không Đúng ", "thông báo");
                    }    
                }else
                {
                    MessageBox.Show("Mật Khẩu Cũ Sai", "thông báo");
                }    
            }else
            {
                MessageBox.Show("Không Được Để Trống Các Ô", "thông báo");
            }    
            
        }
    }
}

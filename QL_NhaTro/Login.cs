using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhaTro.DAO;

namespace QL_NhaTro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Pass.PasswordChar == '\0')
            {
                button2.BringToFront();
                txt_Pass.PasswordChar = '●';
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_Pass.PasswordChar == '●')
            {
                button1.BringToFront();
                txt_Pass.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool Login1(string userName, string passWord)
        {
            return login.logintest(userName, passWord);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Home.TENDN = txt_Uses.Text;
            DoiMK.MaNV = txt_Uses.Text;
            if (txt_Uses.Text != "" && txt_Pass.Text != "")
            {
                string userName = txt_Uses.Text;
                string passWord = txt_Pass.Text;

                if (Login1(userName, passWord))
                {
                    Home a = new Home();
                    this.Hide();
                    a.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("tài khoãng và mật khẩu không đúng ", "thông báo ");

                }
            } 
            else
            {
                MessageBox.Show("không được để trống mật khẩu hoặc tên đăng nhập ", "thông báo ");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Pass.Text= "123";
            txt_Uses.Text = "nv001";
        }
    }
}

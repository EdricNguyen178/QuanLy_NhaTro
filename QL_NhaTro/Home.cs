using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class Home : Form
    {
        public static string TENDN = "";
        public Home()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelchinh.Controls.Add(childForm);
            this.panelchinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LB_time.Text = DateTime.Now.ToString("hh:mm:ss");
            lb_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Home_Load(object sender, EventArgs e)
        {
            panelTaiKhoan.Visible = false;
            timer1.Start();
           
            LB_time.Text = DateTime.Now.ToString("hh:mm:ss");
            lb_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            SetPhanQuyen();

        }
        public void SetPhanQuyen()
        {
            String query= "SELECT * FROM nhanVien where MaNV like '" + TENDN+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                lb_Ten.Text = item[1].ToString();
                lb_ChucVu.Text= item[3].ToString();
                byte[] anh = (byte[])(item[6]);
                if (anh == null)
                {
                    Pic_avata.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(anh);
                    Pic_avata.Image = Image.FromStream(ms);
                }
            }
            if(lb_ChucVu.Text.Contains("Nhân Viên ")|| lb_ChucVu.Text.Contains("nhân Viên ") || lb_ChucVu.Text.Contains("Nhân viên ") || lb_ChucVu.Text.Contains("nhân viên ") )
            {
                btn_NhanVien.Enabled = btn_hopDong.Enabled = false;
            }
            if (lb_ChucVu.Text.Contains("Quản Lý") || lb_ChucVu.Text.Contains("quản Lý") || lb_ChucVu.Text.Contains("Quản lý") || lb_ChucVu.Text.Contains("quản lý"))
            {
                btn_hopDong.Enabled = false;
            }    
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btn_TaiKhoang_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
           
            if (panelTaiKhoan.Visible == true)
                panelTaiKhoan.Visible = false;
            else
                panelTaiKhoan.Visible = true;
            btn_TaiKhoan.BackColor = Color.Black;
        }
        private void panelTaiKhoang_Paint(object sender, PaintEventArgs e)
        {
        }
        public void resetcolor_bnt()
        {
            btn_DangXuat.BackColor = Color.Moccasin;
            btn_KhachHang.BackColor = Color.Moccasin;
            btn_NhanVien.BackColor = Color.Moccasin;
            btn_Phong.BackColor = Color.Moccasin;
            btn_TaiKhoan.BackColor = Color.Moccasin;
            btn_LapHoaDon.BackColor = Color.Moccasin;
            btn_hopDong.BackColor = Color.Moccasin;
        }
        private void btn_Phong_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
            btn_Phong.BackColor = Color.Black;
            openChildForm(new Phong(), sender);
        }
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
            btn_KhachHang.BackColor = Color.Black;
            openChildForm(new DSKhachHang(), sender);
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
            btn_NhanVien.BackColor = Color.Black;
            openChildForm(new NhanVien(), sender);
        }
        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
            btn_LapHoaDon.BackColor = Color.Black;
            openChildForm(new TKHoaDon(), sender);
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            Login DN = new Login();
            this.Hide();
            DN.ShowDialog();
        }
        private void btn_hopDong_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
            btn_hopDong.BackColor = Color.Black;
            openChildForm(new HopDong(), sender);
        }
        private void btn_DoMK_Click(object sender, EventArgs e)
        {
            DoiMK dmk = new DoiMK();
            dmk.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            resetcolor_bnt();
            panelchinh.Controls.Clear();
        }
    }
}


namespace QL_NhaTro
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_time = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.btn_DoMK = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.lb_ChucVu = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.Pic_avata = new System.Windows.Forms.PictureBox();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_hopDong = new System.Windows.Forms.Button();
            this.btn_LapHoaDon = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_Phong = new System.Windows.Forms.Button();
            this.paneltieude = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelchinh = new System.Windows.Forms.Panel();
            this.panelChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_avata)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.paneltieude.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.Moccasin;
            this.panelChucNang.Controls.Add(this.panel1);
            this.panelChucNang.Controls.Add(this.panelTaiKhoan);
            this.panelChucNang.Controls.Add(this.btn_TaiKhoan);
            this.panelChucNang.Controls.Add(this.panelMenu);
            this.panelChucNang.Controls.Add(this.paneltieude);
            this.panelChucNang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChucNang.Location = new System.Drawing.Point(0, 0);
            this.panelChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(266, 1055);
            this.panelChucNang.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LB_time);
            this.panel1.Controls.Add(this.lb_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 933);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 122);
            this.panel1.TabIndex = 7;
            // 
            // LB_time
            // 
            this.LB_time.AutoSize = true;
            this.LB_time.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LB_time.ForeColor = System.Drawing.Color.Black;
            this.LB_time.Location = new System.Drawing.Point(85, 7);
            this.LB_time.Name = "LB_time";
            this.LB_time.Size = new System.Drawing.Size(65, 28);
            this.LB_time.TabIndex = 3;
            this.LB_time.Text = "label2";
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb_ngay.ForeColor = System.Drawing.Color.Black;
            this.lb_ngay.Location = new System.Drawing.Point(70, 35);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(65, 28);
            this.lb_ngay.TabIndex = 4;
            this.lb_ngay.Text = "label3";
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Controls.Add(this.btn_DoMK);
            this.panelTaiKhoan.Controls.Add(this.btn_DangXuat);
            this.panelTaiKhoan.Controls.Add(this.lb_ChucVu);
            this.panelTaiKhoan.Controls.Add(this.lb_Ten);
            this.panelTaiKhoan.Controls.Add(this.Pic_avata);
            this.panelTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaiKhoan.Location = new System.Drawing.Point(0, 462);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(266, 359);
            this.panelTaiKhoan.TabIndex = 6;
            this.panelTaiKhoan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTaiKhoang_Paint);
            // 
            // btn_DoMK
            // 
            this.btn_DoMK.BackColor = System.Drawing.Color.Moccasin;
            this.btn_DoMK.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_DoMK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_DoMK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DoMK.ForeColor = System.Drawing.Color.Red;
            this.btn_DoMK.Location = new System.Drawing.Point(0, 275);
            this.btn_DoMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoMK.Name = "btn_DoMK";
            this.btn_DoMK.Size = new System.Drawing.Size(266, 42);
            this.btn_DoMK.TabIndex = 3;
            this.btn_DoMK.Text = "Đổi Mật Khẩu ";
            this.btn_DoMK.UseVisualStyleBackColor = false;
            this.btn_DoMK.Click += new System.EventHandler(this.btn_DoMK_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Moccasin;
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_DangXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 317);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(266, 42);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.AutoSize = true;
            this.lb_ChucVu.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lb_ChucVu.ForeColor = System.Drawing.Color.Black;
            this.lb_ChucVu.Location = new System.Drawing.Point(20, 250);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.Size = new System.Drawing.Size(162, 22);
            this.lb_ChucVu.TabIndex = 1;
            this.lb_ChucVu.Text = "Nhân Viên bảo Vệ";
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lb_Ten.ForeColor = System.Drawing.Color.Black;
            this.lb_Ten.Location = new System.Drawing.Point(20, 226);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(178, 22);
            this.lb_Ten.TabIndex = 1;
            this.lb_Ten.Text = "Dương Hoàng Hiếu ";
            // 
            // Pic_avata
            // 
            this.Pic_avata.BackColor = System.Drawing.Color.Moccasin;
            this.Pic_avata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_avata.BackgroundImage")));
            this.Pic_avata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_avata.Location = new System.Drawing.Point(3, 5);
            this.Pic_avata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_avata.Name = "Pic_avata";
            this.Pic_avata.Size = new System.Drawing.Size(263, 219);
            this.Pic_avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_avata.TabIndex = 0;
            this.Pic_avata.TabStop = false;
            this.Pic_avata.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.Moccasin;
            this.btn_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.btn_TaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.Image")));
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(0, 406);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Size = new System.Drawing.Size(266, 56);
            this.btn_TaiKhoan.TabIndex = 5;
            this.btn_TaiKhoan.Text = "Tài Khoản";
            this.btn_TaiKhoan.UseVisualStyleBackColor = false;
            this.btn_TaiKhoan.Click += new System.EventHandler(this.btn_TaiKhoang_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btn_hopDong);
            this.panelMenu.Controls.Add(this.btn_LapHoaDon);
            this.panelMenu.Controls.Add(this.btn_NhanVien);
            this.panelMenu.Controls.Add(this.btn_KhachHang);
            this.panelMenu.Controls.Add(this.btn_Phong);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 66);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(266, 340);
            this.panelMenu.TabIndex = 2;
            // 
            // btn_hopDong
            // 
            this.btn_hopDong.BackColor = System.Drawing.Color.Moccasin;
            this.btn_hopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hopDong.FlatAppearance.BorderSize = 0;
            this.btn_hopDong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hopDong.ForeColor = System.Drawing.Color.Red;
            this.btn_hopDong.Location = new System.Drawing.Point(0, 276);
            this.btn_hopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hopDong.Name = "btn_hopDong";
            this.btn_hopDong.Size = new System.Drawing.Size(266, 63);
            this.btn_hopDong.TabIndex = 5;
            this.btn_hopDong.Text = "Hợp Đồng";
            this.btn_hopDong.UseVisualStyleBackColor = false;
            this.btn_hopDong.Click += new System.EventHandler(this.btn_hopDong_Click);
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.BackColor = System.Drawing.Color.Moccasin;
            this.btn_LapHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LapHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_LapHoaDon.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LapHoaDon.ForeColor = System.Drawing.Color.Red;
            this.btn_LapHoaDon.Location = new System.Drawing.Point(0, 207);
            this.btn_LapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.Size = new System.Drawing.Size(266, 69);
            this.btn_LapHoaDon.TabIndex = 3;
            this.btn_LapHoaDon.Text = "Hóa Đơn ";
            this.btn_LapHoaDon.UseVisualStyleBackColor = false;
            this.btn_LapHoaDon.Click += new System.EventHandler(this.btn_LapHoaDon_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.Moccasin;
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.Red;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 138);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(266, 69);
            this.btn_NhanVien.TabIndex = 2;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.Moccasin;
            this.btn_KhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.Red;
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 69);
            this.btn_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(266, 69);
            this.btn_KhachHang.TabIndex = 1;
            this.btn_KhachHang.Text = "Khách Hàng";
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_Phong
            // 
            this.btn_Phong.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Phong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Phong.FlatAppearance.BorderSize = 0;
            this.btn_Phong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Phong.ForeColor = System.Drawing.Color.Red;
            this.btn_Phong.Location = new System.Drawing.Point(0, 0);
            this.btn_Phong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(266, 69);
            this.btn_Phong.TabIndex = 0;
            this.btn_Phong.Text = "Phòng ";
            this.btn_Phong.UseVisualStyleBackColor = false;
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // paneltieude
            // 
            this.paneltieude.Controls.Add(this.label1);
            this.paneltieude.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.paneltieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltieude.Location = new System.Drawing.Point(0, 0);
            this.paneltieude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltieude.Name = "paneltieude";
            this.paneltieude.Size = new System.Drawing.Size(266, 66);
            this.paneltieude.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ TRỌ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelchinh
            // 
            this.panelchinh.BackgroundImage = global::QL_NhaTro.Properties.Resources.z3444205749902_55ce88b62a36d0cf9e11751503ac13d3;
            this.panelchinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(266, 0);
            this.panelchinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1086, 1055);
            this.panelchinh.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 1055);
            this.Controls.Add(this.panelchinh);
            this.Controls.Add(this.panelChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Trọ ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelChucNang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTaiKhoan.ResumeLayout(false);
            this.panelTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_avata)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.paneltieude.ResumeLayout(false);
            this.paneltieude.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Panel paneltieude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_Phong;
        private System.Windows.Forms.Button btn_LapHoaDon;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label LB_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.PictureBox Pic_avata;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lb_ChucVu;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Panel panelchinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_hopDong;
        private System.Windows.Forms.Button btn_DoMK;
    }
}
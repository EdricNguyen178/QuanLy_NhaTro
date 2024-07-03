
namespace QL_NhaTro
{
    partial class TKHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKHoaDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_MaP = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.txt_Nam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CB_thang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_MaP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 80);
            this.panel1.TabIndex = 0;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(589, 25);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(108, 22);
            this.txt_Nam.TabIndex = 6;
            this.txt_Nam.TextChanged += new System.EventHandler(this.txt_Nam_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tháng ";
            // 
            // CB_thang
            // 
            this.CB_thang.FormattingEnabled = true;
            this.CB_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CB_thang.Location = new System.Drawing.Point(386, 25);
            this.CB_thang.Name = "CB_thang";
            this.CB_thang.Size = new System.Drawing.Size(121, 24);
            this.CB_thang.TabIndex = 2;
            this.CB_thang.SelectedIndexChanged += new System.EventHandler(this.CB_thang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng ";
            // 
            // CB_MaP
            // 
            this.CB_MaP.FormattingEnabled = true;
            this.CB_MaP.Items.AddRange(new object[] {
            "full"});
            this.CB_MaP.Location = new System.Drawing.Point(94, 25);
            this.CB_MaP.Name = "CB_MaP";
            this.CB_MaP.Size = new System.Drawing.Size(202, 24);
            this.CB_MaP.TabIndex = 0;
            this.CB_MaP.SelectedIndexChanged += new System.EventHandler(this.CB_MaP_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 122);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(643, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 122);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Tiền : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 354);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MaP,
            this.NgayLap,
            this.TienP,
            this.SKWD,
            this.SKNuoc,
            this.PhiPS,
            this.MaKH,
            this.GC,
            this.Tong});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaNV
            // 
            this.MaNV.FillWeight = 50F;
            this.MaNV.HeaderText = "Mã NV ";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // MaP
            // 
            this.MaP.FillWeight = 50F;
            this.MaP.HeaderText = "Mã Phòng ";
            this.MaP.MinimumWidth = 6;
            this.MaP.Name = "MaP";
            this.MaP.ReadOnly = true;
            // 
            // NgayLap
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayLap.HeaderText = "Ngày Lặp Hóa Đơn ";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TienP
            // 
            this.TienP.HeaderText = "Tiền Phòng Trọ";
            this.TienP.MinimumWidth = 6;
            this.TienP.Name = "TienP";
            this.TienP.ReadOnly = true;
            // 
            // SKWD
            // 
            this.SKWD.FillWeight = 60F;
            this.SKWD.HeaderText = "Số KW Điện ";
            this.SKWD.MinimumWidth = 6;
            this.SKWD.Name = "SKWD";
            this.SKWD.ReadOnly = true;
            // 
            // SKNuoc
            // 
            this.SKNuoc.FillWeight = 60F;
            this.SKNuoc.HeaderText = "Số Khối Nước";
            this.SKNuoc.MinimumWidth = 6;
            this.SKNuoc.Name = "SKNuoc";
            this.SKNuoc.ReadOnly = true;
            // 
            // PhiPS
            // 
            this.PhiPS.HeaderText = "Chi Phí Phát Sinh(nếu có)";
            this.PhiPS.MinimumWidth = 6;
            this.PhiPS.Name = "PhiPS";
            this.PhiPS.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.FillWeight = 60F;
            this.MaKH.HeaderText = "Mã Khách Hàng ";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // GC
            // 
            this.GC.HeaderText = "Ghi Chú";
            this.GC.MinimumWidth = 6;
            this.GC.Name = "GC";
            this.GC.ReadOnly = true;
            // 
            // Tong
            // 
            this.Tong.HeaderText = "Tổng Tiền ";
            this.Tong.MinimumWidth = 6;
            this.Tong.Name = "Tong";
            this.Tong.ReadOnly = true;
            // 
            // TKHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKHoaDon";
            this.Text = "TKHoaDon";
            this.Load += new System.EventHandler(this.TKHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_MaP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_thang;
        private System.Windows.Forms.TextBox txt_Nam;
    }
}
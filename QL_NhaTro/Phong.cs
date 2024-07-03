using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QL_NhaTro.DAO;

namespace QL_NhaTro
{
    
    public partial class Phong : Form
    {
        public String MaNV;
        DataProvider DT = new DataProvider();
        public Phong()
        {
            InitializeComponent();

        }
        private void Phong_Load(object sender, EventArgs e)
        {
            loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai");
        }
        public void loadPhong(String query)
        {
            flowLayoutPanelPhong.Controls.Clear();
            Button Bphong;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                Bphong = new Button();
                bool KT = Boolean.Parse(item[3].ToString());
                
                String NAME = "PHÒNG " + item[0].ToString() + "\n giá: " + item[6].ToString() + "\n số người : "+ item[2].ToString() +"/"+item[7].ToString() ;
                Mot_Phong(Bphong, NAME, KT, item[0].ToString());
                flowLayoutPanelPhong.Controls.Add(Bphong);
            }
        }
        public void Mot_Phong(Button a,String name,bool kt,String MaP)
        {
            a.Font = new Font("arial", 14);
                    a.Name = MaP;
                    a.Size = new Size(150, 150);
                    a.Text = name;
                      a.ForeColor = Color.Black ;
                    if(kt==true)
                    a.BackColor = Color.LimeGreen;
                    else
                     a.BackColor = Color.White;
                      a.ContextMenuStrip = contextMenuStrip1;
                    a.Click += new System.EventHandler(bt_click);
            //ThongTinPhong.a = a.Text;
            //a.MouseHover += new System.EventHandler(bt_MouseHover);
            //a.MouseLeave += new System.EventHandler(bt_MouseLeave);
        }
        private void bt_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
           ThongTinPhong.a = bt.Name;
            ThongTinPhong b = new ThongTinPhong();            
            b.ShowDialog();
            loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai");
        }
        //private void bt_MouseHover(object sender, EventArgs e)
        //{
        //    Button bt = sender as Button;
        //    bt.BackColor = Color.Green;
        //}
        //private void bt_MouseLeave(object sender, EventArgs e)
        //{
        //    Button bt = sender as Button;
        //    bt.BackColor = Color.Red;
        //}
        public void CLEARPhong()
        {
            flowLayoutPanelPhong.Controls.Clear();

        }
        private void CB_TimPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_TimPhong.Text == "Phòng Trống ")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where HienTrangPhong = 'False'");
            }
            if (CB_TimPhong.Text == "Phòng Có Người ")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where HienTrangPhong = 'True' ");
            }
            if (CB_TimPhong.Text == "Full")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai");
            }
        }
        private void CB_LoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_LoaiPhong.Text == "Phòng Máy Lạnh Nhỏ")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP001'");
            }
            if (CB_LoaiPhong.Text == "Phòng Máy Lạnh Lớn")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP002' ");
            }
            if (CB_LoaiPhong.Text == "Phòng lớn")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP003'");
            }
            if (CB_LoaiPhong.Text == "Phòng nhỏ")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where lp.MaLoai ='LP004'");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai");
            }
            else  
            loadPhong("SELECT * FROM PhongTro pt FULL OUTER JOIN LoaiPhong lp  on  pt.MaLoai = lp.MaLoai Where MaPhong like '%" + textBox1.Text.ToString() + "%'");

        }
    }
}

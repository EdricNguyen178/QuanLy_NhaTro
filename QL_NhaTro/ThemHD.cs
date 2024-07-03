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
using ThuVienWinform.Report.AsposeWordExtension;
using Aspose.Words;

namespace QL_NhaTro
{
    public partial class ThemHD : Form
    {
        public static string MaP = "";
        String MaKH = "";
        String MaNV = "";
        String ghichu = "";
        double tienPS = 0;
        double tienP = 0;
        double tiennuoc = 0;
        double tiendien = 0;
        double SoKhoiNuocCu = 0;
        double SoKWDienCu = 0;
        public ThemHD()
        {
            InitializeComponent();
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            label2.Text += "Tháng " + DateTime.Now.ToString("MM");
            if (kthoadon())
            {
                if(ktphong())
                {
                    MessageBox.Show("Phòng Không Có người Ở ", "Thông Báo ");
                    this.Close();
                }  else
                {

                    label1.Text = MaP;
                    toolStripStatusLabel1.Text = DateTime.Now.ToString("dd-MM-yyyy  ");
                }    
                  
            }  else
            {
                MessageBox.Show("Tháng này bạn đã đống tiền rồi", "Thông Báo ");
                this.Close();
            }
            loattienphong();
            loadKH();
            loadNV();
            LoadHDCu();

            }
        private void loattienphong()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("select lp.gia from PhongTro p full outer join LoaiPhong lp on p.MaLoai=lp.MaLoai where p.MaPhong= '" + MaP + "'");
            tienP = int.Parse(result.Rows[0][0].ToString());
            label8.Text = tienP.ToString();
        }
        private bool ktphong()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("select * from PhongTro where soNguoiDangO > 0 and MaPhong = '" + MaP + "'");
            return result.Rows.Count == 0;
        }
        private bool kthoadon()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("select * from HoaDon where MONTH (NgayLapHD) =" + DateTime.Now.ToString("MM") + " and YEAR(NgayLapHD) = " + DateTime.Now.ToString("yyyy") + "and MaPhong = '"+MaP+"'");
            return result.Rows.Count == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadKH()
        {
         
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang where MaPhong = '" + label1.Text + "'");
            foreach (DataRow item in result.Rows)
            {
                CB_TenKH.Items.Add(item[1]);
            }
        }
        private void LoadHDCu()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM DHNuoc where MaP = '" + label1.Text + "'");
            foreach (DataRow item in result.Rows)
            {
                SoKhoiNuocCu = double.Parse(item[1].ToString());
            }
            DataTable result1 = DataProvider.Instance.ExecuteQuery("SELECT * FROM DHDien where MaP = '" + label1.Text + "'");
            foreach (DataRow item in result1.Rows)
            {
                SoKWDienCu = double.Parse(item[1].ToString());
            }

        }
        private void loadNV()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM nhanVien where ChucVu like 'Nhân Viên Thu Ngân'");
            foreach (DataRow item in result.Rows)
            {
                CB_MaNV.Items.Add(item[1]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_ghiChu.Text=="")
            {
                ghichu = "K";
            }    else
            {
                ghichu = txt_ghiChu.Text;
            }
            double d = double.Parse(txt_SoDien.Text.ToString())- SoKWDienCu;
            double n = double.Parse(txt_SoNuoc.Text.ToString()) - SoKhoiNuocCu;
            int test = DataProvider.Instance.UPDATESQL("SET dateformat DMY; INSERT INTO HoaDon values('"+MaNV+"','"+MaP+"','"+ toolStripStatusLabel1 .Text+ "','"+tienP+"','"+d+"','"+n+"','"+txt_ChiPhiPS.Text+"','"+MaKH+"','"+ghichu+"','"+label8.Text+"')");
             test = DataProvider.Instance.UPDATESQL("UPDATE DHNuoc SET SoNuoc ='"+txt_SoNuoc.Text+"' Where MaP ='" + MaP + "'");
             test = DataProvider.Instance.UPDATESQL("UPDATE DHDien SET SoDien ='"+txt_SoDien.Text+"' Where MaP ='" + MaP + "'");

            if (test == 1)
            {

                DialogResult dlr= MessageBox.Show("Thêm thành công \n bạn có muốn in hóa đơn ko ", "thông báo",MessageBoxButtons.YesNo);
                if (dlr==DialogResult.Yes)
                {
                    XuatHoaDon();
                    this.Close();
                }
                else
                {
                    this.Close();
                }    
            }
            else
            {
                MessageBox.Show("Thêm Không thành công", "thông báo");
            }
        }
        private void txt_SoDien_TextChanged(object sender, EventArgs e)
        {
            tiendien = 0;
            if (txt_SoDien.Text == "")
            {
                tiendien = 0;
                label8.Text = (tienP + tiendien + tiennuoc+tienPS).ToString();
            }
            else
            {
                tiendien += (((int.Parse(txt_SoDien.Text.ToString())-SoKWDienCu) * 3000));
                label8.Text = (tienP+tiendien+tiennuoc+tienPS).ToString();
            }
        }
        private void txt_SoDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_SoNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_ChiPhiPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_SoNuoc_TextChanged(object sender, EventArgs e)
        {
            tiennuoc = 0;
            if (txt_SoNuoc.Text == "")
            {
                tiennuoc = 0;
                label8.Text = (tienP + tiendien + tiennuoc+tienPS).ToString();
            }
            else
            {
                tiennuoc += (((int.Parse(txt_SoNuoc.Text.ToString())-SoKhoiNuocCu) * 2500));
                label8.Text = (tienP + tiendien + tiennuoc+tienPS).ToString();
            }
          
        }
        private void txt_ChiPhiPS_TextChanged(object sender, EventArgs e)
        {
            tienPS = 0;
            if (txt_ChiPhiPS.Text == "")
            {
                tienPS = 0;
                label8.Text = (tienP + tiendien + tiennuoc + tienPS).ToString();
            }
            else
            {
                tienPS += ((int.Parse(txt_ChiPhiPS.Text.ToString())));
                label8.Text = (tienP + tiendien + tiennuoc+tienPS).ToString();
            }
        }
        private void CB_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT MaNV FROM nhanVien where TenNV like N'"+CB_MaNV.Text+"'");
            MaNV = result.Rows[0][0].ToString();         
        }
        private void CB_TenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT MaKH FROM KhachHang where TenKH like N'" + CB_TenKH.Text + "'");
            MaKH = result.Rows[0][0].ToString();
        }
        private void XuatHoaDon()
        {
            Document HoaDon = new Document("Template\\HoaDon.doc");

            HoaDon.MailMerge.Execute(new[] { "Thang" }, new[] { DateTime.Now.Month.ToString() });
            HoaDon.MailMerge.Execute(new[] { "Phong" }, new[] { MaP });
            HoaDon.MailMerge.Execute(new[] { "«Ngay_lap_HD»" }, new[] { DateTime.Now.ToString("dd/MM/yyyy") });
            HoaDon.MailMerge.Execute(new[] { "TenNV" }, new[] { CB_MaNV });
            HoaDon.MailMerge.Execute(new[] { "TenKH" }, new[] { CB_TenKH });
            HoaDon.MailMerge.Execute(new[] { "TienPhong" }, new[] { tienP.ToString() });
            HoaDon.MailMerge.Execute(new[] { "SoKhoiNuoc" }, new[] { (int.Parse(txt_SoNuoc.Text.ToString()) - SoKhoiNuocCu).ToString() });
            HoaDon.MailMerge.Execute(new[] { "TienNuoc" }, new[] { tiennuoc.ToString() });
            HoaDon.MailMerge.Execute(new[] { "SoKWDien" }, new[] { (int.Parse(txt_SoDien.Text.ToString()) - SoKWDienCu).ToString() });
            HoaDon.MailMerge.Execute(new[] { "TienDien" }, new[] { tiendien.ToString() });
            HoaDon.MailMerge.Execute(new[] { "TienPS" }, new[] { tienPS.ToString() });
            HoaDon.MailMerge.Execute(new[] { "TongTien" }, new[] { label8.ToString() });
            HoaDon.MailMerge.Execute(new[] { "GhiChu" }, new[] { txt_ghiChu.Text.ToString() });

            HoaDon.MailMerge.Execute(new[] { "Nguoi_Giam_Ho" }, new[] { "Nguyễn Văn A" });

            HoaDon.SaveAndOpenFile("HoaDon.doc");
        }

        
    }
}

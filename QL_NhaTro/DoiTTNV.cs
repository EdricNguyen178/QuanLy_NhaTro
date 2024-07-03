using QL_NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class DoiTTNV : Form
    {
        public static String MVN = "";
       String imgloc = "";
        public DoiTTNV()
        {
            InitializeComponent();
        }

        private void DoiTTNV_Load(object sender, EventArgs e)
        {
            label1.Text = " Nhân Viên : " + MVN;
            loadNV();
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


        public void loadNV()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT * FROM nhanVien Where MaNV = '"+MVN+"' ");
            foreach (DataRow item in result.Rows)
            {
                byte[] anh = (byte[])(item[6]);
                MemoryStream ms = new MemoryStream(anh);
                pictureBox1.Image = Image.FromStream(ms);
                txt_Ten.Text = item[1].ToString();
                txt_ChucVu.Text = item[3].ToString();
                txt_Luong.Text = item[4].ToString();
                txt_SDT.Text = item[2].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test = 0;
                DialogResult dlr = MessageBox.Show("chắc chứ  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (imgloc == "")
                {
                    test = DataProvider.Instance.UPDATESQL("UPDATE nhanVien SET TenNV = N'" + txt_Ten.Text + "', ChucVu = N'" + txt_ChucVu.Text + "', Luong = '" + txt_Luong.Text + "', SĐT = '" + txt_SDT.Text + "' Where MaNV = '" + MVN + "'");

                }
                else
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    test = DataProvider.Instance.UPDATENV(MVN, txt_Ten.Text, txt_SDT.Text, txt_ChucVu.Text, txt_Luong.Text, img);

                }
            }
                if (test == 1)
                    {
                        MessageBox.Show("thay đỏi  thành công", "thông báo");
                    this.Close();
                }
                    else
                    {
                        MessageBox.Show("thay đỏi Không thành công", "thông báo");
                    }
                }
            
    }
}


using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoDA
{
    public partial class frmChonPhong : Form
    {
        List<Button> bt = new List<Button>();
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        NhanVien nhanVien = new NhanVien();
        public frmChonPhong(NhanVien nv)
        {
            InitializeComponent();
            this.nhanVien = nv;
        }
        public frmChonPhong()
        {
            
            InitializeComponent();
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formbook_Load(object sender, EventArgs e)
        {
            List<Button> lColors = this.Controls.OfType<Button>().ToList();
            List<string> list = new List<string>();
            var query = (from n in db.Phongs
                         select n.Available);
            list = query.ToList<string>();
            //lblPhongTrong.Text = lColors.Count().ToString();
            /*
            for (int i=0;i<lColors.Count();i++)
            {
                if (list[i] == "Trong") lColors[i].BackColor = Color.Green;
                else if (list[i] == "Dat") lColors[i].BackColor = Color.Red;
                else
                {
                    lColors[i].BackColor = Color.DarkGray;
                    lColors[i].Enabled = false;
                }
            }*/

            if (list[0] == "Trong") btnP101.BackColor = Color.Green; else if (list[0] == "Dat") btnP101.BackColor = Color.Red; else { btnP101.BackColor = Color.Gray; btnP101.Enabled = false; }
            if (list[1] == "Trong") btnP102.BackColor = Color.Green; else if (list[1] == "Dat") btnP102.BackColor = Color.Red; else { btnP102.BackColor = Color.Gray; btnP102.Enabled = false; }
            if (list[2] == "Trong") btnP103.BackColor = Color.Green; else if (list[2] == "Dat") btnP103.BackColor = Color.Red; else { btnP103.BackColor = Color.Gray; btnP103.Enabled = false; }
            if (list[3] == "Trong") btnP104.BackColor = Color.Green; else if (list[3] == "Dat") btnP104.BackColor = Color.Red; else { btnP104.BackColor = Color.Gray; btnP104.Enabled = false; }
            if (list[4] == "Trong") btnP201.BackColor = Color.Green; else if (list[4] == "Dat") btnP201.BackColor = Color.Red; else { btnP201.BackColor = Color.Gray; btnP201.Enabled = false; }
            if (list[5] == "Trong") btnP202.BackColor = Color.Green; else if (list[5] == "Dat") btnP202.BackColor = Color.Red; else { btnP202.BackColor = Color.Gray; btnP202.Enabled = false; }
            if (list[6] == "Trong") btnP203.BackColor = Color.Green; else if (list[6] == "Dat") btnP203.BackColor = Color.Red; else { btnP203.BackColor = Color.Gray; btnP203.Enabled = false; }
            if (list[7] == "Trong") btnP204.BackColor = Color.Green; else if (list[7] == "Dat") btnP204.BackColor = Color.Red; else { btnP204.BackColor = Color.Gray; btnP204.Enabled = false; }
            if (list[8] == "Trong") btnP301.BackColor = Color.Green; else if (list[8] == "Dat") btnP301.BackColor = Color.Red; else { btnP301.BackColor = Color.Gray; btnP301.Enabled = false; }
            if (list[9] == "Trong") btnP302.BackColor = Color.Green; else if (list[9] == "Dat") btnP302.BackColor = Color.Red; else { btnP302.BackColor = Color.Gray; btnP302.Enabled = false; }
            if (list[10] == "Trong") btnP303.BackColor = Color.Green; else if (list[10] == "Dat") btnP303.BackColor = Color.Red; else { btnP303.BackColor = Color.Gray; btnP303.Enabled = false; }
            if (list[11] == "Trong") btnP304.BackColor = Color.Green; else if (list[11] == "Dat") btnP304.BackColor = Color.Red; else { btnP304.BackColor = Color.Gray; btnP304.Enabled = false; }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom101_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P001"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P001" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if(btnP101.BackColor== Color.Green)
            {
                
                frmDatPhong fbook = new frmDatPhong(p,nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp,nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom105_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom405_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom404_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom403_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom402_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom401_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom301_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P009"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P009" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP301.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom302_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P010"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P010" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP302.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom303_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P011"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P011" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP303.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom304_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P012"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P012" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP304.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom305_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom306_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom206_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom205_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void btroom204_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P008"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P008" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP204.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom203_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P007"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P007" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP203.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom202_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P006"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P006" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP202.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom201_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P005"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P005" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP201.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom102_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P002"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P002" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP102.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom103_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P003"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P003" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP103.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom104_Click(object sender, EventArgs e)
        {
            Phong p = (from n in db.Phongs
                       where n.MaPhong == "P004"
                       select n).SingleOrDefault();
            DatPhong dp = (from n in db.DatPhongs
                           where n.MaPhong == "P004" && n.TinhTrangThanhToan == "Chua Thanh Toan"
                           select n).SingleOrDefault();
            if (btnP104.BackColor == Color.Green)
            {

                frmDatPhong fbook = new frmDatPhong(p, nhanVien);
                this.Hide();
                fbook.ShowDialog();
            }
            else
            {
                frmThanhToan fthanhtoan = new frmThanhToan(dp, nhanVien);
                this.Hide();
                fthanhtoan.ShowDialog();
            }
        }

        private void btroom106_Click(object sender, EventArgs e)
        {
            frmDatPhong fbook = new frmDatPhong();
            this.Hide();
            fbook.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboLP_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            var query = (from n in db.Phongs
                         select n.MaLoaiPhong);
            list = query.ToList<string>();
            ComboBox cb = sender as ComboBox;
            string s = cb.SelectedItem.ToString();
            
            if (s =="Phong 1 giuong don")
            {
                if (list[0] == "LP01") btnP101.Visible = true; else btnP101.Visible = false;
                if (list[1] == "LP01") btnP102.Visible = true; else btnP102.Visible = false;
                if (list[2] == "LP01") btnP103.Visible = true; else btnP103.Visible = false;
                if (list[3] == "LP01") btnP104.Visible = true; else btnP104.Visible = false;
                if (list[4] == "LP01") btnP201.Visible = true; else btnP201.Visible = false;
                if (list[5] == "LP01") btnP202.Visible = true; else btnP202.Visible = false;
                if (list[6] == "LP01") btnP203.Visible = true; else btnP203.Visible = false;
                if (list[7] == "LP01") btnP304.Visible = true; else btnP204.Visible = false;
                if (list[8] == "LP01") btnP301.Visible = true; else btnP301.Visible = false;
                if (list[9] == "LP01") btnP302.Visible = true; else btnP302.Visible = false;
                if (list[10] == "LP01") btnP303.Visible = true; else btnP303.Visible = false;
                if (list[11] == "LP01") btnP304.Visible = true; else btnP304.Visible = false;

            }
            if (s == "Phong 2 giuong don")
            {
                if (list[0] == "LP02") btnP101.Visible = true; else btnP101.Visible = false;
                if (list[1] == "LP02") btnP102.Visible = true; else btnP102.Visible = false;
                if (list[2] == "LP02") btnP103.Visible = true; else btnP103.Visible = false;
                if (list[3] == "LP02") btnP104.Visible = true; else btnP104.Visible = false;
                if (list[4] == "LP02") btnP201.Visible = true; else btnP201.Visible = false;
                if (list[5] == "LP02") btnP202.Visible = true; else btnP202.Visible = false;
                if (list[6] == "LP02") btnP203.Visible = true; else btnP203.Visible = false;
                if (list[7] == "LP02") btnP304.Visible = true; else btnP204.Visible = false;
                if (list[8] == "LP02") btnP301.Visible = true; else btnP301.Visible = false;
                if (list[9] == "LP02") btnP302.Visible = true; else btnP302.Visible = false;
                if (list[10] == "LP02") btnP303.Visible = true; else btnP303.Visible = false;
                if (list[11] == "LP02") btnP304.Visible = true; else btnP304.Visible = false;

            }
            if (s == "Phong 1 giuong doi")
            {
                if (list[0] == "LP03") btnP101.Visible = true; else btnP101.Visible = false;
                if (list[1] == "LP03") btnP102.Visible = true; else btnP102.Visible = false;
                if (list[2] == "LP03") btnP103.Visible = true; else btnP103.Visible = false;
                if (list[3] == "LP03") btnP104.Visible = true; else btnP104.Visible = false;
                if (list[4] == "LP03") btnP201.Visible = true; else btnP201.Visible = false;
                if (list[5] == "LP03") btnP202.Visible = true; else btnP202.Visible = false;
                if (list[6] == "LP03") btnP203.Visible = true; else btnP203.Visible = false;
                if (list[7] == "LP03") btnP304.Visible = true; else btnP204.Visible = false;
                if (list[8] == "LP03") btnP301.Visible = true; else btnP301.Visible = false;
                if (list[9] == "LP03") btnP302.Visible = true; else btnP302.Visible = false;
                if (list[10] == "LP03") btnP303.Visible = true; else btnP303.Visible = false;
                if (list[11] == "LP03") btnP304.Visible = true; else btnP304.Visible = false;

            }
            if (s == "Phong 2 giuong doi")
            {
                if (list[0] == "LP04") btnP101.Visible = true; else btnP101.Visible = false;
                if (list[1] == "LP04") btnP102.Visible = true; else btnP102.Visible = false;
                if (list[2] == "LP04") btnP103.Visible = true; else btnP103.Visible = false;
                if (list[3] == "LP04") btnP104.Visible = true; else btnP104.Visible = false;
                if (list[4] == "LP04") btnP201.Visible = true; else btnP201.Visible = false;
                if (list[5] == "LP04") btnP202.Visible = true; else btnP202.Visible = false;
                if (list[6] == "LP04") btnP203.Visible = true; else btnP203.Visible = false;
                if (list[7] == "LP04") btnP304.Visible = true; else btnP204.Visible = false;
                if (list[8] == "LP04") btnP301.Visible = true; else btnP301.Visible = false;
                if (list[9] == "LP04") btnP302.Visible = true; else btnP302.Visible = false;
                if (list[10] == "LP04") btnP303.Visible = true; else btnP303.Visible = false;
                if (list[11] == "LP04") btnP304.Visible = true; else btnP304.Visible = false;

            }

        }
    }
}

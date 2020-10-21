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
    public partial class frmMain : Form
    {
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        public frmMain()
        {
            InitializeComponent();
        }

        public string mnv = "";
        public string tnv = "";

        public frmMain(string mnv)
        {
            InitializeComponent();
            this.mnv = mnv;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btbook_Click(object sender, EventArgs e)
        {
            NhanVien pq = (from n in db.NhanViens
                           where n.MaNhanVien == mnv
                           select n).SingleOrDefault();
            frmChonPhong fbook = new frmChonPhong(pq);
            fbook.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //forminfoNV finfonv = new forminfoNV();
            //finfonv.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKhachHang finfoKH = new frmKhachHang();
            finfoKH.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmNhanVien fquanlyNV = new frmNhanVien();
            fquanlyNV.ShowDialog();
        }

        private void menustripusername_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChinhSuaPhong fupdateroom = new frmChinhSuaPhong();
            fupdateroom.ShowDialog();
        }

        private void btchinhsuaDV_Click(object sender, EventArgs e)
        {
            frmDichVu fupdateDV = new frmDichVu();
            fupdateDV.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            NhanVien pq = (from n in db.NhanViens
                         where n.MaNhanVien == mnv
                         select n).SingleOrDefault();
            txtPhanQuyen.Text = "Xin chào "+ pq.TenNhanVien;
            if (pq.ChucVu=="Le tan")
            {
                btnQLNhanVien.Enabled = false;
                btnCSPhong.Enabled = false;
                btnCSDichVu.Enabled = false;
            }    
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSuDatPhong fls = new frmLichSuDatPhong();
            fls.ShowDialog();
        }
    }
}

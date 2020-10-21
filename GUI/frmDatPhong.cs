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
    public partial class frmDatPhong : Form
    {
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        public Phong ph;
        public NhanVien nv;
        public frmDatPhong(Phong p,NhanVien n)
        {
            InitializeComponent();
            this.ph = p;
            this.nv = n;
        }
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (ph.MaLoaiPhong == "LP01") txtLoaiPhong.Text = "Phong 1 giuong don";
            else if (ph.MaLoaiPhong == "LP02") txtLoaiPhong.Text = "Phong 2 giuong don";
            else if (ph.MaLoaiPhong == "LP03") txtLoaiPhong.Text = "Phong 1 giuong doi";
            else txtLoaiPhong.Text = "Phong 2 giuong doi";
            txtSoPhong.Text = ph.TenPhong;
            txtTang.Text = ph.Tang;
            txtLoaiPhong.Enabled = false;
            txtSoPhong.Enabled = false;
            txtTang.Enabled = false;
            List<string> dv = new List<string>();
            List<string> makh= new List<string>();
            List<string> tenkh = new List<string>();
            var tdv = (from n in db.DichVus
                       select n.TenDichVu);
            dv = tdv.ToList<string>();
            
            for (int i=0;i<dv.Count();i++)
            {
                clbDichVu.Items.Insert(i, dv[i]);
            }
            clbDichVu.Visible = false;
            var tkh = (from n in db.KhachHangs
                       select n.TenKhachHang);
            tenkh = tkh.ToList <string>();
           
            cboKhachHang.DataSource = tenkh;
            cboKhachHang.Text = "";
            var mkh = (from n in db.KhachHangs
                       select n.MaKhachHang);
            makh = mkh.ToList<string>();
            makh.Sort();
            int count = makh.Count()-1;
            
            makh[count] = makh[count].Remove(makh[count].Length - 1, 1) + (int.Parse(makh[count].Last().ToString())+1).ToString();
            txtMaKHDP.Text = makh[count];
            txtMaKHDP.Enabled = false;
        }

        private void formbook_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChonPhong froom = new frmChonPhong();
            this.Hide();
            froom.ShowDialog();
        }

        private void btcomfirm_Click(object sender, EventArgs e)
        {
            if(cboKhachHang.Text=="")
            {
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = txtMaKHDP.Text;
                kh.TenKhachHang = txtHoTenDP.Text;
                kh.SoDienThoai = txtSDTDP.Text;
                kh.NgaySinh = dtpNgaySinhDP.Value.ToString();
                kh.PassPort = txtPassPortDP.Text;
                kh.QuocTich = txtQuocTichDP.Text;
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
                //Ma Dat Phong
                DatPhong dp = new DatPhong();
                List<string> mdp = new List<string>();
                var madp = (from n in db.DatPhongs
                           select n.MaDatPhong);
                mdp = madp.ToList<string>();
                mdp.Sort();
                int count = mdp.Count() - 1;
                mdp[count] = mdp[count].Remove(mdp[count].Length - 1, 1) + (int.Parse(mdp[count].Last().ToString()) + 1).ToString();
                //Ma Dich Vu
                string dv = clbDichVu.CheckedItems.ToString();
                string query = (from n in db.DichVus
                             where n.TenDichVu == dv
                             select n.MaDichVu).FirstOrDefault();
                //Tinh tien

                double ngay = (dtpNgayTra.Value - dtpNgayDat.Value).TotalDays;
                //int ngay = int.Parse((dtpNgayTra.Value.Date - dtpNgayDat.Value.Date).ToString());
                int giaP = (from n in db.LoaiPhongs
                           where n.MaLoaiPhong == ph.MaLoaiPhong
                           select n.Gia).FirstOrDefault();
                int giaDV = (from n in db.DichVus
                             where n.TenDichVu == dv
                             select n.Gia).FirstOrDefault();
                double giaphong = ngay * giaP;
                //Ma Nhan Vien


                dp.MaDatPhong = mdp[count];
                dp.MaPhong= ph.MaPhong;
                //dp.MaDichVu = query;
                dp.MaNhanVien = nv.MaNhanVien;
                dp.MaKhachHang = kh.MaKhachHang;
                dp.NgayDat = dtpNgayDat.Value.ToString();
                dp.NgayTra = dtpNgayTra.Value.ToString();
                dp.TinhTrangThanhToan = "Chua thanh toan";
                //dp.ThanhTien = int.Parse(giaphong.ToString());
                db.DatPhongs.InsertOnSubmit(dp);
                db.SubmitChanges();

                
                MessageBox.Show("Dat phong thanh cong");

                //Chinh tinh trang phong
                Phong phon = db.Phongs.FirstOrDefault(s => s.MaPhong == ph.MaPhong);
                phon.Available = "Dat";
                db.SubmitChanges();

                frmChonPhong f = new frmChonPhong(nv);
                this.Close();
                f.ShowDialog();


            }
            else if(cboKhachHang.Text!=null)
            {
                string tkh = cboKhachHang.Text;
                KhachHang kha = (from n in db.KhachHangs
                                where n.TenKhachHang == tkh
                                select n).FirstOrDefault();
                //Ma Dat Phong
                DatPhong dp = new DatPhong();
                List<string> mdp = new List<string>();
                var madp = (from n in db.DatPhongs
                            select n.MaDatPhong);
                mdp = madp.ToList<string>();
                mdp.Sort();
                int count = mdp.Count() - 1;
                mdp[count] = mdp[count].Remove(mdp[count].Length - 1, 1) + (int.Parse(mdp[count].Last().ToString()) + 1).ToString();
                //Ma Dich Vu
                string dv = clbDichVu.CheckedItems.ToString();
                string query = (from n in db.DichVus
                                where n.TenDichVu == dv
                                select n.MaDichVu).FirstOrDefault();
                //Tinh tien
                double ngay = (dtpNgayTra.Value - dtpNgayDat.Value).TotalDays;
                //int ngay = int.Parse((dtpNgayTra.Value.Date - dtpNgayDat.Value.Date).ToString());
                int giaP = (from n in db.LoaiPhongs
                            where n.MaLoaiPhong == ph.MaLoaiPhong
                            select n.Gia).FirstOrDefault();
                int giaDV = (from n in db.DichVus
                             where n.TenDichVu == dv
                             select n.Gia).FirstOrDefault();
                double giaphong = ngay * giaP;
                //Ma Nhan Vien


                dp.MaDatPhong = mdp[count];
                dp.MaPhong = ph.MaPhong;
                //dp.MaDichVu = query;
                dp.MaNhanVien = nv.MaNhanVien;
                dp.MaKhachHang = kha.MaKhachHang;
                dp.NgayDat = dtpNgayDat.Value.ToString();
                dp.NgayTra = dtpNgayTra.Value.ToString();
                //dp.ThanhTien = giaphong;
                dp.TinhTrangThanhToan = "Chua thanh toan";
                db.DatPhongs.InsertOnSubmit(dp);
                db.SubmitChanges();


                MessageBox.Show("Dat phong thanh cong");

                //Chinh tinh trang phong
                Phong phon = db.Phongs.FirstOrDefault(s => s.MaPhong == ph.MaPhong);
                phon.Available = "Dat";
                db.SubmitChanges();

                frmChonPhong f = new frmChonPhong(nv);
                this.Close();
                f.ShowDialog();



            }    
            
        }
    }
}

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
    public partial class frmThanhToan : Form
    {
        NhanVien nhanVien = new NhanVien();
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        DatPhong dp = new DatPhong();
        public frmThanhToan(DatPhong datphong,NhanVien nv)
        {
            InitializeComponent();
            this.dp = datphong;
            this.nhanVien = nv;
        }
        public frmThanhToan()
        {
            InitializeComponent();
        }
        
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            Phong phdat = (from n in db.Phongs
                           where n.MaPhong == dp.MaPhong
                           select n).SingleOrDefault();
            LoaiPhong gia = (from n in db.LoaiPhongs
                             where n.MaLoaiPhong == phdat.MaLoaiPhong
                             select n).SingleOrDefault();
            txtSoPhongTT.Text = phdat.TenPhong;
            txtGiaPTT.Text = gia.Gia.ToString();
            dtpNgayDatTT.Value = DateTime.Parse(dp.NgayDat);
            dtpNgayTraTT.Value = DateTime.Parse(dp.NgayTra);
            txtTongTienPTT.Text = dp.ThanhTien.ToString();
            txtSoPhongTT.Enabled = false;
            txtGiaPTT.Enabled = false;
            dtpNgayDatTT.Enabled = false;
            dtpNgayTraTT.Enabled = false;
            txtTongTienPTT.Enabled = false;
            List<string> dv = new List<string>();
            List<int> gdv = new List<int>();
            var tdv = (from n in db.DichVus
                       select n.TenDichVu);
            dv = tdv.ToList<string>();

            for (int i = 0; i < dv.Count(); i++)
            {
                clbDichVu.Items.Insert(i, dv[i]);
            }
            var giadv = (from n in db.DichVus
                       select n.Gia);
            gdv = giadv.ToList<int>();
            lbxGiaDV.DataSource = gdv;
            txtTongTienTT.Text = txtTongTienPTT.Text;

        }

        private void clbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            double tien = double.Parse(txtTongTienPTT.Text);
            List<string> it = new List<string>();
            foreach(object checkedItem in clbDichVu.CheckedItems)
            {
                it.Add(checkedItem.ToString());
            }
            foreach(string i in it)
            {
                int giadv = (from n in db.DichVus
                             where n.TenDichVu == i
                             select n.Gia).SingleOrDefault();
                tien += giadv;
            }
            txtTongTienTT.Text = tien.ToString();
            
        }

        private void bthoanthanhgiatien_Click(object sender, EventArgs e)
        {
            DatPhong datphong = db.DatPhongs.FirstOrDefault(s => s.MaDatPhong == dp.MaDatPhong);
            datphong.TinhTrangThanhToan = "Da thanh toan";
            datphong.ThanhTien = int.Parse(txtTongTienTT.Text);
            db.SubmitChanges();
            Phong phong = db.Phongs.FirstOrDefault(s => s.MaPhong == dp.MaPhong);
            phong.Available = "Trong";
            db.SubmitChanges();
            MessageBox.Show("Trả phòng thành công!");
            frmChonPhong f = new frmChonPhong(nhanVien);
            this.Close();
            f.ShowDialog();

        }
    }
}

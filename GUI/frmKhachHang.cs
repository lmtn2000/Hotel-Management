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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        private void formquanlythongtinKH_Load(object sender, EventArgs e)
        {
            //QLKSLinQDataContext db = new QLKSLinQDataContext();
            List<KhachHang> list = new List<KhachHang>();
            var query = (from n in db.KhachHangs
                         select n);
            list = query.ToList<KhachHang>();
            dgvKhachHang.DataSource = list;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaKH.Enabled = false;
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtPassPort.Enabled = false;
            txtQuocTich.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (dgvKhachHang.SelectedCells == null) return;
            if (btnThem.Text == "Thêm")
            {
                txtMaKH.Text = "";
                txtHoTen.Text = "";
                txtSDT.Text = "";
                dtpNgaySinh.ResetText();
                txtPassPort.Text = "";
                txtQuocTich.Text = "";
                btnThem.Text = "Lưu";
                txtMaKH.Enabled = true;
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtPassPort.Enabled = true;
                txtQuocTich.Enabled = true;
            }
            else
            {
                try
                {
                    string makh = txtMaKH.Text;
                    KhachHang kt = (from n in db.KhachHangs
                                 where n.MaKhachHang == makh
                                 select n).SingleOrDefault();
                    if (kt == null)
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKhachHang = txtMaKH.Text;
                        kh.TenKhachHang = txtHoTen.Text;
                        kh.SoDienThoai = txtSDT.Text;
                        kh.NgaySinh = dtpNgaySinh.Value.ToString();
                        kh.PassPort = txtPassPort.Text;
                        kh.QuocTich = txtQuocTich.Text;
                        db.KhachHangs.InsertOnSubmit(kh);
                        db.SubmitChanges();
                        MessageBox.Show("Them thanh cong!");
                        List<KhachHang> list = new List<KhachHang>();
                        var query = (from n in db.KhachHangs
                                     select n);
                        list = query.ToList<KhachHang>();
                        dgvKhachHang.DataSource = list;
                        txtMaKH.Text = "";
                        txtHoTen.Text = "";
                        txtSDT.Text = "";
                        dtpNgaySinh.ResetText();
                        txtPassPort.Text = "";
                        txtQuocTich.Text = "";
                        txtMaKH.Enabled = false;
                        txtHoTen.Enabled = false;
                        txtSDT.Enabled = false;
                        txtPassPort.Enabled = false;
                        txtQuocTich.Enabled = false;
                        dtpNgaySinh.Enabled = false;
                        btnThem.Text = "Thêm";
                    }
                    else
                    {
                        MessageBox.Show("Khach hang da ton tai!");
                    }
                }
                catch (Exception e1)
                { }

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedCells == null) return;
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                txtMaKH.Enabled = true;
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtPassPort.Enabled = true;
                txtQuocTich.Enabled = true;


            }
            else
            {
                try
                {
                    KhachHang kh = db.KhachHangs.FirstOrDefault(s => s.MaKhachHang == txtMaKH.Text);
                    kh.TenKhachHang = txtHoTen.Text;
                    kh.SoDienThoai = txtSDT.Text;
                    kh.NgaySinh = dtpNgaySinh.Value.ToString();
                    kh.PassPort = txtPassPort.Text;
                    kh.QuocTich = txtQuocTich.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sua thanh cong!");
                    List<KhachHang> list = new List<KhachHang>();
                    var query = (from n in db.KhachHangs
                                 select n);
                    list = query.ToList<KhachHang>();
                    dgvKhachHang.DataSource = list;
                    txtMaKH.Text = "";
                    txtHoTen.Text = "";
                    txtSDT.Text = "";
                    dtpNgaySinh.ResetText();
                    txtPassPort.Text = "";
                    txtQuocTich.Text = "";
                    txtMaKH.Enabled = false;
                    txtHoTen.Enabled = false;
                    txtSDT.Enabled = false;
                    txtPassPort.Enabled = false;
                    txtQuocTich.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    btnSua.Text = "Sửa";
                }
                catch (Exception e1)
                {

                }

            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedCells == null) return;
            if (MessageBox.Show("Bạn thực sự muốn xóa?", "Xóa Khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.OK)
            {
                KhachHang kh = (from n in db.KhachHangs
                             where n.MaKhachHang == dgvKhachHang.CurrentRow.Cells[0].Value.ToString()
                             select n).SingleOrDefault();
                if (kh != null)
                {
                    db.KhachHangs.DeleteOnSubmit(kh);
                    db.SubmitChanges();
                    List<KhachHang> list = new List<KhachHang>();
                    var query = (from n in db.KhachHangs
                                 select n);
                    list = query.ToList<KhachHang>();
                    dgvKhachHang.DataSource = list;
                    MessageBox.Show("Xóa thành công!");
                    txtMaKH.Text = "";
                    txtHoTen.Text = "";
                    txtSDT.Text = "";
                    dtpNgaySinh.ResetText();
                    txtPassPort.Text = "";
                    txtQuocTich.Text = "";
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtQuocTich.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse( row.Cells[4].Value.ToString());
                txtPassPort.Text = row.Cells[4].Value.ToString();

            }
        }
    }
}

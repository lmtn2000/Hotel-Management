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
using System.Data.Linq;

namespace demoDA
{
    public partial class frmNhanVien : Form
    {
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listviewquanlynhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formquanlyNV_Load(object sender, EventArgs e)
        {
            
            List<NhanVien> listNV = new List<NhanVien>();
            var queryNV = (from n in db.NhanViens
                         select n);
            listNV = queryNV.ToList<NhanVien>();
            dgvNhanVien.DataSource = listNV;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Login> listLG = new List<Login>();
            var queryLG = (from n in db.Logins
                         select n);
            listLG = queryLG.ToList<Login>();
            dgvLogin.DataSource = listLG;
            dgvLogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaNV.Enabled = false;
            txtHoTenNV.Enabled = false;
            cboChucVu.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            txtMail.Enabled = false;
            txtTaiKhoanNV.Enabled = false;
            txtPassWord.Enabled = false;
        }

        private void btthemNV_Click(object sender, EventArgs e)
        {
            if (btnThemNV.Text == "Thêm")
            {
                txtMaNV.Text = "";
                txtHoTenNV.Text = "";
                cboChucVu.ResetText();
                dtpNgaySinh.ResetText();
                txtSDT.Text = "";
                txtMail.Text = "";
                txtTaiKhoanNV.Text = "";
                txtPassWord.Text = "";
                btnThemNV.Text = "Lưu";
                txtMaNV.Enabled = true;
                txtHoTenNV.Enabled = true;
                cboChucVu.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtSDT.Enabled = true;
                txtMail.Enabled = true;
                txtTaiKhoanNV.Enabled = true;
                txtPassWord.Enabled = true;
            }
            else
            {
                try
                {
                    string manv = txtMaNV.Text;
                    NhanVien kt = (from n in db.NhanViens
                                    where n.MaNhanVien == manv
                                    select n).SingleOrDefault();
                    if (kt == null)
                    {
                        NhanVien nv = new NhanVien();
                        Login lg = new Login();
                        nv.MaNhanVien = txtMaNV.Text;
                        nv.TenNhanVien = txtHoTenNV.Text;
                        nv.ChucVu = cboChucVu.SelectedItem.ToString();
                        nv.NgaySinh = dtpNgaySinh.Value.ToString();
                        nv.SoDienThoai = txtSDT.Text;
                        nv.Mail = txtMail.Text;
                        lg.TenDangNhap = txtTaiKhoanNV.Text;
                        lg.MatKhau = txtPassWord.Text;
                        lg.MaNhanVien = txtMaNV.Text;
                        db.NhanViens.InsertOnSubmit(nv);
                        db.SubmitChanges();
                        db.Logins.InsertOnSubmit(lg);
                        db.SubmitChanges();
                        MessageBox.Show("Them thanh cong!");
                        List<NhanVien> listNV = new List<NhanVien>();
                        var queryNV = (from n in db.NhanViens
                                       select n);
                        listNV = queryNV.ToList<NhanVien>();
                        dgvNhanVien.DataSource = listNV;
                        List<Login> listLG = new List<Login>();
                        var queryLG = (from n in db.Logins
                                       select n);
                        listLG = queryLG.ToList<Login>();
                        dgvLogin.DataSource = listLG;
                        txtMaNV.Text = "";
                        txtHoTenNV.Text = "";
                        cboChucVu.ResetText();
                        dtpNgaySinh.ResetText();
                        txtSDT.Text = "";
                        txtMail.Text = "";
                        txtTaiKhoanNV.Text = "";
                        txtPassWord.Text = "";
                        txtMaNV.Enabled = false;
                        txtHoTenNV.Enabled = false;
                        cboChucVu.Enabled = false;
                        dtpNgaySinh.Enabled = false;
                        txtSDT.Enabled = false;
                        txtMail.Enabled = false;
                        txtTaiKhoanNV.Enabled = false;
                        txtPassWord.Enabled = false;
                        btnThemNV.Text = "Thêm";
                    }
                    else
                    {
                        MessageBox.Show("Nhan vien da ton tai!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTenNV.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Quan ly") cboChucVu.SelectedIndex = 1; else cboChucVu.SelectedIndex = 0;    
                dtpNgaySinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtMail.Text = row.Cells[5].Value.ToString();

            }
        }

        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLogin.Rows[e.RowIndex];
                txtTaiKhoanNV.Text = row.Cells[0].Value.ToString();
                txtPassWord.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells == null) return;
            if (btnSuaNV.Text == "Sửa")
            {
                btnSuaNV.Text = "Lưu";
                txtMaNV.Enabled = true;
                txtHoTenNV.Enabled = true;
                cboChucVu.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtSDT.Enabled = true;
                txtMail.Enabled = true;


            }
            else
            {
                try
                {
                    NhanVien nv = db.NhanViens.FirstOrDefault(s => s.MaNhanVien == txtMaNV.Text);
                    nv.TenNhanVien = txtHoTenNV.Text;
                    nv.ChucVu = cboChucVu.SelectedItem.ToString();
                    nv.NgaySinh = dtpNgaySinh.Value.ToString();
                    nv.SoDienThoai = txtSDT.Text;
                    nv.Mail = txtMail.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sua thanh cong!");
                    List<NhanVien> listNV = new List<NhanVien>();
                    var queryNV = (from n in db.NhanViens
                                   select n);
                    listNV = queryNV.ToList<NhanVien>();
                    dgvNhanVien.DataSource = listNV;

                    txtMaNV.Text = "";
                    txtHoTenNV.Text = "";
                    cboChucVu.ResetText();
                    dtpNgaySinh.ResetText();
                    txtSDT.Text = "";
                    txtMail.Text = "";
                    txtMaNV.Enabled = false;
                    txtHoTenNV.Enabled = false;
                    cboChucVu.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    txtSDT.Enabled = false;
                    txtMail.Enabled = false;
                    btnSuaNV.Text = "Sửa";
                }
                catch (Exception e1)
                {

                }

            }


        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (dgvLogin.SelectedCells == null) return;
            if (btnSuaTK.Text == "Sửa")
            {
                btnSuaTK.Text = "Lưu";
                txtTaiKhoanNV.Enabled = true;
                txtPassWord.Enabled = true;


            }
            else
            {
                try
                {
                    Login lg = db.Logins.FirstOrDefault(s => s.TenDangNhap == txtTaiKhoanNV.Text);
                    lg.MatKhau = txtPassWord.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sua thanh cong!");
                    List<Login> listLG = new List<Login>();
                    var queryLG = (from n in db.Logins
                                   select n);
                    listLG = queryLG.ToList<Login>();
                    dgvLogin.DataSource = listLG;
                    txtTaiKhoanNV.Text = "";
                    txtPassWord.Text = "";
                    txtTaiKhoanNV.Enabled = false;
                    txtPassWord.Enabled = false;
                    btnSuaTK.Text = "Sửa";
                }
                catch (Exception e1)
                {

                }

            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells == null) return;
            if (MessageBox.Show("Bạn thực sự muốn xóa?", "Xóa Khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.OK)
            {

                NhanVien nv = (from n in db.NhanViens
                                where n.MaNhanVien == dgvNhanVien.CurrentRow.Cells[0].Value.ToString()
                                select n).SingleOrDefault();
                Login lg = (from n in db.Logins
                               where n.MaNhanVien == dgvNhanVien.CurrentRow.Cells[0].Value.ToString()
                               select n).SingleOrDefault();
                if (nv != null)
                {
                    db.Logins.DeleteOnSubmit(lg);
                    db.SubmitChanges();
                    db.NhanViens.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    
                    List<NhanVien> listNV = new List<NhanVien>();
                    var queryNV = (from n in db.NhanViens
                                   select n);
                    listNV = queryNV.ToList<NhanVien>();
                    dgvNhanVien.DataSource = listNV;
                    List<Login> listLG = new List<Login>();
                    var queryLG = (from n in db.Logins
                                   select n);
                    listLG = queryLG.ToList<Login>();
                    dgvLogin.DataSource = listLG;
                    MessageBox.Show("Xóa thành công!");
                    txtMaNV.Text = "";
                    txtHoTenNV.Text = "";
                    cboChucVu.ResetText();
                    dtpNgaySinh.ResetText();
                    txtSDT.Text = "";
                    txtMail.Text = "";
                    txtTaiKhoanNV.Text = "";
                    txtPassWord.Text = "";
                }
            }
        }
    }
}

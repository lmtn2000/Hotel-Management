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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }
        QLKSLinQDataContext db = new QLKSLinQDataContext();

        private void formchinhsuaDV_Load(object sender, EventArgs e)
        {
            
            List<DichVu> list = new List<DichVu>();
            var query = (from n in db.DichVus
                         select n);
            list = query.ToList<DichVu>();
            dgvDichVu.DataSource = list;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaDV.Enabled = false;
            txtTenDV.Enabled = false;
            txtGiaDV.Enabled = false;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            //if (dgvDichVu.SelectedCells == null) return;
            if (btnThemDV.Text=="Thêm")
            {
                txtMaDV.Text = "";
                txtTenDV.Text = "";
                txtGiaDV.Text = "";
                btnThemDV.Text = "Lưu";
                txtMaDV.Enabled = true;
                txtTenDV.Enabled = true;
                txtGiaDV.Enabled = true;
            }
            else
            {
                try
                {
                    string madv = txtMaDV.Text;
                    DichVu kt = (from n in db.DichVus
                                 where n.MaDichVu == madv
                                 select n).SingleOrDefault();
                    if (kt == null)
                    {
                        DichVu dv = new DichVu();
                        dv.MaDichVu = txtMaDV.Text;
                        dv.TenDichVu = txtTenDV.Text;
                        dv.Gia = int.Parse(txtGiaDV.Text);
                        db.DichVus.InsertOnSubmit(dv);
                        db.SubmitChanges();
                        MessageBox.Show("Them thanh cong!");
                        List<DichVu> list = new List<DichVu>();
                        var query = (from n in db.DichVus
                                     select n);
                        list = query.ToList<DichVu>();
                        dgvDichVu.DataSource = list;
                        txtMaDV.Text = "";
                        txtTenDV.Text = "";
                        txtGiaDV.Text = "";
                        txtMaDV.Enabled = false;
                        txtTenDV.Enabled = false;
                        txtGiaDV.Enabled = false;
                        btnThemDV.Text = "Thêm";
                    }
                    else
                    {
                        MessageBox.Show("Dich vu da ton tai!");
                    }
                }
                catch (Exception e1)
                { }

            }    
            
        }

        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedCells == null) return;
            if (btnSuaDichVu.Text=="Sửa")
            {
                btnSuaDichVu.Text = "Lưu";
                txtMaDV.Enabled = true;
                txtTenDV.Enabled = true;
                txtGiaDV.Enabled = true;

            
            }
            else
            {
                try
                {
                    DichVu dv = db.DichVus.FirstOrDefault(s => s.MaDichVu == txtMaDV.Text);
                    dv.TenDichVu = txtTenDV.Text;
                    dv.Gia = int.Parse(txtGiaDV.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Sua thanh cong!");
                    List<DichVu> list = new List<DichVu>();
                    var query = (from n in db.DichVus
                                 select n);
                    list = query.ToList<DichVu>();
                    dgvDichVu.DataSource = list;
                    txtMaDV.Text = "";
                    txtTenDV.Text = "";
                    txtGiaDV.Text = "";
                    txtMaDV.Enabled = false;
                    txtTenDV.Enabled = false;
                    txtGiaDV.Enabled = false;
                    btnSuaDichVu.Text = "Sửa";
                } catch (Exception e1)
                {

                }
           
            }    
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvDichVu.Rows[e.RowIndex];
                txtMaDV.Text = row.Cells[0].Value.ToString();
                txtTenDV.Text = row.Cells[1].Value.ToString();
                txtGiaDV.Text = row.Cells[2].Value.ToString();


            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedCells == null) return;
            if (MessageBox.Show("Bạn thực sự muốn xóa?","Xóa dịch vụ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                ==System.Windows.Forms.DialogResult.OK)
            {
                DichVu dv = (from n in db.DichVus
                             where n.MaDichVu == dgvDichVu.CurrentRow.Cells[0].Value.ToString()
                             select n).SingleOrDefault();
                if(dv!=null)
                {
                    db.DichVus.DeleteOnSubmit(dv);
                    db.SubmitChanges();
                    List<DichVu> list = new List<DichVu>();
                    var query = (from n in db.DichVus
                                 select n);
                    list = query.ToList<DichVu>();
                    dgvDichVu.DataSource = list;
                    MessageBox.Show("Xóa thành công!");
                    txtMaDV.Text = "";
                    txtTenDV.Text = "";
                    txtGiaDV.Text = "";
                }
            }
        }
    }
}

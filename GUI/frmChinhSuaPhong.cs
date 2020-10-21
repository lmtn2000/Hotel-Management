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
    public partial class frmChinhSuaPhong : Form
    {
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        public frmChinhSuaPhong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formchinhsuaphong_Load(object sender, EventArgs e)
        {
            
            List<LoaiPhong> list = new List<LoaiPhong>();
            var query = (from n in db.LoaiPhongs
                         select n);
            list = query.ToList<LoaiPhong>();
            dgvPhong.DataSource = list;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtGiaPhong.Enabled = false;
            txtSoNguoiO.Enabled = false;
            txtMaLP.Enabled = false;
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedCells == null) return;
            if (btnSuaPhong.Text == "Sửa")
            {
                btnSuaPhong.Text = "Lưu";
                txtGiaPhong.Enabled = true;
                txtSoNguoiO.Enabled = true;


            }
            else
            {
                try
                {
                    LoaiPhong lp = db.LoaiPhongs.FirstOrDefault(s => s.MaLoaiPhong == txtMaLP.Text);
                    lp.Gia = int.Parse(txtGiaPhong.Text);
                    lp.SoNguoiO = int.Parse(txtSoNguoiO.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Sua thanh cong!");
                    List<LoaiPhong> list = new List<LoaiPhong>();
                    var query = (from n in db.LoaiPhongs
                                 select n);
                    list = query.ToList<LoaiPhong>();
                    dgvPhong.DataSource = list;

                    txtMaLP.Text = "";
                    txtGiaPhong.Text = "";
                    txtSoNguoiO.Text = "";
                    txtGiaPhong.Enabled = false;
                    txtSoNguoiO.Enabled = false;
                    btnSuaPhong.Text = "Sửa";
                }
                catch (Exception e1)
                {

                }

            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPhong.Rows[e.RowIndex];
                txtMaLP.Text = row.Cells[0].Value.ToString();
                txtGiaPhong.Text = row.Cells[2].Value.ToString();
                txtSoNguoiO.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}

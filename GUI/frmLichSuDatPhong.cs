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
    public partial class frmLichSuDatPhong : Form
    {
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        public frmLichSuDatPhong()
        {
            InitializeComponent();
        }

        private void frmLichSuDatPhong_Load(object sender, EventArgs e)
        {
            List<DatPhong> list = new List<DatPhong>();
            var query = (from n in db.DatPhongs
                           select n);
            list = query.ToList<DatPhong>();
            dgvLichSu.DataSource = list;
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedCells == null) return;
            if (MessageBox.Show("Bạn thực sự muốn xóa?", "Xóa lịch sử", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.OK)
            {
                DatPhong dp = (from n in db.DatPhongs
                               where n.MaDatPhong == dgvLichSu.CurrentRow.Cells[0].Value.ToString()
                               select n).SingleOrDefault();
                if (dp != null)
                {
                    db.DatPhongs.DeleteOnSubmit(dp);
                    db.SubmitChanges();
                    List<DatPhong> list = new List<DatPhong>();
                    var query = (from n in db.DatPhongs
                                 select n);
                    list = query.ToList<DatPhong>();
                    dgvLichSu.DataSource = list;
                    MessageBox.Show("Xóa thành công!");
                }

            }
        }
    }
}

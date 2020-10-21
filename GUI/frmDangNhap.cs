 using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoDA
{
    public partial class frmDangNhap : Form
    {
      
        public frmDangNhap()
        {
            InitializeComponent();
            
           
        }


        
        private void btsignin_Click(object sender, EventArgs e)
        {
            
            QLKSLinQDataContext dulieu = new QLKSLinQDataContext();
            var kt = (from Login in dulieu.Logins
                      where Login.TenDangNhap == txtTenDangNhap.Text.Trim() && Login.MatKhau == txtMatKhau.Text
                      select Login).SingleOrDefault();
            if (kt== null)
            {
                MessageBox.Show("Dang nhap khong thanh cong!");
            }
            else
            {
                frmMain fmain = new frmMain(kt.MaNhanVien);
                this.Hide();
                fmain.ShowDialog();
                this.Show();
            }
            
        }

        private void Formsignin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn đồng ý thoát?", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formsignin_Load(object sender, EventArgs e)
        {
           

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}

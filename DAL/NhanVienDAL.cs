using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        QLKSLinQDataContext db = new QLKSLinQDataContext();
        public DataSet NhanVien_Login;
        private BindingSource BindingNhanVien, BindingLogin;
        private Dictionary<string, BindingSource> BSource;
        public void InitializeDataSet()
        {
            if (NhanVien_Login == null)
            {
                NhanVien_Login = new DataSet("NhanVien_Login");

                // -- Creating DataTable
                DataTable NhanVien, Login;

                Login = new DataTable("Login");

                Login.Columns.Add(new DataColumn("Tên đăng nhập"));
                Login.Columns.Add(new DataColumn("Mật khẩu"));
                Login.Columns.Add(new DataColumn("Mã nhân viên"));

                NhanVien = new DataTable("NhanVien");
                NhanVien.Columns.Add(new DataColumn("Mã nhân viên"));
                NhanVien.Columns.Add(new DataColumn("Tên nhân viên"));
                NhanVien.Columns.Add(new DataColumn("Chức vụ"));
                NhanVien.Columns.Add(new DataColumn("Ngày sinh"));
                NhanVien.Columns.Add(new DataColumn("Số điện thoại"));
                NhanVien.Columns.Add(new DataColumn("Mail"));
                

                // -- Setting PRIMARY KEY Contraint on Tables
                Login.PrimaryKey = new DataColumn[] { Login.Columns["Tên đăng nhập"] };
                NhanVien.PrimaryKey = new DataColumn[] { NhanVien.Columns["ID"] };

                // -- Adding Tables into DataSet Person_Contact
                NhanVien_Login.Tables.Add(NhanVien);
                NhanVien_Login.Tables.Add(Login);

                // -- Creating DataRelation
                DataRelation rel;
                DataColumn parentCol = NhanVien_Login.Tables["NhanVien"].Columns["Mã nhân viên"];
                DataColumn childCol = NhanVien_Login.Tables["Login"].Columns["Mã nhân viên"];
                rel = new DataRelation("NhanVienLogin", parentCol, childCol);

                // -- Adding relation to DataSet
                NhanVien_Login.Relations.Add(rel);

                // -- BindingSource
                BindingLogin = new BindingSource();
                BindingLogin.DataSource = Login;
                BindingNhanVien = new BindingSource();
                BindingNhanVien.DataSource = NhanVien;

                BSource = new Dictionary<string, BindingSource>();
                BSource["Login"] = BindingLogin;
                BSource["NhanVien"] = BindingNhanVien;
            }

        }
        public void FillDataSet()
        {
            InitializeDataSet();
            foreach (DataTable dt in NhanVien_Login.Tables)
            {
                //var query = (from n in db.)
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class QuanLyKhachSanContext : DbContext

    {
        public QuanLyKhachSanContext():base("name=QuanLyKhachSanDoAn")
        {

        }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }

        public DbSet<DatPhong> DatPhongs { get; set; }

        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<NhanVien> NhanViens { get; set; }
    }
}

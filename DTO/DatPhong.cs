using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Table("DatPhong")]
    public class DatPhong
    {
        [Key]

        public string MaDatPhong { get; set; }

        public string NgayDat { get; set; }

        public string NgayTra {get; set;}

        public int ThanhTien { get; set; }

        public string TinhTrangThanhToan { get; set; }

        public string MaKhachHang { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public string MaPhong { get; set; }

        public virtual Phong Phong { get; set; }

        public string MaNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}

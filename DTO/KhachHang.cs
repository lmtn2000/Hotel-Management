using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }

        public string QuocTich { get; set; }

        public string NgaySinh { get; set; }

        public string PassPort { get; set; }

        public string SoDienThoai { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }

    }
}

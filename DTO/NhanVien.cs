using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]

        public string MaNhanVien { get; set; }


        public string TenNhanVien { get; set; }

        public string ChucVu { get; set; }

        public string Mail { get; set; }


        public string NgaySinh { get; set; }

        public string SoDienThoai { get; set; }

        public virtual ICollection<Login> Logins { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }


        public string MaNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}

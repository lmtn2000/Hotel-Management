using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    [Table("LoaiPhong")]
    public class LoaiPhong
    {
        [Key]

        public string MaLoaiPhong { get; set; }
  
        public string TenLoaiPhong { get; set; }

        public int Gia { get; set; }

        public int SoNguoiO { get; set; }


        public virtual ICollection <Phong> Phongs { get; set; }

    }
}

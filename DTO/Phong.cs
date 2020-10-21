using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    [Table ("Phong")]
    public class Phong
    { 
        [Key]

        public string MaPhong { get; set; }

        public string TenPhong { get; set; }


        public string Available { get; set; }

        public string Tang { get; set; }
        

        public string MaLoaiPhong { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }

    }
}

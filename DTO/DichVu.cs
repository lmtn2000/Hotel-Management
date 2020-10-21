using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    [Table("DichVu")]
    public class DichVu
    {
        [Key]
        public string MaDichVu { get; set; }

        public string TenDichVu { get; set; }

        public int Gia { get; set; }


    }
}

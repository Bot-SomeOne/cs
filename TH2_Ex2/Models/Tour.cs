using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH2_Ex2.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string TenKhachHang { get; set; }
        public string ThoiGian { get; set; }
        public double GiaThuyen { get; set; }
        public double GiaDoUong { get; set; }
        public double TongTien { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th3_2.Models
{
    public class BaiTapDienTu
    {
        // Variables
        public string CauHoi { get; set; }
        public string DapAn { get; set; }
        public List<string> DapAnList { get; set; }

        // Constructor
        public BaiTapDienTu(string cauHoi, string dapAn)
        {
            this.CauHoi = cauHoi;
            this.DapAn = dapAn;
        }

        public BaiTapDienTu(string cauHoi, string dapAn, List<string> dapAnList)
        {
            this.CauHoi = cauHoi;
            this.DapAn = dapAn;
            this.DapAnList = dapAnList;
        }
    }
}

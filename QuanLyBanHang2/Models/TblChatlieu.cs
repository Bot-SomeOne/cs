using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models;

public partial class TblChatlieu
{
    public string MaChatlieu { get; set; } = null!;

    public string Tenchatlieu { get; set; } = null!;

    public virtual ICollection<TblHang> TblHangs { get; set; } = new List<TblHang>();
}

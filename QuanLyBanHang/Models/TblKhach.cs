using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models;

public partial class TblKhach
{
    public string Makhach { get; set; } = null!;

    public string Tenkhach { get; set; } = null!;

    public string? Diachi { get; set; }

    public string? Dienthoai { get; set; }

    public virtual ICollection<TblHdban> TblHdbans { get; set; } = new List<TblHdban>();
}

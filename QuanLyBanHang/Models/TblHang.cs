using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models;

public partial class TblHang
{
    public string Mahang { get; set; } = null!;

    public string Tenhang { get; set; } = null!;

    public string MaChatlieu { get; set; } = null!;

    public int Soluong { get; set; }

    public double Dongianhap { get; set; }

    public double Dongiaban { get; set; }

    public string? Anh { get; set; }

    public string? Ghichu { get; set; }

    public virtual TblChatlieu MaChatlieuNavigation { get; set; } = null!;

    public virtual ICollection<TblChitietHdban> TblChitietHdbans { get; set; } = new List<TblChitietHdban>();
}

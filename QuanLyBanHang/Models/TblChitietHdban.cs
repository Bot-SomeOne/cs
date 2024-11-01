using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models;

public partial class TblChitietHdban
{
    public string MaHdban { get; set; } = null!;

    public string Mahang { get; set; } = null!;

    public double Soluong { get; set; }

    public double Giamgia { get; set; }

    public double Thanhtien { get; set; }

    public virtual TblHdban MaHdbanNavigation { get; set; } = null!;

    public virtual TblHang MahangNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models;

public partial class TblHdban
{
    public string MaHdban { get; set; } = null!;

    public string Manhanvien { get; set; } = null!;

    public DateOnly Ngayban { get; set; }

    public string Makhach { get; set; } = null!;

    public double Tongtien { get; set; }

    public virtual TblKhach MakhachNavigation { get; set; } = null!;

    public virtual TblNhanvien ManhanvienNavigation { get; set; } = null!;

    public virtual ICollection<TblChitietHdban> TblChitietHdbans { get; set; } = new List<TblChitietHdban>();
}

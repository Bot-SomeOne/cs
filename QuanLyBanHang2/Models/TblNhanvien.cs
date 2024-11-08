using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models;

public partial class TblNhanvien
{
    public string Manhanvien { get; set; } = null!;

    public string Tennhanvien { get; set; } = null!;

    public string Gioitinh { get; set; } = null!;

    public string? Diachi { get; set; }

    public string? Dienthoai { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? MatKhau { get; set; }

    public virtual ICollection<TblHdban> TblHdbans { get; set; } = new List<TblHdban>();
}

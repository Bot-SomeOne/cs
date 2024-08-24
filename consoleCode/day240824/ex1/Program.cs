using System;
using System.Collections.Generic;

class ThiSinh
{
    // Thuộc tính
    public string SBD { get; set; }
    public string HoTen { get; set; }
    public double M1 { get; set; }
    public double M2 { get; set; }
    public double M3 { get; set; }

    // Phương thức tạo
    public ThiSinh() { }

    public ThiSinh(string sbd, string hoTen, double m1, double m2, double m3)
    {
        SBD = sbd;
        HoTen = hoTen;
        M1 = m1;
        M2 = m2;
        M3 = m3;
    }

    // Phương thức tính tổng điểm
    public virtual double TinhTongDiem()
    {
        return M1 + M2 + M3;
    }

    // Phuong thức nhập dữ liệu
    public virtual void Nhap()
    {
        Console.Write("Nhập số báo danh: ");
        SBD = Console.ReadLine();

        Console.Write("Nhập họ tên: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhập điểm môn 1: ");
        M1 = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm môn 2: ");
        M2 = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm môn 3: ");
        M3 = double.Parse(Console.ReadLine());
    }
}

class TuyenSinh : ThiSinh
{
    // Thuộc tính bổ sung
    public int KhuVuc { get; set; }

    // Phương thức tạo
    public TuyenSinh() { }

    public TuyenSinh(string sbd, string hoTen, double m1, double m2, double m3, int khuVuc)
        : base(sbd, hoTen, m1, m2, m3)
    {
        KhuVuc = khuVuc;
    }

    // Phương thức tính tổng điểm có tính đến khu vực
    public override double TinhTongDiem()
    {
        double diemKV = 0;
        if (KhuVuc == 2)
        {
            diemKV = 1;
        }
        else if (KhuVuc == 3)
        {
            diemKV = 2;
        }
        return base.TinhTongDiem() + diemKV;
    }

    // Phương thức nhập dữ liệu
    public override void Nhap()
    {
        base.Nhap();

        Console.Write("Nhập khu vực dự thi (1, 2, 3): ");
        KhuVuc = int.Parse(Console.ReadLine());
    }

    // Phương thức xuất dữ liệu
    public void Xuat()
    {
        Console.WriteLine($"SBD: {SBD}, Họ tên: {HoTen}, Tổng điểm: {TinhTongDiem()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<TuyenSinh> danhSachThiSinh = new List<TuyenSinh>();

        Console.Write("Nhập số lượng thí sinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin thí sinh thứ {i + 1}:");
            TuyenSinh ts = new TuyenSinh();
            ts.Nhap();
            danhSachThiSinh.Add(ts);
        }

        Console.Write("Nhập điểm chuẩn: ");
        double diemChuan = double.Parse(Console.ReadLine());

        Console.WriteLine("Danh sách thí sinh trúng tuyển:");
        foreach (TuyenSinh ts in danhSachThiSinh)
        {
            if (ts.TinhTongDiem() >= diemChuan)
            {
                ts.Xuat();
            }
        }
    }
}

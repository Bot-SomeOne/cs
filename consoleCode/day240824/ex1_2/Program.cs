using System;
using System.Collections.Generic;

class CarRental
{
    public string HoTen { get; set; }
    public int SoGioThue { get; set; }
    public string LoaiXe { get; set; }

    public CarRental(string hoTen, int soGioThue, string loaiXe)
    {
        HoTen = hoTen;
        SoGioThue = soGioThue;
        LoaiXe = loaiXe;
    }

    public double TinhTienThue()
    {
        double tienThue = 0;

        if (LoaiXe == "Xe du lịch")
        {
            tienThue = 250000 + (SoGioThue - 1) * 70000;
        }
        else if (LoaiXe == "Xe tải")
        {
            tienThue = 220000 + (SoGioThue - 1) * 85000;
        }

        return tienThue;
    }

    public override string ToString()
    {
        return $"Họ tên: {HoTen}, Số giờ thuê: {SoGioThue}, Loại xe: {LoaiXe}, Thành tiền: {TinhTienThue():N0} đ";
    }

    // Input
    public virtual void Nhap()
    {
        Console.Write("Nhập họ tên người thuê: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhập số giờ thuê: ");
        SoGioThue = int.Parse(Console.ReadLine());

        Console.Write("Nhập loại xe (Xe du lịch / Xe tải): ");
        LoaiXe = Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<CarRental> danhSachThueXe = new List<CarRental>();

        while (true)
        {
            Console.Write("Nhập họ tên người thuê (hoặc gõ 'exit' để kết thúc): ");
            string hoTen = Console.ReadLine();
            if (hoTen.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Nhập số giờ thuê: ");
            int soGioThue = int.Parse(Console.ReadLine());

            Console.Write("Nhập loại xe (Xe du lịch / Xe tải): ");
            string loaiXe = Console.ReadLine();

            CarRental thueXe = new CarRental(hoTen, soGioThue, loaiXe);
            danhSachThueXe.Add(thueXe);
        }

        Console.WriteLine("\nDanh sách thông tin thuê xe:");
        foreach (var thueXe in danhSachThueXe)
        {
            Console.WriteLine(thueXe);
        }
    }
}

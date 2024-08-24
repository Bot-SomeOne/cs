using System;
using System.Collections.Generic;

class SinhVien
{
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public double DiemLapTrinh { get; set; }
    public double DiemCoSoDuLieu { get; set; }
    public double DiemThietKeWeb { get; set; }

    // Constructor
    public SinhVien()
    {
        HoTen = "";
        NgaySinh = DateTime.Now;
        DiemLapTrinh = 0;
        DiemCoSoDuLieu = 0;
        DiemThietKeWeb = 0;
    }

    public SinhVien(string name, DateTime dateTime, double dlt, double dcsdl, double dtkw)
    {
        HoTen = name;
        NgaySinh = dateTime;
        DiemLapTrinh = dlt;
        DiemCoSoDuLieu = dcsdl;
        DiemThietKeWeb = dtkw;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap ngay sinh: ");
        NgaySinh = DateTime.Parse(Console.ReadLine());
        Console.Write("Nhap diem lap trinh: ");
        DiemLapTrinh = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem co so du lieu: ");
        DiemCoSoDuLieu = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem thiet ke web: ");
        DiemThietKeWeb = double.Parse(Console.ReadLine());
    }

    // Overise ToString
    public override string ToString()
    {
        return $"Ho ten: {HoTen}, Ngay sinh: {NgaySinh}, Diem lap trinh: {DiemLapTrinh}, Diem co so du lieu: {DiemCoSoDuLieu}, Diem thiet ke web: {DiemThietKeWeb}";
    }

    public double DiemTrungBinh()
    {
        return (DiemLapTrinh + DiemCoSoDuLieu + DiemThietKeWeb) / 3.0;
    }

    public bool DuocLamKhoaLuan()
    {
        return DiemTrungBinh() >= 8.0 && DiemLapTrinh >= 5.0 && DiemCoSoDuLieu >= 5.0 && DiemThietKeWeb >= 5.0;
    }

    public bool DuocLamChuyenDeTotNghiep()
    {
        return DiemLapTrinh >= 5.0 && DiemCoSoDuLieu >= 5.0 && DiemThietKeWeb >= 5.0;
    }
}

class DanhSachSinhVien
{
    private List<SinhVien> sinhViens;

    public DanhSachSinhVien()
    {
        sinhViens = new List<SinhVien>();
    }

    public void ThemSinhVien(SinhVien sv)
    {
        sinhViens.Add(sv);
    }

    public int SoLuongSinhVienLamKhoaLuan()
    {
        int count = 0;
        foreach (var sv in sinhViens)
        {
            if (sv.DuocLamKhoaLuan())
            {
                count++;
            }
        }
        return count;
    }

    public int SoLuongSinhVienLamChuyenDeTotNghiep()
    {
        int count = 0;
        foreach (var sv in sinhViens)
        {
            if (sv.DuocLamChuyenDeTotNghiep())
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        test();     
    }

    static void test() {
        DanhSachSinhVien danhSach = new DanhSachSinhVien();

        // Thêm sinh viên vào danh sách (dữ liệu mẫu)
        danhSach.ThemSinhVien(new SinhVien { HoTen = "Nguyen Van A", NgaySinh = new DateTime(2000, 1, 1), DiemLapTrinh = 9, DiemCoSoDuLieu = 8.5, DiemThietKeWeb = 8 });
        danhSach.ThemSinhVien(new SinhVien { HoTen = "Tran Thi B", NgaySinh = new DateTime(2000, 2, 2), DiemLapTrinh = 7, DiemCoSoDuLieu = 6, DiemThietKeWeb = 5.5 });
        danhSach.ThemSinhVien(new SinhVien { HoTen = "Le Van C", NgaySinh = new DateTime(2000, 3, 3), DiemLapTrinh = 6, DiemCoSoDuLieu = 6, DiemThietKeWeb = 6 });

        int soLuongKhoaLuan = danhSach.SoLuongSinhVienLamKhoaLuan();
        int soLuongChuyenDe = danhSach.SoLuongSinhVienLamChuyenDeTotNghiep();

        Console.WriteLine("Số lượng sinh viên được làm khoá luận tốt nghiệp: " + soLuongKhoaLuan);
        Console.WriteLine("Số lượng sinh viên làm chuyên đề tốt nghiệp: " + soLuongChuyenDe);
    }

    static void app() {
        Console.Write("So sinh vien trong danh sach: ");
        int n = Int32.Parse(Console.ReadLine());
        DanhSachSinhVien danhSach = new DanhSachSinhVien();
        Console.WriteLine("Nhap thong tin " + n + " sinh vien: ");
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Nhap thong tin sinh vien " + i + 1 + ": ");
            SinhVien sv = new SinhVien();
            sv.Nhap();
            danhSach.ThemSinhVien(sv);
        }

        int soLuongKhoaLuan = danhSach.SoLuongSinhVienLamKhoaLuan();
        int soLuongChuyenDe = danhSach.SoLuongSinhVienLamChuyenDeTotNghiep();

        Console.WriteLine("Số lượng sinh viên được làm khoá luận tốt nghiệp: " + soLuongKhoaLuan);
        Console.WriteLine("Số lượng sinh viên làm chuyên đề tốt nghiệp: " + soLuongChuyenDe);
    }
}

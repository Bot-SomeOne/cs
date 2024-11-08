using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;

// 
using QuanLyBanHang.Data;
using QuanLyBanHang.Models;

namespace QuanLyBanHang
{
    public partial class HoaDon : Form
    {
        // Variables
        private readonly QuanlybanhangContext _context;
        private string maNhanVien;
        private string tenNhanVien;
        private int sohoadontrongngay = 0;

        public HoaDon(
            QuanlybanhangContext context,
            string MaNV)
        {
            InitializeComponent();
            _context = context;
            maNhanVien = MaNV;

            this.init();
        }

        private async void init()
        {
            resetValue();
            hideText(true);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            txtMaNhanVien.Enabled = false;

            // Gan ten nhan vien, ma nhan vien
            txtMaNhanVien.Text = maNhanVien;
            var nv = await _context.TblNhanviens
                .FirstOrDefaultAsync(x => x.Manhanvien.ToUpper() == maNhanVien.ToUpper());

            txtTenNhanVien.Text = nv.Tennhanvien;
            tenNhanVien = nv.Tennhanvien;
            tenNhanVienDangNhap.Text = tenNhanVien;

            // Get list Hoa Don trong vong 1 tuan gan day
            var listHoaDon = await (
                from hdban in _context.TblHdbans
                where hdban.Manhanvien.ToUpper() == maNhanVien.ToUpper()
                //&& hdban.Ngayban >= DateOnly.FromDateTime(DateTime.Now.AddDays(-7))
                select new
                {
                    MaHdban = hdban.MaHdban,
                }).ToListAsync();


            cbbMaHD.DataSource = listHoaDon;
            cbbMaHD.ValueMember = "MaHdban";
            cbbMaHD.DisplayMember = "MaHdban";
            cbbMaHD.SelectedIndex = -1;

            get_ma_hang();
        }

        // Xu li khi chon hoa don trong combobox
        private void cbbMaHD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbMaHD.SelectedIndex == -1) return;

            txtMaHD.Text = cbbMaHD.SelectedValue.ToString();

            var hdban = _context.TblHdbans
                .FirstOrDefault(x => x.MaHdban.ToUpper() == txtMaHD.Text.ToUpper());

            dtpNgayBan.Value = hdban.Ngayban.ToDateTime(TimeOnly.MinValue);
            //
            var kh = _context.TblKhaches
                .FirstOrDefault(x => x.Makhach == hdban.Makhach);
            cbbMaKH.Text = kh.Makhach;
            txtTenKH.Text = kh.Tenkhach;
            txtDiaChi.Text = kh.Diachi;
            txtDienThoai.Text = kh.Dienthoai;
            txtTongTien.Text = hdban.Tongtien.ToString();
            //
            var nv = _context.TblNhanviens.FirstOrDefault(x => x.Manhanvien.ToUpper() == hdban.Manhanvien.ToUpper());
            txtMaNhanVien.Text = hdban.Manhanvien;
            txtTenNhanVien.Text = nv.Tennhanvien;
        }

        // Tim kiem hien thi chi tiet hoa don
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mahd = cbbMaHD.SelectedValue.ToString();
            if (mahd == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hdban = _context.TblHdbans
                .FirstOrDefault(x => x.MaHdban.ToUpper() == mahd.ToUpper());
            var kh = _context.TblKhaches
                .FirstOrDefault(x => x.Makhach == hdban.Makhach);
            var chitiet = _context.TblChitietHdbans
                .Where(x => x.MaHdban == mahd)
                .FirstOrDefault();
            var hang = _context.TblHangs
                .FirstOrDefault(x => x.Mahang == chitiet.Mahang);

            // gan gia tri
            dtpNgayBan.Value = hdban.Ngayban.ToDateTime(TimeOnly.MinValue);
            cbbMaKH.Text = kh.Makhach;
            txtTenKH.Text = kh.Tenkhach;
            txtDiaChi.Text = kh.Diachi;
            txtDienThoai.Text = kh.Dienthoai;
            txtTongTien.Text = hdban.Tongtien.ToString();
            //
            cbbMaHang.Text = chitiet.Mahang;
            txtTenHang.Text = hang.Tenhang;
            txtSoLuong.Text = chitiet.Soluong.ToString();
            txtGiamGia.Text = chitiet.Giamgia.ToString();
            txtDonGia.Text = hang.Dongiaban.ToString();
            txtThanhTien.Text = chitiet.Thanhtien.ToString();

        }

        // Dong hoa don 
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?",
                                          "Xác nhận",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Xu li khi thay doi khi tu trong sdt
        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            string sdt_input = txtDienThoai.Text;

            var kh = (
                from k in _context.TblKhaches
                where k.Dienthoai.Contains(sdt_input)
                select new
                {
                    Makhach = k.Makhach,
                    Tenkhach = k.Tenkhach,
                    Diachi = k.Diachi,
                    Dienthoai = k.Dienthoai,
                }
            ).ToList();

            if (kh.Any())
            {
                cbbMaKH.DataSource = kh.ToList();
                cbbMaKH.ValueMember = "Makhach";
                cbbMaKH.DisplayMember = "Makhach";
                cbbMaKH.Visible = true;
                cbbMaKH.Enabled = true;

                txtTenHang.Text = "";
                txtDiaChi.Text = "";

                button_tao_moi_kh.Visible = false;
                button_tao_moi_kh.Enabled = false;
            }
            else
            {
                cbbMaKH.DataSource = null;
                cbbMaKH.Enabled = false;

                button_tao_moi_kh.Visible = true;
                button_tao_moi_kh.Enabled = true;
            }
        }

        // Xu li khi chon khach hang trong combobox
        private void cbbMaKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string makh = cbbMaKH.SelectedValue.ToString();

            var kh = _context.TblKhaches
                .FirstOrDefault(x => x.Makhach == makh);
            var hdb = (
                from hd in _context.TblHdbans
                where hd.Makhach == makh
                select new
                {
                    MaHdban = hd.MaHdban,
                    maNhanVien = hd.Manhanvien,
                    Ngayban = hd.Ngayban,
                    Tongtien = hd.Tongtien,
                }).ToList();

            if (kh != null)
            {
                txtTenKH.Text = kh.Tenkhach;
                txtDiaChi.Text = kh.Diachi;
                txtDienThoai.Text = kh.Dienthoai;
            }

            if (hdb.Any())
            {
                cbbMaHD.DataSource = hdb;
                cbbMaHD.ValueMember = "MaHdban";
                cbbMaHD.DisplayMember = "MaHdban";
            }
        }

        // Them moi khach hang
        private void button_tao_moi_kh_Click(object sender, EventArgs e)
        {
            var tenkh = txtTenKH.Text;
            var diachi = txtDiaChi.Text;
            var dienthoai = txtDienThoai.Text;

            if (tenkh == "" || diachi == "" || dienthoai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kh = new TblKhach
            {
                Makhach = "KH_" + dienthoai,
                Tenkhach = tenkh,
                Diachi = diachi,
                Dienthoai = dienthoai,
            };

            _context.TblKhaches.Add(kh);
            _context.SaveChanges();

            //
            cbbMaKH.Enabled = true;
            cbbMaKH.Text = kh.Makhach;
        }

        // Chon ma hang
        private void cbbMaHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbMaHang.SelectedIndex == -1) return;

            string mahang = cbbMaHang.SelectedValue.ToString();
            var hang = _context.TblHangs
                .FirstOrDefault(x => x.Mahang == mahang);
            if (hang == null) return;

            txtTenHang.Text = hang.Tenhang;
            txtDonGia.Text = hang.Dongiaban.ToString();
        }

        // Xu li them hoa don
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahang = cbbMaHang.SelectedValue.ToString();
            string makhachhang = cbbMaKH.SelectedValue.ToString();
            if (mahang == "")
            {
                MessageBox.Show("Bạn chưa chọn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (makhachhang == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soluong = txtSoLuong.Text;
            string giamgia = txtGiamGia.Text;
            string thanhtien = txtThanhTien.Text;
            if (soluong == "" || giamgia == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng và giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

            }
            catch (Exception ex)
            {
            }
            string mahoadonban = GenerateMaHoaDon();
            this.sohoadontrongngay += 1;

            var hoadonban = new TblHdban
            {
                MaHdban = mahoadonban,
                Manhanvien = txtMaNhanVien.Text,
                Ngayban = DateOnly.FromDateTime(dtpNgayBan.Value),
                Makhach = makhachhang,
                Tongtien = float.Parse(thanhtien)
            };

            var chitiethoadon = new TblChitietHdban
            {
                MaHdban = mahoadonban,
                Mahang = mahang,
                Soluong = int.Parse(soluong),
                Giamgia = float.Parse(giamgia),
                Thanhtien = float.Parse(thanhtien),
            };

            _context.TblHdbans.Add(hoadonban);
            _context.TblChitietHdbans.Add(chitiethoadon);

            _context.SaveChanges();

            this.init();
        }

        // Xu li thanh tien
        private void thanhtien(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtDonGia.Text == "") return;

            int soluong = int.Parse(txtSoLuong.Text);
            float dongia = float.Parse(txtDonGia.Text);
            float thanhtien = soluong * dongia;

            string giamgia = txtGiamGia.Text;
            if (giamgia != "")
            {
                float giam_gia = float.Parse(giamgia);
                thanhtien = thanhtien - (thanhtien * giam_gia / 100);
            }

            txtThanhTien.Text = thanhtien.ToString();
            btnHuy.Enabled = true;
        }

        // huy don
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.init();
        }

        // Reset hoa don nhu vua dang nhap
        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.init();
        }

        private void hideText(bool hide)
        {
            txtMaHD.Enabled = hide;
            dtpNgayBan.Enabled = hide;
            cbbMaKH.Enabled = hide;
            txtTenKH.Enabled = hide;
            txtDiaChi.Enabled = hide;
            txtDienThoai.Enabled = hide;
            cbbMaHang.Enabled = hide;
            txtTenHang.Enabled = hide;
            txtSoLuong.Enabled = hide;
            txtGiamGia.Enabled = hide;
            txtDonGia.Enabled = hide;
            txtThanhTien.Enabled = hide;
            txtTongTien.Enabled = hide;
        }
        private void resetValue()
        {
            txtMaHD.Text = null;
            dtpNgayBan.Text = null;
            cbbMaKH.Text = null;
            txtTenKH.Text = null;
            txtDiaChi.Text = null;
            txtDienThoai.Text = null;
            cbbMaHang.Text = null;
            txtTenHang.Text = null;
            txtSoLuong.Text = null;
            txtGiamGia.Text = null;
            txtDonGia.Text = null;
            txtThanhTien.Text = null;
            txtTongTien.Text = null;
            dtpNgayBan.Value = DateTime.Now;
        }
        private void get_ma_hang()
        {
            var mh = (
                from h in _context.TblHangs
                select new
                {
                    Mahang = h.Mahang,
                    Tenhang = h.Tenhang,
                    MaChatkieu = h.MaChatlieu,
                    Soluong = h.Soluong,
                    Dongianhap = h.Dongianhap,
                    Dongiaban = h.Dongiaban,
                    Anh = h.Anh,
                    Ghichu = h.Ghichu,
                }).ToList();

            cbbMaHang.DataSource = mh;
            cbbMaHang.ValueMember = "Mahang";
            cbbMaHang.DisplayMember = "Mahang";
            cbbMaHang.SelectedIndex = -1;
        }
        private string GenerateMaHoaDon()
        {
            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now;

            // Định dạng ngày thành ddMMyyyy
            string datePart = currentDate.ToString("ddMMyyyy");

            //string serialPart = this.sohoadontrongngay.ToString();
            string giophutgiay = currentDate.ToString("HHmmss");
            string serialPart = giophutgiay;

            // Kết hợp để tạo mã hóa đơn
            string maHoaDon = $"HĐB_{datePart}0{serialPart}";

            return maHoaDon;
        }

        // Chi cho textbox nhap tu 1 den 100
        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                // Kiểm tra nếu giá trị nhập vào là một số hợp lệ từ 1 đến 100
                string inputValue = txtGiamGia.Text + e.KeyChar;  // Xử lý giá trị nhập vào tạm thời
                if (int.TryParse(inputValue, out int result))
                {
                    if (result < 1 || result > 100)
                    {
                        e.Handled = true;  // Nếu không trong khoảng 1 đến 100, không cho nhập
                    }
                }
            }
        }

    }
}

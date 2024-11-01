using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private int sinhMaHD = 1;
        private string maNhanVien;

        public HoaDon(
            QuanlybanhangContext context,
            string MaNV)
        {
            InitializeComponent();
            _context = context;
            maNhanVien = MaNV;
        }

        public void hideText(bool hide)
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
        public void resetValue()
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
        }
        void LoadData()
        {
            var dtTT = (from hang in _context.TblHangs
                        join chitiet in _context.TblChitietHdbans 
                            on hang.Mahang equals chitiet.Mahang
                        join hdban in _context.TblHdbans 
                            on chitiet.MaHdban equals hdban.MaHdban
                        where hdban.Manhanvien == maNhanVien && hdban.MaHdban == txtMaHD.Text
                        select new
                        {
                            hang.Mahang,
                            hang.Tenhang,
                            chitiet.Soluong,
                            hang.Dongiaban,
                            chitiet.Giamgia,
                            chitiet.Thanhtien
                        }).ToList();

            dgvThongTin.DataSource = dtTT;
            dgvThongTin.BackgroundColor = Color.LightBlue;
        }
        private void LoadCbbMHD()
        {
            var dtHoaDon = (from hdban in _context.TblHdbans
                            where hdban.Manhanvien == maNhanVien 
                            //&& hdban.Ngayban >= DateOnly.FromDateTime(DateTime.Now.AddDays(-7))
                            select new
                            {
                                hdban.MaHdban
                            }).ToList();

            cbbMaHD.DataSource = dtHoaDon;
            cbbMaHD.DisplayMember = "MaHDBan";
            cbbMaHD.ValueMember = "MaHDBan";

            cbbMaHD.SelectedIndex = -1;

            cbbMaHD.DropDownStyle = ComboBoxStyle.DropDown;
            cbbMaHD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaHD.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            hideText(false);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            txtMaNhanVien.Text = maNhanVien;
            txtMaNhanVien.Enabled = false;

            // Fetch the employee name for the given employee ID
            var nhanVien = _context.TblNhanviens
                .Where(nv => nv.Manhanvien == maNhanVien)
                .Select(nv => nv.Tennhanvien)
                .FirstOrDefault();

            if (nhanVien != null)
            {
                txtTenNhanVien.Text = nhanVien;
                txtTenNhanVien.Enabled = false;
                LoadCbbMHD();
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvThongTin.Visible = true;
            btnIn.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
            hideText(false);
            if (string.IsNullOrEmpty(cbbMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu mã hóa đơn chưa được nhập
            }
            var dtinfo = (from chitiet in _context.TblChitietHdbans
                          join hdban in _context.TblHdbans on chitiet.MaHdban equals hdban.MaHdban
                          join khach in _context.TblKhaches on hdban.Makhach equals khach.Makhach
                          join hang in _context.TblHangs on chitiet.Mahang equals hang.Mahang
                          where chitiet.MaHdban == cbbMaHD.Text && hdban.Manhanvien == maNhanVien
                          select new
                          {
                              hdban.Ngayban,
                              hdban.Makhach,
                              khach.Tenkhach,
                              khach.Diachi,
                              khach.Dienthoai,
                              hdban.Tongtien
                          }).ToList();

            if (dtinfo.Any())
            {
                var info = dtinfo.First();
                txtMaHD.Text = cbbMaHD.Text;
                dtpNgayBan.Value = info.Ngayban.ToDateTime(TimeOnly.MinValue);
                cbbMaKH.Text = info.Makhach;
                txtTenKH.Text = info.Tenkhach;
                txtDiaChi.Text = info.Diachi;
                txtDienThoai.Text = info.Dienthoai;
                txtTongTien.Text = info.Tongtien.ToString();
                LoadData();
            }
            else
            {
                MessageBox.Show("Không có mã hóa đơn '" + cbbMaHD.Text + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaHD.Text = txtMaHD.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvThongTin.Visible = false;

            // Populate cbbMaHang with product IDs
            var dtHang = _context.TblHangs.Select(h => new { h.Mahang }).ToList();
            cbbMaHang.DataSource = dtHang;
            cbbMaHang.DisplayMember = "Mahang";
            cbbMaHang.ValueMember = "Mahang";
            cbbMaHang.SelectedIndex = -1;
            cbbMaHang.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate cbbMaKH with customer IDs
            var dtKH = _context.TblKhaches.Select(k => new { k.Makhach }).ToList();
            cbbMaKH.DataSource = dtKH;
            cbbMaKH.DisplayMember = "Makhach";
            cbbMaKH.ValueMember = "Makhach";
            cbbMaKH.SelectedIndex = -1;
            cbbMaKH.DropDownStyle = ComboBoxStyle.DropDown;
            cbbMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaKH.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnHuy.Enabled = false;

            resetValue();
            txtSoLuong.Enabled = false;
            txtGiamGia.Enabled = false;
            cbbMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            cbbMaHang.Enabled = true;

            // Generate new invoice ID based on the current date and invoice counter
            string formatDate = DateTime.Now.ToString("ddMMyyyy");
            string formatNumber = sinhMaHD.ToString("D3");
            string MaHDText = $"HDB_{formatDate}0{formatNumber}";

            // Ensure unique invoice ID by checking the database
            while (Check(MaHDText))
            {
                sinhMaHD++;
                formatNumber = sinhMaHD.ToString("D3");
                MaHDText = $"HDB_{formatDate}0{formatNumber}";
            }

            txtMaHD.Text = MaHDText;
        }

        public bool Check(string MaHDText)
        {
            return _context.TblHdbans.Any(hd => hd.MaHdban == MaHDText);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Ngăn không cho nhập nếu không phải là số
                e.Handled = true;
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDienThoai.Text))
            {
                // Query to find customer by phone number
                var customer = _context.TblKhaches
                    .Where(k => k.Dienthoai == txtDienThoai.Text)
                    .Select(k => new { k.Makhach, k.Tenkhach, k.Diachi })
                    .FirstOrDefault();

                if (customer != null) // If customer data is found
                {
                    // Update customer information fields
                    cbbMaKH.Text = customer.Makhach;
                    txtTenKH.Text = customer.Tenkhach;
                    txtDiaChi.Text = customer.Diachi;
                }
                else // If no customer data is found
                {
                    cbbMaKH.Text = string.Empty;
                    txtTenKH.Text = string.Empty;
                    txtDiaChi.Text = string.Empty;
                }
            }
            else // If phone number field is empty
            {
                cbbMaKH.Text = string.Empty;
                txtTenKH.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
            }
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbMaHang.Text))
            {
                // Query to get product information based on selected Mahang
                var product = _context.TblHangs
                    .Where(h => h.Mahang == cbbMaHang.Text)
                    .Select(h => new { h.Tenhang, h.Dongiaban })
                    .FirstOrDefault();

                if (product != null)
                {
                    // Populate fields with product data
                    txtTenHang.Text = product.Tenhang;
                    txtDonGia.Text = product.Dongiaban.ToString();
                    txtSoLuong.Enabled = true;
                    txtGiamGia.Enabled = true;
                }
                else
                {
                    // Clear fields if no data found
                    txtTenHang.Text = string.Empty;
                    txtDonGia.Text = string.Empty;
                    txtSoLuong.Enabled = false;
                    txtGiamGia.Enabled = false;
                }
            }
            else
            {
                // Clear fields if no Mahang is selected
                txtTenHang.Text = string.Empty;
                txtDonGia.Text = string.Empty;
                txtSoLuong.Enabled = false;
                txtGiamGia.Enabled = false;
            }
        }


        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Focus();
                    return;
                }

                // Query to get the stock quantity for the selected product
                var product = _context.TblHangs
                    .Where(h => h.Mahang == cbbMaHang.Text)
                    .Select(h => h.Soluong)
                    .FirstOrDefault();

                if (product != null && soLuong > product)
                {
                    MessageBox.Show($"Số lượng yêu cầu lớn hơn số lượng tồn kho ({product}). Vui lòng nhập lại.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                }
                else
                {
                    TinhThanhTien();
                }
            }
        }

        private void txtGiamGia_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtGiamGia.Text, out int giamGia))  // Sửa thành int
            {
                if (giamGia < 0)
                {
                    MessageBox.Show("Giảm giá phải lớn hơn hoặc bằng 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiamGia.Focus();
                }
                else
                {
                    TinhThanhTien();
                }
            }
        }
        private void TinhThanhTien()
        {
            // Chỉ tính toán nếu tất cả các giá trị cần thiết đều có
            if (double.TryParse(txtDonGia.Text, out double donGia) &&
                int.TryParse(txtSoLuong.Text, out int soLuong) &&
                int.TryParse(txtGiamGia.Text, out int giamGia))
            {
                // Tính toán thành tiền với giảm giá là số nguyên
                double thanhTien = donGia * soLuong * (100 - giamGia) / 100.0;
                txtThanhTien.Text = thanhTien.ToString();
                txtTongTien.Text = thanhTien.ToString();
            }
        }

        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(cbbMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbMaHang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaHang.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giảm giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return false;
            }
            return true;
        }
        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbMaKH.Text))
            {
                // Query to get customer information for the selected Makhach
                var customer = _context.TblKhaches
                    .Where(k => k.Makhach == cbbMaKH.Text)
                    .Select(k => new { k.Tenkhach, k.Diachi, k.Dienthoai })
                    .FirstOrDefault();

                if (customer != null)
                {
                    // Populate fields with customer data
                    txtTenKH.Text = customer.Tenkhach;
                    txtDiaChi.Text = customer.Diachi;
                    txtDienThoai.Text = customer.Dienthoai;
                }
                else
                {
                    // Clear fields if no data found
                    txtTenKH.Text = string.Empty;
                    txtDiaChi.Text = string.Empty;
                    txtDienThoai.Text = string.Empty;
                }
            }
            else
            {
                // Clear fields if no Makhach is selected
                txtTenKH.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtDienThoai.Text = string.Empty;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
            {
                return;
            }
            try
            {
                // Create a new Hoa Don (invoice) entry
                var hoaDon = new TblHdban
                {
                    MaHdban = txtMaHD.Text,
                    Manhanvien = maNhanVien,
                    Makhach = cbbMaKH.Text,
                    Ngayban = DateOnly.FromDateTime(dtpNgayBan.Value),
                    Tongtien = double.Parse(txtTongTien.Text) // Parse to decimal directly
                };
                _context.TblHdbans.Add(hoaDon);

                // Create a new Chi Tiet Hoa Don (invoice details) entry
                var chiTietHoaDon = new TblChitietHdban
                {
                    MaHdban = txtMaHD.Text,
                    Mahang = cbbMaHang.Text,
                    Soluong = int.Parse(txtSoLuong.Text),
                    Giamgia = int.Parse(txtGiamGia.Text),
                    Thanhtien = double.Parse(txtThanhTien.Text) // Parse to decimal directly
                };
                _context.TblChitietHdbans.Add(chiTietHoaDon);

                // Update inventory (decrease stock quantity)
                var product = _context.TblHangs.FirstOrDefault(h => h.Mahang == cbbMaHang.Text);
                if (product != null)
                {
                    product.Soluong -= int.Parse(txtSoLuong.Text);
                }

                // Save all changes to the database in one transaction
                _context.SaveChanges();

                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                resetValue();
                LoadCbbMHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này không?",
                                  "Xác nhận",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string maHDBan = cbbMaHD.Text;

            try
            {
                // Retrieve the invoice details by MaHDBan
                var chiTietHDBanList = _context.TblChitietHdbans
                    .Where(ct => ct.MaHdban == maHDBan)
                    .ToList();

                // Update stock quantities for each item in the invoice details
                foreach (var chiTiet in chiTietHDBanList)
                {
                    var product = _context.TblHangs.FirstOrDefault(h => h.Mahang == chiTiet.Mahang);
                    if (product != null)
                    {
                        product.Soluong += (int)chiTiet.Soluong;
                    }
                }

                // Remove all invoice details for the specified MaHDBan
                _context.TblChitietHdbans.RemoveRange(chiTietHDBanList);

                // Remove the invoice from TblHdbans
                var hoaDon = _context.TblHdbans.FirstOrDefault(hd => hd.MaHdban == maHDBan);
                if (hoaDon != null)
                {
                    _context.TblHdbans.Remove(hoaDon);
                }

                // Commit all changes to the database
                _context.SaveChanges();

                MessageBox.Show("Hủy hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCbbMHD();
                dgvThongTin.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hủy hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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

        private void dgvThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (dgvThongTin.CurrentRow != null)
            {
                // Get the primary key values
                string maHDBan = cbbMaHD.Text;
                string maHang = dgvThongTin.CurrentRow.Cells["Mahang"].Value.ToString();

                // Check the number of rows to determine the action
                if (dgvThongTin.Rows.Count == 2)
                {
                    // Confirm full invoice cancellation if only one item is left
                    DialogResult result = MessageBox.Show($"Hóa đơn '{maHDBan}' chỉ còn một mặt hàng. Bạn có muốn hủy toàn bộ hóa đơn này không?",
                                                          "Xác nhận hủy hóa đơn",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Retrieve and delete all items in this invoice
                            var chiTietHDBanList = _context.TblChitietHdbans
                                .Where(ct => ct.MaHdban == maHDBan)
                                .ToList();
                            _context.TblChitietHdbans.RemoveRange(chiTietHDBanList);

                            // Retrieve and delete the main invoice record
                            var hoaDon = _context.TblHdbans.FirstOrDefault(hd => hd.MaHdban == maHDBan);
                            if (hoaDon != null)
                            {
                                _context.TblHdbans.Remove(hoaDon);
                            }

                            // Save changes to the database
                            _context.SaveChanges();

                            // Update display and reset total amount
                            LoadData();
                            LoadCbbMHD();
                            txtTongTien.Text = "0";
                            MessageBox.Show("Hóa đơn đã được hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi hủy hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // If more than one row, delete only the selected item
                    DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa mặt hàng '{maHang}' trong hóa đơn '{maHDBan}' không?",
                                                          "Xác nhận xóa",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Retrieve and delete the specific item from the invoice
                            var chiTietHDBan = _context.TblChitietHdbans
                                .FirstOrDefault(ct => ct.MaHdban == maHDBan && ct.Mahang == maHang);
                            if (chiTietHDBan != null)
                            {
                                _context.TblChitietHdbans.Remove(chiTietHDBan);
                            }

                            // Update the total amount for the invoice
                            var totalAmount = _context.TblChitietHdbans
                                .Where(ct => ct.MaHdban == maHDBan)
                                .Sum(ct => (decimal?)ct.Thanhtien) ?? 0;

                            var hoaDon = _context.TblHdbans.FirstOrDefault(hd => hd.MaHdban == maHDBan);
                            if (hoaDon != null)
                            {
                                hoaDon.Tongtien = (double)totalAmount;
                            }

                            // Save changes to the database
                            _context.SaveChanges();

                            // Update display with new total
                            LoadData();
                            LoadCbbMHD();
                            txtTongTien.Text = totalAmount.ToString();
                            MessageBox.Show("Đã xóa mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa mặt hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            // Tạo một ứng dụng Excel mới
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false; // Đặt là true nếu bạn muốn thấy Excel mở ra khi xuất

            // Tạo một workbook mới
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

            // Xuất thông tin từ các textbox và combobox
            worksheet.Cells[1, 1] = "Mã Hóa Đơn";
            worksheet.Cells[1, 2] = txtMaHD.Text;

            worksheet.Cells[2, 1] = "Mã Nhân Viên";
            worksheet.Cells[2, 2] = txtMaNhanVien.Text;

            worksheet.Cells[3, 1] = "Tên Nhân Viên";
            worksheet.Cells[3, 2] = txtTenNhanVien.Text;

            worksheet.Cells[4, 1] = "Ngày Bán";
            worksheet.Cells[4, 2] = dtpNgayBan.Value.ToString("dd/MM/yyyy");
            ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[4, 2]).NumberFormat = "dd/mm/yyyy";


            worksheet.Cells[5, 1] = "Mã Khách Hàng";
            worksheet.Cells[5, 2] = cbbMaKH.Text;

            worksheet.Cells[6, 1] = "Tên Khách Hàng";
            worksheet.Cells[6, 2] = txtTenKH.Text;

            worksheet.Cells[7, 1] = "Địa Chỉ";
            worksheet.Cells[7, 2] = txtDiaChi.Text;

            worksheet.Cells[8, 1] = "Điện Thoại";
            worksheet.Cells[8, 2] = txtDienThoai.Text;

            // Xuất dữ liệu từ DataGridView
            worksheet.Cells[10, 1] = "Mã Hàng";
            worksheet.Cells[10, 2] = "Tên Hàng";
            worksheet.Cells[10, 3] = "Số Lượng";
            worksheet.Cells[10, 4] = "Đơn Giá";
            worksheet.Cells[10, 5] = "Giảm Giá";
            worksheet.Cells[10, 6] = "Thành Tiền";

            // Thêm dữ liệu từ DataGridView vào worksheet
            int rowIndex = 11;
            foreach (DataGridViewRow row in dgvThongTin.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua hàng mới
                {
                    worksheet.Cells[rowIndex, 1] = row.Cells["Mahang"].Value;
                    worksheet.Cells[rowIndex, 2] = row.Cells["Tenhang"].Value;
                    worksheet.Cells[rowIndex, 3] = row.Cells["Soluong"].Value;
                    worksheet.Cells[rowIndex, 4] = row.Cells["Dongiaban"].Value;
                    worksheet.Cells[rowIndex, 5] = row.Cells["Giamgia"].Value;
                    worksheet.Cells[rowIndex, 6] = row.Cells["Thanhtien"].Value;
                    rowIndex++;
                }
            }

            // Hiển thị hộp thoại để người dùng chọn vị trí lưu file
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            saveFileDialog.FileName = "HoaDon.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu workbook
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Hóa đơn đã được xuất ra file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Giải phóng tài nguyên
            workbook.Close();
            excelApp.Quit();

            // Thêm các dòng giải phóng bộ nhớ (Garbage Collection)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            worksheet = null;
            workbook = null;
            excelApp = null;

            // Gọi Garbage Collector
            GC.Collect();
        }
    }
}

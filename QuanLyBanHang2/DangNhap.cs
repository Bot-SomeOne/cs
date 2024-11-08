using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Models
{
    public partial class DangNhap : Form
    {
        // Variables
        private readonly QuanlybanhangContext _context;
        // Constructor
        public DangNhap(
                QuanlybanhangContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMNV.Text.Trim(); // Lấy mã nhân viên từ textbox
            string matkhau = txtMK.Text.Trim(); // Lấy mật khẩu từ textbox

            // Kiểm tra xem mã nhân viên có trong cơ sở dữ liệu không
            var nhanvien = _context.TblNhanviens.Where(nv =>
                nv.Manhanvien == maNhanVien && nv.MatKhau == matkhau)
                .FirstOrDefault();
            if (nhanvien == null) // Nếu có nhân viên với mã đó
            {
                // Thông báo không tìm thấy mã nhân viên
                MessageBox.Show("Vui long kiem tra lai thong tin nhan vien!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Làm mới form đăng nhập
                txtMNV.Clear(); // Xóa nội dung textbox
                txtMK.Clear(); // Xóa nội dung textbox
                txtMNV.Focus(); // Đặt con trỏ về textbox để người dùng nhập lại  
            } else
            {
                // Mở form HDB
                HoaDon formHDB = new HoaDon(_context , maNhanVien);
                formHDB.Show(); // Hiển thị form HDB
                this.Hide(); // Ẩn form đăng nhập
            }
           
        }

        private void frmLoginHDB_Load(object sender, EventArgs e)
        {

        }
    }
}

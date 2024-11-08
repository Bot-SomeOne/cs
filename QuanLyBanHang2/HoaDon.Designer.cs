namespace QuanLyBanHang
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            grbttchung = new GroupBox();
            txtMaHD = new TextBox();
            cbbMaKH = new ComboBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTenKH = new TextBox();
            dtpNgayBan = new DateTimePicker();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_reset = new Button();
            lblThanhTien = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnIn = new Button();
            btnDong = new Button();
            label16 = new Label();
            txtTongTien = new TextBox();
            dgvThongTin = new DataGridView();
            label15 = new Label();
            cbbMaHang = new ComboBox();
            txtThanhTien = new TextBox();
            txtDonGia = new TextBox();
            txtGiamGia = new TextBox();
            txtTenHang = new TextBox();
            txtSoLuong = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label17 = new Label();
            cbbMaHD = new ComboBox();
            btnTimKiem = new Button();
            saveFileDialog1 = new SaveFileDialog();
            button_tao_moi_kh = new Button();
            tenNhanVienDangNhap = new TextBox();
            grbttchung.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(480, 9);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(166, 17);
            lblName.TabIndex = 0;
            lblName.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // grbttchung
            // 
            grbttchung.Controls.Add(txtMaHD);
            grbttchung.Controls.Add(cbbMaKH);
            grbttchung.Controls.Add(txtDienThoai);
            grbttchung.Controls.Add(txtDiaChi);
            grbttchung.Controls.Add(txtTenKH);
            grbttchung.Controls.Add(dtpNgayBan);
            grbttchung.Controls.Add(txtTenNhanVien);
            grbttchung.Controls.Add(txtMaNhanVien);
            grbttchung.Controls.Add(label5);
            grbttchung.Controls.Add(label6);
            grbttchung.Controls.Add(label7);
            grbttchung.Controls.Add(label8);
            grbttchung.Controls.Add(label4);
            grbttchung.Controls.Add(label3);
            grbttchung.Controls.Add(label2);
            grbttchung.Controls.Add(label1);
            grbttchung.Location = new Point(91, 85);
            grbttchung.Margin = new Padding(4, 3, 4, 3);
            grbttchung.Name = "grbttchung";
            grbttchung.Padding = new Padding(4, 3, 4, 3);
            grbttchung.Size = new Size(866, 165);
            grbttchung.TabIndex = 1;
            grbttchung.TabStop = false;
            grbttchung.Text = "Thông tin chung";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(242, 23);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(190, 26);
            txtMaHD.TabIndex = 16;
            // 
            // cbbMaKH
            // 
            cbbMaKH.FormattingEnabled = true;
            cbbMaKH.Location = new Point(648, 23);
            cbbMaKH.Name = "cbbMaKH";
            cbbMaKH.Size = new Size(190, 27);
            cbbMaKH.TabIndex = 15;
            cbbMaKH.SelectionChangeCommitted += cbbMaKH_SelectionChangeCommitted;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(648, 121);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(190, 26);
            txtDienThoai.TabIndex = 14;
            txtDienThoai.TextChanged += txtDienThoai_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(648, 87);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(190, 26);
            txtDiaChi.TabIndex = 13;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(648, 55);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(190, 26);
            txtTenKH.TabIndex = 12;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Format = DateTimePickerFormat.Short;
            dtpNgayBan.Location = new Point(242, 52);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(190, 26);
            dtpNgayBan.TabIndex = 11;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Enabled = false;
            txtTenNhanVien.Location = new Point(242, 121);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(190, 26);
            txtTenNhanVien.TabIndex = 10;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Location = new Point(242, 87);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(190, 26);
            txtMaNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 124);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 7;
            label5.Text = "Điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 90);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 6;
            label6.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 58);
            label7.Name = "label7";
            label7.Size = new Size(107, 19);
            label7.TabIndex = 5;
            label7.Text = "Tên khách hàng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(465, 26);
            label8.Name = "label8";
            label8.Size = new Size(105, 19);
            label8.TabIndex = 4;
            label8.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 124);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 3;
            label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 90);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 2;
            label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 58);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Ngày bán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_reset);
            groupBox1.Controls.Add(lblThanhTien);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnIn);
            groupBox1.Controls.Add(btnDong);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(dgvThongTin);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbbMaHang);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtTenHang);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(24, 256);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(1027, 375);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin các mặt hàng";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(7, 345);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(76, 30);
            btn_reset.TabIndex = 33;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(20, 310);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(75, 19);
            lblThanhTien.TabIndex = 17;
            lblThanhTien.Text = "Thanh Tien";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(335, 339);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 30);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm hóa đơn";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(479, 339);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(127, 30);
            btnLuu.TabIndex = 31;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(612, 339);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(127, 30);
            btnHuy.TabIndex = 30;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(745, 339);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(127, 30);
            btnIn.TabIndex = 29;
            btnIn.Text = "In hóa đơn";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(878, 339);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(127, 30);
            btnDong.TabIndex = 28;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Red;
            label16.Location = new Point(20, 279);
            label16.Name = "label16";
            label16.Size = new Size(203, 19);
            label16.TabIndex = 17;
            label16.Text = "Kích đúp một dòng hàng để xóa";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(816, 276);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(190, 26);
            txtTongTien.TabIndex = 18;
            // 
            // dgvThongTin
            // 
            dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTin.Location = new Point(24, 104);
            dgvThongTin.Name = "dgvThongTin";
            dgvThongTin.RowHeadersWidth = 51;
            dgvThongTin.RowTemplate.Height = 24;
            dgvThongTin.Size = new Size(981, 162);
            dgvThongTin.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(711, 279);
            label15.Name = "label15";
            label15.Size = new Size(68, 19);
            label15.TabIndex = 17;
            label15.Text = "Tổng tiền:";
            // 
            // cbbMaHang
            // 
            cbbMaHang.FormattingEnabled = true;
            cbbMaHang.Location = new Point(145, 34);
            cbbMaHang.Name = "cbbMaHang";
            cbbMaHang.Size = new Size(190, 27);
            cbbMaHang.TabIndex = 17;
            cbbMaHang.SelectionChangeCommitted += cbbMaHang_SelectionChangeCommitted;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(796, 68);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(190, 26);
            txtThanhTien.TabIndex = 26;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(796, 34);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(190, 26);
            txtDonGia.TabIndex = 25;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(479, 68);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(190, 26);
            txtGiamGia.TabIndex = 24;
            txtGiamGia.TextChanged += thanhtien;
            txtGiamGia.KeyPress += txtGiamGia_KeyPress;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(479, 34);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(190, 26);
            txtTenHang.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(145, 68);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(190, 26);
            txtSoLuong.TabIndex = 18;
            txtSoLuong.TextChanged += thanhtien;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(693, 71);
            label13.Name = "label13";
            label13.Size = new Size(71, 19);
            label13.TabIndex = 22;
            label13.Text = "Thành tiền";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(693, 37);
            label14.Name = "label14";
            label14.Size = new Size(56, 19);
            label14.TabIndex = 21;
            label14.Text = "Đơn giá";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(373, 71);
            label11.Name = "label11";
            label11.Size = new Size(79, 19);
            label11.TabIndex = 20;
            label11.Text = "Giảm giá %";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(373, 37);
            label12.Name = "label12";
            label12.Size = new Size(67, 19);
            label12.TabIndex = 19;
            label12.Text = "Tên hàng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 71);
            label9.Name = "label9";
            label9.Size = new Size(64, 19);
            label9.TabIndex = 18;
            label9.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 37);
            label10.Name = "label10";
            label10.Size = new Size(65, 19);
            label10.TabIndex = 17;
            label10.Text = "Mã hàng:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 42);
            label17.Name = "label17";
            label17.Size = new Size(86, 19);
            label17.TabIndex = 33;
            label17.Text = "Mã hóa đơn:";
            // 
            // cbbMaHD
            // 
            cbbMaHD.FormattingEnabled = true;
            cbbMaHD.Location = new Point(133, 39);
            cbbMaHD.Name = "cbbMaHD";
            cbbMaHD.Size = new Size(190, 27);
            cbbMaHD.TabIndex = 17;
            cbbMaHD.SelectionChangeCommitted += cbbMaHD_SelectionChangeCommitted;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(349, 38);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(138, 30);
            btnTimKiem.TabIndex = 33;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // button_tao_moi_kh
            // 
            button_tao_moi_kh.Enabled = false;
            button_tao_moi_kh.Location = new Point(964, 209);
            button_tao_moi_kh.Name = "button_tao_moi_kh";
            button_tao_moi_kh.Size = new Size(97, 23);
            button_tao_moi_kh.TabIndex = 34;
            button_tao_moi_kh.Text = "Tao Moi KH";
            button_tao_moi_kh.UseVisualStyleBackColor = true;
            button_tao_moi_kh.Visible = false;
            button_tao_moi_kh.Click += button_tao_moi_kh_Click;
            // 
            // tenNhanVienDangNhap
            // 
            tenNhanVienDangNhap.Enabled = false;
            tenNhanVienDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenNhanVienDangNhap.Location = new Point(8, 9);
            tenNhanVienDangNhap.Name = "tenNhanVienDangNhap";
            tenNhanVienDangNhap.Size = new Size(126, 26);
            tenNhanVienDangNhap.TabIndex = 35;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 638);
            Controls.Add(tenNhanVienDangNhap);
            Controls.Add(button_tao_moi_kh);
            Controls.Add(btnTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(grbttchung);
            Controls.Add(cbbMaHD);
            Controls.Add(lblName);
            Controls.Add(label17);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HoaDon";
            Text = "HÓA ĐƠN BÁN";
            grbttchung.ResumeLayout(false);
            grbttchung.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbttchung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbMaHD;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Button button_tao_moi_kh;
        private TextBox tenNhanVienDangNhap;
        private Button btn_reset;
    }
}
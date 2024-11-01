-- Tạo bảng tblChatlieu
CREATE TABLE tblChatlieu (
    MaChatlieu NVARCHAR(10) NOT NULL PRIMARY KEY,
    Tenchatlieu NVARCHAR(50) NOT NULL
);

-- Tạo bảng tblHang
CREATE TABLE tblHang (
    Mahang NVARCHAR(10) NOT NULL PRIMARY KEY,
    Tenhang NVARCHAR(50) NOT NULL,
    MaChatlieu NVARCHAR(10) NOT NULL,
    Soluong INT NOT NULL,
    Dongianhap FLOAT NOT NULL,
    Dongiaban FLOAT NOT NULL,
    Anh NTEXT,
    Ghichu NTEXT,
    FOREIGN KEY (MaChatlieu) REFERENCES tblChatlieu(MaChatlieu)
);

-- Tạo bảng tblNhanvien
CREATE TABLE tblNhanvien (
    Manhanvien NVARCHAR(10) NOT NULL PRIMARY KEY,
    Tennhanvien NVARCHAR(50) NOT NULL,
    Gioitinh NVARCHAR(50) NOT NULL,
    Diachi NVARCHAR(100),
    Dienthoai NVARCHAR(15),
    Ngaysinh DATE,
    MatKhau VARCHAR(50)
);

-- Tạo bảng tblKhach
CREATE TABLE tblKhach (
    Makhach NVARCHAR(10) NOT NULL PRIMARY KEY,
    Tenkhach NVARCHAR(50) NOT NULL,
    Diachi NTEXT ,
    Dienthoai NVARCHAR(15)
);

-- Tạo bảng tblHDBan
CREATE TABLE tblHDBan (
    MaHDBan NVARCHAR(30) NOT NULL PRIMARY KEY,
    Manhanvien NVARCHAR(10) NOT NULL,
    Ngayban DATE NOT NULL,
    Makhach NVARCHAR(10) NOT NULL,
    Tongtien FLOAT NOT NULL,
    FOREIGN KEY (Manhanvien) REFERENCES tblNhanvien(Manhanvien),
    FOREIGN KEY (Makhach) REFERENCES tblKhach(Makhach)
);

-- Tạo bảng tblChitietHDBan
CREATE TABLE tblChitietHDBan (
    MaHDBan NVARCHAR(30) NOT NULL,
    Mahang NVARCHAR(10) NOT NULL,
    Soluong FLOAT NOT NULL,
    Giamgia FLOAT NOT NULL,
    Thanhtien FLOAT NOT NULL,
    PRIMARY KEY (MaHDBan, Mahang),
    FOREIGN KEY (MaHDBan) REFERENCES tblHDBan(MaHDBan),
    FOREIGN KEY (Mahang) REFERENCES tblHang(Mahang)
);

-- Thêm dữ liệu vào bảng tblChatlieu
INSERT INTO tblChatlieu (MaChatlieu, Tenchatlieu)
VALUES 
    ('CL01', N'Nhựa'),
    ('CL02', N'Kim loại'),
    ('CL03', N'Gỗ');

-- Thêm dữ liệu vào bảng tblHang
INSERT INTO tblHang (Mahang, Tenhang, MaChatlieu, Soluong, Dongianhap, Dongiaban, Anh, Ghichu)
VALUES 
    ('H01', N'Bàn nhựa', 'CL01', 50, 100000, 150000, NULL, N'Dùng cho gia đình'),
    ('H02', N'Ghế kim loại', 'CL02', 30, 200000, 250000, NULL, N'Chất lượng cao'),
    ('H03', N'Tủ gỗ', 'CL03', 20, 500000, 700000, NULL, N'Thiết kế hiện đại');

-- Thêm dữ liệu vào bảng tblNhanvien
INSERT INTO tblNhanvien (Manhanvien, Tennhanvien, Gioitinh, Diachi, Dienthoai, Ngaysinh, MatKhau)
VALUES 
    ('NV01', N'Nguyễn Văn A', N'Nam', N'Hà Nội', '0912345678', '1985-10-10', 'password1'),
    ('NV02', N'Trần Thị B', N'Nữ', N'Đà Nẵng', '0987654321', '1990-05-20', 'password2'),
    ('NV03', N'Lê Văn C', N'Nam', N'Hồ Chí Minh', '0932123456', '1988-08-08', 'password3');

-- Thêm dữ liệu vào bảng tblKhach
INSERT INTO tblKhach (Makhach, Tenkhach, Diachi, Dienthoai)
VALUES 
    ('KH01', N'Phạm Thị D', N'Hà Nội', '0912123456'),
    ('KH02', N'Nguyễn Văn E', N'Bắc Ninh', '0922123456'),
    ('KH03', N'Trần Thị F', N'Quảng Ninh', '0933123456');

-- Thêm dữ liệu vào bảng tblHDBan
INSERT INTO tblHDBan (MaHDBan, Manhanvien, Ngayban, Makhach, Tongtien)
VALUES 
    ('HD01', 'NV01', '2024-01-10', 'KH01', 150000),
    ('HD02', 'NV02', '2024-01-15', 'KH02', 250000),
    ('HD03', 'NV03', '2024-01-20', 'KH03', 700000);

-- Thêm dữ liệu vào bảng tblChitietHDBan
INSERT INTO tblChitietHDBan (MaHDBan, Mahang, Soluong, Giamgia, Thanhtien)
VALUES 
    ('HD01', 'H01', 1, 0, 150000),
    ('HD02', 'H02', 1, 0, 250000),
    ('HD03', 'H03', 1, 0, 700000);

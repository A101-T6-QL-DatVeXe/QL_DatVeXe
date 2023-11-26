CREATE DATABASE QL_DATVEXE
GO
USE QL_DATVEXE

-- Bảng nhân viên
GO
CREATE TABLE NHANVIEN (
    MANV INT IDENTITY(1,1)  PRIMARY KEY,
    TENNV NVARCHAR(50) NOT NULL,
	NGAYSINH DATE NOT NULL,
    GIOITINH NVARCHAR(5) NOT NULL,
    DIACHI NVARCHAR(50) NOT NULL,
    SDT NVARCHAR(11) NOT NULL UNIQUE,
    TrangThai NVARCHAR(50) DEFAULT N'Đang làm' -- TRẠNG THÁI ĐANG LÀM VÀ NGHỈ VIỆC
);

-- Bảng tài khoản nhân viên
GO
CREATE TABLE TAIKHOANNV (
    TAIKHOAN VARCHAR(50) PRIMARY KEY,
    MATKHAU VARCHAR(50) NOT NULL,
	MANV INT UNIQUE,
	QUYEN NVARCHAR(10) NOT NULL,
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
);

-- Bảng khách hàng
GO
CREATE TABLE KHACHHANG (
    MAKH INT IDENTITY(1,1) PRIMARY KEY,
	TENKH  NVARCHAR(50) NOT NULL,
	NGAYSINH DATE NOT NULL,
	GIOITINH NVARCHAR(5) NOT NULL,
	DIACHI NVARCHAR(50) NOT NULL,
	SDT VARCHAR(11) NOT NULL,
	TAIKHOAN VARCHAR(50) NOT NULL UNIQUE,
	MATKHAU VARCHAR(50) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	TRANGTHAI NVARCHAR DEFAULT N'Không khóa' -- TRẠNG THÁI KHÔNG KHÓA VÀ KHÓA
);

-- Bảng vé xe
GO
CREATE TABLE VEXE (
    MAVE INT IDENTITY(1,1) PRIMARY KEY,
	TENVE NVARCHAR(50) NOT NULL,
	GIAVE INT,
	CONTRONG INT NOT NULL,
	DIEMDON NVARCHAR(50) NOT NULL,
	DIEMDEN NVARCHAR(50) NOT NULL,
	THOIGIANDON NVARCHAR(50) NOT NULL,
    SOSAO INT,
	LUOTDANHGIA INT,
	MOTA NVARCHAR(MAX) NOT NULL,
	HINHANH VARCHAR(50),
);

-- Bảng hoá đơn
GO
CREATE TABLE HOADON (
    MAHD INT IDENTITY(1,1)  PRIMARY KEY,
    MAKH INT NOT NULL,
    NGAYLAP DATETIME,
    THANHTIEN INT,
    TRANGTHAI bit DEFAULT 0, -- 0 Là hóa đơn chưa xác nhận, 1 là hóa được đã được xác nhận
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
);

-- Bảng chi tiết hoá đơn
GO
CREATE TABLE CHITIETHOADON (
    MAHD INT NOT NULL,
    MAVE INT NOT NULL,
    SOLUONG INT NOT NULL,
	PRIMARY KEY (MAHD, MAVE),
	FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
	FOREIGN KEY (MAVE) REFERENCES VEXE(MAVE)
);

-- Bảng đánh giá
GO
CREATE TABLE DANHGIA (
    MAKH INT NOT NULL,
    MAVE INT NOT NULL,
    NOIDUNG NVARCHAR(MAX),
	SOSAO INT,
	NGAYDG DATETIME,
	PRIMARY KEY (MAKH, MAVE),
    FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
    FOREIGN KEY (MAVE) REFERENCES VEXE(MAVE)
);

-- Bảng vé xe trong giỏ hàng
GO
CREATE TABLE VEXETRONGGIOHANG (
    MAVE INT NOT NULL,
    MAKH int NOT NULL,
	SOLUONG INT,
	PRIMARY KEY (MAVE, MAKH),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	FOREIGN KEY (MAVE) REFERENCES VEXE(MAVE)
);

-- Bảng chi tiết xác nhận hoá đơn
GO
CREATE TABLE XACNHANHOADON (
    MAHD INT unique,
    MANV INT NOT NULL,
    NGAYXACNHAN DATETIME,
	PRIMARY KEY (MAHD, MANV),
	FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

-- Bảng tin tức
GO
CREATE TABLE TINTUC (
    MATIN INT IDENTITY(1,1) PRIMARY KEY,
    TIEUDE NVARCHAR(50) NOT NULL,
    NOIDUNG NVARCHAR(MAX),
    NGAYDANG DATETIME,
    HINHANH VARCHAR(50)
);

GO
INSERT INTO VEXE
VALUES (N'Luxury Van Limousine',320000,13,N'Ninh Bình',N'Quảng Ninh',N'07 giờ 30 phút',4,50,N'Limousine 10 chỗ','offer_1.jpg'),
	   (N'Premium Van',250000, 11, N'Hà Nội', N'Hải Phòng', N'08 giờ', 5,30,N'Premium Van phòng đôi 22 chỗ mới (Có Toilet)','offer_2.jpg'),
	   (N'Deluxe Bus',450000,30, N'Hồ Chí Minh', N'Nha Trang', N'09 giờ', 2,60,N'Giường nằm 40 chỗ có toilet', 'offer_3.jpg'),
	   (N'Luxury Van Limousine',300000,22, N'Đà Nẵng', N'Hội An', N'07 giờ 30 phút', 1,22,N'Giường nằm 42 chỗ', 'offer_4.jpg'),
	   (N'Premium Van',280000,23, N'Quảng Ninh', N'Ninh Bình', N'08 giờ', 5,84,N'Giường nằm 40 chỗ có toilet', 'offer_5.jpg'),
	   (N'Deluxe Bus',500000,31, N'Hà Nội', N'Hồ Chí Minh', N'09 giờ 30 phút', 2,33,N'Giường nằm 40 chỗ có toilet', 'offer_6.jpg'),
	   (N'Luxury Van Limousine',350000,10, N'Hải Phòng', N'Hạ Long', N'08 giờ',4,34, N'Limousine 21 phòng (WC)', 'offer_7.jpg'),
	   (N'Premium Van',320000, 5, N'Đà Lạt', N'Đà Nẵng', N'09 giờ 30 phút',3,67, N'Xe chất lượng cao','offer_8.jpg'),
	   (N'Deluxe Bus',550000, 6, N'Nha Trang', N'Vũng Tàu', N'10 giờ', 5,53,N'Giường nằm 38 chỗ (WC)','offer_1.jpg'),
	   (N'Luxury Van Limousine',300000,14, N'Ninh Bình', N'Hà Nội', N'07 giờ',4,112, N'Giường nằm 38 chỗ (WC)', 'offer_2.jpg'),
	   (N'Premium Van',280000,23, N'Hồ Chí Minh', N'Quảng Ninh', N'08 giờ 30 phút',3,14, N'Giường nằm 20 chỗ có toilet', 'offer_3.jpg'),
	   (N'Deluxe Bus',480000,32, N'Hội An', N'Đà Nẵng', N'09 giờ 30 phút', 2,44,N'Giường nằm 40 chỗ có toilet', 'offer_4.jpg'),
   	   (N'Luxury Van Limousine',350000,11, N'Quảng Ninh', N'Hà Nội', N'07 giờ', 1,43,N'Giường nằm 40 chỗ có toilet', 'offer_5.jpg'),
	   (N'Premium Van',300000,36, N'Hải Phòng', N'Hồ Chí Minh', N'08 giờ', 3,34,N'Giường nằm 40 chỗ có toilet', 'offer_6.jpg'),
	   (N'Deluxe Bus',500000,16, N'Đà Nẵng', N'Nha Trang', N'09 giờ', 5,32,N'Giường nằm 40 chỗ có toilet', 'offer_7.jpg'),
	   (N'Luxury Van Limousine',320000,18, N'Ninh Bình', N'Hội An', N'07 giờ 30 phút', 3,79,N'Giường nằm 40 chỗ có toilet', 'offer_8.jpg'),
	   (N'Premium Van',280000,30, N'Quảng Ninh', N'Ninh Bình', N'08 giờ',4,82, N'Giường nằm 40 chỗ có toilet', 'offer_1.jpg'),
	   (N'Deluxe Bus',450000,30, N'Hà Nội', N'Hồ Chí Minh', N'09 giờ 30 phút', 5,66,N'Giường nằm 40 chỗ có toilet', 'offer_2.jpg'),
	   (N'Luxury Van Limousine',320000,30, N'Hải Phòng', N'Hạ Long', N'08 giờ', 1,48,N'Giường nằm 40 chỗ có toilet', 'offer_3.jpg'),
	   (N'Premium Van',300000,33, N'Đà Lạt', N'Đà Nẵng', N'09 giờ 30 phút', 2,47,N'Giường nằm 40 chỗ có toilet', 'offer_4.jpg');

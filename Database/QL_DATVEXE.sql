﻿CREATE DATABASE QL_DATVEXE
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
	TRANGTHAI NVARCHAR(50) DEFAULT N'Không khóa' -- TRẠNG THÁI KHÔNG KHÓA VÀ KHÓA
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
	NGAYDI DATETIME NOT NULL,
	NGAYVE DATETIME NOT NULL,
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
	TIEUDE NVARCHAR(50),
    NOIDUNG NVARCHAR(MAX),
	SOSAO INT,
	HINHANH VARCHAR(50),
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

-- Tạo trigger để cập nhật số sao của vé xe khi có lượt đánh giá mới
GO
CREATE TRIGGER UpdateRating
ON DANHGIA
AFTER INSERT
AS
BEGIN
    -- Cập nhật số sao của vé xe liên quan đến lượt đánh giá mới
    UPDATE VEXE
    SET SOSAO = ROUND((
        SELECT SUM(DANHGIA.SOSAO) 
        FROM DANHGIA 
        WHERE DANHGIA.MAVE = VEXE.MAVE
    ) / (
        SELECT COUNT(*)
        FROM DANHGIA
        WHERE DANHGIA.MAVE = VEXE.MAVE
    ), 0)
    FROM VEXE
    JOIN inserted ON VEXE.MAVE = inserted.MAVE;
END;

-- Tạo trigger để cập nhật lượt đánh giá của vé xe khi có lượt đánh giá mới
GO
CREATE TRIGGER trg_DanhGia_Insert
ON DANHGIA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật lượt đánh giá trong bảng VEXE
    UPDATE VEXE
    SET LUOTDANHGIA = VEXE.LUOTDANHGIA + I.NumRatings
    FROM VEXE
    JOIN (
        SELECT MAVE, COUNT(*) AS NumRatings
        FROM inserted
        GROUP BY MAVE
    ) AS I ON VEXE.MAVE = I.MAVE;

END;

GO
INSERT INTO VEXE
VALUES (N'Phúc Xuyên',260000,12,N'Quảng Ninh',N'Hà Nội', '2023-12-01', '2023-12-03', N'07 giờ 30 phút',0,0,N'Limousine 12 chỗ','phucxuyen.jpeg'),
	   (N'Hải Phòng Travel',270000, 11, N'Hà Nội', N'Hải Phòng', '2023-12-01', '2023-12-03', N'08 giờ', 0,0,N'Limousine 12 chỗ','haiphong.jpeg'),
	   (N'Hạ Long Travel',300000,10, N'Hồ Chí Minh', N'Quảng Ninh', '2023-12-03', '2023-12-05', N'09 giờ', 0,0,N'Limousine 10 chỗ', 'halong.jpeg'),
	   (N'Duy Khánh Limousine',300000,9, N'Đà Nẵng', N'Hội An', '2023-12-01', '2023-12-02', N'14 giờ 30 phút', 0,0,N'Limousine 9 chỗ', 'duykhanh.jpeg'),
	   (N'Daiichi Travel',200000,45, N'Quảng Ninh', N'Ninh Bình', '2023-12-02', '2023-12-04', N'08 giờ', 0,0,N'Sơ đồ 45 chỗ', 'daiichi.jpeg'),
	   (N'Hải Âu',130000,29, N'Hà Nội', N'Hải Phòng', '2023-12-03', '2023-12-05', N'09 giờ 30 phút', 0,0,N'Ghế Ngồi 29 Chỗ', 'haiau.jpeg'),
	   (N'Thuận Thảo',280000,40, N'Hồ Chí Minh', N'Phú Yên', '2023-12-01', '2023-12-03', N'08 giờ',0,0, N'Giường nằm 40 chỗ', 'thuanthao.jpeg'),
	   (N'Ngọc Hùng Văn Nhân',800000, 46, N'Ninh Bình', N'Đà Lạt', '2023-12-02', '2023-12-04', N'09 giờ 30 phút',0,0, N'Giường nằm 46 chỗ','ngochung.jpeg'),
	   (N'Huỳnh Gia',280000, 38, N'Hồ Chí Minh', N'Nha Trang', '2023-12-03', '2023-12-05', N'10 giờ', 0,0,N'Giường nằm 38 chỗ (WC)','huynhgia.jpeg'),
	   (N'Phương Nam',250000,40, N'Hồ Chí Minh', N'Vũng Tàu', '2023-12-01', '2023-12-04', N'07 giờ',0,0, N'Giường nằm 40 chỗ có toilet', 'phuongnam.jpeg'),
	   (N'Phúc Xuyên',260000,11,N'Hà Nội',N'Quảng Ninh', '2023-12-04', '2023-12-06', N'07 giờ 30 phút',0,0,N'Limousine 11 chỗ','phucxuyen.jpeg'),
	   (N'Hải Phòng Travel',270000, 11, N'Hải Phòng', N'Hà Nội', '2023-12-05', '2023-12-07', N'08 giờ', 0,0,N'Limousine 11 chỗ','haiphong.jpeg'),
	   (N'Hạ Long Travel',310000,10, N'Quảng Ninh', N'Hồ Chí Minh', '2023-12-03', '2023-12-05', N'09 giờ', 0,0,N'Limousine 10 chỗ', 'halong.jpeg'),
	   (N'Duy Khánh Limousine',300000,9, N'Hội An', N'Đà Nẵng', '2023-12-02', '2023-12-05', N'13 giờ 30 phút', 0,0,N'Limousine 9 chỗ', 'duykhanh.jpeg'),
	   (N'Daiichi Travel',200000,45, N'Ninh Bình', N'Quảng Ninh', '2023-12-06', '2023-12-08', N'08 giờ', 0,0,N'Sơ đồ 45 chỗ', 'daiichi.jpeg'),
	   (N'Hải Âu',130000,25, N'Hải Phòng', N'Hà Nội', '2023-12-03', '2023-12-05', N'15 giờ 20 phút', 0,0,N'Ghế Ngồi 25 Chỗ', 'haiau.jpeg'),
	   (N'Thuận Thảo',280000,40, N'Phú Yên', N'Hồ Chí Minh', '2023-12-07', '2023-12-09', N'08 giờ',0,0, N'Giường nằm 40 chỗ', 'thuanthao.jpeg'),
	   (N'Ngọc Hùng Văn Nhân',800000, 46, N'Đà Lạt', N'Ninh Bình', '2023-12-05', '2023-12-08', N'09 giờ 30 phút',0,0, N'Giường nằm 46 chỗ','ngochung.jpeg'),
	   (N'Huỳnh Gia',280000, 36, N'Nha Trang', N'Hồ Chí Minh', '2023-12-03', '2023-12-05', N'10 giờ', 0,0,N'Giường nằm 36 chỗ (WC)','huynhgia.jpeg'),
	   (N'Phương Nam',250000,40, N'Vũng Tàu', N'Hồ Chí Minh', '2023-12-08', '2023-12-10', N'07 giờ',0,0, N'Giường nằm 40 chỗ có toilet', 'phuongnam.jpeg');

INSERT INTO KhachHang (TENKH, NGAYSINH, GIOITINH, DIACHI, SDT, TAIKHOAN, MATKHAU, EMAIL, TRANGTHAI)
VALUES  (N'Nguyễn Văn Tuấn','1985-09-30', N'Nam', N'TP. Hồ Chí Minh', N'0946777364', N'tuan12', N'123', N'tuan12@gmail.com', N'Không khoá'),
		(N'Nguyễn Nguyên Bảo','2002-08-04', N'Nam', N'TP. Hồ Chí Minh', N'0569512477', N'1', N'1', N'040802.nguyenbao@gmail.com', N'Không khoá'),
		(N'Nguyễn Thị Ánh ', '1985-08-10', N'Nữ', N'TP. Hồ Chí Minh', N'0278555643', N'anhnguyen', N'123', N'anhnguyen@gmail.com', N'Không khoá'),
		(N'Trần Thị Quỳnh Như', '1993-05-25', N'Nữ', N'TP. Hồ Chí Minh', N'0797444362', N'nhu', N'123', N'nhu@gmail.com', N'Không khoá'),
		(N'Lê Thị Hồng', '1998-12-05', N'Nữ', N'TP. Hồ Chí Minh', N'0942888764', N'user5', N'hongle', N'hongle@gmail.com', N'Không khoá'),
		(N'Nguyễn Tuấn Tú', '1995-03-20', N'Nam', N'TP. Hồ Chí Minh', N'0124777652', N'user2', N'tu111', N'tu111@gmail.com', N'Không khoá');

INSERT INTO DANHGIA
VALUES  (1,1, N'Rất tuyệt vời', N'Xe chạy chậm, tài xế vui vẻ', 5, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(3,1, N'Hôm nay tôi thất tình', N'..............', 1, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(4,2, N'Rất tuyệt vời', N'Xe chạy chậm, tài xế vui vẻ', 5, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(5,2, N'Không có tình người', N'Tôi mắc tè nhưng tài xế nhất quyết không cho tôi xuống', 2, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(6,3, N'Không như mong đợi', N'Phụ xe hơi khó tính.', 2, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(1,4, N'Dẹp nhà xe này đi', N'Quát đờ phắc tôi đang đi chuyến xe quái quỷ gì vậy??? Bác tài chạy 100km/h coi thường mạng sống hành khách. Tôi sẽ không bao giờ đi xe nhà xe này nữa. Quá tệ!', 1, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(3,5, N'Opps', N'Dịch vụ tốt nhưng hơi lạnh, bác tài khó tính.', 4, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(4,6, N'Rất tuyệt vời', N'Nếu có thể đánh giá 10 sao tôi sẽ đánh giá 3 sao', 3, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(5,7, N'Nhà xe okela', N'Xe êm, tài xế và lơ xe đều nhiệt tình ', 5, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(6,8, N'Tôi cảm giác mình bị bẻ cong', N'Lơ xe đẹp trai quá ai biết info cho mình xin.', 5, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(1,9, N'Phụ xe hơi kém', N'Hôm nay khách hàng chuyến này rất ồn ào mất lịch sự nhưng phụ xe không giải quyết được gì.', 3, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(3,10, N'Rất tuyệt vờiiiii', N'Tôi được thuê để đánh giá 5 sao.', 5, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(4,11, N'Mệt mỏi', N'Làm ơn hãy nói với bác tài rằng đừng mở những bài hát Ấn Độ nữa, mô Phật', 3, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(5,12, N'Ai da lỡ tay', N'hehe', 1, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(6,13, N'Hạ Long Travel là số 1', N'Cảm ơn nhà xe đã xếp tôi kế bạn nữ xinh đẹp và bây giờ cô ấy là người yêu tôi 100/10.', 5, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(1,14, N'', N'', 2, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(3,15, N'', N'', 5, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(4,16, N'', N'', 1, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(5,17, N'', N'', 4, 'review_1.jpg', '2023-12-01 01:24:36.180'),
		(6,18, N'', N'', 3, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(1,19, N'', N'', 5, 'review_2.jpg', '2023-12-01 01:24:36.180'),
		(3,20, N'', N'', 5, 'review_1.jpg', '2023-12-01 01:24:36.180');

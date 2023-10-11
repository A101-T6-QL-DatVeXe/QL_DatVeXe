CREATE DATABASE QL_DATVEXE
GO
USE QL_DATVEXE
GO
CREATE TABLE QUANTRI (
    TAIKHOAN VARCHAR(50) PRIMARY KEY,
    MATKHAU VARCHAR(50) NOT NULL
);
CREATE TABLE KHACHHANG (
    MAKH VARCHAR(10) PRIMARY KEY,
	TENKH  NVARCHAR(50) NOT NULL,
	DIACHI NVARCHAR(50) NOT NULL,
	SDT VARCHAR(11) NOT NULL,
	GIOITINH NVARCHAR(30) NOT NULL,
	NGAYSINH DATETIME NOT NULL,
	TAIKHOAN VARCHAR(50) NOT NULL UNIQUE,
	MATKHAU VARCHAR(50) NOT NULL,
	EMAIL VARCHAR(40) NOT NULL
);
GO
CREATE TABLE VEXE (
    MAVE VARCHAR(10) PRIMARY KEY,
	TENVE NVARCHAR(50) NOT NULL,
	HINHANH VARCHAR(20),
	DIEMBATDAU NVARCHAR(50) NOT NULL,
	DIEMDEN NVARCHAR(50) NOT NULL,
	THOIGIANDON NVARCHAR(20) NOT NULL,
    DONGIA DECIMAL(18,3) NOT NULL,
	MOTA NVARCHAR(MAX) NOT NULL,
);
GO
CREATE TABLE DATVEXE (
    MAKH VARCHAR(10),
    MAVE VARCHAR(10),
    NGAYDAT DATETIME,
    PRIMARY KEY (MAKH, MAVE),
    FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
    FOREIGN KEY (MAVE) REFERENCES VEXE(MAVE)
);
GO
CREATE TABLE HOADON (
    MAHOADON VARCHAR(10) PRIMARY KEY,
    NGAYTHANHTOAN DATETIME NOT NULL,
    TONGTIEN DECIMAL(18, 3) NOT NULL,
    MAKH VARCHAR(10),
    FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
);
GO
CREATE TABLE DANHGIA (
	MADG VARCHAR(10) PRIMARY KEY,
    MAKH VARCHAR(10),
    MAVE VARCHAR(10),
    NOIDUNG NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
    FOREIGN KEY (MAVE) REFERENCES VEXE(MAVE)
);
GO
INSERT INTO QUANTRI
VALUES ('admin','123'),
	   ('bao','123'),
	   ('truong','123'),
	   ('hau','123')
GO
INSERT INTO KHACHHANG
VALUES  ('KH001',N'Phạm Tuấn Trường', N'306 Nguyễn Trãi, P.8, Q.5','0336543212',N'Nam','1998-03-11', 'tuan.truong', '123456', 'truong2468@gmail.com'),
		('KH002',N'Trần Quang Hậu', N'306 Đồng Nai, P.8, Q.Tân Phú','0569484629',N'Nam','2002-03-21', 'hau', '123456', 'hau@gmail.com'),
		('KH003',N'Phạm Tuân Phong', N'306 Nguyễn Tri Phương, P.13, Q8','0356559872',N'Nam','1998-03-11', 'phong', '123456', 'phong@gmail.com'),
		('KH004',N'Nguyễn Thị Hồng', N'Hồ Chí Minh','05545844',N'Nữ','1978-05-11', 'hong', '123456', 'hong@gmail.com'),
		('KH005',N'Nguyễn Nguyên Bảo', N'Củ Chi','054755754',N'Nữ','2002-04-08', 'bao', '123456', 'baonguyen0408@gmail.com'),
		('KH006',N'Lê Bùi Tấn Trưởng', N'Bình Định','0755481454',N'Nam','1998-09-11', 'buoitruong', '123456', 'truong123@gmail.com'),
		('KH007',N'Nguyễn Đức Huy', N'Hồ Chí Minh','08725545',N'Nam','2002-03-11', 'huy', '123456', 'huyne@gmail.com'),
		('KH008',N'Lê Thị Đào', N'Nha Trang','089574955',N'Nữ','2000-03-11', 'dao', '123456', 'dao123@gmail.com'),
		('KH009', N'Nguyễn Thị Hằng', N'123 Lê Lợi, P.10, Q.1', '0987654321', N'Nữ', '1995-08-10', 'hangnguyen', '123456', 'hang.nguyen@gmail.com'),
		('KH010', N'Lê Thị Mai', N'456 Trần Hưng Đạo, P.5, Q.3', '0123456789', N'Nữ', '1990-12-25', 'maile', '123456', 'mai.le@gmail.com'),
		('KH011', N'Phạm Thị Lan', N'789 Nguyễn Văn Cừ, P.2, Q.10', '0369876542', N'Nữ', '1988-06-15', 'lanpham', '123456', 'lan.pham@gmail.com'),
		('KH012', N'Nguyễn Thị Thu', N'987 Nguyễn Thái Học, P.7, Q.4', '0765432109', N'Nữ', '1997-10-20', 'thunguyen', '123456', 'thu.nguyen@gmail.com'),
		('KH013', N'Vũ Thị Hương', N'246 Lý Thường Kiệt, P.3, Q.11', '0923456781', N'Nữ', '1993-04-05', 'huongvu', '123456', 'huong.vu@gmail.com')
GO
INSERT INTO VEXE
VALUES ('VX001',N'Luxury Van Limousine','anhxe1.jpg',N'Ninh Bình',N'Quảng Ninh',N'07 giờ 30 phút',320000,N'Limousine 10 chỗ'),
	   ('VX002', N'Premium Van', 'anhxe2.jpg', N'Hà Nội', N'Hải Phòng', N'08 giờ', 250000, N'Xe chất lượng cao'),
	   ('VX003', N'Deluxe Bus', 'anhxe3.jpg', N'Hồ Chí Minh', N'Nha Trang', N'09 giờ', 450000, N'Xe sang trọng'),
	   ('VX004', N'Luxury Van Limousine', 'anhxe4.jpg', N'Đà Nẵng', N'Hội An', N'07 giờ 30 phút', 300000, N'Xe cao cấp'),
	   ('VX005', N'Premium Van', 'anhxe5.jpg', N'Quảng Ninh', N'Ninh Bình', N'08 giờ', 280000, N'Xe chất lượng cao'),
	   ('VX006', N'Deluxe Bus', 'anhxe6.jpg', N'Hà Nội', N'Hồ Chí Minh', N'09 giờ 30 phút', 500000, N'Xe sang trọng'),
	   ('VX007', N'Luxury Van Limousine', 'anhxe7.jpg', N'Hải Phòng', N'Hạ Long', N'08 giờ', 350000, N'Xe cao cấp'),
	   ('VX008', N'Premium Van', 'anhxe8.jpg', N'Đà Lạt', N'Đà Nẵng', N'09 giờ 30 phút', 320000, N'Xe chất lượng cao'),
	   ('VX009', N'Deluxe Bus', 'anhxe9.jpg', N'Nha Trang', N'Vũng Tàu', N'10 giờ', 550000, N'Xe sang trọng'),
	   ('VX010', N'Luxury Van Limousine', 'anhxe10.jpg', N'Ninh Bình', N'Hà Nội', N'07 giờ', 300000, N'Xe cao cấp'),
	   ('VX011', N'Premium Van', 'anhxe11.jpg', N'Hồ Chí Minh', N'Quảng Ninh', N'08 giờ 30 phút', 280000, N'Xe chất lượng cao'),
	   ('VX012', N'Deluxe Bus', 'anhxe12.jpg', N'Hội An', N'Đà Nẵng', N'09 giờ 30 phút', 480000, N'Xe sang trọng'),
   	   ('VX013', N'Luxury Van Limousine', 'anhxe13.jpg', N'Quảng Ninh', N'Hà Nội', N'07 giờ', 350000, N'Xe cao cấp'),
	   ('VX014', N'Premium Van', 'anhxe14.jpg', N'Hải Phòng', N'Hồ Chí Minh', N'08 giờ', 300000, N'Xe chất lượng cao'),
	   ('VX015', N'Deluxe Bus', 'anhxe15.jpg', N'Đà Nẵng', N'Nha Trang', N'09 giờ', 500000, N'Xe sang trọng'),
	   ('VX016', N'Luxury Van Limousine', 'anhxe16.jpg', N'Ninh Bình', N'Hội An', N'07 giờ 30 phút', 320000, N'Xe caocấp'),
	   ('VX017', N'Premium Van', 'anhxe17.jpg', N'Quảng Ninh', N'Ninh Bình', N'08 giờ', 280000, N'Xe chất lượng cao'),
	   ('VX018', N'Deluxe Bus', 'anhxe18.jpg', N'Hà Nội', N'Hồ Chí Minh', N'09 giờ 30 phút', 450000, N'Xe sang trọng'),
	   ('VX019', N'Luxury Van Limousine', 'anhxe19.jpg', N'Hải Phòng', N'Hạ Long', N'08 giờ', 320000, N'Xe cao cấp'),
	   ('VX020', N'Premium Van', 'anhxe20.jpg', N'Đà Lạt', N'Đà Nẵng', N'09 giờ 30 phút', 300000, N'Xe chất lượng cao');
GO
INSERT INTO DATVEXE
VALUES ('KH001','VX001','2023-09-26'),
	   ('KH001','VX003','2023-10-09'),
	   ('KH003','VX006','2023-08-06'),
	   ('KH005','VX008','2023-10-11'),
	   ('KH006','VX010','2023-11-05'),
	   ('KH004','VX011','2023-06-12'),
	   ('KH009','VX020','2023-03-14'),
	   ('KH004','VX015','2023-11-30'),
	   ('KH008','VX013','2023-07-22'),
	   ('KH010','VX017','2023-06-26')
GO
INSERT INTO HOADON
VALUES ('HD001','2023-09-26',320000,'KH001'),
	   ('HD002','2023-10-09',450000,'KH001'),
	   ('HD003','2023-08-06',500000,'KH003'),
	   ('HD004','2023-10-11',320000,'KH005'),
	   ('HD005','2023-11-05',300000,'KH006'),
	   ('HD006','2023-06-12',280000,'KH004'),
	   ('HD007','2023-03-14',300000,'KH009'),
	   ('HD008','2023-11-30',500000,'KH004'),
	   ('HD009','2023-07-22',350000,'KH008'),
	   ('HD010','2023-06-26',280000,'KH010')
GO
INSERT INTO DANHGIA
VALUES ('DG001','KH001','VX001','Xe rất êm, bác tài rất vui tính, 5 sao.'),
	   ('DG002','KH001','VX003','Tạm ổn, phụ xe hơi khó tính.'),
	   ('DG003','KH003','VX006','Quát đờ phắc tôi đang đi chuyến xe quái quỷ gì vậy??? Bác tài chạy 100km/h coi thường mạng sống hành khách. Tôi sẽ không bao giờ đi xe của web này nữa. Quá tệ!'),
	   ('DG004','KH005','VX008','Không hiểu tại sao xe êm, tài xế nhiệt tình như vậy mà nhiều người đánh giá kém.'),
	   ('DG005','KH006','VX010','Ô mai gót! Tôi nhìn thấy phụ xe xàm sở 1 người đàn ông! Tôi thầm nghĩ khi nào tới lượt mình.'),
	   ('DG006','KH004','VX011','Dịch vụ tốt nhưng hơi lạnh, bác tài khó tính.'),
	   ('DG007','KH009','VX020','Khách hàng chuyến này rất ồn ào mất lịch sự nhưng phụ xe không giải quyết được nhưng không sao vẫn ổn 8/10.'),
	   ('DG008','KH004','VX015','Tôi được thuê để đánh giá 5 sao.'),
	   ('DG009','KH008','VX013','Làm ơn hãy nói với bác tài rằng đừng mở những bài hát 10 năm trước nữa mô Phật'),
	   ('DG010','KH010','VX007','Cảm ơn chuyến xe đã xếp tôi kế bạn nữ xinh đẹp và bây giờ cô ấy là người yêu tôi 100/10.')
GO
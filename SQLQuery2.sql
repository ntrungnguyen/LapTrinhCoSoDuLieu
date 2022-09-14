CREATE DATABASE QuanLyGiayDep
GO

USE QuanLyGiayDep
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE NhomMatHang
(
MaNhom INT IDENTITY(1,1) NOT NULL,
TenNhom NVARCHAR(100) NULL
	CONSTRAINT PK_NhomMatHang PRIMARY KEY CLUSTERED (MaNhom ASC) 
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON)
			ON [PRIMARY]) ON [PRIMARY]
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE MatHang
(
MaMatHang INT IDENTITY(1,1) NOT NULL,
TenMatHang NVARCHAR(100) NULL,
SoLuongTon INT NULL,
Size INT NULL,
GiaBan INT NULL,
HinhAnh IMAGE NULL,
MoTa NVARCHAR(300) NULL,
MaNhom INT NULL
	CONSTRAINT PK_MatHang PRIMARY KEY CLUSTERED (MaMatHang ASC) 
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
			ON [PRIMARY]) ON [PRIMARY]
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE NguoiDung
(
MaNhanVien INT IDENTITY(1,1) NOT NULL,
TenNhanVien NVARCHAR(100) NULL,
SoDienThoai NVARCHAR(100) NOT NULL,
TaiKhoan NVARCHAR(100) NOT NULL,
MatKhau NVARCHAR(100) NOT NULL
CONSTRAINT PK_NguoiDung PRIMARY KEY CLUSTERED(MaNhanVien ASC)
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
			ON [PRIMARY]) ON [PRIMARY]
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE HoaDon
(
MaHoaDon INT IDENTITY(1,1) NOT NULL,
NgayBanHang SMALLDATETIME NULL
	CONSTRAINT PK_HoaDon PRIMARY KEY CLUSTERED (MaHoaDon ASC)
		WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON)
			ON [PRIMARY]) ON [PRIMARY]
GO 





SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO 
CREATE TABLE ChiTietHoaDon
(
MaHoaDon INT  NOT NULL,
MaNhanVien INT NULL,
MaMatHang INT NULL,
TenMatHang NVARCHAR(100) NULL,
SoLuong INT NULL,
GiamGia FLOAT NULL,
KhachHang NVARCHAR(100) NULL,
SoDienThoai NVARCHAR(100) NULL,
DonGia INT NULL,
ThanhTien INT NULL
)
GO


--========================================================--

-- dữ liệu nhóm mặt hàng
INSERT dbo.NhomMatHang (TenNhom) VALUES (N'Giày dép nam') 
INSERT dbo.NhomMatHang (TenNhom) VALUES (N'Giày dép nữ') 


--========================================================--
-- dữ liệu mặt hàng
INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày đá banh', 3, 42, 300000, NULL, N'Hãy mang giấc mơ của bạn lên đôi chân để dẫn lối giấc mơ đó thành hiện thực', 1)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày Sneaker Rush Crush', 5, 36, 1200000, NULL, N'Hãy đưa một đôi giày phù hợp cho cô gái và cô ấy sẽ chinh phục cả thế giới này', 2)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày cao gót Giovanni', 3, 35, 14200000, NULL, N'Làm sao bạn có thể sống một cuộc sống thượng đỉnh nếu bạn không mang giày cao gót?', 2)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày Nike Air Jordan 1', 6, 42, 5100000, NULL, N'Một đôi giày có thể thay đổi cuộc đời bạn', 1)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày Balenciaga Triple S', 1, 45, 25000000, NULL, N'Tôi thấy một đôi giày tôi thích, tôi mua nó không cần biết là nó có vừa chân mình không', 1)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Dép tổ ong', 1, 40, 20000, NULL, N'Cuồng giày dép thật sự rất tuyệt vời. "Đủ loại màu"', 1)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày cao gót Charles & Keith', 4, 35, 2100000, NULL, N'Tôi không sợ độ cao, bạn đã thấy giày của tôi chưa?', 2)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày Louis Vuitton Carlo Moccasin', 1, 40, 20500000, NULL,N'Tại sao phải buồn vì bạn luôn vui tươi', 1)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày Gucci Crytal Embellished', 1, 37, 27500000, NULL, N'Nếu chưa có ai là gu bạn, tại sao bạn không chọn gucci', 2)

INSERT dbo.MatHang (TenMatHang,SoLuongTon,Size,GiaBan,HinhAnh,MoTa,MaNhom)
VALUES (N'Giày Adidas Ultraboost', 4, 39, 5000000, NULL, N'Một người Lào đã từng nói: "ເກີບງາມ"', 1)



--========================================================--
--dữ liệu người dùng
INSERT dbo.NguoiDung (TenNhanVien,SoDienThoai,TaiKhoan,MatKhau)
VALUES (N'Nguyễn Trung Nguyên', N'0912312312', N'nguyen1', N'123')

INSERT dbo.NguoiDung (TenNhanVien,SoDienThoai,TaiKhoan,MatKhau)
VALUES (N'Nguyễn Trung A', N'0945645645', N'nguyen2', N'456')

INSERT dbo.NguoiDung (TenNhanVien,SoDienThoai,TaiKhoan,MatKhau)
VALUES (N'Nguyễn Trung B', N'0978978978', N'nguyen3', N'789')


--========================================================--
--dữ liệu hóa đơn
INSERT dbo.HoaDon
(
    NgayBanHang
)
VALUES
('2021-09-08 04:36:32' -- NgayBanHang - smalldatetime
    )

INSERT dbo.HoaDon
(
    NgayBanHang
)
VALUES
('2021-09-06 04:36:32' -- NgayBanHang - smalldatetime
    )

INSERT dbo.HoaDon
(
    NgayBanHang
)
VALUES
('2021-09-05 04:36:32' -- NgayBanHang - smalldatetime
    )


	

--========================================================--
--dữ liệu chi tiết hóa đơn

INSERT dbo.ChiTietHoaDon (MaHoaDon,MaNhanVien,MaMatHang,TenMatHang,SoLuong,GiamGia,KhachHang,SoDienThoai,DonGia,ThanhTien)
VALUES (1, 1, 2, N'Giày Sneaker Rush Crush',1, 0.0, N'Khách hàng A',N'0123456789', 1200000, 1200000)

INSERT dbo.ChiTietHoaDon (MaHoaDon,MaNhanVien,MaMatHang,TenMatHang,SoLuong,GiamGia,KhachHang,SoDienThoai,DonGia,ThanhTien)
VALUES (2, 2, 5, N'Giày Balenciaga Triple S',1, 0.0, N'Khách hàng B',N'0987654321', 25000000, 25000000)

INSERT dbo.ChiTietHoaDon (MaHoaDon,MaNhanVien,MaMatHang,TenMatHang,SoLuong,GiamGia,KhachHang,SoDienThoai,DonGia,ThanhTien)
VALUES (3, 3, 7, N'Giày cao gót Charles & Keith',1, 0.0, N'Khách hàng C',N'0456123789', 2100000, 2100000)

SELECT * FROM dbo.ChiTietHoaDon
SELECT * FROM dbo.HoaDon
SELECT * FROM dbo.MatHang 
SELECT * FROM dbo.NguoiDung 
SELECT * FROM dbo.NhomMatHang











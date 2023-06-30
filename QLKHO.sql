USE [master]
GO
/****** Object:  Database [QUANLYKHO]     ******/
CREATE DATABASE [QUANLYKHO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYKHO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QUANLYKHO.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYKHO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QUANLYKHO_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYKHO] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYKHO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYKHO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYKHO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYKHO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYKHO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYKHO] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYKHO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYKHO] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYKHO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYKHO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYKHO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYKHO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYKHO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYKHO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYKHO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYKHO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYKHO] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYKHO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYKHO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYKHO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYKHO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYKHO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYKHO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYKHO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYKHO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYKHO] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYKHO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYKHO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYKHO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYKHO] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QUANLYKHO]
GO
/****** Object:  StoredProcedure [dbo].[hienthitenhang]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[hienthitenhang] @TenHang NVARCHAR(20)
AS
SELECT * FROM Hang WHERE TenHang =@TenHang

GO
/****** Object:  Table [dbo].[CuaHang]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuaHang](
	[MaCH] [nvarchar](20) NOT NULL,
	[TenCH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangNhap]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[id] [int] NOT NULL,
	[displayname] [nvarchar](100) NOT NULL,
	[usename] [nvarchar](100) NOT NULL,
	[password] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hang]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[MaHang] [nvarchar](20) NOT NULL,
	[TenHang] [nvarchar](30) NULL,
	[Loai] [nvarchar](10) NULL,
	[SoLuong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [nvarchar](20) NOT NULL,
	[TenKho] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCC]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [nvarchar](20) NOT NULL,
	[TenNCC] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Đthoai] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](20) NOT NULL,
	[TenNV] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[email] [nvarchar](20) NULL,
	[Đthoai] [nvarchar](15) NULL,
 CONSTRAINT [pk_MaNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nvarchar](20) NOT NULL,
	[MaHang] [nvarchar](20) NULL,
	[MaNCC] [nvarchar](20) NULL,
	[MaKho] [nvarchar](20) NULL,
	[MaNV] [nvarchar](20) NULL,
	[NgayNhap] [date] NULL,
	[GiaNhap] [float] NULL,
	[SoLuongNhap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [nvarchar](20) NOT NULL,
	[MaHang] [nvarchar](20) NULL,
	[MaCH] [nvarchar](20) NULL,
	[MaKho] [nvarchar](20) NULL,
	[MaNV] [nvarchar](20) NULL,
	[NgayXuat] [date] NULL,
	[SoluongXuat] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH01', N'THOI TRANG DIO1', N'Hoang Mai-Ha Noi')
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH02', N'THOI TRANG DIO 2', N'Tien Lu-Hung Yen')
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH03', N'THOI TRANG DIO 3', N'Tay Son-Bac Ninh')
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH04', N'THOI TRANG DIO 4', N'Xuan Hoa-Vinh Phuc')
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH05', N'THOI TRANG DIO 5', N'My Ðinh-Ha Noi')
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH06', N'THOI TRANG DIO STORE', N'Cầu Giấy')
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi]) VALUES (N'CH07', N'THOI TRANG DIO 5', N'My Ðinh-Ha Noi')
INSERT [dbo].[DangNhap] ([id], [displayname], [usename], [password]) VALUES (1, N'dao quang huy', N'huyhalo', N'123')
INSERT [dbo].[DangNhap] ([id], [displayname], [usename], [password]) VALUES (2, N'nguyen van thanh', N'thanh', N'1')
INSERT [dbo].[DangNhap] ([id], [displayname], [usename], [password]) VALUES (3, N'pham xuan phu', N'phu', N'1')
INSERT [dbo].[DangNhap] ([id], [displayname], [usename], [password]) VALUES (4, N'nguyen trong dai', N'dai', N'1')
INSERT [dbo].[DangNhap] ([id], [displayname], [usename], [password]) VALUES (5, N'nguyên quy dat', N'dat', N'1')
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H01', N'Giày Convert', N'giày', 3000)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H02', N'Quần Thô', N'Quần', 5660)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H03', N'Váy đi biển', N'váy', 778)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H04', N'Quần bò baggy', N'quần', 2200)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H05', N'Áo cardigan', N'áo', 2349)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H06', N'Áo thun', N'áo', 2279)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H07', N'Quần jean', N'quần', 2858)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H08', N'Giày thể thao', N'giày', 5150)
INSERT [dbo].[Hang] ([MaHang], [TenHang], [Loai], [SoLuong]) VALUES (N'H09', N'Áo hoa', N'áo', 1950)
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi]) VALUES (N'K01', N'KHO 01', N'HAI BA CHUNG')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi]) VALUES (N'K02', N'KHO 02', N'CO NHUE')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChi], [Đthoai]) VALUES (N'N01', N'CÔNG TY  NIKE', N'TP HCM', N'0315224512')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChi], [Đthoai]) VALUES (N'N02', N'CÔNG TY  SPORT', N'TP HCM', N'0315224512')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChi], [Đthoai]) VALUES (N'N03', N'CÔNG TY  HOA MAI', N'TP HCM', N'0315224512')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChi], [Đthoai]) VALUES (N'N04', N'CÔNG TY  NO1', N'TP HCM', N'0315214521')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChi], [Đthoai]) VALUES (N'N05', N'CÔNG TY  NO2', N'TP HCM', N'0315214521')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChi], [Đthoai]) VALUES (N'N06', N'CÔNG TY  NO3', N'sds', N'0315214521')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [email], [Đthoai]) VALUES (N'NV01', N'Nguyen Van Anh', CAST(0x93240B00 AS Date), N'Nam', N'Hoang Mai-Ha Noi', N'alo@gmail', N'0961827653')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [email], [Đthoai]) VALUES (N'NV02', N'Nguyen Mai Anh', CAST(0xFC230B00 AS Date), N'Nu', N'Van Giang-Hung Yen', N'alo@gmail', N'0961577693')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [email], [Đthoai]) VALUES (N'NV03', N'Tran Thi Huyen My', CAST(0xCF240B00 AS Date), N'Nu', N'Cau Giay-Ha Noi', N'alo@gmail', N'0931836753')
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN01', N'H05', N'N05', N'K01', N'NV02', CAST(0xF6400B00 AS Date), 200000, 300)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN02', N'H06', N'N04', N'K01', N'NV01', CAST(0x04410B00 AS Date), 350000, 200)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN03', N'H08', N'N05', N'K02', N'NV03', CAST(0xD6400B00 AS Date), 420000, 150)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN04', N'H06', N'N05', N'K02', N'NV02', CAST(0xA3400B00 AS Date), 300000, 400)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN05', N'H09', N'N05', N'K02', N'NV02', CAST(0xA3400B00 AS Date), 300000, 600)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN06', N'H02', N'N05', N'K02', N'NV02', CAST(0xA3400B00 AS Date), 300000, 550)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN07', N'H02', N'N05', N'K02', N'NV02', CAST(0xA3400B00 AS Date), 300000, 450)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN08', N'H06', N'N04', N'K01', N'NV01', CAST(0x04410B00 AS Date), 2000, 200)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaHang], [MaNCC], [MaKho], [MaNV], [NgayNhap], [GiaNhap], [SoLuongNhap]) VALUES (N'PN09', N'H01', N'N04', N'K01', N'NV01', CAST(0x04410B00 AS Date), 2000, 50)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX01', N'H01', N'CH04', N'K02', N'NV01', CAST(0x3F410B00 AS Date), 250)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX02', N'H06', N'CH04', N'K02', N'NV03', CAST(0x3C410B00 AS Date), 120)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX03', N'H07', N'CH01', N'K01', N'NV01', CAST(0x3C410B00 AS Date), 142)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX05', N'H09', N'CH05', N'K02', N'NV02', CAST(0x38410B00 AS Date), 150)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX06', N'H03', N'CH06', N'K02', N'NV02', CAST(0x37410B00 AS Date), 200)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX07', N'H01', N'CH05', N'K01', N'NV01', CAST(0x36410B00 AS Date), 500)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX08', N'H02', N'CH04', N'K02', N'NV02', CAST(0x0E410B00 AS Date), 350)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaHang], [MaCH], [MaKho], [MaNV], [NgayXuat], [SoluongXuat]) VALUES (N'PX09', N'H01', N'CH04', N'K02', N'NV02', CAST(0x0E410B00 AS Date), 100)
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[Hang] ([MaHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaCH])
REFERENCES [dbo].[CuaHang] ([MaCH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[Hang] ([MaHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [QUANLYKHO] SET  READ_WRITE 
GO




/* cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhật */
/* chạy câu lệnh 1*/
CREATE TRIGGER trg_DatHang ON PhieuXuat AFTER INSERT AS 
BEGIN
	UPDATE Hang
	SET SoLuong = SoLuong - (
		SELECT SoluongXuat
		FROM inserted
		WHERE MaHang = Hang.MaHang
	)
	FROM Hang
	JOIN inserted ON Hang.MaHang = inserted.MaHang
END
GO


/* chạy câu lệnh 2*/
/* cập nhật hàng trong kho sau khi cập nhật đặt hàng */
CREATE TRIGGER trg_CapNhatDatHang on PhieuXuat after update AS
BEGIN
   UPDATE Hang SET SoLuong = SoLuong -
	   (SELECT SoLuongXuat FROM inserted WHERE MaHang = Hang.MaHang) +
	   (SELECT SoluongXuat FROM deleted WHERE MaHang = Hang.MaHang)
   FROM Hang
   JOIN deleted ON Hang.MaHang = deleted.MaHang
end
GO



/* chạy câu lệnh 3*/
/* cập nhật hàng trong kho sau khi hủy đặt hàng */
create TRIGGER trg_HuyDatHang ON PhieuXuat FOR DELETE AS 
BEGIN
	UPDATE Hang
	SET SoLuong = SoLuong + (SELECT SoluongXuat FROM deleted WHERE MaHang = Hang.MaHang)
	FROM Hang
	JOIN deleted ON Hang.MaHang = deleted.MaHang
END



/* chạy câu lệnh 4*/
 -- cap nhat phieu nhap--
 create trigger insertphieunhap on PhieuNhap after insert as
 BEGIN
 UPDATE Hang SET SoLuong = SoLuong + (select SoLuongNhap from inserted where MaHang = Hang.MaHang)
 FROM Hang
 JOIN inserted ON Hang.MaHang = inserted.MaHang

 END



 /* chạy câu lệnh 5*/
 create TRIGGER HuyNhapHang ON PhieuNhap FOR DELETE AS 
BEGIN
	UPDATE Hang
	SET SoLuong = SoLuong - (SELECT SoLuongNhap FROM deleted WHERE MaHang = Hang.MaHang)
	FROM Hang
	JOIN deleted ON Hang.MaHang = deleted.MaHang
END
----------------------------------------------------------------------
/* chạy câu lệnh 6*/
CREATE TRIGGER suaphieunhap on PhieuNhap after update AS
BEGIN
   UPDATE Hang SET SoLuong = SoLuong +
	   (SELECT SoLuongNhap FROM inserted WHERE MaHang = Hang.MaHang) -
	   (SELECT SoluongNhap FROM deleted WHERE MaHang = Hang.MaHang)
   FROM Hang
   JOIN deleted ON Hang.MaHang = deleted.MaHang
end
GO

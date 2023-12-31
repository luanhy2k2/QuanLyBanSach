USE [master]
GO
/****** Object:  Database [QuanLySach]    Script Date: 24/4/2023 10:39:56 PM ******/
CREATE DATABASE [QuanLySach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QuanLySach.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QuanLySach_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLySach] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySach] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySach] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLySach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySach] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLySach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySach] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySach] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLySach] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySach] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLySach] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLySach] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLySach]
GO
/****** Object:  Table [dbo].[ChiTietAnh]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietAnh](
	[MaAnhChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[sanp_id] [int] NULL,
	[Anh] [nvarchar](2000) NULL,
 CONSTRAINT [PK_ChiTietAnh] PRIMARY KEY CLUSTERED 
(
	[MaAnhChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTietDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaDonHang] [int] NULL,
	[sanp_id] [int] NULL,
	[soLuong] [int] NULL,
	[gia] [int] NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[MaChiTietDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonBan]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBan](
	[MaChiTietHoaDonBan] [int] IDENTITY(1,1) NOT NULL,
	[SoHoaDon] [int] NULL,
	[sanp_id] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[maChiTietHoaDonNhap] [int] IDENTITY(1,1) NOT NULL,
	[soHoaDon] [int] NULL,
	[sanp_id] [int] NULL,
	[soLuong] [int] NULL,
	[donGia] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[maChiTietHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietKho]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietKho](
	[MaChiTietKho] [int] IDENTITY(1,1) NOT NULL,
	[MaKho] [int] NULL,
	[sanp_id] [int] NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietKho] PRIMARY KEY CLUSTERED 
(
	[MaChiTietKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[danhmucs]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danhmucs](
	[maDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[tenDanhMuc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NULL,
	[NgayDat] [date] NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaCa]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaCa](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[sanp_id] [int] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_GiaCa] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBan](
	[SoHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayBan] [date] NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_HoaDonBan] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[soHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[ngayNhap] [date] NULL,
	[maNguoiDung] [int] NULL,
	[nsx_id] [int] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[soHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenKhachHang] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [int] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaisp]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaisp](
	[loai_id] [int] IDENTITY(1,1) NOT NULL,
	[loai_name] [nvarchar](50) NOT NULL,
	[danhmuc_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[loai_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[maNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[maNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhasx]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhasx](
	[nsx_id] [int] IDENTITY(1,1) NOT NULL,
	[nsx_name] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nsx_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sanpham]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanpham](
	[sanp_id] [int] IDENTITY(1,1) NOT NULL,
	[sanp_name] [nvarchar](250) NOT NULL,
	[size] [nvarchar](50) NOT NULL,
	[TG_id] [int] NOT NULL,
	[loai_id] [int] NOT NULL,
	[nsx_id] [int] NOT NULL,
	[sotrang] [int] NOT NULL,
	[tomtat] [nvarchar](2000) NOT NULL,
	[namsx] [datetime] NULL,
	[image] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[sanp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slide]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slide](
	[MaSlide] [int] IDENTITY(1,1) NOT NULL,
	[Slide] [nvarchar](2000) NULL,
	[Link] [nvarchar](200) NULL,
 CONSTRAINT [PK_Slide] PRIMARY KEY CLUSTERED 
(
	[MaSlide] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[maTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[maNguoiDung] [int] NULL,
	[taiKhoan] [nvarchar](50) NULL,
	[matKhau] [nvarchar](50) NULL,
	[ngayBatDau] [date] NULL,
	[ngayKetThuc] [date] NULL,
	[trangThai] [nvarchar](50) NULL,
	[loaiQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[maTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TG]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TG](
	[TG_id] [int] IDENTITY(1,1) NOT NULL,
	[TG_name] [nvarchar](50) NOT NULL,
	[TG_diachi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
	[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TG_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietAnh] ON 

INSERT [dbo].[ChiTietAnh] ([MaAnhChiTiet], [sanp_id], [Anh]) VALUES (1, 6, NULL)
INSERT [dbo].[ChiTietAnh] ([MaAnhChiTiet], [sanp_id], [Anh]) VALUES (2, 6, NULL)
INSERT [dbo].[ChiTietAnh] ([MaAnhChiTiet], [sanp_id], [Anh]) VALUES (3, 12, NULL)
INSERT [dbo].[ChiTietAnh] ([MaAnhChiTiet], [sanp_id], [Anh]) VALUES (4, 12, NULL)
SET IDENTITY_INSERT [dbo].[ChiTietAnh] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] ON 

INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (1, 1, 2, 10, 10000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (3, 3, 2, 4, 400000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (4, 4, 2, 4, 400000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (5, 5, 2, 1, 100000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (6, 6, 3, 1, 100000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (7, 7, 3, 5, 500000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (8, 8, 1, 4, 0)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (9, 9, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (10, 10, 1, 2, 120000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (12, 12, 2, 2, NULL)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (13, 12, 2, 2, NULL)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (14, 13, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (15, 13, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (16, 14, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (17, 15, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (18, 16, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (19, 17, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (20, 18, 1, 1, 1)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (21, 19, 1, 1, 125000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (22, 20, 1, 1, 125000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (23, 20, 2, 1, 97000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (24, 21, 1, 1, 125000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (25, 21, 2, 1, 97000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (26, 1, 1, 2, 10000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (27, 1, 1, 10, 10000)
INSERT [dbo].[ChiTietDonHang] ([MaChiTietDonHang], [MaDonHang], [sanp_id], [soLuong], [gia]) VALUES (28, 22, 3, 1, 87000)
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonBan] ON 

INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (1, 1, 1, 1, 100000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (2, 1, 2, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (3, 2, 7, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (4, 2, 8, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (5, 3, 8, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (6, 3, 8, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (7, 3, 1, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (8, 3, 2, 1, 110000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (9, 4, 10, 3, 310000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (10, 4, 11, 3, 310000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (11, 4, 12, 3, 310000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (13, 1, 1, 2, 10000)
INSERT [dbo].[ChiTietHoaDonBan] ([MaChiTietHoaDonBan], [SoHoaDon], [sanp_id], [SoLuong], [GiaBan]) VALUES (14, 1, 4, 1, 10000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonBan] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonNhap] ON 

INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (1, 1, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (2, 1, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (3, 2, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (4, 2, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (5, 3, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (6, 4, 2, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (7, 5, 2, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (8, 6, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (9, 7, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (10, 8, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (11, 9, 1, NULL, NULL)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (12, 10, 1, 1, 100)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (17, 15, 1, 10, 10000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (18, 15, 1, 10, 10000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (21, 17, 2, 100, 2340000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (23, 19, 1, 10, 100000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (24, 20, 1, 10, 100000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (25, 1, 1, 1000, 1000000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (26, 1, 1, 121, 1210000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (27, 1, 1, 121, 1210000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maChiTietHoaDonNhap], [soHoaDon], [sanp_id], [soLuong], [donGia]) VALUES (28, 21, 1, 100, 1000000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietKho] ON 

INSERT [dbo].[ChiTietKho] ([MaChiTietKho], [MaKho], [sanp_id], [soLuong]) VALUES (1, 1, 1, 451)
INSERT [dbo].[ChiTietKho] ([MaChiTietKho], [MaKho], [sanp_id], [soLuong]) VALUES (2, 2, 2, 341)
SET IDENTITY_INSERT [dbo].[ChiTietKho] OFF
GO
SET IDENTITY_INSERT [dbo].[danhmucs] ON 

INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (1, N'Văn học Việt Nam')
INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (2, N'Văn học nước ngoài')
INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (3, N'Tham Khảo')
INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (12, N'Thiếu nhi')
INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (13, N'Tình cảm - Lãng mạn')
INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (20, N'Lãng mạn')
INSERT [dbo].[danhmucs] ([maDanhMuc], [tenDanhMuc]) VALUES (21, N'16')
SET IDENTITY_INSERT [dbo].[danhmucs] OFF
GO
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (1, 1, CAST(N'2023-03-14' AS Date), N'Chưa xác thực')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (3, 3, CAST(N'2023-03-14' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (4, 4, CAST(N'2023-03-14' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (5, 5, CAST(N'2023-03-14' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (6, 6, CAST(N'2023-03-14' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (7, 7, CAST(N'2023-03-14' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (8, 8, CAST(N'2023-03-14' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (9, 9, CAST(N'2023-03-21' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (10, 10, CAST(N'2023-04-01' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (12, 12, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (13, 13, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (14, 14, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (15, 15, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (16, 16, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (17, 17, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (18, 18, CAST(N'2023-04-18' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (19, 19, CAST(N'2023-04-19' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (20, 20, CAST(N'2023-04-19' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (21, 21, CAST(N'2023-04-19' AS Date), N'1')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TrangThai]) VALUES (22, 22, CAST(N'2023-04-24' AS Date), N'1')
SET IDENTITY_INSERT [dbo].[DonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[GiaCa] ON 

INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (1, 6, CAST(N'2023-03-16' AS Date), CAST(N'2023-03-16' AS Date), 123000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (2, 12, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 234000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (3, 1, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 125000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (4, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 97000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (5, 3, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 87000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (6, 4, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 100000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (7, 5, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 121000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (9, 7, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 54000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (10, 8, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 90787)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (11, 9, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 121000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (12, 10, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 123000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (13, 11, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 125000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (15, 16, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-21' AS Date), 110000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (17, 22, CAST(N'2023-04-16' AS Date), NULL, 231000)
INSERT [dbo].[GiaCa] ([MaSo], [sanp_id], [NgayBatDau], [NgayKetThuc], [Gia]) VALUES (18, 23, CAST(N'2023-04-16' AS Date), NULL, 110000)
SET IDENTITY_INSERT [dbo].[GiaCa] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonBan] ON 

INSERT [dbo].[HoaDonBan] ([SoHoaDon], [NgayBan], [MaKhachHang]) VALUES (1, CAST(N'2022-01-01' AS Date), 1)
INSERT [dbo].[HoaDonBan] ([SoHoaDon], [NgayBan], [MaKhachHang]) VALUES (2, CAST(N'2023-04-22' AS Date), 2)
INSERT [dbo].[HoaDonBan] ([SoHoaDon], [NgayBan], [MaKhachHang]) VALUES (3, CAST(N'2023-04-22' AS Date), 3)
INSERT [dbo].[HoaDonBan] ([SoHoaDon], [NgayBan], [MaKhachHang]) VALUES (4, CAST(N'2023-04-22' AS Date), 3)
SET IDENTITY_INSERT [dbo].[HoaDonBan] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonNhap] ON 

INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (1, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (2, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (3, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (4, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (5, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (6, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (7, NULL, NULL, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (8, NULL, NULL, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (9, CAST(N'2023-03-21' AS Date), NULL, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (10, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (15, CAST(N'2023-04-10' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (17, CAST(N'2023-04-11' AS Date), 4, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (19, CAST(N'2023-04-11' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (20, CAST(N'2023-04-11' AS Date), 1, 1)
INSERT [dbo].[HoaDonNhap] ([soHoaDon], [ngayNhap], [maNguoiDung], [nsx_id]) VALUES (21, CAST(N'2023-04-18' AS Date), 1, 1)
SET IDENTITY_INSERT [dbo].[HoaDonNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (1, N'Luan', N'Hưng Yên', N'luan2k2hy@gmail.com', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (2, N'string', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (3, N'a', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (4, N'a', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (5, N'a', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (6, N'b', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (7, N'b', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (8, N'string', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (9, N'Đinh Thành Luân', N'Ân Thi-Hưng Yên', N'luan2k2hy@gmail.com', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (10, N'Bùi Hải Hiệp', N'Hưng Yên', N'hiep@gmail.com', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (12, N'string', N'string', N'string', NULL)
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (13, N'string', N'string', N'string', N'84971877014')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (14, N'a', N'a', N'a', N'84971877014')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (15, N'a', N'a', N'a', N'1')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (16, N'a', N'a', N'a', N'1')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (17, N'a', N'a', N'a', N'1')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (18, N'a', N'a', N'a', N'1')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (19, N'a111a', N'a111', N'111', N'1111')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (20, N'Luân', N'Ân Thi', N'luan2k2hy@gmail.com', N'0971877014')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (21, N'a', N'a', N'a', N'a')
INSERT [dbo].[KhachHang] ([MaKhachHang], [tenKhachHang], [diaChi], [email], [sdt]) VALUES (22, N'as', N'ads', N'sda', N'sda')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi]) VALUES (1, N'Nhã Nam', N'Hà Nội')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi]) VALUES (2, N'Phụ nữ', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[Kho] OFF
GO
SET IDENTITY_INSERT [dbo].[Loaisp] ON 

INSERT [dbo].[Loaisp] ([loai_id], [loai_name], [danhmuc_id]) VALUES (1, N'Tình cảm - Lãng mạn', 2)
INSERT [dbo].[Loaisp] ([loai_id], [loai_name], [danhmuc_id]) VALUES (2, N'Sử/kí', 1)
INSERT [dbo].[Loaisp] ([loai_id], [loai_name], [danhmuc_id]) VALUES (3, N'Hài hước', 2)
INSERT [dbo].[Loaisp] ([loai_id], [loai_name], [danhmuc_id]) VALUES (4, N'Văn học Việt Nam', 1)
INSERT [dbo].[Loaisp] ([loai_id], [loai_name], [danhmuc_id]) VALUES (5, N'Văn học nước ngoài', 2)
INSERT [dbo].[Loaisp] ([loai_id], [loai_name], [danhmuc_id]) VALUES (8, N'Thiếu nhi', 1)
SET IDENTITY_INSERT [dbo].[Loaisp] OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([maNguoiDung], [hoTen], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt]) VALUES (1, N'Đinh Thành Luân', CAST(N'2002-09-15' AS Date), N'Nam', N'Ân Thi-Hưng Yên', N'luan2k2hy@gmail.com', NULL)
INSERT [dbo].[NguoiDung] ([maNguoiDung], [hoTen], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt]) VALUES (4, N'Lê Thị Hoà', CAST(N'2023-04-11' AS Date), N'Nữ', N'Đặng Lễ-Ân Thi-Hưng Yên', N'hoa@gmail.com', N'0976879876')
INSERT [dbo].[NguoiDung] ([maNguoiDung], [hoTen], [ngaySinh], [gioiTinh], [diaChi], [email], [sdt]) VALUES (5, N'Nguyễn Quang Anh', CAST(N'2002-09-01' AS Date), N'Nam', N'Đặng Lễ-Ân Thi-Hưng Yên', N'anh2k2hy@gmail.com', N'0987878787')
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO
SET IDENTITY_INSERT [dbo].[Nhasx] ON 

INSERT [dbo].[Nhasx] ([nsx_id], [nsx_name], [diachi], [sdt]) VALUES (1, N'Nhã Nam', N'Hà Nội', 0)
INSERT [dbo].[Nhasx] ([nsx_id], [nsx_name], [diachi], [sdt]) VALUES (2, N'Phụ nữ', N'Hà Nội', 0)
INSERT [dbo].[Nhasx] ([nsx_id], [nsx_name], [diachi], [sdt]) VALUES (3, N'IPM', N'Hồ Chí Minh', NULL)
SET IDENTITY_INSERT [dbo].[Nhasx] OFF
GO
SET IDENTITY_INSERT [dbo].[Sanpham] ON 

INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (1, N'Mã Mẫu Tử', N'23x12', 1, 4, 1, 123, N'string', CAST(N'2023-03-13T08:07:56.973' AS DateTime), N'ITIP1FEH.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (2, N'Nhắn gửi 1 tôi người đã yêu em', N'23x12', 1, 5, 1, 123, N'string', CAST(N'2022-03-13T08:07:56.973' AS DateTime), N'8BF9J45D.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (3, N'Lão Hạc', N'23x12', 1, 1, 1, 123, N'string', CAST(N'2022-03-13T08:07:56.973' AS DateTime), N'SN8N3FX2.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (4, N'Tình Mẫu Tử', N'23x12', 1, 4, 1, 123, N'string', CAST(N'2021-03-13T08:07:56.973' AS DateTime), N'NGQ7VG5G.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (5, N'Vệ sinh cơ thể', N'23x12', 1, 4, 1, 123, N'string', CAST(N'2021-03-13T08:07:56.973' AS DateTime), N'J5YIBHHY.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (6, N'Sinh vật học kì thú', N'23x32', 1, 1, 1, 123, N'string', CAST(N'2023-03-16T00:36:55.027' AS DateTime), N'PT9WXQU7.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (7, N'Đại Nam', N'32x15', 1, 4, 1, 2123, N'<p>sad</p>
', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'7YYWZJ3H.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (8, N'Chăm mẹ ốm mệt', N'32x15', 1, 4, 1, 231, N'<p>qew</p>
', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'GN3VCU28.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (9, N'Gương soi tội lỗi', N'43x14', 1, 1, 1, 123, N'<p>wqe</p>
', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'35I2XI5F.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (10, N'Học cách sẻ chia', N'43x14', 1, 1, 1, 321, N'<p>eqw</p>
', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'GEIEZZ8K.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (11, N'Lão hạc', N'43x14', 1, 1, 1, 31, N'<p>weq</p>
', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'tải xuống.jfif')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (12, N'Nhắn gửi tất cả các em những người tôi đã yêu', N'23x32', 1, 5, 1, 123, N'string', CAST(N'2023-03-21T02:44:22.143' AS DateTime), N'N6MDM5X4.png')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (16, N'Trồng cây gây rừng', N'32x12', 1, 1, 1, 121, N'a', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'3UBHZDJM.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (21, N'Đại Nam', N'32x12', 1, 1, 1, 121, N'a', CAST(N'1990-01-12T00:00:00.000' AS DateTime), N'7YYWZJ3H.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (22, N'Tâm hồn cao thượng', N'32x12', 1, 1, 1, 231, N'a', CAST(N'2002-09-01T00:00:00.000' AS DateTime), N'7QBCRMMF.jpg')
INSERT [dbo].[Sanpham] ([sanp_id], [sanp_name], [size], [TG_id], [loai_id], [nsx_id], [sotrang], [tomtat], [namsx], [image]) VALUES (23, N'Chăm mẹ ốm mệt', N'42x12', 1, 8, 1, 98, N'a', CAST(N'2002-02-03T00:00:00.000' AS DateTime), N'GN3VCU28.jpg')
SET IDENTITY_INSERT [dbo].[Sanpham] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([maTaiKhoan], [maNguoiDung], [taiKhoan], [matKhau], [ngayBatDau], [ngayKetThuc], [trangThai], [loaiQuyen]) VALUES (1, 1, N'luan', N'1', NULL, NULL, N'1', N'Admin')
INSERT [dbo].[TaiKhoan] ([maTaiKhoan], [maNguoiDung], [taiKhoan], [matKhau], [ngayBatDau], [ngayKetThuc], [trangThai], [loaiQuyen]) VALUES (4, 4, N'hoa', N'1', NULL, NULL, N'1', N'Admin')
INSERT [dbo].[TaiKhoan] ([maTaiKhoan], [maNguoiDung], [taiKhoan], [matKhau], [ngayBatDau], [ngayKetThuc], [trangThai], [loaiQuyen]) VALUES (5, 5, N'anh', N'1', NULL, NULL, N'1', N'Admin')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[TG] ON 

INSERT [dbo].[TG] ([TG_id], [TG_name], [TG_diachi], [sdt], [email]) VALUES (1, N'Ngô Tất Tố', N'Hà Nội', 0, NULL)
INSERT [dbo].[TG] ([TG_id], [TG_name], [TG_diachi], [sdt], [email]) VALUES (2, N'Nguyễn Văn Linh', N'Hà Nội', 0, NULL)
SET IDENTITY_INSERT [dbo].[TG] OFF
GO
ALTER TABLE [dbo].[Nhasx] ADD  DEFAULT ((0)) FOR [diachi]
GO
ALTER TABLE [dbo].[Nhasx] ADD  DEFAULT ((0)) FOR [sdt]
GO
ALTER TABLE [dbo].[Sanpham] ADD  DEFAULT ((0)) FOR [tomtat]
GO
ALTER TABLE [dbo].[TG] ADD  DEFAULT ((0)) FOR [TG_diachi]
GO
ALTER TABLE [dbo].[TG] ADD  DEFAULT ((0)) FOR [sdt]
GO
ALTER TABLE [dbo].[ChiTietAnh]  WITH CHECK ADD FOREIGN KEY([sanp_id])
REFERENCES [dbo].[Sanpham] ([sanp_id])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([sanp_id])
REFERENCES [dbo].[Sanpham] ([sanp_id])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH CHECK ADD FOREIGN KEY([sanp_id])
REFERENCES [dbo].[Sanpham] ([sanp_id])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH CHECK ADD FOREIGN KEY([SoHoaDon])
REFERENCES [dbo].[HoaDonBan] ([SoHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([sanp_id])
REFERENCES [dbo].[Sanpham] ([sanp_id])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([soHoaDon])
REFERENCES [dbo].[HoaDonNhap] ([soHoaDon])
GO
ALTER TABLE [dbo].[ChiTietKho]  WITH CHECK ADD FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[ChiTietKho]  WITH CHECK ADD FOREIGN KEY([sanp_id])
REFERENCES [dbo].[Sanpham] ([sanp_id])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GiaCa]  WITH CHECK ADD FOREIGN KEY([sanp_id])
REFERENCES [dbo].[Sanpham] ([sanp_id])
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([maNguoiDung])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([nsx_id])
REFERENCES [dbo].[Nhasx] ([nsx_id])
GO
ALTER TABLE [dbo].[Loaisp]  WITH CHECK ADD FOREIGN KEY([danhmuc_id])
REFERENCES [dbo].[danhmucs] ([maDanhMuc])
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD FOREIGN KEY([loai_id])
REFERENCES [dbo].[Loaisp] ([loai_id])
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD FOREIGN KEY([nsx_id])
REFERENCES [dbo].[Nhasx] ([nsx_id])
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD FOREIGN KEY([TG_id])
REFERENCES [dbo].[TG] ([TG_id])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([maNguoiDung])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
/****** Object:  StoredProcedure [dbo].[sp_banchay_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_banchay_get_by_id](@SoLuong int)
AS
    BEGIN
 --       SELECT TOP (1) ChiTietHoaDonBan.sanp_id ,SUM(ChiTietHoaDonBan.SoLuong) as SL
	--FROM SanPham inner  JOIN ChiTietHoaDonBan on ChiTietHoaDonBan.sanp_id = SanPham.sanp_id
	--GROUP BY ChiTietHoaDonBan.sanp_id
	SELECT TOP (@SoLuong) ChiTietDonHang.sanp_id, Sanpham.sanp_name, Sanpham.Size, Sanpham.TG_id, Sanpham.loai_id, Sanpham.nsx_id, Sanpham.sotrang, Sanpham.tomtat,
	Sanpham.namsx, Sanpham.Image, GiaCa.Gia,SUM(ChiTietDonHang.SoLuong) as SL
	FROM SanPham inner  JOIN  ChiTietDonHang on ChiTietDonHang.sanp_id = SanPham.sanp_id inner join GiaCa on GiaCa.sanp_id = Sanpham.sanp_id
	GROUP BY ChiTietDonHang.sanp_id, Sanpham.sanp_name, Sanpham.Size, Sanpham.TG_id, Sanpham.loai_id, Sanpham.nsx_id, Sanpham.sotrang, Sanpham.tomtat,
	Sanpham.namsx, Sanpham.Image, GiaCa.Gia
	order by SL desc
	
	
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_chitietdonhang_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_chitietdonhang_create]
(

@maDonHang int,
@sanp_id int,
@soLuong int,
@gia int
)
AS
    BEGIN
     
	 insert into  ChiTietDonHang(
	  
	  MaDonHang,
	  sanp_id,
	  soLuong,
	  gia)
	  values(@maDonHang, @sanp_id, @soLuong, @gia)

    
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_chitietdonhang_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_chitietdonhang_delete_by_id](@ma int)
AS
    BEGIN
	  Delete from ChiTietDonHang
	  where MaDonHang = @ma
        
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_chitietdonhang_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_chitietdonhang_update]
(
@maChiTietDonHang int,
@maDonHang int,
@sanp_id int,
@soLuong int,
@gia int
)
AS
    BEGIN
     
	 Update  ChiTietDonHang
	  set  
	  MaDonHang = @maDonHang,
	  sanp_id = @sanp_id,
	  soLuong = @soLuong,
	  gia = @gia
	  
	  
	  Where MaChiTietDonHang = @maChiTietDonHang
    
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_chitiethoadonban_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_chitiethoadonban_create]
(
 
 @SoHoaDon int,
 @sanp_id int,
 @SoLuong int,
 @GiaBan int
 
 --@maSanPham nvarchar(10),
 --@soLuong nvarchar(10),
 --@donGiaNhap nvarchar(10)



)
AS
    BEGIN
	--IF(@listchitiet is not null)

      INSERT INTO ChiTietHoaDonban
                (  
				
				SoHoaDon,
				sanp_id,
				SoLuong,
				GiaBan
                )
                VALUES
                (
				@SoHoaDon,
				@sanp_id,
				@SoLuong,
				@GiaBan
                );
				
		end

        SELECT '';
GO
/****** Object:  StoredProcedure [dbo].[sp_chitiethoadonban_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_chitiethoadonban_delete_by_id](@ma int)
AS
    BEGIN
	  Delete from ChiTietHoaDonBan
	  where SoHoaDon = @ma
        
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_chitiethoadonban_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_chitiethoadonban_update]
(
@MaChiTietHoaDonBan int,
@sanp_id int,
@SoLuong int,
@GiaBan int,
@SoHoaDon int

)
AS
    BEGIN
     
	 Update   ChiTietHoaDonBan
	  set  
	  
	  SoHoaDon = @SoHoaDon,
	  sanp_id = @sanp_id,
	  SoLuong = @SoLuong,
	  GiaBan = @GiaBan
	  
	  Where MaChiTietHoaDonBan = @MaChiTietHoaDonBan
	  
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_chitiethoadonnhap_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_chitiethoadonnhap_create]
(
 
 @soHoaDon int,
 @sanp_id int,
 @soLuong int,
 @donGia int
 
 --@maSanPham nvarchar(10),
 --@soLuong nvarchar(10),
 --@donGiaNhap nvarchar(10)



)
AS
    BEGIN
	--IF(@listchitiet is not null)

      INSERT INTO ChiTietHoaDonNhap
                (  
				
				soHoaDon,
				sanp_id,
				soLuong,
				donGia
                )
                VALUES
                (
				@soHoaDon,
				@sanp_id,
				@soLuong,
				@donGia
                );
				Update ChiTietKho
		set soLuong += @soLuong
		where sanp_id = sanp_id
		end

        SELECT '';
GO
/****** Object:  StoredProcedure [dbo].[sp_danhmuc_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_danhmuc_create]
(
 @TenDanhMuc       NVARCHAR(250)
)
AS
    BEGIN
      INSERT INTO danhmucs
                (  
				
				tenDanhMuc
                )
                VALUES
                ( @TenDanhMuc
                );
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_danhmuc_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_danhmuc_delete_by_id](@MaDanhMuc int)
AS
    BEGIN
        Delete From danhmucs
      where  maDanhMuc = @MaDanhMuc;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_danhmuc_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [dbo].[sp_danhmuc_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) * FROM danhmucs;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_danhmuc_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_danhmuc_get_by_id](@MaDanhMuc int)
AS
    BEGIN
        SELECT *                       
        FROM danhmucs
      where  maDanhMuc = @MaDanhMuc;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_danhmuc_search]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[sp_danhmuc_search] (@page_index  INT, 
                                       @page_size   INT,
									   @tendanhmuc Nvarchar(250)
									  
									   )
AS
    BEGIN
        DECLARE @RecordCount BIGINT;
                SET NOCOUNT ON;
                        SELECT(ROW_NUMBER() OVER(ORDER BY ds.maDanhMuc)) AS RowNumber,ds.tenDanhMuc , ds.maDanhMuc
                        INTO #Results1
                        FROM danhmucs AS ds
					    WHERE  (@tendanhmuc = '' or ds.tenDanhMuc LIKE N'%' + @tendanhmuc + '%') /*muons tim them thif		and (@tenDauSach = '' or ds.tenDauSach LIKE N'%' + @tenDauSach + '%')   */       
                        SELECT @RecordCount = COUNT(*)
                        FROM #Results1;
                        SELECT *, 
                               @RecordCount AS RecordCount
                        FROM #Results1
                        WHERE ROWNUMBER BETWEEN(@page_index - 1) * @page_size + 1 AND(((@page_index - 1) * @page_size + 1) + @page_size) - 1
                              OR @page_index = -1;
                        DROP TABLE #Results1; 
            
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_danhmuc_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_danhmuc_update]
(
@MaDanhMuc             int, 

 @TenDanhMuc       NVARCHAR(250)

)
AS
    BEGIN
     
	 Update   danhmucs
	  set  
	  
	  tenDanhMuc = @TenDanhMuc
	  
	  Where maDanhMuc = @MaDanhMuc
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[sp_donhang_create]
(@khach      NVARCHAR(MAX),  
 @listchitiet NVARCHAR(MAX)
)
AS
    BEGIN
	 IF(@khach IS NOT NULL)
	 Begin
	   INSERT INTO KhachHang
                (tenKhachHang, 
                 diaChi,
				 email,
				 sdt
                )
		 SELECT JSON_VALUE(@khach, '$.tenKhachHang'), 
				JSON_VALUE(@khach, '$.diaChi'), 
				
				JSON_VALUE(@khach, '$.email'), 
				JSON_VALUE(@khach, '$.sdt')
	 end;
	 IF(@listchitiet IS NOT NULL)
	 Begin
	    -- Thêm bảng đơn hàng
		INSERT INTO DonHang
        (MaKhachHang, 
            NgayDat, 
            TrangThai              
        )
        VALUES
        (IDENT_CURRENT('KhachHang'), 
            GETDATE(), 
            1
        );
		-- Thêm bảng chi tiết đơn hàng
        INSERT INTO ChiTietDonHang
                (   MaDonHang, 
                    sanp_id, 
                    soLuong, 
                    gia                       
                )
        SELECT 
			IDENT_CURRENT('DonHang'),		
			JSON_VALUE(p.value, '$.sanp_id'), 
			JSON_VALUE(p.value, '$.soLuong'), 
			JSON_VALUE(p.value, '$.gia')    
        FROM OPENJSON(@listchitiet) AS p;
	end;
    SELECT '';
   END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_creates]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_donhang_creates]
(

@maKhachHang int,
@ngayDat date,
@trangThai nvarchar(50)
)
AS
    BEGIN
     
	 insert into DonHang
	  (
	  
	  MaKhachHang,
	  NgayDat,
	  TrangThai)
	 values(@maKhachHang, @ngayDat, @trangThai)
    
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_data_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_donhang_data_by_id](@ma int)
AS
    BEGIN
        SELECT DonHang.MaDonHang, DonHang.MaKhachHang, DonHang.NgayDat, DonHang.TrangThai, ChiTietDonHang.MaChiTietDonHang,
		ChiTietDonHang.sanp_id, ChiTietDonHang.soLuong, ChiTietDonHang.gia, KhachHang.tenKhachHang, Sanpham.sanp_name
		from DonHang inner join ChiTietDonHang on DonHang.MaDonHang = ChiTietDonHang.MaDonHang inner join Sanpham on ChiTietDonHang.sanp_id = Sanpham.sanp_id
		inner join KhachHang on KhachHang.MaKhachHang = DonHang.MaKhachHang
		where DonHang.MaDonHang = @ma
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_donhang_delete_by_id](@ma int)
AS
    BEGIN
	  Delete from ChiTietDonHang
	  where MaDonHang = @ma
        Delete From DonHang
      where  MaDonHang = @ma;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_donhang_get_all_data](@soluong int)
AS
    BEGIN
        SELECT Top(@soluong) DonHang.MaDonHang, DonHang.MaKhachHang, DonHang.NgayDat, DonHang.TrangThai, ChiTietDonHang.MaChiTietDonHang,
		ChiTietDonHang.sanp_id, ChiTietDonHang.soLuong, ChiTietDonHang.gia, KhachHang.tenKhachHang, Sanpham.sanp_name
		from DonHang inner join ChiTietDonHang on DonHang.MaDonHang = ChiTietDonHang.MaDonHang inner join Sanpham on ChiTietDonHang.sanp_id = Sanpham.sanp_id
		inner join KhachHang on KhachHang.MaKhachHang = DonHang.MaKhachHang
		
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_donhang_get_by_id](@MaDonHang int)
AS
    BEGIN
        SELECT 
		d.MaDonHang,
		d.NgayDat,
		k.TenKhachHang,
		k.DiaChi,
		k.Email,
			   	(
					SELECT 
						c.sanp_id,
						c.SoLuong,
						c.Gia,
						s.sanp_name
						
					FROM ChiTietDonHang AS c
					Inner Join SanPham s on c.sanp_id = s.sanp_id
					WHERE c.MaDonHang = d.MaDonHang FOR JSON PATH
				) AS listjson_chitiet
        FROM DonHang d
		Inner Join KhachHang k on d.MaKhachHang = k.MaKhachHang
      where  d.MaDonHang = @MaDonHang;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_search]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_donhang_search] (@page_index  INT, 
                                       @page_size   INT,
									   @TenKhachHang Nvarchar(250),
									   @SoDienThoai varchar(20),
									   @Email varchar(50),
									   @fr_NgayDat Datetime,
									   @to_NgayDat Datetime
									   )
AS
    BEGIN
        DECLARE @RecordCount BIGINT;
        IF(@page_size <> 0)
            BEGIN
                SET NOCOUNT ON;
                       SELECT(ROW_NUMBER() OVER(
                              ORDER BY d.NgayDat ASC)) AS RowNumber, 
                               d.MaDonHang,
							   d.NgayDat,
							  k.TenKhachHang,
							  k.DiaChi
                        INTO #Results1
                        FROM [DonHang] AS d
						Inner Join KhachHang k On d.MaKhachHang = k.MaKhachHang
					    WHERE    (@TenKhachHang = ''  OR (k.TenKhachHang LIKE '%' + @TenKhachHang + '%')) AND
								 (@SoDienThoai = ''  OR (k.SDT LIKE '%' + @SoDienThoai + '%')) AND
								 (@Email = ''  OR (k.Email LIKE '%' + @Email + '%')) AND 
							     ((@fr_NgayDat IS NULL AND @to_NgayDat IS NULL)
                                    OR (@fr_NgayDat IS NOT NULL
                                       AND @to_NgayDat IS NULL
                                       AND d.NgayDat >= @fr_NgayDat)
                                    OR (@fr_NgayDat IS NULL
                                       AND @to_NgayDat IS NOT NULL
                                       AND d.NgayDat <= @to_NgayDat)
                                   OR (d.NgayDat BETWEEN @fr_NgayDat AND @to_NgayDat));                   
                        SELECT @RecordCount = COUNT(*)
                        FROM #Results1;
                        SELECT *, 
                               @RecordCount AS RecordCount
                        FROM #Results1
                        WHERE ROWNUMBER BETWEEN(@page_index - 1) * @page_size + 1 AND(((@page_index - 1) * @page_size + 1) + @page_size) - 1
                              OR @page_index = -1;
                        DROP TABLE #Results1; 
            END;
            ELSE
            BEGIN
                SET NOCOUNT ON;
                       SELECT(ROW_NUMBER() OVER(
                              ORDER BY d.NgayDat ASC)) AS RowNumber, 
                               d.MaDonHang,
							   d.NgayDat,
							  k.TenKhachHang,
							  k.DiaChi
                        INTO #Results2
                        FROM [DonHang] AS d
						Inner Join KhachHang k On d.MaKhachHang = k.MaKhachHang
					    WHERE    (@TenKhachHang = ''  OR (k.TenKhachHang LIKE '%' + @TenKhachHang + '%')) AND
								 (@SoDienThoai = ''  OR (k.SDT LIKE '%' + @SoDienThoai + '%')) AND
								 (@Email = ''  OR (k.Email LIKE '%' + @Email + '%')) AND
								 ((@fr_NgayDat IS NULL AND @to_NgayDat IS NULL)
                                    OR (@fr_NgayDat IS NOT NULL
                                       AND @to_NgayDat IS NULL
                                       AND d.NgayDat >= @fr_NgayDat)
                                    OR (@fr_NgayDat IS NULL
                                       AND @to_NgayDat IS NOT NULL
                                       AND d.NgayDat <= @to_NgayDat)
                                   OR (d.NgayDat BETWEEN @fr_NgayDat AND @to_NgayDat));                   
                        SELECT @RecordCount = COUNT(*)
                        FROM #Results2;
                        SELECT *, 
                               @RecordCount AS RecordCount
                        FROM #Results2;   
						
                        DROP TABLE #Results2; 
        END;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_donhang_timkiem](@ma varchar)
AS
    BEGIN
	
        SELECT  DonHang.MaDonHang, DonHang.MaKhachHang, DonHang.NgayDat, DonHang.TrangThai, ChiTietDonHang.MaChiTietDonHang,
		ChiTietDonHang.sanp_id, ChiTietDonHang.soLuong, ChiTietDonHang.gia, KhachHang.tenKhachHang, KhachHang.sdt, Sanpham.sanp_name
		from DonHang inner join ChiTietDonHang on DonHang.MaDonHang = ChiTietDonHang.MaDonHang inner join Sanpham on ChiTietDonHang.sanp_id = Sanpham.sanp_id
		inner join KhachHang on KhachHang.MaKhachHang = DonHang.MaKhachHang
		

		where KhachHang.tenKhachHang like '%'+@ma+'%' 
		or DonHang.MaDonHang like @ma or KhachHang.sdt like @ma
		
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_timkiem_nguoidung]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_donhang_timkiem_nguoidung](@ma nvarchar)
AS
    BEGIN
	
        SELECT  DonHang.MaDonHang, DonHang.MaKhachHang, DonHang.NgayDat, DonHang.TrangThai, ChiTietDonHang.MaChiTietDonHang,
		ChiTietDonHang.sanp_id, ChiTietDonHang.soLuong, ChiTietDonHang.gia, KhachHang.tenKhachHang, KhachHang.sdt, Sanpham.sanp_name
		from DonHang inner join ChiTietDonHang on DonHang.MaDonHang = ChiTietDonHang.MaDonHang inner join Sanpham on ChiTietDonHang.sanp_id = Sanpham.sanp_id
		inner join KhachHang on KhachHang.MaKhachHang = DonHang.MaKhachHang
		

		where KhachHang.sdt like '%'+@ma 
		
		
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_donhang_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_donhang_update]
(
@maDonHang int,
@maKhachHang int,
@ngayDat date,
@trangThai nvarchar(50)
)
AS
    BEGIN
     
	 Update DonHang
	  set  
	  
	  MaKhachHang = @maKhachHang,
	  NgayDat = @ngayDat,
	  TrangThai = @trangThai
	  
	  
	  Where MaDonHang = @maDonHang
    
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonban_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[sp_hoadonban_create]
(
 
 @NgayBan date,
 @MaKhachHang int
 
 --@maSanPham nvarchar(10),
 --@soLuong nvarchar(10),
 --@donGiaNhap nvarchar(10)



)
AS
    BEGIN
	--IF(@listchitiet is not null)

      INSERT INTO HoaDonBan
                (  
				
				NgayBan,
				MaKhachHang
                )
                VALUES
                (
				@NgayBan,
				@MaKhachHang
                );
		
	
		end

        SELECT '';
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonban_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_hoadonban_delete_by_id](@ma int)
AS
    BEGIN
	  Delete from ChiTietHoaDonBan
	  where SoHoaDon = @ma
        Delete From HoaDonBan
      where  SoHoaDon = @ma;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonban_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_hoadonban_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) HoaDonBan.SoHoaDon, HoaDonBan.NgayBan, HoaDonBan.MaKhachHang, KhachHang.tenKhachHang, ChiTietHoaDonBan.MaChiTietHoaDonBan,
		ChiTietHoaDonBan.sanp_id, ChiTietHoaDonBan.SoLuong, ChiTietHoaDonBan.GiaBan, Sanpham.sanp_name
		from HoaDonBan inner join ChiTietHoaDonBan on HoaDonBan.soHoaDon = ChiTietHoaDonBan.soHoaDon inner join Sanpham on ChiTietHoaDonBan.sanp_id = Sanpham.sanp_id inner join KhachHang on KhachHang.MaKhachHang = HoaDonBan.MaKhachHang
		;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonban_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_hoadonban_timkiem](@ma nvarchar)
AS
    BEGIN
        SELECT HoaDonBan.SoHoaDon, HoaDonBan.NgayBan, HoaDonBan.MaKhachHang, KhachHang.tenKhachHang, ChiTietHoaDonBan.MaChiTietHoaDonBan,
		ChiTietHoaDonBan.sanp_id, ChiTietHoaDonBan.SoLuong, ChiTietHoaDonBan.GiaBan, Sanpham.sanp_name
		from HoaDonBan inner join ChiTietHoaDonBan on HoaDonBan.soHoaDon = ChiTietHoaDonBan.soHoaDon inner join Sanpham on ChiTietHoaDonBan.sanp_id = Sanpham.sanp_id inner join KhachHang on KhachHang.MaKhachHang = HoaDonBan.MaKhachHang
      where  HoaDonBan.soHoaDon like @ma or KhachHang.tenKhachHang like '%'+@ma+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonban_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_hoadonban_update]
(
@SoHoaDon int,
@NgayBan date,
@MaKhachHang int
)
AS
    BEGIN
     
	 Update   HoaDonBan
	  set  
	  
	  NgayBan = @NgayBan,
	  MaKhachHang = @MaKhachHang
	  
	  Where soHoaDon = @SoHoaDon
	  
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonnhap_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[sp_hoadonnhap_create]
(
 
 @MaNguoiDung int,
 @nsx_id int,
 @listchitiet nvarchar(max)
 --@maSanPham nvarchar(10),
 --@soLuong nvarchar(10),
 --@donGiaNhap nvarchar(10)



)
AS
    BEGIN
	--IF(@listchitiet is not null)

      INSERT INTO HoaDonNhap
                (  
				
				NgayNhap,
				MaNguoiDung,
				nsx_id
                )
                VALUES
                (
				GETDATE(),
				@MaNguoiDung,
				@nsx_id
                );
		

		INSERT INTO ChiTietHoaDonNhap
                (
				
				SoHoaDon,
				sanp_id,
				SoLuong,
				DonGia
                )
		--values
		--(@@IDENTITY, @maSanPham, @soLuong, @donGiaNhap)
		--Update ChiTietKho
		--set SoLuong = SoLuong + @soLuong
		--where sanp_id = @maSanPham
		--values(@@IDENTITY, @SoLuong,@DonGia)
        SELECT 
			IDENT_CURRENT('HoaDonNhap'),
			
			JSON_VALUE(p.value, '$.maSanPham'),
			JSON_VALUE(p.value, '$.soLuong'),
			JSON_VALUE(p.value, '$.donGiaNhap')
        FROM OPENJSON(@listchitiet) as p;
		Update ChiTietKho
		set SoLuong +='$.soLuong'
		where sanp_id = '$.maSanPham'
		end

        SELECT '';
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonnhap_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_hoadonnhap_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) HoaDonNhap.soHoaDon, NguoiDung.hoTen, Sanpham.sanp_name, Nhasx.nsx_name,  HoaDonNhap.ngayNhap, HoaDonNhap.maNguoiDung, HoaDonNhap.nsx_id,ChiTietHoaDonNhap.maChiTietHoaDonNhap,ChiTietHoaDonNhap.sanp_id,
		ChiTietHoaDonNhap.soLuong, ChiTietHoaDonNhap.donGia
		from HoaDonNhap inner join ChiTietHoaDonNhap on HoaDonNhap.soHoaDon = ChiTietHoaDonNhap.soHoaDon inner join Sanpham on ChiTietHoaDonNhap.sanp_id = Sanpham.sanp_id inner join Nhasx on Nhasx.nsx_id = HoaDonNhap.nsx_id
		inner join NguoiDung on NguoiDung.maNguoiDung = HoaDonNhap.maNguoiDung;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonnhap_tao]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[sp_hoadonnhap_tao]
(
 
 @MaNguoiDung int,
 @nsx_id int,
 @sanp_id int,
 @SoLuong int,
 @DonGia int
 --@maSanPham nvarchar(10),
 --@soLuong nvarchar(10),
 --@donGiaNhap nvarchar(10)



)
AS
    BEGIN
	--IF(@listchitiet is not null)

      INSERT INTO HoaDonNhap
                (  
				
				NgayNhap,
				MaNguoiDung,
				nsx_id
                )
                VALUES
                (
				GETDATE(),
				@MaNguoiDung,
				@nsx_id
                );
		

		INSERT INTO ChiTietHoaDonNhap
                (
				
				soHoaDon,
				sanp_id,
				soLuong,
				donGia
                )
		values(@@IDENTITY, @sanp_id, @SoLuong, @DonGia)
		Update ChiTietKho
		set soLuong += @SoLuong
		where sanp_id = sanp_id
		end

        SELECT '';
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonnhap_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_hoadonnhap_timkiem](@string int)
AS
    BEGIN
        SELECT HoaDonNhap.soHoaDon, NguoiDung.hoTen, Sanpham.sanp_name, Nhasx.nsx_name,  HoaDonNhap.ngayNhap, HoaDonNhap.maNguoiDung, HoaDonNhap.nsx_id,ChiTietHoaDonNhap.maChiTietHoaDonNhap,ChiTietHoaDonNhap.sanp_id,
		ChiTietHoaDonNhap.soLuong, ChiTietHoaDonNhap.donGia
		from HoaDonNhap inner join ChiTietHoaDonNhap on HoaDonNhap.soHoaDon = ChiTietHoaDonNhap.soHoaDon inner join Sanpham on ChiTietHoaDonNhap.sanp_id = Sanpham.sanp_id inner join Nhasx on Nhasx.nsx_id = HoaDonNhap.nsx_id
		inner join NguoiDung on NguoiDung.maNguoiDung = HoaDonNhap.maNguoiDung
      where  HoaDonNhap.soHoaDon like @string
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_hoadonnhap_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_hoadonnhap_update]
(
@SoHoaDon int,
 @MaNguoiDung int,
 @nsx_id int,
 @sanp_id int,
 @SoLuong int,
 @DonGia int,
 @NgayNhap date
)
AS
    BEGIN
     
	 Update   HoaDonNhap
	  set  
	  
	  NgayNhap = @NgayNhap,
	  maNguoiDung = @MaNguoiDung,
	  nsx_id = @nsx_id
	  
	  Where soHoaDon = @SoHoaDon
	  update ChiTietHoaDonNhap
	  set
	  sanp_id = @sanp_id,
	  soLuong = @SoLuong,
	  donGia = @DonGia
	  where soHoaDon = @SoHoaDon
	  Update ChiTietKho
		set soLuong += @SoLuong
		where sanp_id = sanp_id
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_get_loaisp_by_danhmuc]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_home_get_loaisp_by_danhmuc](@MaDanhMuc int)
AS
    BEGIN
        SELECT *                       
        FROM Loaisp
      where  danhmuc_id = @MaDanhMuc;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_get_sanpham_by_loáip]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_home_get_sanpham_by_loáip](@MaLoaisp int)
AS
    BEGIN
        SELECT *                       
        FROM Sanpham
      where  loai_id = @MaLoaisp;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_get_sanpham_by_nhasx]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_home_get_sanpham_by_nhasx](@matacgia int)
AS
    BEGIN
        SELECT *                       
        FROM Sanpham
      where nsx_id = @matacgia;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_get_sanpham_by_tacgia]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_home_get_sanpham_by_tacgia](@matacgia int)
AS
    BEGIN
        SELECT *                       
        FROM Sanpham
      where TG_id = @matacgia;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_getsp_by_loai]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_home_getsp_by_loai](@SoLuong int,@Ten int)
AS
    BEGIN
        SELECT TOP(@SoLuong) *                       
        FROM Sanpham
      where  loai_id = @Ten;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_sach_cungtacgia]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_home_sach_cungtacgia](@MaTacGia int, @SoLuong int)
AS
    BEGIN
        SELECT top(@soluong) *                     
        FROM Sanpham
      where TG_id = @MaTacGia;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_home_timkiem_sanpham]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_home_timkiem_sanpham](@string nvarchar(50))
AS
    BEGIN
        SELECT *                       
        FROM Sanpham c inner join TG d on c.TG_id = d.TG_id
      where  c.sanp_name like '%'+@string+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_kho_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kho_create]
(
 @TenKho nvarchar(50),
 @DiaChi nvarchar(50),
 @sanp_id int,
 @SoLuong int
)
AS
    BEGIN
      INSERT INTO Kho
                (  
				
				TenKho,
				DiaChi
                )
                VALUES
                (
				@TenKho,
				@DiaChi
                );
	   Insert into ChiTietKho(
	   MaKho, sanp_id, SoLuong) values(@@IDENTITY, @sanp_id, @SoLuong);
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_kho_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_kho_delete_by_id](@MaKho int)
AS
    BEGIN
        Delete From Kho
      where  MaKho = @MaKho;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_kho_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kho_get_all_data]
AS
    BEGIN
        SELECT Kho.MaKho, Kho.TenKho, Kho.DiaChi, ChiTietKho.sanp_id, ChiTietKho.soLuong
		from Kho inner join ChiTietKho on Kho.MaKho = ChiTietKho.MaKho;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_kho_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_kho_get_by_id](@MaKho int)
AS
    BEGIN
        SELECT *                       
        FROM Kho
      where  MaKho = @MaKho;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_kho_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kho_timkiem](@string int)
AS
    BEGIN
        SELECT Kho.MaKho, Kho.TenKho, Kho.DiaChi, ChiTietKho.sanp_id, ChiTietKho.soLuong
		from Kho inner join ChiTietKho on Kho.MaKho = ChiTietKho.MaKho
      where  Kho.MaKho like @string
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_kho_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kho_update]
(
@MaKho int,
@TenKho nvarchar(50),
@DiaChi nvarchar(50),
@sanp_id int,
@SoLuong int
)
AS
    BEGIN
     
	 Update   Kho
	  set  
	  TenKho = @TenKho,
	  DiaChi = @DiaChi
	  
	  
	  Where MaKho = @MaKho
     UpDate ChiTietKho
	 set
	  sanp_id = @sanp_id,
	  SoLuong = @SoLuong
	Where MaKho = @MaKho
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_loaisp_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loaisp_create]
(
 @loai_name       NVARCHAR(250),
 @danhmuc_id int
)
AS
    BEGIN
      INSERT INTO Loaisp
                (  
				
				loai_name,
				danhmuc_id
                )
                VALUES
                (
				@loai_name,
				@danhmuc_id
                );
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_loaisp_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [dbo].[sp_loaisp_delete_by_id](@MaLoaisp int)
AS
    BEGIN
        Delete From Loaisp
      where  loai_id = @MaLoaisp;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_loaisp_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_loaisp_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) * FROM Loaisp;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_loaisp_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [dbo].[sp_loaisp_get_by_id](@MaLoaisp int)
AS
    BEGIN
        SELECT *                       
        FROM Loaisp
      where  loai_id = @MaLoaisp;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_loaisp_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_loaisp_timkiem](@string nvarchar(50))
AS
    BEGIN
        SELECT *                       
        FROM Loaisp
      where  loai_name like '%'+@string+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_loaisp_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_loaisp_update]
(
@loai_id int,
@loai_name nvarchar(50),
@danhmuc_id int

)
AS
    BEGIN
     
	 Update   Loaisp
	  set  
	  
	  loai_name = @loai_name,
	  danhmuc_id = @danhmuc_id
	  
	  Where loai_id = @loai_id
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nguoidung_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nguoidung_create]
(
 @HoTen nvarchar(50),
 @NgaySinh Date,
 @GioiTinh nvarchar(50),
 @DiaChi nvarchar(50),
 @Email nvarchar(50),
 @SDT nvarchar(50),
 @TaiKhoan nvarchar(50),
 @MatKhau nvarchar(50),	
 @TrangThai nvarchar(50),
 @LoaiQuyen nvarchar(50)
)
AS
    BEGIN
      INSERT INTO NguoiDung
                (  
				
				hoTen, ngaySinh, gioiTinh, diaChi, email, sdt
                )
                VALUES
                (
				@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SDT
                );
		INSERT INTO TaiKhoan
                (  
				
				maNguoiDung, taiKhoan, matKhau, trangThai, loaiQuyen
                )
                VALUES
                (
				@@IDENTITY, @TaiKhoan, @MatKhau,@TrangThai, @LoaiQuyen
                );
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nguoidung_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_nguoidung_delete_by_id](@MaNguoiDung int)
AS
    BEGIN
	  Delete From TaiKhoan
      where  MaNguoiDung = @MaNguoiDung;
      Delete From NguoiDung
      where  MaNguoiDung = @MaNguoiDung;
	  
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nguoidung_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nguoidung_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) NguoiDung.maNguoiDung, NguoiDung.hoTen, NguoiDung.gioiTinh, NguoiDung.diaChi,NguoiDung.email,NguoiDung.sdt,
		TaiKhoan.taiKhoan, TaiKhoan.matKhau, TaiKhoan.trangThai, TaiKhoan.loaiQuyen
		from NguoiDung inner join TaiKhoan on NguoiDung.MaNguoiDung = TaiKhoan.MaNguoiDung;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nguoidung_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_nguoidung_get_by_id](@MaNguoiDung int)
AS
    BEGIN
        SELECT *                       
        FROM NguoiDung
      where  MaNguoiDung = @MaNguoiDung;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nguoidung_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_nguoidung_timkiem](@string nvarchar(50))
AS
    BEGIN
        SELECT NguoiDung.maNguoiDung, NguoiDung.hoTen, NguoiDung.gioiTinh, NguoiDung.diaChi,NguoiDung.email,NguoiDung.sdt,
		TaiKhoan.taiKhoan, TaiKhoan.matKhau, TaiKhoan.trangThai, TaiKhoan.loaiQuyen
		from NguoiDung inner join TaiKhoan on NguoiDung.MaNguoiDung = TaiKhoan.MaNguoiDung
      where  NguoiDung.hoTen like '%'+@string+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nguoidung_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_nguoidung_update]
(
@MaNguoiDung int,
 @HoTen nvarchar(50),
 @NgaySinh Date,
 @GioiTinh nvarchar(50),
 @DiaChi nvarchar(50),
 @Email nvarchar(50),
 @SDT nvarchar(50),
  @TaiKhoan nvarchar(50),
 @MatKhau nvarchar(50),	
 @TrangThai nvarchar(50),
 @LoaiQuyen nvarchar(50)
)
AS
    BEGIN
     
	 Update   NguoiDung
	  set  
	  hoTen = @HoTen,
	  ngaySinh = @NgaySinh,
	  gioiTinh = @GioiTinh,
	  diaChi = @DiaChi,
	  email = @Email,
	  sdt = @SDT
	  Where maNguoiDung = @MaNguoiDung
	  update TaiKhoan
	  set
	  taiKhoan = @TaiKhoan,
	  matKhau = @MatKhau,
	  trangThai = @TrangThai,
	  loaiQuyen = @LoaiQuyen
	  where maNguoiDung = @MaNguoiDung
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nhasanxuat_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_nhasanxuat_create]
(
 @nsx_name nvarchar(50),
 @diachi nvarchar(50),
 @sdt int
)
AS
    BEGIN
      INSERT INTO Nhasx
                (  
				nsx_name,
				dichi,
				sdt
				
                )
                VALUES
                (
				@nsx_name,
				@diachi,@sdt
                );
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nhasanxuat_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_nhasanxuat_delete_by_id](@MaNhaSanXuat int)
AS
    BEGIN
        Delete From Nhasx
      where  nsx_id = @MaNhaSanXuat;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nhasanxuat_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_nhasanxuat_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) * FROM Nhasx;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nhasanxuat_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [dbo].[sp_nhasanxuat_get_by_id](@MaNhaSanXuat int)
AS
    BEGIN
        SELECT *                       
        FROM Nhasx
      where  nsx_id = @MaNhaSanXuat;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nhasanxuat_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_nhasanxuat_timkiem](@string nvarchar(50))
AS
    BEGIN
        SELECT *                       
        FROM Nhasx
      where  nsx_name like '%'+@string+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_nhasanxuat_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_nhasanxuat_update]
(
@nsx_id int,
 @nsx_name nvarchar(50),
 @diachi nvarchar(50),
 @sdt int
)
AS
    BEGIN
     
	 Update   Nhasx
	  set  
	  nsx_name = @nsx_name,
	  dichi = @diachi,
	  sdt = @sdt
	  
	  
	  Where nsx_id = @nsx_id
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sach_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sach_create]
(
 @sanp_name nvarchar(50),
 @size nvarchar(50),
 @TG_id int,
 @loai_id int,
 @nsx_id int,
 @sotrang int,
 @tomtat nvarchar(2000),
 @namsx datetime,
 @Image nvarchar(1000),
 @gia int

)
AS
    BEGIN
      INSERT INTO Sanpham
                (  
				
				sanp_name,
				Size,
				TG_id,
				loai_id,
				nsx_id,
				sotrang,
				tomtat,
				namsx,
				Image
                )
                VALUES
                (
				@sanp_name,
				@size,
				@TG_id,
				@loai_id,
				@nsx_id,
				@sotrang,
				@tomtat,
				@namsx,
				@Image
                );
		Insert into GiaCa(sanp_id, NgayBatDau, Gia)
		values(@@IDENTITY, GETDATE(), @gia);
		insert into ChiTietKho(MaKho, sanp_id,soLuong)
		values(1, IDENT_CURRENT('Sanpham'), 0)
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sach_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sach_update]
(
@sanp_id int,
 @sanp_name nvarchar(50),
 @size nvarchar(50),
 @TG_id int,
 @loai_id int,
 @nsx_id int,
 @sotrang int,
 @tomtat nvarchar(2000),
 @namsx datetime,
 @Image nvarchar(1000),
 @gia int
)
AS
    BEGIN
     
	 Update   Sanpham
	  set  
	  sanp_name = @sanp_name,
	  Size = @size,
	  TG_id = @TG_id,
	  loai_id = @loai_id,
	  nsx_id = @nsx_id,
	  sotrang = @sotrang,
	  tomtat = @tomtat,
	  namsx = @namsx,
	  image = @Image
	  
	  
	  Where sanp_id = @sanp_id
     Update GiaCa
	 set
	 Gia = @gia
	 where sanp_id = @sanp_id
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sanpham_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sanpham_create]
(
 @sanp_name nvarchar(50),
 @size nvarchar(50),
 @TG_id int,
 @loai_id int,
 @nsx_id int,
 @sotrang int,
 @tomtat nvarchar(2000),
 @namsx datetime,
 @Image nvarchar(1000),
 @GiaCa int,
 @NgayBatDau date,
 @NgayKetThuc date,
 @ListAnh nvarchar(max)

)
AS
    BEGIN
      INSERT INTO Sanpham
                (  
				
				sanp_name,
				Size,
				TG_id,
				loai_id,
				nsx_id,
				sotrang,
				tomtat,
				namsx,
				Image
                )
                VALUES
                (
				@sanp_name,
				@size,
				@TG_id,
				@loai_id,
				@nsx_id,
				@sotrang,
				@tomtat,
				@namsx,
				@Image
                );
		Insert into GiaCa(sanp_id, NgayBatDau, NgayKetThuc, Gia)
		values(@@IDENTITY, @NgayBatDau, @NgayKetThuc, @GiaCa)

		INSERT INTO ChiTietAnh
                (
				sanp_id,
				Anh
                )
        SELECT 
			IDENT_CURRENT('Sanpham'),		
			JSON_VALUE(p.value, '$.Anh')  
        FROM OPENJSON(@ListAnh) AS p;


        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sanpham_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_sanpham_delete_by_id](@MaLoaisp int)
AS
    BEGIN
	  Delete from GiaCa
	  where sanp_id = @MaLoaisp
	   Delete from ChiTietKho
	  where sanp_id = @MaLoaisp
        Delete From Sanpham
      where  sanp_id = @MaLoaisp;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sanpham_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sanpham_get_all_data]
AS
    BEGIN
        SELECt Sanpham.sanp_id, Sanpham.sanp_name, Sanpham.size, Sanpham.TG_id, Sanpham.loai_id, Sanpham.nsx_id, Sanpham.sotrang,
		Sanpham.tomtat, Sanpham.namsx, Sanpham.image, TG.TG_name,Nhasx.nsx_name, Loaisp.loai_name, GiaCa.Gia
		from Sanpham inner join TG on Sanpham.TG_id = TG.TG_id inner join Nhasx on Sanpham.nsx_id = Nhasx.nsx_id inner join Loaisp on Sanpham.loai_id = Loaisp.loai_id
		inner join GiaCa on Sanpham.sanp_id = GiaCa.sanp_id;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sanpham_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_sanpham_get_by_id](@MaSanPham int)
AS
    BEGIN
        SELECt Sanpham.sanp_id, Sanpham.sanp_name, Sanpham.size, Sanpham.TG_id, Sanpham.loai_id, Sanpham.nsx_id, Sanpham.sotrang,
		Sanpham.tomtat, Sanpham.namsx, Sanpham.image, TG.TG_name,Nhasx.nsx_name, Loaisp.loai_name, GiaCa.Gia
		from Sanpham inner join TG on Sanpham.TG_id = TG.TG_id inner join Nhasx on Sanpham.nsx_id = Nhasx.nsx_id inner join Loaisp on Sanpham.loai_id = Loaisp.loai_id
		inner join GiaCa on Sanpham.sanp_id = GiaCa.sanp_id
      where  Sanpham.sanp_id = @MaSanPham;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sanphammoitaiban_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_sanphammoitaiban_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) * FROM Sanpham order by namsx Desc;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_sanphams_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sanphams_timkiem](@string nvarchar(50))
AS
    BEGIN
        SELECt Sanpham.sanp_id, Sanpham.sanp_name, Sanpham.size, Sanpham.TG_id, Sanpham.loai_id, Sanpham.nsx_id, Sanpham.sotrang,
		Sanpham.tomtat, Sanpham.namsx, Sanpham.image, TG.TG_name,Nhasx.nsx_name, Loaisp.loai_name, GiaCa.Gia
		from Sanpham inner join TG on Sanpham.TG_id = TG.TG_id inner join Nhasx on Sanpham.nsx_id = Nhasx.nsx_id inner join Loaisp on Sanpham.loai_id = Loaisp.loai_id
		inner join GiaCa on Sanpham.sanp_id = GiaCa.sanp_id
      where  sanp_name like '%'+@string+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_tacgia_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_tacgia_create]
(
 @TenTacGia nvarchar(50),
 @DiaChi nvarchar(50),
 @sdt  int
)
AS
    BEGIN
      INSERT INTO TG
                (  
				
				TG_name,
				TG_diachi,
				sdt
                )
                VALUES
                (
				@TenTacGia,
				@DiaChi,
				@sdt
                );
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_tacgia_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_tacgia_delete_by_id](@MaTacGia int)
AS
    BEGIN
        Delete From TG
      where  TG_id = @MaTacGia;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_tacgia_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_tacgia_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) * FROM TG;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_tacgia_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_tacgia_get_by_id](@MaTacGia int)
AS
    BEGIN
        SELECT *                       
        FROM TG
      where  TG_id = @MaTacGia;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_tacgia_timkiem]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_tacgia_timkiem](@string nvarchar(50))
AS
    BEGIN
        SELECT *                       
        FROM TG
      where  TG_name like '%'+@string+'%'
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_tacgia_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_tacgia_update]
(
@MaTacGia int,
@TenTacGia nvarchar(50),
@DiaChi nvarchar(50),
@sdt int
)
AS
    BEGIN
     
	 Update   TG
	  set  
	  TG_name = @TenTacGia,
	  TG_diachi = @DiaChi,
	  sdt = @sdt
	  
	  
	  Where TG_id = @MaTacGia
      
	  SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_taikhoan_create]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_taikhoan_create]
(
 @MaNguoiDung int,
 @TaiKhoan nvarchar(50),
 @MatKhau nvarchar(50),
 @NgayBatDau Date,
 @NgayKetThuc Date,
 @TrangThai nvarchar(50),
 @LoaiQuyen nvarchar(50)
)
AS
    BEGIN
      INSERT INTO TaiKhoan
                (  
				
				MaNguoiDung, TaiKhoan, MatKhau, NgayBatDau, NgayKetThuc, TrangThai, LoaiQuyen
                )
                VALUES
                (
				@MaNguoiDung, @TaiKhoan, @MatKhau, @NgayBatDau, @NgayKetThuc ,@TrangThai, @LoaiQuyen
                );
        SELECT '';
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_taikhoan_delete_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[sp_taikhoan_delete_by_id](@MaTaiKhoan int)
AS
    BEGIN
        Delete From TaiKhoan
      where  MaTaiKhoan = @MaTaiKhoan;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_taikhoan_get_all_data]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_taikhoan_get_all_data](@SoLuong int)
AS
    BEGIN
        SELECT TOP(@SoLuong) * FROM TaiKhoan;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_taikhoan_get_by_id]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_taikhoan_get_by_id](@MaTaiKhoan int)
AS
    BEGIN
        SELECT *                       
        FROM TaiKhoan
      where  MaTaiKhoan = @MaTaiKhoan;
    END;
GO
/****** Object:  StoredProcedure [dbo].[sp_taikhoan_update]    Script Date: 24/4/2023 10:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_taikhoan_update]
(
@MaTaiKhoan int,
 @MaNguoiDung int,
 @TaiKhoan nvarchar(50),
 @MatKhau nvarchar(50),
 @NgayBatDau Date,
 @NgayKetThuc Date,
 @TrangThai nvarchar(50),
 @LoaiQuyen nvarchar(50)
)
AS
    BEGIN
     
	 Update   TaiKhoan
	  set  
	  MaNguoiDung = @MaNguoiDung,
	  TaiKhoan = @TaiKhoan,
	  MatKhau = @MatKhau,
	  NgayBatDau = @NgayBatDau,
	  NgayKetThuc = @NgayKetThuc,
	  TrangThai = @TrangThai,
	  LoaiQuyen = @LoaiQuyen
	  
	  
	  
	  Where MaTaiKhoan = @MaTaiKhoan
      
	  SELECT '';
    END;
GO
USE [master]
GO
ALTER DATABASE [QuanLySach] SET  READ_WRITE 
GO

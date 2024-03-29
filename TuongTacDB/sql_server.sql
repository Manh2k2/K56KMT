USE [master]
GO
/****** Object:  Database [svKMT_tnut]    Script Date: 14/04/2023 14:59:58 ******/
CREATE DATABASE [svKMT_tnut]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'svKMT_tnut', FILENAME = N'D:\svKMT_tnut.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'svKMT_tnut_log', FILENAME = N'D:\svKMT_tnut_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [svKMT_tnut] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [svKMT_tnut].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [svKMT_tnut] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [svKMT_tnut] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [svKMT_tnut] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [svKMT_tnut] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [svKMT_tnut] SET ARITHABORT OFF 
GO
ALTER DATABASE [svKMT_tnut] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [svKMT_tnut] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [svKMT_tnut] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [svKMT_tnut] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [svKMT_tnut] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [svKMT_tnut] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [svKMT_tnut] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [svKMT_tnut] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [svKMT_tnut] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [svKMT_tnut] SET  DISABLE_BROKER 
GO
ALTER DATABASE [svKMT_tnut] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [svKMT_tnut] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [svKMT_tnut] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [svKMT_tnut] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [svKMT_tnut] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [svKMT_tnut] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [svKMT_tnut] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [svKMT_tnut] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [svKMT_tnut] SET  MULTI_USER 
GO
ALTER DATABASE [svKMT_tnut] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [svKMT_tnut] SET DB_CHAINING OFF 
GO
ALTER DATABASE [svKMT_tnut] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [svKMT_tnut] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [svKMT_tnut] SET DELAYED_DURABILITY = DISABLED 
GO
USE [svKMT_tnut]
GO
/****** Object:  Table [dbo].[ChiTiet]    Script Date: 14/04/2023 14:59:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTiet](
	[id] [int] NOT NULL,
	[masv] [varchar](13) NOT NULL,
	[Vang] [int] NULL,
 CONSTRAINT [PK_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DiemDanh]    Script Date: 14/04/2023 14:59:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemDanh](
	[id] [int] NOT NULL,
	[ngay] [datetime] NULL,
 CONSTRAINT [PK_DiemDanh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SV]    Script Date: 14/04/2023 14:59:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SV](
	[STT] [int] NULL,
	[masv] [varchar](13) NOT NULL,
	[ho] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NULL,
	[lop] [nvarchar](50) NULL,
 CONSTRAINT [PK_SV] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'CPC205013', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'CPC205016', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'CPC205020', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K185480106029', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K195480106022', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106002', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106011', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106013', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106018', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106022', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106026', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106032', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106034', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106040', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106043', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106045', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106048', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106050', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'K205480106052', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'LAOS195089', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (1, N'LAOS195098', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'CPC205013', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'CPC205016', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'CPC205020', 0)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K185480106029', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K185520103229', 0)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K195480106022', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106002', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106011', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106013', 0)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106018', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106026', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106032', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106034', 0)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106040', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106043', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106045', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106048', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106050', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'K205480106052', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'LAOS195089', 1)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'LAOS195098', 2)
GO
INSERT [dbo].[ChiTiet] ([id], [masv], [Vang]) VALUES (2, N'X123', 0)
GO
INSERT [dbo].[DiemDanh] ([id], [ngay]) VALUES (1, CAST(N'2023-04-13 09:13:00.000' AS DateTime))
GO
INSERT [dbo].[DiemDanh] ([id], [ngay]) VALUES (2, CAST(N'2023-04-13 09:24:00.000' AS DateTime))
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (38, N'CPC205013', N'Kun', N'Vengann', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (28, N'CPC205016', N'Mao', N'Sorakpheanukma', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (27, N'CPC205020', N'Pon', N'Sokphal', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (37, N'K185480106029', N'Vi Anh', N'Tuấn', N'K54KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (1, N'K185520103229', N'Nguyễn Tá', N'Anh', N'K54KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (33, N'K195480106022', N'Lê Đức', N'Toàn', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (3, N'K205480106002', N'Đỗ Tuấn', N'Anh', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (2, N'K205480106003', N'Vũ Công', N'Anh', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (5, N'K205480106005', N'Nguyễn Duy', N'Cao', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (8, N'K205480106010', N'Ma Bách', N'Duy', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (9, N'K205480106011', N'Phương Minh', N'Duy', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (43, N'K205480106013', N'Nguyễn Thế', N'Định', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (16, N'K205480106015', N'Đặng Thị', N'Hà', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (19, N'K205480106018', N'Triệu Văn', N'Lương', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (22, N'K205480106020', N'Giáp Văn', N'Nam', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (23, N'K205480106021', N'Dương Thị Bích', N'Nguyệt', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (25, N'K205480106022', N'Hoàng Tràn', N'Phâu', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (31, N'K205480106025', N'Hoàng Mạnh', N'Tiến', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (32, N'K205480106026', N'Lê Việt', N'Tiến', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (30, N'K205480106027', N'Nguyễn Thị', N'Thảo', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (40, N'K205480106030', N'Xèn Đức', N'Việt', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (42, N'K205480106032', N'Nguyễn Phi', N'Vũ', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (10, N'K205480106033', N'Nguyễn Thị Mỹ', N'Duyên', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (26, N'K205480106034', N'Vi Duy', N'Quốc', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (34, N'K205480106035', N'Vũ Ngọc', N'Trang', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (35, N'K205480106037', N'Nguyễn Phương', N'Trâm', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (21, N'K205480106038', N'Nguyễn Đức', N'Mạnh', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (29, N'K205480106039', N'Nguyễn Ngọc', N'Thái', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (4, N'K205480106040', N'Vũ Ngọc', N'Bình', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (18, N'K205480106041', N'Hà Văn', N'Khánh', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (11, N'K205480106042', N'Phạm Tuấn', N'Dương', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (44, N'K205480106043', N'Bùi Minh', N'Đức', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (13, N'K205480106044', N'Đỗ Văn', N'Hiếu', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (12, N'K205480106045', N'Hà Trung', N'Hiếu', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (6, N'K205480106048', N'Hoàng Đức', N'Chung', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (24, N'K205480106049', N'Dương Văn', N'Ninh', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (36, N'K205480106050', N'Trần Nhật', N'Trường', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (41, N'K205480106052', N'Lưu Viết', N'Vĩ', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (14, N'K205480106054', N'Nguyễn Thị Minh', N'Hoa', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (15, N'K205480106055', N'Trần Quang', N'Huy', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (17, N'K205510205187', N'Trần Thái', N'Học', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (39, N'LAOS195087', N'Vilaphon', N'Viengsavanh', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (20, N'LAOS195089', N'Kouson', N'Mosaky', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (7, N'LAOS195098', N'Phommaly', N'Dobee', N'K56KMT.01')
GO
INSERT [dbo].[SV] ([STT], [masv], [ho], [ten], [lop]) VALUES (45, N'X123', N'Đỗ Duy', N'Cốp', N'ABC')
GO
ALTER TABLE [dbo].[ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiet_DiemDanh] FOREIGN KEY([id])
REFERENCES [dbo].[DiemDanh] ([id])
GO
ALTER TABLE [dbo].[ChiTiet] CHECK CONSTRAINT [FK_ChiTiet_DiemDanh]
GO
ALTER TABLE [dbo].[ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiet_SV] FOREIGN KEY([masv])
REFERENCES [dbo].[SV] ([masv])
GO
ALTER TABLE [dbo].[ChiTiet] CHECK CONSTRAINT [FK_ChiTiet_SV]
GO
/****** Object:  StoredProcedure [dbo].[sp_biendoi]    Script Date: 14/04/2023 14:59:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_biendoi]
	@id int,
	@masv nvarchar(50),
	@target int
AS
BEGIN
	if exists(select * from chitiet where id=@id and masv=@masv)
		update ChiTiet set Vang=@target where masv=@masv and id=@id;
	else
		insert into ChiTiet(id,masv,vang)values(@id,@masv,@target);
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DiemDanh]    Script Date: 14/04/2023 14:59:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		do duy cop
-- Create date: 13.4.23
-- Description:	view kq diem danh
-- =============================================
CREATE PROCEDURE [dbo].[SP_DiemDanh]
	@action nvarchar(50)='View_kq_dd',
	@id int
AS
BEGIN
	if(@action='View_kq_dd')
	begin	    
		select S.*, 
			case 
				when C.Vang=1  then N'Vắng mặt' 
				when C.Vang=2  then N'Đi muộn' 
				else N'Đi học'
			 end as [Điểm Danh]
		from SV S left join ChiTiet C on S.masv=C.masv and C.id=@id

	end
END

GO
USE [master]
GO
ALTER DATABASE [svKMT_tnut] SET  READ_WRITE 
GO

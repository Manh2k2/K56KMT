USE [master]
GO
/****** Object:  Database [QLDT]    Script Date: 22/04/2023 12:10:59 ******/
CREATE DATABASE [QLDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDT', FILENAME = N'D:\SQL2014\DB\QLDT.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDT_log', FILENAME = N'D:\SQL2014\DB\QLDT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDT] SET  MULTI_USER 
GO
ALTER DATABASE [QLDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLDT] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLDT]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ds_mon_se_hoc]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Do Duy Cop
-- Create date: 20.4.23
-- Description:	tao ds mon cua 1 sv se hoc
-- =============================================
CREATE FUNCTION [dbo].[fn_ds_mon_se_hoc]
(
	@masv varchar(13),
	@n int =2  -- số môn tối đa trong 1 đợt mà sv đc phép học cùng lúc
)
RETURNS 
@KQ TABLE
(
	mamon varchar(7)
)
AS
BEGIN
	with T as(
		select distinct H.MaMon,  C.STT
		from HocTap H join SV S on (H.masv=S.masv)and(S.masv=@masv)and(H.maTT=1 or H.maTT=5)
		              join Nganh N on N.maNganh=S.maNganh
					  join ChiTiet C on (C.manganh=N.maNganh)and(C.mamon=H.maMon)
	)
	insert into @KQ(mamon)
		select top (@n) maMon 
		from T 
		order by T.STT;	
	
	RETURN 
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_ds_sv_se_hoc]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Do Duy Cop
-- Create date: 20.4.23
-- Description:	tao ds mon cua 1 sv se hoc
-- =============================================
CREATE FUNCTION [dbo].[fn_ds_sv_se_hoc]
(
	@maMon varchar(7),
	@n int
)
RETURNS 
@KQ TABLE
(
	masv varchar(13)
)
AS
BEGIN
	with T as(
		select S.masv, H.MaMon, C.STT
		from HocTap H join SV S on H.masv=S.masv and H.maMon=@maMon
					join Nganh N on N.maNganh=S.maNganh
					join ChiTiet C on C.manganh=N.maNganh and C.mamon=H.maMon
		where (H.maTT=1 or H.maTT=5)
			and(H.maMon in (select maMon from dbo.fn_ds_mon_se_hoc(S.masv,@n)))
	)
	insert into @KQ(masv)
		select masv
		from T
		order by T.STT;

	RETURN 
END

GO
/****** Object:  Table [dbo].[ChiTiet]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTiet](
	[manganh] [int] NOT NULL,
	[mamon] [varchar](7) NOT NULL,
	[STT] [int] NULL,
 CONSTRAINT [PK_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[manganh] ASC,
	[mamon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangKy](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maLop] [int] NULL,
	[maMon] [varchar](7) NULL,
	[maDot] [char](5) NULL,
	[masv] [varchar](13) NULL,
	[DiemKT] [float] NULL,
	[DiemThi] [float] NULL,
 CONSTRAINT [PK_DangKy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dot]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dot](
	[maDot] [char](5) NOT NULL,
	[TuNgay] [date] NULL,
	[DenNgay] [date] NULL,
 CONSTRAINT [PK_Dot] PRIMARY KEY CLUSTERED 
(
	[maDot] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocTap]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocTap](
	[masv] [varchar](13) NOT NULL,
	[maMon] [varchar](7) NOT NULL,
	[maTT] [int] NOT NULL CONSTRAINT [DF_HocTap_maTT]  DEFAULT ((1)),
	[Diem] [float] NULL,
 CONSTRAINT [PK_HocTap] PRIMARY KEY CLUSTERED 
(
	[masv] ASC,
	[maMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [int] IDENTITY(1,1) NOT NULL,
	[maMon] [varchar](7) NULL,
	[maDot] [char](5) NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMon] [varchar](7) NOT NULL,
	[tenMon] [nvarchar](50) NULL,
	[STC] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[maMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[maNganh] [int] NOT NULL,
	[tenNganh] [nvarchar](500) NULL,
 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED 
(
	[maNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SV]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SV](
	[masv] [varchar](13) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[GT] [bit] NULL,
	[maNganh] [int] NULL,
	[maDot] [char](5) NULL,
 CONSTRAINT [PK_SV] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[maTT] [int] NOT NULL,
	[tenTT] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[maTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiet_MonHoc] FOREIGN KEY([mamon])
REFERENCES [dbo].[MonHoc] ([maMon])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTiet] CHECK CONSTRAINT [FK_ChiTiet_MonHoc]
GO
ALTER TABLE [dbo].[ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiet_Nganh] FOREIGN KEY([manganh])
REFERENCES [dbo].[Nganh] ([maNganh])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTiet] CHECK CONSTRAINT [FK_ChiTiet_Nganh]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_Dot] FOREIGN KEY([maDot])
REFERENCES [dbo].[Dot] ([maDot])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_Dot]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_Lop] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([maLop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_Lop]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_MonHoc] FOREIGN KEY([maMon])
REFERENCES [dbo].[MonHoc] ([maMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_MonHoc]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_SV] FOREIGN KEY([masv])
REFERENCES [dbo].[SV] ([masv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_SV]
GO
ALTER TABLE [dbo].[HocTap]  WITH CHECK ADD  CONSTRAINT [FK_HocTap_MonHoc] FOREIGN KEY([maMon])
REFERENCES [dbo].[MonHoc] ([maMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HocTap] CHECK CONSTRAINT [FK_HocTap_MonHoc]
GO
ALTER TABLE [dbo].[HocTap]  WITH CHECK ADD  CONSTRAINT [FK_HocTap_SV] FOREIGN KEY([masv])
REFERENCES [dbo].[SV] ([masv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HocTap] CHECK CONSTRAINT [FK_HocTap_SV]
GO
ALTER TABLE [dbo].[HocTap]  WITH CHECK ADD  CONSTRAINT [FK_HocTap_TrangThai] FOREIGN KEY([maTT])
REFERENCES [dbo].[TrangThai] ([maTT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HocTap] CHECK CONSTRAINT [FK_HocTap_TrangThai]
GO
ALTER TABLE [dbo].[SV]  WITH CHECK ADD  CONSTRAINT [FK_SV_Nganh] FOREIGN KEY([maNganh])
REFERENCES [dbo].[Nganh] ([maNganh])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SV] CHECK CONSTRAINT [FK_SV_Nganh]
GO
ALTER TABLE [dbo].[SV]  WITH CHECK ADD  CONSTRAINT [FK_SV_SV] FOREIGN KEY([maDot])
REFERENCES [dbo].[Dot] ([maDot])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SV] CHECK CONSTRAINT [FK_SV_SV]
GO
/****** Object:  StoredProcedure [dbo].[SP_MoLop]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Do Duy Cop
-- Create date: 20.4.23
-- Description:	ds lop se mo -> $$$
-- =============================================
CREATE PROCEDURE [dbo].[SP_MoLop]
    @action nvarchar(50),
	@MinSL int= 20,
	@MaxLop int =4,
	@maDot char(5)=null
AS
BEGIN
	if(@action='List_Lop')
	begin
		with T as (
			select H.MaMon,count(H.maMon) as SL
			from HocTap H join SV S on H.masv=S.masv
			where (H.maTT=1 or H.maTT=5)
				  AND H.MaMon in (select mamon from DBO.fn_ds_mon_se_hoc(S.masv,@MaxLop))
			group by H.MaMon
			having count(*)>=@minSL
		)

		select M.mamon as [Mã môn],
			   M.tenMon as [Tên môn],
			   M.STC,
			   T.SL  as [Sĩ Số lớp]
		from T join MonHoc M on T.maMon=M.maMon
		order by SL desc;
	end
	else if(@action='Mo_Lop')
	begin
		with T as(
			select H.MaMon,count(H.maMon) as SL
			from HocTap H join SV S on H.masv=S.masv
			where (H.maTT=1 or H.maTT=5)
				  AND H.MaMon in (select mamon from DBO.fn_ds_mon_se_hoc(S.masv,@MaxLop))
			group by H.MaMon
			having count(*)>=@minSL
		)
		insert into Lop(MaMon,MaDot,SL)
		select T.maMon,@maDot,T.SL
		from T 
		where MaMon not in (select MaMon From Lop where maDot=@maDot)
		order by T.SL desc;

		DECLARE C CURSOR LOCAL FAST_FORWARD READ_ONLY FOR
					select L.maLop, L.maMon
					from Lop as L
					where L.maDot=@maDot;
		declare @malop int, @mamon varchar(7);
		OPEN C;
		FETCH NEXT FROM C INTO @malop,@mamon;
		WHILE @@FETCH_STATUS = 0  
			BEGIN
				insert into DangKy(malop,mamon,madot,masv)
				select @malop,@mamon,@madot,T.masv from [dbo].[fn_ds_sv_se_hoc](@mamon,4) as T
				where T.masv not in (select masv from DangKy where malop=@malop);

				update HocTap set maTT=2 
				where (mamon=@mamon) 
				  and (maTT=1 or maTT=5) 
				  and (masv in (select masv from DangKy where malop=@malop));

				FETCH NEXT FROM C INTO @malop,@mamon;
			END;
		CLOSE C;
		DEALLOCATE C;

	end
END

GO
/****** Object:  StoredProcedure [dbo].[SP_SV]    Script Date: 22/04/2023 12:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Do duy cop
-- Create date: 21.04.2023
-- Modify date: 22.04.2023
-- Description:	xử lý 6 thao tác cơ bản với table SV<--n--1--Nganh
-- =============================================
CREATE PROCEDURE [dbo].[SP_SV]
	@action nvarchar(50),
	@q nvarchar(50)=null,
	@masv varchar(13)=null,
	@masv_cu varchar(13)=null,
	@hoten nvarchar(50)=null,
	@ngaysinh date=null,
	@gt bit=null,
	@manganh int=null
AS
BEGIN
	if(@action='LIST_ALL')
	begin
		select 
			masv, 
			hoten as [Họ tên SV], 
			ngaysinh as [Ngày sinh],
			case when GT=1 then N'Nam' else N'Nữ' end as [Giới tính],
			N.tenNganh as [Ngành học]
		from SV S join Nganh N on S.maNganh=N.maNganh
		order by S.maNganh,masv;
	end
	else if(@action='SEARCH_SV')
	begin
		set @q = '%' + @q + '%';
		select 
			masv, 
			hoten as [Họ tên SV], 
			ngaysinh as [Ngày sinh],
			case when GT=1 then N'Nam' else N'Nữ' end as [Giới tính],
			N.tenNganh as [Ngành học]
		from SV S join Nganh N on S.maNganh=N.maNganh
		where (masv like @q)
		    or(hoten like @q) 
			or(ngaysinh like @q) 
			or(tenNganh like @q) 
		order by S.maNganh,masv;
	end
	else if(@action='GET_1_SV')
	begin
		select *
		from SV
		where masv=@masv;
	end
	else if(@action='LIST_NGANH')
	begin
		select maNganh,tenNganh
		from Nganh
		order by maNganh;
	end
	else if(@action='ADD_SV')
	begin
		if(exists(select * from SV where masv=@masv))
		  begin
		    select @hoten=hoten from SV where masv=@masv;
		    RaisError(N'Trùng mã sv: %s với tên %s rồi bạn ơi!',16,1,@masv,@hoten)
			return;
		  end
		insert into SV(masv,hoten,ngaysinh,gt,maNganh)
		values(@masv,@hoten,@ngaysinh,@gt,@maNganh);
	end
	else if(@action='EDIT_SV')
	begin
		if(exists(select * from SV where masv=@masv and masv!=@masv_cu))
		  begin
		    select @hoten=hoten from SV where masv=@masv;
		    RaisError(N'Trùng mã sv: %s với tên %s rồi bạn ơi!',16,1,@masv,@hoten)
			return;
		  end
		update SV 
		set masv=@masv,hoten=@hoten,ngaysinh=@ngaysinh,gt=@gt,maNganh=@maNganh
		where masv=@masv_cu;
	end
	else if(@action='DELETE_SV')
	begin
		if(not exists(select * from SV where masv=@masv))
		  begin
			RaisError(N'Sai mã sv rồi, không có mã %s trong csdl bạn ơi!',16,1,@masv)
			return;
		  end
		delete from SV where masv=@masv;
	end
END

GO
USE [master]
GO
ALTER DATABASE [QLDT] SET  READ_WRITE 
GO

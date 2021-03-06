USE [Qlsv1]
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANGDIEM](
	[MaHocSinh] [char](10) NOT NULL,
	[MaHocKy] [char](10) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[Nam] [int] NOT NULL,
	[DiemMieng] [float] NULL,
	[Diem15] [float] NULL,
	[Diem1Tiet] [float] NULL,
	[DiemCuoiKy] [float] NULL,
	[DiemTB] [float] NULL,
 CONSTRAINT [PK_BANGDIEM] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC,
	[MaHocKy] ASC,
	[MaMon] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIANGDAY]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIANGDAY](
	[MaLop] [char](10) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[Nam] [int] NOT NULL,
	[MaHocKy] [char](10) NOT NULL,
	[MaGiaoVien] [char](10) NULL,
	[SoLuongDat] [int] NULL,
	[TyLe] [float] NULL,
 CONSTRAINT [PK_GIANGDAY] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaMon] ASC,
	[Nam] ASC,
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGiaoVien] [char](10) NOT NULL,
	[TenGiaoVien] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[NoiSinh] [nvarchar](300) NULL,
	[CMND] [int] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Email] [varchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
	[MaMon] [char](10) NULL,
	[MatKhau] [varchar](50) NULL,
	[PhanQuyen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOCKY]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCKY](
	[MaHocKy] [char](10) NOT NULL,
	[TenHocKy] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHocSinh] [char](10) NOT NULL,
	[TenHocSinh] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[NoiSinh] [nvarchar](300) NULL,
	[CMND] [int] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Email] [varchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
	[MatKhau] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOI]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOI](
	[MaKhoi] [char](10) NOT NULL,
	[TenKhoi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [char](10) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[MaKhoi] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMon] [char](10) NOT NULL,
	[TenMon] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THAMSO](
	[MaThamSo] [char](10) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
	[MucToiThieu] [float] NULL,
	[MucToiDa] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TONGKET]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TONGKET](
	[MaLop] [char](10) NOT NULL,
	[MaHocKy] [char](10) NOT NULL,
	[Nam] [int] NULL,
	[SiSo] [int] NULL,
	[SoLuongDatHK] [int] NULL,
	[TyLeHK] [float] NULL,
 CONSTRAINT [PK_TONGKET] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XEPLOP]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XEPLOP](
	[MaHocSinh] [char](10) NOT NULL,
	[Nam] [int] NOT NULL,
	[MaLop] [char](10) NULL,
 CONSTRAINT [PK_XEPLOP] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BD_HK] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BD_HK]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BD_HS] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BD_HS]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BD_MH] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BD_MH]
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_GD_GV] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[GIANGDAY] CHECK CONSTRAINT [FK_GD_GV]
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_GD_HK] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[GIANGDAY] CHECK CONSTRAINT [FK_GD_HK]
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_GD_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[GIANGDAY] CHECK CONSTRAINT [FK_GD_L]
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD  CONSTRAINT [FK_GD_MH] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[GIANGDAY] CHECK CONSTRAINT [FK_GD_MH]
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GV_MH] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [FK_GV_MH]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_L_K] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[KHOI] ([MaKhoi])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_L_K]
GO
ALTER TABLE [dbo].[TONGKET]  WITH CHECK ADD  CONSTRAINT [FK_TK_HK] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[TONGKET] CHECK CONSTRAINT [FK_TK_HK]
GO
ALTER TABLE [dbo].[TONGKET]  WITH CHECK ADD  CONSTRAINT [FK_TK_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[TONGKET] CHECK CONSTRAINT [FK_TK_L]
GO
ALTER TABLE [dbo].[XEPLOP]  WITH CHECK ADD  CONSTRAINT [FK_XL_HS] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
GO
ALTER TABLE [dbo].[XEPLOP] CHECK CONSTRAINT [FK_XL_HS]
GO
ALTER TABLE [dbo].[XEPLOP]  WITH CHECK ADD  CONSTRAINT [FK_XL_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[XEPLOP] CHECK CONSTRAINT [FK_XL_L]
GO
/****** Object:  StoredProcedure [dbo].[Delete_GIANGDAY]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_GIANGDAY]
@MaGiaoVien char(10)
AS
BEGIN
DELETE FROM GIANGDAY
WHERE MaGiaoVien=@MaGiaoVien
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_GiaoVien]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_GiaoVien]
@MaGiaoVien char(10)
AS
BEGIN
DELETE FROM GIAOVIEN
WHERE MaGiaoVien=@MaGiaoVien
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_HOCSINH]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_HOCSINH]
@MaHocSinh char(10) 
AS
BEGIN
DELETE FROM HOCSINH 
WHERE MaHocSinh=@MaHocSinh
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_HOCSINHXL]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_HOCSINHXL]
@MaHocSinh char(10) 
AS
BEGIN
DELETE FROM XEPLOP
WHERE MaHocSinh=@MaHocSinh
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_MONHOC]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_MONHOC] 
@MaMon char(10) 
AS
BEGIN
DELETE FROM MONHOC 
WHERE MaMon = @MaMon 
END
GO
/****** Object:  StoredProcedure [dbo].[HS_select_All_Mon]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HS_select_All_Mon]
as
begin
	select * from MONHOC
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_GIANGDAY]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_GIANGDAY](
@MaLop char(10),
@MaHocKy char(10),
@Nam int,
@MaMon char(10),
@MaGiaoVien char(10)
)
AS
BEGIN
INSERT INTO GIANGDAY(MaLop,MaMon,Nam,MaHocKy,MaGiaoVien)
VALUES (@MaLop,@MaMon,@Nam,@MaHocKy,@MaGiaoVien) 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_GiaoVien]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_GiaoVien](
@MaGiaoVien char(10),
@TenGiaoVien nvarchar(100),
@GioiTinh nvarchar(10),
@NgaySinh smalldatetime,
@NoiSinh nvarchar(300),
@CMND int,
@DiaChi nvarchar(200),
@Email varchar(100),
@DienThoai varchar(20),
@MaMon char(10)
)
AS
BEGIN
INSERT INTO GIAOVIEN(MaGiaoVien,TenGiaoVien,GioiTinh,NgaySinh,NoiSinh,CMND,DiaChi,Email,DienThoai,MaMon)
VALUES (@MaGiaoVien,@TenGiaoVien,@GioiTinh,@NgaySinh,@NoiSinh,@CMND,@DiaChi,@Email,@DienThoai,@MaMon) 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_HOCSINH]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_HOCSINH](
@MaHocSinh char(10),
@TenHocSinh nvarchar(100),
@GioiTinh nvarchar(10),
@NgaySinh smalldatetime,
@NoiSinh nvarchar(300),
@CMND int,
@DiaChi nvarchar(200),
@Email varchar(100),
@DienThoai varchar(20)
)
AS
BEGIN
INSERT INTO HOCSINH(MaHocSinh,TenHocSinh,GioiTinh,NgaySinh,NoiSinh,CMND,DiaChi,Email,DienThoai)
VALUES (@MaHocSinh,@TenHocSinh,@GioiTinh,@NgaySinh,@NoiSinh,@CMND,@DiaChi,@Email,@DienThoai) 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_MONHOC]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_MONHOC](
@MaMon char(10),
@TenMon nvarchar(100)
)
AS
BEGIN
INSERT INTO MONHOC(MaMon, TenMon) 
VALUES ( @MaMon, @TenMon) 
END
GO
/****** Object:  StoredProcedure [dbo].[select_AllLop]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_AllLop]
AS
BEGIN
select * from LOP
END
GO
/****** Object:  StoredProcedure [dbo].[select_AllLopMA]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_AllLopMA](
@MaKhoi char(10)
)
AS
BEGIN
select * from LOP 
where MaKhoi=@MaKhoi
END
GO
/****** Object:  StoredProcedure [dbo].[select_GIANGDAY]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_GIANGDAY](
@MaKhoi char(10),
@MaLop char(10),
@MaHocKy char(10),
@Nam int
)
AS
BEGIN
select gv.MaLop,gv.MaMon,gv.MaGiaoVien,gv.MaHocKy
from GIANGDAY as GV
join LOP
on GV.MaLop=LOP.MaLop
where MaKhoi=@MaKhoi and LOP.MaLop= @MaLop and MaHocKy= @MaHocKy and Nam= @Nam
END
GO
/****** Object:  StoredProcedure [dbo].[select_GiaoVien]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_GiaoVien](
@MaMon char(10)
)
AS
BEGIN
select GV.MaGiaoVien,GV.TenGiaoVien,GV.GioiTinh,GV.NgaySinh,GV.NoiSinh,GV.CMND,
GV.DiaChi,GV.Email,GV.DienThoai
from  GIAOVIEN as GV
where GV.MaMon=@MaMon
END
GO
/****** Object:  StoredProcedure [dbo].[select_HocSinh]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_HocSinh](
@MaLop char(10)
,@MaKhoi char(10)
)
AS
BEGIN
select hs.MaHocSinh,hs.TenHocSinh,hs.GioiTinh,hs.NgaySinh,hs.CMND,hs.DienThoai,hs.Email,hs.NoiSinh,hs.DiaChi  from  XEPLOP
join LOP 
on XEPLOP.MaLop=LOP.MaLop
join KHOI
on KHOI.MaKhoi=LOP.MaKhoi
join HOCSINH as hs
on hs.MaHocSinh=XEPLOP.MaHocSinh 
where KHOI.MaKhoi=@MaKhoi and  LOP.MaLop=@MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[select_HocSinhSiSo]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_HocSinhSiSo](
@MaLop char(10)
,@MaKhoi char(10)
)
AS
BEGIN
select COUNT(*) as tong  from  XEPLOP
join LOP 
on XEPLOP.MaLop=LOP.MaLop
join KHOI
on KHOI.MaKhoi=LOP.MaKhoi
join HOCSINH as hs
on hs.MaHocSinh=XEPLOP.MaHocSinh 
where KHOI.MaKhoi=@MaKhoi and  LOP.MaLop=@MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[select_TUOIHS]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_TUOIHS]
AS
BEGIN
select MucToiThieu, MucToiDa 
from THAMSO
WHERE MaThamSo = 'QDTHS   ';
END
GO
/****** Object:  StoredProcedure [dbo].[Update_DiemDat]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_DiemDat](
@MucToiThieu float,
@MucToiDa float
)
AS
BEGIN
UPDATE THAMSO
SET MucToiThieu =  @MucToiThieu, MucToiDa = @MucToiDa
WHERE MaThamSo = 'QDDD   ';
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_GIANGDAY]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_GIANGDAY](
@MaLop char(10),
@MaHocKy char(10),
@Nam int,
@MaMon char(10),
@MaGiaoVien char(10)
)
AS
BEGIN
UPDATE GIANGDAY 
SET MaLop= @MaLop, MaHocKy= @MaHocKy, Nam= @Nam,MaMon=@MaMon,MaGiaoVien=@MaGiaoVien
where MaGiaoVien=@MaGiaoVien
END
GO
/****** Object:  StoredProcedure [dbo].[Update_GiaoVien]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_GiaoVien](
@MaGiaoVien char(10),
@TenGiaoVien nvarchar(100),
@GioiTinh nvarchar(10),
@NgaySinh smalldatetime,
@NoiSinh nvarchar(300),
@CMND int,
@DiaChi nvarchar(200),
@Email varchar(100),
@DienThoai varchar(20),
@MaMon char(10)
)
AS
BEGIN
 UPDATE GIAOVIEN SET MaGiaoVien=@MaGiaoVien,TenGiaoVien=@TenGiaoVien,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh
 ,NoiSinh=@NoiSinh,CMND=@CMND,DiaChi=@DiaChi,Email=@Email,DienThoai=@DienThoai,MaMon=@MaMon
 WHERE MaGiaoVien=@MaGiaoVien
END
GO
/****** Object:  StoredProcedure [dbo].[Update_HOCSINH]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_HOCSINH](
@MaHocSinh char(10),
@TenHocSinh nvarchar(100),
@GioiTinh nvarchar(10),
@NgaySinh smalldatetime,
@NoiSinh nvarchar(300),
@CMND int,
@DiaChi nvarchar(200),
@Email varchar(100),
@DienThoai varchar(20)
)
AS
BEGIN
 UPDATE HOCSINH SET MaHocSinh=@MaHocSinh,TenHocSinh=@TenHocSinh,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh
 ,NoiSinh=@NoiSinh,CMND=@CMND,DiaChi=@DiaChi,Email=@Email,DienThoai=@DienThoai
 WHERE MaHocSinh=@MaHocSinh
END
GO
/****** Object:  StoredProcedure [dbo].[Update_MONHOC]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_MONHOC](
@MaMon char(10),
@TenMon nvarchar(100)
)
AS
BEGIN
UPDATE MONHOC
SET MaMon =  @MaMon, TenMon = @TenMon
WHERE MaMon = @MaMon 
END
GO
/****** Object:  StoredProcedure [dbo].[Update_TUOIGV]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_TUOIGV](
@MucToiThieu float,
@MucToiDa float
)
AS
BEGIN
UPDATE THAMSO
SET MucToiThieu =  @MucToiThieu, MucToiDa = @MucToiDa
WHERE MaThamSo = 'QDTGV   ';
END
GO
/****** Object:  StoredProcedure [dbo].[Update_TUOIHS]    Script Date: 5/14/2017 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_TUOIHS](
@MucToiThieu float,
@MucToiDa float
)
AS
BEGIN
UPDATE THAMSO
SET MucToiThieu =  @MucToiThieu, MucToiDa = @MucToiDa
WHERE MaThamSo = 'QDTHS   ';
END

GO

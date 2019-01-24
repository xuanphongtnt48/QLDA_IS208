--thêm d? li?u vào b?ng môn h?c
CREATE PROCEDURE Insert_MONHOC(
@MaMon char(10),
@TenMon nvarchar(100)
)
AS
BEGIN
INSERT INTO MONHOC(MaMon, TenMon) 
VALUES ( @MaMon, @TenMon) 
END
--Update d? li?u vào b?ng môn h?c
CREATE PROCEDURE Update_MONHOC(
@MaMon char(10),
@TenMon nvarchar(100)
)
AS
BEGIN
UPDATE MONHOC
SET MaMon =  @MaMon, TenMon = @TenMon
WHERE MaMon = @MaMon 
END
--Delete d? li?u vào b?ng môn h?c
CREATE PROCEDURE Delete_MONHOC 
@MaMon char(10) 
AS
BEGIN
DELETE FROM MONHOC 
WHERE MaMon = @MaMon 
END
--select d? li?u b?ng lop
CREATE PROCEDURE select_AllLop
AS
BEGIN
select * from LOP
END
--select d? li?u b?ng lop theo ma khoi
CREATE PROCEDURE select_AllLopMA(
@MaKhoi char(10)
)
AS
BEGIN
select * from LOP 
where MaKhoi=@MaKhoi
END
--select d? li?u sinh viên theo kh?i và l?p 
CREATE PROCEDURE select_HocSinh(
@MaLop char(10)
,@MaKhoi char(10)
)
AS
BEGIN
select hs.MaHocSinh,hs.TenHocSinh,hs.GioiTinh,hs.NgaySinh,hs.CMND,hs.DienThoai,hs.Email,hs.NoiSinh,hs.DiaChi,LOP.MaKhoi,LOP.MaLop  from  XEPLOP
join LOP 
on XEPLOP.MaLop=LOP.MaLop
join KHOI
on KHOI.MaKhoi=LOP.MaKhoi
join HOCSINH as hs
on hs.MaHocSinh=XEPLOP.MaHocSinh 
where KHOI.MaKhoi=@MaKhoi and  LOP.MaLop=@MaLop
END
-- thêm d? li?u vào b?ng h?c sinh
CREATE PROCEDURE Insert_HOCSINH(
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
-- s?a thông tin
CREATE PROCEDURE Update_HOCSINH(
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
--delede h?c sinh
CREATE PROCEDURE Delete_HOCSINH
@MaHocSinh char(10) 
AS
BEGIN
DELETE FROM HOCSINH 
WHERE MaHocSinh=@MaHocSinh
END
-- delesinh vien bang xep lop
CREATE PROCEDURE Delete_HOCSINHXL
@MaHocSinh char(10) 
AS
BEGIN
DELETE FROM XEPLOP
WHERE MaHocSinh=@MaHocSinh
END
--them sv bang xl
CREATE PROCEDURE Update_HOCSINHXL(
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
-- c?p nh?t tu?i h?c sinh
CREATE PROCEDURE Update_TUOIHS(
@MucToiThieu float,
@MucToiDa float
)
AS
BEGIN
UPDATE THAMSO
SET MucToiThieu =  @MucToiThieu, MucToiDa = @MucToiDa
WHERE MaThamSo = 'QDTHS   ';
END
--select tuoi hs
CREATE PROCEDURE select_TUOIHS
AS
BEGIN
select MucToiThieu, MucToiDa 
from THAMSO
WHERE MaThamSo = 'QDTHS   ';
END
--select d? li?u Giao Vien 
CREATE PROCEDURE select_GiaoVien(
@MaMon char(10)
)
AS
BEGIN
select GV.MaGiaoVien,GV.TenGiaoVien,GV.GioiTinh,GV.NgaySinh,GV.NoiSinh,GV.CMND,
GV.DiaChi,GV.Email,GV.DienThoai
from  GIAOVIEN as GV
where GV.MaMon='MA002'
END
-- thêm d? li?u vào b?ng h?c sinh
CREATE PROCEDURE Insert_GiaoVien(
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
-- s?a thông tin
CREATE PROCEDURE Update_GiaoVien(
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
--delede h?c sinh
CREATE PROCEDURE Delete_GiaoVien
@MaGiaoVien char(10)
AS
BEGIN
DELETE FROM GIAOVIEN
WHERE MaGiaoVien=@MaGiaoVien
END
-- c?p nh?t tu?i Giao vien
CREATE PROCEDURE Update_TUOIGV(
@MucToiThieu float,
@MucToiDa float
)
AS
BEGIN
UPDATE THAMSO
SET MucToiThieu =  @MucToiThieu, MucToiDa = @MucToiDa
WHERE MaThamSo = 'QDTGV   ';
END
--c?p nh?t ?i?m ??t
CREATE PROCEDURE Update_DiemDat(
@MucToiThieu float,
@MucToiDa float
)
AS
BEGIN
UPDATE THAMSO
SET MucToiThieu =  @MucToiThieu, MucToiDa = @MucToiDa
WHERE MaThamSo = 'QDDD   ';
END
-- select bang Giang Day
CREATE PROCEDURE select_GIANGDAY(
@MaKhoi char(10),
@MaLop char(10),
@MaHocKy char(10),
@MaMon char(10),
@MaGiaoVien char(10)
)
AS
BEGIN
select gv.MaLop,gv.MaMon,gv.MaGiaoVien,gv.MaHocKy
from GIANGDAY as GV
join LOP
on GV.MaLop=LOP.MaLop
where MaKhoi='k11' and LOP.MaLop= 'LA' and MaHocKy= 'HK1' 
and MaMon= 'MA00' and MaGiaoVien= 'GV01'
END
and MaMon= 'MA00' and MaGiaoVien= 'GV01'
--where MaKhoi='k11' and LOP.MaLop= 'LA' and MaHocKy= 'HK1' 
-- select bang giang day theo lop khoi nam hoc ky 
CREATE PROCEDURE select_GIANGDAY(
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
where MaKhoi='k11' and LOP.MaLop= 'LA' and MaHocKy= 'HK1' and Nam='2016'
END
--MaKhoi='k11' and LOP.MaLop= 'LA' and MaHocKy= 'HK1' and Nam='2016'
--MaKhoi=@MaKhoi and LOP.MaLop= @MaLop and MaHocKy= @MaHocKy and Nam= @Nam
--update giao vien
CREATE PROCEDURE select_GIANGDAY1(
@MaKhoi char(10),
@MaLop char(10),
@MaHocKy char(10),
@MaMon char(10),
@MaGiaoVien char(10)
)
AS
BEGIN
select gv.MaLop,gv.MaMon,gv.MaGiaoVien,gv.MaHocKy
from GIANGDAY as GV
join LOP
on GV.MaLop=LOP.MaLop
where MaKhoi='k11' and LOP.MaLop= 'LA' and MaHocKy= 'HK1' 
and MaMon= 'MA00' and MaGiaoVien= 'GV01'
END
and MaMon= 'MA00' and MaGiaoVien= 'GV01'
--where MaKhoi='k11' and LOP.MaLop= 'LA' and MaHocKy= 'HK1' 
-- select update du lieu bang
CREATE PROCEDURE UPDATE_GIANGDAY(
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
-- insert du lieu giang day
CREATE PROCEDURE Insert_GIANGDAY(
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
--dele bang giag day
CREATE PROCEDURE Delete_GIANGDAY
@MaGiaoVien char(10)
AS
BEGIN
DELETE FROM GIANGDAY
WHERE MaGiaoVien=@MaGiaoVien
END

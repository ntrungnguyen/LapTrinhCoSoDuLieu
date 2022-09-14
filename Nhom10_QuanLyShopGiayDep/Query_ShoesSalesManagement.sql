
----------MẶT HÀNG----------------
CREATE PROC MatHang_GetAll
AS 
	SELECT * FROM dbo.MatHang
GO 

----------LOẠI HÀNG----------------
CREATE PROC LoaiHang_GetAll
AS	
	SELECT * FROM dbo.LoaiHang
GO 

----------HÓA ĐƠN----------------
Create proc HoaDon_GetAll
as 
	select * from HoaDon
go 

----------NGƯỜI DÙNG----------------
create proc NguoiDung_GetAll
as
	select * from NguoiDung
go

----------CHI TIẾT HÓA ĐƠN----------------
create proc ChiTietHoaDon_GetAll
as
	select * from ChiTietHoaDon
go

----------ID Cha----------------
create proc LoaiHang_GetIDCha
as 
	select * from LoaiHang
	where ID_Cha = 0
go

----------ID Con----------------
create proc LoaiHang_GetIDCon
as 
	select * from LoaiHang
	where ID_Cha != 0
go


----------THỦ TỤC THÊM XÓA SỬA BẢNG LOẠI HÀNG----------------
create PROCEDURE LoaiHang_InsertUpdateDelete
@ID int OUTPUT,
@TenLoai nvarchar(1000),
@ID_Cha int,
@MoTa nvarchar(3000),
@Action int

AS 
IF @Action = 0
	BEGIN
		INSERT INTO dbo.LoaiHang ( TenLoai,ID_Cha,MoTa )
		VALUES (   @TenLoai, @ID_Cha, @MoTa )
		SET @ID = @@IDENTITY
	END 

ELSE IF @Action = 1
	BEGIN
		UPDATE dbo.LoaiHang SET TenLoai = @TenLoai, ID_Cha = @ID_Cha, MoTa = @MoTa
		WHERE ID = @ID
	END 

ELSE IF @Action = 2
	BEGIN 
		DELETE FROM dbo.LoaiHang WHERE ID = @ID
	END 




----------THỦ TỤC THÊM XÓA SỬA BẢNG MẶT HÀNG----------------
create PROCEDURE MatHang_InsertUpdateDelete
@ID int OUTPUT,
@TenMatHang nvarchar(1000),
@ID_Loai int,
@SoLuongTon int,
@GiaNhap int,
@GiaBan int,
@ThuongHieu nvarchar(1000),
@HinhAnh image,
@MoTa nvarchar(3000),
@Action int

as 
if @Action = 0
	begin 
		insert into MatHang (TenMatHang,ID_Loai,SoLuongTon,GiaNhap,GiaBan,ThuongHieu,HinhAnh,MoTa)
		values (@TenMatHang,@ID_Loai,@SoLuongTon,@GiaNhap,@GiaBan,@ThuongHieu@HinhAnh,@MoTa)
		set @ID = @@identity
	end
else if @Action = 1
	begin 
		update MatHang set TenMatHang=@TenMatHang,ID_Loai=@ID_Loai,SoLuongTon=@SoLuongTon,GiaNhap=@GiaNhap,GiaBan=@GiaBan,ThuongHieu=@ThuongHieu,HinhAnh=@HinhAnh,MoTa=@MoTa
		where ID=@ID
	end
else if @Action = 2
	begin
		delete from MatHang	where ID = @ID
	end


----------THỦ TỤC THÊM XÓA SỬA BẢNG HÓA ĐƠN----------------
create procedure HoaDon_InsertUpdateDelete
@ID int output,
@NgayBanHang smalldatetime,
@TenKhachHang nvarchar(1000),
@SoDienThoai nvarchar(15),
@ID_NhanVien int,
@KhuyenMai float,
@Action int

as 
if @Action = 0
	begin
		insert into HoaDon (NgayBanHang, TenKhachHang, SoDienThoai, ID_NhanVien, KhuyenMai)
		values (@NgayBanHang, @TenKhachHang, @SoDienThoai, @ID_NhanVien, @KhuyenMai)
		set @ID = @@identity
	end
else if @Action = 1
	begin
		update HoaDon set NgayBanHang = @NgayBanHang, TenKhachHang = @TenKhachHang, SoDienThoai = @SoDienThoai, ID_NhanVien = @ID_NhanVien, KhuyenMai = @KhuyenMai
		where ID = @ID
	end
else if @Action =2 
	begin
		delete from HoaDon where ID = @ID
	end
	

----------THỦ TỤC THÊM XÓA SỬA BẢNG CHI TIẾT HÓA ĐƠN----------------
create procedure ChiTietHoaDon_InsertUpdateDelete
@ID int output,
@ID_HoaDon int,
@ID_MatHang int,
@SoLuongMua int,
@Action int

as 
if @Action = 0
	begin
		insert into ChiTietHoaDon (ID_HoaDon, ID_MatHang, SoLuongMua)
		values (ID_HoaDon = @ID_HoaDon, ID_MatHang = @ID_MatHang, SoLuongMua = @SoLuongMua)
		where ID = @ID
	end




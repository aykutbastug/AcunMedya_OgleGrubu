alter proc dbo.sp_PersonelEkle
	@adi varchar(10),
	@soyadi varchar(20)
as
begin
	if ((select count(*) from dbo.Employees where FirstName=@adi and LastName=@soyadi) > 0)
	begin
		select @adi + ' ' + @soyadi + ' isimli personel sistemde kayýtlý.'
	end
	else
	begin
		insert into dbo.Employees (FirstName, LastName) values (@adi, @soyadi)
		select @adi + ' ' + @soyadi + ' isimli personel sisteme eklenmiþtir.'
	end
end

alter proc sp_PersonelEkle
		   @LastName nvarchar(20),
           @FirstName nvarchar(10),
           @Title nvarchar(30),
           @TitleOfCourtesy nvarchar(25),
           @BirthDate datetime,
           @HireDate datetime,
           @Address nvarchar(60),
           @City nvarchar(15),
           @Region nvarchar(15),
           @PostalCode nvarchar(10),
           @Country nvarchar(15),
           @HomePhone nvarchar(24),
           @Extension nvarchar(4),
           @Photo image,
           @Notes ntext,
           @ReportsTo int,
           @PhotoPath nvarchar(255)
as
begin

declare @personelSayisi int = exec sp_PersonelKontrol @LastName,@FirstName

if (@personelSayisi = 0)
begin
	insert into [dbo].[Employees] ([LastName], [FirstName], [Title], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [Country], [HomePhone], [Extension], [Photo], [Notes], [ReportsTo], [PhotoPath]) values (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Photo, @Notes, @ReportsTo, @PhotoPath)
	select 'Personel eklemiþtir'
end
else begin
	select 'Personel zaten kayýtlý'
end
end



create proc sp_PersonelKontrol
	@LastName nvarchar(20),
    @FirstName nvarchar(10)
as
begin
	declare @personelSayisi int
	select @personelSayisi=Count(*) from dbo.Employees where LastName=@LastName and FirstName=@FirstName


	select @personelSayisi
end





exec sp_PersonelEkle 'Baþtuð', 'Aykut', 'asda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL

select * from dbo.Employees
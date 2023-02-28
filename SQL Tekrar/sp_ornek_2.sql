create proc dbo.sp_StokKontrol
	@productId int
as
begin
declare @stokMiktari int
select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@productId

--if ((select UnitsInStock from dbo.Products where ProductID=@productId) <= 0)
if (@stokMiktari <= 0)
begin
	select 'Stok Yok (' + CONVERT(VARCHAR, @stokMiktari) + ')' as [Stok Durumu]
end
else
begin
	select 'Stok Var (' + CONVERT(VARCHAR, @stokMiktari) + ')' as [Stok Durumu]
end
end

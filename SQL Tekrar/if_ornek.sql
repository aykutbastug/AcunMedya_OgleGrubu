--bir deðiþkene product ID tanýmlayalým
--UnitsInStock = stok miktarý

--StokMiktarý 10'un altýndaysa 'Kritik stok miktarý'
--sýfýr veya altýnda ise 'Stok Yok'
--herhangi birisi deðilse 'Stok Yeterli'

declare @productId int = 8, @stokMiktari int
select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@productId
select UnitsInStock from dbo.Products where ProductID=@productId

if (@stokMiktari < 10 and @stokMiktari > 0)
begin
	select 'Kritik stok miktarý'
end
else if (@stokMiktari <= 0)
begin
	select 'Stok Yok'
end
else
begin
	select 'Stok Yeterli'
end

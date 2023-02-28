--bir de�i�kene product ID tan�mlayal�m
--UnitsInStock = stok miktar�

--StokMiktar� 10'un alt�ndaysa 'Kritik stok miktar�'
--s�f�r veya alt�nda ise 'Stok Yok'
--herhangi birisi de�ilse 'Stok Yeterli'

declare @productId int = 8, @stokMiktari int
select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@productId
select UnitsInStock from dbo.Products where ProductID=@productId

if (@stokMiktari < 10 and @stokMiktari > 0)
begin
	select 'Kritik stok miktar�'
end
else if (@stokMiktari <= 0)
begin
	select 'Stok Yok'
end
else
begin
	select 'Stok Yeterli'
end

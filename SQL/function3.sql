alter function dbo.fn_StokYeterliMi (@ProductID int, @Quantity smallint)
returns smallint
as
begin

declare @stokMiktari int
select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@ProductID

declare @sonuc smallint
if (@Quantity > @stokMiktari)
begin
	set @sonuc= 0
end
else begin
	set @sonuc= 1
end

return @sonuc
end
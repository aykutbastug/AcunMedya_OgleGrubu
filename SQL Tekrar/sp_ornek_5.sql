--gelen OrderId sistemden kayýtlý mý deðil mi ?
--gelen ProductId sistemde kayýtlý mý deðil mi ?
--Products tablosunda gelen miktar kadar ürün varmý ? (Stok miktarý yeterli mi ?)

--gelen productId ve OrderId ye ait Details tablosunda kayýt varmý ?
--varsa details tablosundaki miktarý gelen miktar kadar arttýr yani update et
--yoksa order details tablosuna insert at

create proc dbo.sp_SiparisOlustur
	@OrderId int,
	@ProductId int,
	@UnitePrice money,
	@Quantity smallint,
	@discount real
as
begin
	declare @sonuc varchar(500)

	if ((select count(*) from dbo.Orders where OrderID=@OrderId) = 0)
	begin
		set @sonuc = 'Sipariþ numarasý bulunamadý'
	end
	else if ((select count(*) from dbo.Products where ProductID=@ProductId) = 0)
	begin
		set @sonuc = 'Ürün sistemde bulunamadý'
	end
	else if ((select UnitsInStock from dbo.Products where ProductID=@ProductId) < @Quantity)
	begin
		set @sonuc = 'Ürün stok miktarý yeterli deðil'
	end
	else if ((select count(*) from dbo.[Order Details] where ProductID=@ProductId and OrderID=@OrderId) = 0)
	begin
		insert into dbo.[Order Details] values (@OrderId, @ProductId, @UnitePrice, @Quantity, @discount)
		set @sonuc = 'Sipariþ eklendi'
	end
	else
	begin
		update dbo.[Order Details] set UnitPrice=@UnitePrice, Quantity=@Quantity, Discount=@discount where OrderID=@OrderId and ProductID=@ProductId
		set @sonuc = 'Sipariþ güncellendi'
	end


	select @sonuc
end
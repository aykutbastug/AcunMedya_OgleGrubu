--gelen OrderId sistemden kay�tl� m� de�il mi ?
--gelen ProductId sistemde kay�tl� m� de�il mi ?
--Products tablosunda gelen miktar kadar �r�n varm� ? (Stok miktar� yeterli mi ?)

--gelen productId ve OrderId ye ait Details tablosunda kay�t varm� ?
--varsa details tablosundaki miktar� gelen miktar kadar artt�r yani update et
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
		set @sonuc = 'Sipari� numaras� bulunamad�'
	end
	else if ((select count(*) from dbo.Products where ProductID=@ProductId) = 0)
	begin
		set @sonuc = '�r�n sistemde bulunamad�'
	end
	else if ((select UnitsInStock from dbo.Products where ProductID=@ProductId) < @Quantity)
	begin
		set @sonuc = '�r�n stok miktar� yeterli de�il'
	end
	else if ((select count(*) from dbo.[Order Details] where ProductID=@ProductId and OrderID=@OrderId) = 0)
	begin
		insert into dbo.[Order Details] values (@OrderId, @ProductId, @UnitePrice, @Quantity, @discount)
		set @sonuc = 'Sipari� eklendi'
	end
	else
	begin
		update dbo.[Order Details] set UnitPrice=@UnitePrice, Quantity=@Quantity, Discount=@discount where OrderID=@OrderId and ProductID=@ProductId
		set @sonuc = 'Sipari� g�ncellendi'
	end


	select @sonuc
end
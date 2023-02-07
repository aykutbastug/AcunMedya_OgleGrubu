create proc dbo.sp_StokMiktariYeterliMi
	@ProductID int,
	@Quantity int
as
begin
	declare @stokMiktari int
	select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@ProductID

	if (@Quantity > @stokMiktari)
	begin
		select 0
	end
	else begin
		select 1
	end
end

alter proc dbo.sp_SiparisOlustur
	@OrderID int,
	@ProductID int,
	@UnitePrice money,
	@Quantity smallint,
	@Discount real
as
begin

	--Stok miktarı yeterlimi değilmi ?
	--OrderDeteils tablosun ilgili ürün varmı ?

	declare @stokMiktariYeterlimi smallint
	--exec @stokMiktariYeterlimi= dbo.sp_StokMiktariYeterliMi @ProductID, @Quantity

	declare @stokMiktari int
	select @stokMiktari=UnitsInStock from dbo.Products where ProductID=@ProductID

	if (@Quantity > @stokMiktari)
	begin
		set @stokMiktariYeterlimi= 0
	end
	else begin
		set @stokMiktariYeterlimi= 1
	end


	if (@stokMiktariYeterlimi = 0)
	begin		
		select 'Stok miktarı yeterli değil..'
	end
	else begin
		declare @SiparisSayisi int
		select @SiparisSayisi=COUNT(*) from dbo.OrderDetails where ProductID=@ProductID and OrderID=@OrderID

		if (@SiparisSayisi = 0)
		begin
			insert into dbo.OrderDetails values (@OrderID, @ProductID, @UnitePrice, @Quantity, @Discount)
			select 'Sipariş oluşturuldu..'
		end
		else begin
			update dbo.OrderDetails set Quantity=Quantity+@Quantity where OrderID=@OrderID and ProductID=@ProductID			
			select 'Sipariş güncellendi..'
		end
	end

end


--select * from dbo.Products where ProductID=5
--select * from dbo.OrderDetails where OrderID=10248

--exec dbo.sp_SiparisOlustur 10248, 5, 21.35, 3, 0
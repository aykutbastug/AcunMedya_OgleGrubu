ALTER proc [dbo].[sp_SiparisOlustur]
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
	select @stokMiktariYeterlimi = dbo.fn_StokYeterliMi(@ProductID, @Quantity)

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

--Ürün Adý (Products)
--Stok Miktarý (Products)
--Kategori Adý (Categories)
--Tedarikçi Adý (Suppliers)
--Tedarikçi Telefon (Suppliers)

--KritikStokMiktarý parametre olarak verilecek

create proc dbo.sp_KritikStokListesi
	@KritikStokMiktari int
as
begin
	select p.ProductName as [Ürün Adý],
	p.UnitsInStock as [Stok Miktarý],
	c.CategoryName as [Kategori Adý],
	s.CompanyName as [Tedarikçi Adý],
	s.Phone as [Telefon]
	from dbo.Products as p
	inner join dbo.Categories as c on c.CategoryID=p.CategoryID
	inner join dbo.Suppliers as s on s.SupplierID=p.SupplierID
	where p.UnitsInStock <= @KritikStokMiktari
end

exec dbo.sp_KritikStokListesi 0
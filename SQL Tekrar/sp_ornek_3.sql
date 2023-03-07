--�r�n Ad� (Products)
--Stok Miktar� (Products)
--Kategori Ad� (Categories)
--Tedarik�i Ad� (Suppliers)
--Tedarik�i Telefon (Suppliers)

--KritikStokMiktar� parametre olarak verilecek

create proc dbo.sp_KritikStokListesi
	@KritikStokMiktari int
as
begin
	select p.ProductName as [�r�n Ad�],
	p.UnitsInStock as [Stok Miktar�],
	c.CategoryName as [Kategori Ad�],
	s.CompanyName as [Tedarik�i Ad�],
	s.Phone as [Telefon]
	from dbo.Products as p
	inner join dbo.Categories as c on c.CategoryID=p.CategoryID
	inner join dbo.Suppliers as s on s.SupplierID=p.SupplierID
	where p.UnitsInStock <= @KritikStokMiktari
end

exec dbo.sp_KritikStokListesi 0
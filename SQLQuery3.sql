select p.ProductID, p.ProductName, c.CategoryName, p.UnitPrice, p.UnitsInStock, p.Discontinued, s.CompanyName as [Tedarikçi]
from dbo.Products as p
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
left join dbo.Suppliers as s on s.SupplierID=p.SupplierID
--where c.CategoryName like 's%'
--where p.UnitsInStock between 50 and 100
where p.UnitsInStock>='50' and p.UnitsInStock <=100
order by c.CategoryName desc



--insert into dbo.Products values ('Notebook', NULL, 9, 'ADET', 43.500, 50, 0, 0, 0)
--insert into dbo.Products (ProductName, UnitPrice, UnitsInStock, Discontinued) values ('Notebook 2', 42000,10,1)
--insert into dbo.Products select 'Notebook 3', NULL, 9, 'ADET', 43.500, 50, 0, 0, 0


select MAX(UnitPrice) from dbo.Products
select TOP(1) * from dbo.Products order by UnitPrice desc

select * from dbo.Categories
--KategoriAdi, ÜrünSayýsý

select c.CategoryID, c.CategoryName, COUNT(p.ProductID) as [Ürün Sayýsý]
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID=c.CategoryID
group by c.CategoryID, c.CategoryName


--select COUNT(p.ProductID) from dbo.Products as p where CategoryID=1

select c.CategoryID, c.CategoryName, 
(select COUNT(p.ProductID) from dbo.Products as p where p.CategoryID=c.CategoryID) as Miktar
from dbo.Categories as c

--açýk adres city/country

--Sipariþ No(OrderId)
--Müþteri Adý (Customers)
--Adres ([ShipAddress] + [ShipCity] + [ShipCountry])
--Kargo Firmasý ([Shippers].CompanyName)
--Toplam Tutar (OrderDetails)(UnitePrice * Quantity)
--Kargo Ücreti (Freight)
--Genel Toplam (ToplamTutar + Freight)



select * from [dbo].[Shippers]
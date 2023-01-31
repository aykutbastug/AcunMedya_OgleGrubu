select p.ProductID, p.ProductName, c.CategoryName, p.UnitPrice, p.UnitsInStock, p.Discontinued, s.CompanyName as [Tedarik�i]
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
--KategoriAdi, �r�nSay�s�

select c.CategoryID, c.CategoryName, COUNT(p.ProductID) as [�r�n Say�s�]
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID=c.CategoryID
group by c.CategoryID, c.CategoryName


--select COUNT(p.ProductID) from dbo.Products as p where CategoryID=1

select c.CategoryID, c.CategoryName, 
(select COUNT(p.ProductID) from dbo.Products as p where p.CategoryID=c.CategoryID) as Miktar
from dbo.Categories as c

--a��k adres city/country

--Sipari� No(OrderId)
--M��teri Ad� (Customers)
--Adres ([ShipAddress] + [ShipCity] + [ShipCountry])
--Kargo Firmas� ([Shippers].CompanyName)
--Toplam Tutar (OrderDetails)(UnitePrice * Quantity)
--Kargo �creti (Freight)
--Genel Toplam (ToplamTutar + Freight)



select o.OrderID as [Sipari� No],
c.CompanyName as [M��teri Adi],
o.ShipAddress + ' ' + o.ShipCity + ' / ' + o.ShipCountry as [Teslimat Adresi],
s.CompanyName as [Kargo Firmas�],
SUM(od.Quantity * od.UnitPrice) as Toplam,
o.Freight as [Kargo �creti],
SUM(od.Quantity * od.UnitPrice) + o.Freight as [Genel Sipari� Toplam�]
from [dbo].[Orders] as o
inner join dbo.Customers as c on c.CustomerID=o.CustomerID
inner join dbo.Shippers as s on s.ShipperID=o.ShipVia
inner join dbo.[Order Details] as od on od.OrderID=o.OrderID
group by o.OrderID, c.CompanyName, o.ShipAddress, o.ShipCity, o.ShipCountry, s.CompanyName, o.Freight




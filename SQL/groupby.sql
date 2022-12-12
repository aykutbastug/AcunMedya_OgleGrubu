select Country, City from [dbo].[Customers] group by Country,City

select Country, COUNT(Country) as Sayi from dbo.Customers group by Country


--komut sıraları aşağıdaki gibi olmak zorunda
select c.CategoryName, SUM(UnitsInStock) as [Stok Miktarı] 
from dbo.Products as p
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
where c.CategoryName like 'C%'
group by c.CategoryName 
having SUM(UnitsInStock)>200
order by c.CategoryName desc

--Ükle (Country), ToplamSiparişTutarı (UnitePrice * Quantity
select c.Country, SUM(od.UnitPrice * od.Quantity) as SiparisTutari
from dbo.OrderDetails as od
inner join dbo.Orders as o on o.OrderID=od.OrderID
inner join dbo.Customers as c on c.CustomerID=o.CustomerID
group by c.Country


select cu.Country, 
(select SUM(od.UnitPrice * od.Quantity) 
from dbo.OrderDetails as od 
inner join dbo.Orders  as o on o.OrderID =od.OrderID
inner join dbo.Customers as c on c.CustomerID=o.CustomerID
where c.Country=cu.Country)

from dbo.Customers cu



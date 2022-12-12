select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products p
inner join dbo.Categories as c on c.CategoryID=p.CategoryID

select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products p
left join dbo.Categories as c on c.CategoryID=p.CategoryID

select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products p
right join dbo.Categories as c on c.CategoryID=p.CategoryID

select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products p
full outer join dbo.Categories as c on c.CategoryID=p.CategoryID


---------------------------------------------------------

select p.ProductID, p.ProductName, s.CompanyName as [Supplier], c.CategoryName

from Products as p
inner join dbo.Suppliers as s on s.SupplierID=p.SupplierID
right join dbo.Categories as c on c.CategoryID=p.CategoryID

order by p.ProductName

----


--Sipariş Tarihi, Kargo Adresi, Ürün Adı, Kategori Adı, Sipariş Birim Fiyatı, Ürün Miktarı, İndirim, Sipariş Tutaru, Personel Adı

--Siparişler		= Orders
--Sipariş Detaları	= OrderDetails
--Personeller		= Employees
--Sipariş Tarihi	= OrderDate
--Kargo Adresi		= ShipAddress
--Sipariş Birim Fiyatı= Unite Price
--Miktar			= Quantity

---

select o.OrderDate as [Sipariş Tarihi], o.ShipAddress as [Kargo Adresi], p.ProductName as [Ürün Adı], c.CategoryName as [Kategori Adı], od.UnitPrice as [Birim Fiyat], od.Quantity as [Sipariş Miktarı], od.Discount as [İndirim], (od.UnitPrice * od.Quantity) - od.Discount as [Sipariş Tutarı], e.FirstName + ' ' + e.LastName as [Personel]

from dbo.OrderDetails as od
inner join dbo.Orders as o on o.OrderID=od.OrderID
inner join dbo.Products as p on p.ProductID=od.ProductID
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
inner join dbo.Employees as e on e.EmployeeID=o.EmployeeID
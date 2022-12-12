select * 
from dbo.UrunKategorileri
--inner join 
where [Kategori Adı]='Condiments'
order by [Ürün Adı]

--create view [dbo].[UrunKategorileri2]
alter view [dbo].[UrunKategorileri2]
as

select c.Country, SUM(od.UnitPrice * od.Quantity) as SiparisTutari
from dbo.OrderDetails as od
inner join dbo.Orders as o on o.OrderID=od.OrderID
inner join dbo.Customers as c on c.CustomerID=o.CustomerID
group by c.Country


select * from [dbo].[UrunKategorileri2]

create view BirazilyaliMusteriler
as
select * from dbo.Customers where Country='Brazil'

select * from BirazilyaliMusteriler


--hangi kategoriden kaç tane ürünüm var listesiinin dönen view?
create view KategoriUrunSayisi
as
select c.CategoryName, COUNT(c.CategoryName) as UrunSayisi
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID=c.CategoryID
group by c.CategoryName

select * from KategoriUrunSayisi
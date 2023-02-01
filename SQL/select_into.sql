select * 
--into tedarikciler2
from dbo.Suppliers


select CompanyName, Country,
case when Country='UK' then 'England'
when Country='USA' then 'America' else Country end as Ulke
--into YeniTedarikciler
from [dbo].[Suppliers]


select p.ProductID, p.ProductName, c.CategoryName 
--into UrunKategorileri
from dbo.Products as p
inner join dbo.Categories as c on c.CategoryID=p.CategoryID


select * from dbo.UrunKategorileri
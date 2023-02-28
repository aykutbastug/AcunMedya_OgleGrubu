select *,
case 
when UnitsInStock < 10 and UnitsInStock > 0 then 'Kritik Stok Miktarý'
when UnitsInStock <=0 then 'Stok Yok'
else 'Stok Yeterli'
end as [Stok Durumu]

from dbo.Products --where ProductID=10

-----------------------------------------------

select 
case 
when Country = 'USA' then 'America'
when Country = 'UK' then 'England'
else Country
end
from Customers


update dbo.Customers set Country=
case 
when Country = 'USA' then 'America'
when Country = 'UK' then 'England'
end
where Country in ('USA','UK')


select * from Customers
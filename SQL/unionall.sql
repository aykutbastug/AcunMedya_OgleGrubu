select [CompanyName],[ContactName],[ContactTitle] from dbo.Customers
union all
select [CompanyName],[ContactName], NULL from dbo.Suppliers
union all
select '111','',''


select [Type], CompanyName, ContactName, ContactTitle from(

select 'CUST' as [Type], [CompanyName],[ContactName],[ContactTitle] 
from dbo.Customers where CompanyName like '%os%'

union all

select  'SUPP' as [Type], [CompanyName],[ContactName], [ContactTitle] from dbo.Suppliers
) as YeniTablo

--where 
order by CompanyName desc

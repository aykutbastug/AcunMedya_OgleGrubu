declare @categoryName varchar(150) = 'Produce'
select * from dbo.Categories where CategoryName=@categoryName



declare @country varchar(50) = 'Germany'
select o.* 
from dbo.Orders as o
where o.CustomerID IN (select CustomerID from dbo.Customers where Country=@country)


declare @country2 varchar(50) = 'UK'
select o.* 
from dbo.Orders as o
inner join dbo.Customers as c on c.CustomerID=o.CustomerID
where c.Country=@country2
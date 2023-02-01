declare @country varchar(50) = 'Canada'

select * from dbo.Orders where CustomerID IN
(select CustomerID from dbo.Customers where Country=@country)

select o.* from Orders as o
inner join dbo.Customers as c on c.CustomerID=o.CustomerID
where c.Country=@country

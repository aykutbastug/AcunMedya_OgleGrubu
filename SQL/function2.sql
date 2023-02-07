create function dbo.fn_GetFullName
(
	@name varchar(10),
	@lastName varchar(20)
)
returns varchar(35)
as
begin
	return @name + ' ' + @lastName 
end

--=============================

alter function dbo.fn_GetAge( @birthDate datetime)
returns int
as
begin
	--return DATEDIFF(Year, @birthDate, GETDATE())
	return YEAR(GETDATE()) - YEAR(@birthDate)
end



select *, dbo.fn_GetFullName(FirstName, LastName) as FullName, dbo.fn_GetAge(BirthDate) as Age from Employees
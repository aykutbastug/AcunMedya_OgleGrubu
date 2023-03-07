CREATE FUNCTION fn_Ornek1
(
	@param1 varchar(10),
	@param2 int
)
RETURNS int
AS
BEGIN
	DECLARE @result int = 5

	RETURN @result
END

select dbo.fn_Ornek1('asd',8)

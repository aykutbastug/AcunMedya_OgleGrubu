CREATE FUNCTION fn_CarpiminiAl 
(
	@sayi1 int,
	@sayi2 int
)
RETURNS int
AS
BEGIN
	--IF kodları, varsa değişkenler burada, varsa select, insert, delete, update cümleri burada, stored procedure kodları burada
	declare @toplam int
	set @toplam = @sayi1 * @sayi2

	RETURN @toplam

END



---========================


ALTER FUNCTION fn_StokDurumu
(
	@MevcutStokMiktari int
)
RETURNS varchar(150)
AS
BEGIN
	--IF kodları, varsa değişkenler burada, varsa select, insert, delete, update cümleri burada, stored procedure kodları burada
	declare @sonuc varchar(150)
	set @sonuc = 'Stok Yeterli'

	if (@MevcutStokMiktari <= 0)
	begin
		set @sonuc = 'Stokta Yok'
	end
	--else if (@MevcutStokMiktari> 0 and @MevcutStokMiktari < 20)
	else if (@MevcutStokMiktari < 20)
	begin
		set @sonuc = 'Kritik Stok Miktarı'
	end
	else begin
		set @sonuc = 'Stok Yeterli'
	end

	RETURN @sonuc

END
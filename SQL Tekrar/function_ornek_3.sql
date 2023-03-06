--tarih tipinde bir paramatre alan ve geriye girilen tarihe g�re ya�� hesaplay�p ya��n� d�nen function �rne�ini yazal�m
create function fn_YasHEsapla
( 
	@dogumTarihi date
)
returns int
as
begin
	declare @yas int
	set @yas = YEAR(GETDATE()) - YEAR(@dogumTarihi)
	return @yas
end

select dbo.fn_YasHEsapla('1985.01.25')
select dbo.fn_YasHEsapla(GETDATE())
select *, dbo.fn_YasHEsapla(DogumTarihi) as [Ya��] from dbo.Personeller
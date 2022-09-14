CREATE PROCEDURE dbo.PretrazivanjeAuta
@modelAuta varchar(50)
AS
	SELECT @modelAuta = '%' + @modelAuta + '%';
	SELECT * FROM dbo.AUTOMOBIL,dbo.MARKA
	WHERE dbo.AUTOMOBIL.MARKA = dbo.MARKA.BRAND_ID and dbo.AUTOMOBIL.MODEL LIKE @modelAuta;
GO

EXEC dbo.PretrazivanjeAuta @modelAuta = "SUPERB";
GO
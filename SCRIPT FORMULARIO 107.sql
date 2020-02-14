use Formulario_102A

create table Form107 (
id_declar_107 int identity (1,1) primary key,
ruc varchar (13) not null,
razon_social varchar (40) not null,
v_301 numeric (6,2) null,
v_303 numeric (6,2) null,
v_305 numeric (6,2) null,
v_307 numeric (6,2) null,
v_311 numeric (6,2) null,
v_313 numeric (6,2) null,
v_315 numeric (6,2) null,
v_317 numeric (6,2) null,
v_351 numeric (6,2) null,
v_353 numeric (6,2) null,
v_361 numeric (6,2) null,
v_363 numeric (6,2) null,
v_365 numeric (6,2) null,
v_367 numeric (6,2) null,
v_369 numeric (6,2) null,
v_371 numeric (6,2) null,
v_373 numeric (6,2) null,
v_381 numeric (6,2) null,
v_399 numeric (6,2) null,
v_401 numeric (6,2) null,
v_403 numeric (6,2) null,
v_405 numeric (6,2) null,
v_407 numeric (6,2) null,
)

SELECT * FROM Form107

INSERT INTO [Form107] ([ruc], [razon_social], [v_301], [v_303], [v_305], [v_307], [v_311], [v_313], [v_315], [v_317], [v_351], [v_353], [v_361], [v_363], [v_365], [v_367], [v_369], [v_371], [v_373], [v_381], [v_399], [v_401], [v_403], [v_405], [v_407]) VALUES (@ruc, @razon_social, @v_301, @v_303, @v_305, @v_307, @v_311, @v_313, @v_315, @v_317, @v_351, @v_353, @v_361, @v_363, @v_365, @v_367, @v_369, @v_371, @v_373, @v_381, @v_399, @v_401, @v_403, @v_405, @v_407);

SELECT ruc,razon_social,v_399 FROM Form107
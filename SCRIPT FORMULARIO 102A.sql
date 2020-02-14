create database Formulario_102A 

use Formulario_102A

create table CONTRIBUYENTE (id_contribuyente int identity (1,1) primary key,
ruc_contr varchar (13) not null,
RazonSocial_Contr varchar (20) not null,
Saldo_Contr numeric (6,2) not null
)
GO 

create table INGRESOS (id_ingresos int identity (1,1) primary key,
valor_ingresos numeric (6,2) null,
id_contribuyente_FK int not null
Foreign key (id_contribuyente_FK) references CONTRIBUYENTE(id_contribuyente))
GO

create table GASTOS (id_gastos int identity (1,1) primary key,
valor_gastos numeric (6,2) null,
id_contribuyente_FK int not null
Foreign key (id_contribuyente_FK) references CONTRIBUYENTE(id_contribuyente))
GO

SELECT * FROM CONTRIBUYENTE

SELECT id_contribuyente FROM CONTRIBUYENTE WHERE ruc_contr=@ruc

INSERT INTO [CONTRIBUYENTE] ([ruc_contr], [RazonSocial_Contr]) VALUES (@ruc_contr, @RazonSocial_Contr);

UPDATE [CONTRIBUYENTE] SET  [Saldo_Contr] = @Saldo_Contr WHERE (([id_contribuyente] = @Original_id_contribuyente) );

SELECT * FROM INGRESOS

SELECT * FROM INGRESOS WHERE id_contribuyente_FK = @id_contr

INSERT INTO [INGRESOS] ([valor_ingresos], [id_contribuyente_FK]) VALUES (@valor_ingresos, @id_contribuyente_FK);

SELECT * FROM GASTOS WHERE id_contribuyente_FK = @id_contr

INSERT INTO [GASTOS] ([id_contribuyente_FK], [valor_gastos]) VALUES (@id_contribuyente_FK, @valor_gastos);




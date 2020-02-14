Use Formulario_102A

create table AUDITORIA (
id_aud int identity(1,1) primary key,
RazonSocial varchar(20) not null,
ruc_contr varchar(13)not null,
Saldo_Contr numeric(6,2) null,
Action_aud varchar(15)not null,
)

CREATE TRIGGER AÑADIR
ON CONTRIBUYENTE
FOR INSERT
AS
INSERT INTO AUDITORIA(RazonSocial,ruc_contr,Saldo_Contr,Action_aud)
SELECT INSERTED.RazonSocial_Contr,INSERTED.ruc_contr,inserted.Saldo_Contr , 'DATA ADDED' 
FROM INSERTED

CREATE TRIGGER NUEVOSALDO  
ON CONTRIBUYENTE
FOR UPDATE
AS
UPDATE AUDITORIA
SET RazonSocial = inserted.RazonSocial_Contr, ruc_contr=inserted.ruc_contr, Saldo_Contr=inserted.Saldo_Contr, Action_aud='Nuevo Dato'
FROM CONTRIBUYENTE, INSERTED, DELETED 
WHERE CONTRIBUYENTE.id_contribuyente = DELETED.id_contribuyente

SELECT * FROM CONTRIBUYENTE



Update CONTRIBUYENTE set Saldo_Contr=200 where id_contribuyente=5
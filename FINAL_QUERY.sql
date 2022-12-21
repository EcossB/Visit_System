create database VISITOR_DB
use VISITOR_DB

---Tablas para el sistema de visitas

--- tabla del usuario general de las cuales tomamos los campos usuario y contra para el mismo login 
CREATE TABLE G_USER (
IDUSER INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
CODIGO AS ('G_U' +RIGHT('00' + CONVERT(VARCHAR,IDUSER),(2))),
NOMBRE nVARCHAR(100)NOT NULL, 
APELLIDO nVARCHAR(100)NOT NULL,
FECHA_NACIMIENTO DATE NOT NULL,
TIPO_USUARIO nVARCHAR(8) NOT NULL,
USUARIO nVARCHAR(100) unique NOT NULL,
CONTRA nVARCHAR (100) unique NOT NULL
);

CREATE TABLE G_ADMIN (
IDADMIN INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
CODIGO AS ('G_A' +RIGHT('00' + CONVERT(VARCHAR,IDADMIN),(2))),
NOMBRE nVARCHAR(100)NOT NULL, 
APELLIDO nVARCHAR(100)NOT NULL,
FECHA_NACIMIENTO DATE NOT NULL,
TIPO_USUARIO nVARCHAR(14) NOT NULL,
USUARIO nVARCHAR(100) unique  NOT NULL,
CONTRA nVARCHAR (100)  unique  NOT NULl
)

CREATE TABLE EDIFICIOS (
IDEDIFICIO INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
CODIGO AS ('ED' +RIGHT('00' + CONVERT(VARCHAR,IDEDIFICIO),(2))),
EDIFICIO NVARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE AULAS(
IDAULA INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
CODIGO AS ('AU' +RIGHT('00' + CONVERT(VARCHAR,IDAULA),(2))),
AULA NVARCHAR(100) unique not null,
Edificio Int constraint FK_edificio foreign key (Edificio) references EDIFICIOS(IDEDIFICIO)
)

create table VISITOR (
IDVISITOR INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
CODIGO AS ('G_A' +RIGHT('00' + CONVERT(VARCHAR,IDVISITOR),(2))),
NOMBRE nVARCHAR(100)NOT NULL, 
APELLIDO nVARCHAR(100)NOT NULL,
CARRERA nVARCHAR(100)NOT NULL,
CORREO nVARCHAR(100)NOT NULL,
EDIFICIO nVARCHAR(100)NOT NULL,
HORA_ENT DATETIME,
HORA_SALIDA DATETIME,
MOTIVO nVARCHAR(240)NOT NULL,
AULA NVARCHAR(100) NOT NULL
)

GO


--procedimientos almacenados SP para la tabla visitor
--procedimiento buscar vistantes
Create proc SP_Consultar_visitas
@buscar nvarchar(100)
as 
select * from VISITOR
where NOMBRE like @buscar +'%'

GO

--Procedimiento Insertar visitantes
Create proc SP_Insertar_Visitos
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@CARRERA nVARCHAR(100),
@CORREO nVARCHAR(100),
@EDIFICIO nVARCHAR(100),
@HORA_ENT DATETIME,
@HORA_SALIDA DATETIME,
@MOTIVO nVARCHAR(240),
@AULA NVARCHAR(100) 
as 
Insert into VISITOR values (@NOMBRE, @APELLIDO, @CARRERA, @CORREO, @EDIFICIO, @HORA_ENT, @HORA_SALIDA,@MOTIVO,@AULA)

GO 


---Procedimiento editar visitantes 
create proc SP_EDITARVISITANTES
@IDVISITOR int,
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@CARRERA nVARCHAR(100),
@CORREO nVARCHAR(100),
@EDIFICIO nVARCHAR(100),
@HORA_ENT DATETIME,
@HORA_SALIDA DATETIME,
@MOTIVO nVARCHAR(240),
@foto varbinary (max),
@AULA NVARCHAR(100) 
as 
Update VISITOR set NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, CARRERA = @CARRERA, CORREO = @CORREO, EDIFICIO = @EDIFICIO, HORA_ENT = @HORA_ENT,
HORA_SALIDA = @HORA_SALIDA, MOTIVO = @MOTIVO, foto = @foto, AULA = @AULA where IDVISITOR = @IDVISITOR

GO

--- procedimiento para eliminar visitante
create proc SP_ELIMINARVISITANTE
@IDVISITOR int
as 
Delete VISITOR
where IDVISITOR = @IDVISITOR

GO

---procedimientos almacenados para la tabla Edificio

create proc SP_Consultar_edificios
@buscar nvarchar(100)
as 
select * from EDIFICIOS
where EDIFICIO like @buscar +'%'

go

create proc SP_Insertar_edificios
@edificio nvarchar(100)
as
insert into EDIFICIOS values (@edificio)
go 

create proc SP_Editar_Edificios 
@ID_EDIFICIO int,
@edificio nvarchar(100)
as
UPDATE EDIFICIOS set EDIFICIO = @edificio where IDEDIFICIO = @ID_EDIFICIO
go

create proc SP_eliminar_Edificios
@ID_EDIFICIOS int 
as 
Delete EDIFICIOS where IDEDIFICIO = @ID_EDIFICIOS
go

---procedimientos almacenados para la tabla aula

create proc SP_Consultar_aulas
@buscar nvarchar(100)
as 
select * from AULAS where AULA like @buscar +'%'
go

create proc SP_insertar_aulas
@aula nvarchar(100),
@edificio int
as
insert into AULAS values (@aula,@edificio)
go

create proc SP_editar_aulas
@Id_AULAS int,
@aula nvarchar(100), 
@edificio int
as
UPDATE AULAS SET AULA = @aula, Edificio = @edificio where IDAULA = @Id_AULAS
go

create proc SP_eliminar_aula
@idaula int
as
Delete AULAS where IDAULA = @idaula 
go


---procedimientos almacenados para la tabla G_USER

create proc SP_insertar_G_USER
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@FECHA_NACIMIENTO DATE ,
@TIPO_USUARIO nVARCHAR(8) ,
@USUARIO nVARCHAR(100) ,
@CONTRA nVARCHAR (100)
as
insert into G_USER values (@NOMBRE, @APELLIDO, @FECHA_NACIMIENTO, @TIPO_USUARIO, @USUARIO, @CONTRA)
go

create proc SP_Consultar_G_USER
@buscar_u nvarchar(100)
as 
select * from G_USER where USUARIO like @buscar_u  +'%'
go

create proc SP_Editar_G_USER
@ID_USER INT,
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@FECHA_NACIMIENTO DATE ,
@TIPO_USUARIO nVARCHAR(8) ,
@USUARIO nVARCHAR(100) ,
@CONTRA nVARCHAR (100)
as
UPDATE G_USER set NOMBRE = @NOMBRE, APELLIDO = @APELLIDO,
FECHA_NACIMIENTO = @FECHA_NACIMIENTO, TIPO_USUARIO = @TIPO_USUARIO,
USUARIO = @USUARIO, CONTRA = @CONTRA where IDUSER = @ID_USER
go

create proc SP_Eliminar_G_User
@id_user int 
as 
delete G_USER where IDUSER = @id_user
go


---procesos almacenados para la tabla G_admin
create proc SP_insertar_G_admin
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@FECHA_NACIMIENTO DATE ,
@TIPO_USUARIO nVARCHAR(8) ,
@USUARIO nVARCHAR(100) ,
@CONTRA nVARCHAR (100)
as
insert into G_ADMIN values (@NOMBRE, @APELLIDO, @FECHA_NACIMIENTO, @TIPO_USUARIO, @USUARIO, @CONTRA)
go

create proc SP_Consultar_G_ADMIN
@buscar_u nvarchar(100)
as 
select * from G_ADMIN where USUARIO like @buscar_u  +'%'
go

create proc SP_Editar_G_ADMIN
@ID_ADMIN INT,
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@FECHA_NACIMIENTO DATE ,
@TIPO_USUARIO nVARCHAR(8) ,
@USUARIO nVARCHAR(100) ,
@CONTRA nVARCHAR (100)
as
UPDATE G_ADMIN set NOMBRE = @NOMBRE, APELLIDO = @APELLIDO,
FECHA_NACIMIENTO = @FECHA_NACIMIENTO, TIPO_USUARIO = @TIPO_USUARIO,
USUARIO = @USUARIO, CONTRA = @CONTRA where IDADMIN = @ID_ADMIN
go

create proc SP_Eliminar_G_ADMIN
@id_admin int 
as 
delete G_ADMIN where IDADMIN = @id_admin
go


---nuevo store procedure para validar el usuario y contrasena
create proc SP_loginA
@usarioA nVARCHAR(100),
@contraA nvarchar(100)
as
select top 1 count(*) from G_ADMIN where G_ADMIN.USUARIO = @usarioA and G_ADMIN.CONTRA  = @contraA

go

create proc SP_loginU
@usarioU nVARCHAR(100),
@contraU nvarchar(100)
as
select top 1 count(*) from G_USER where G_USER.USUARIO = @usarioU and G_USER.CONTRA  = @contraU
go

create proc sp_login
@usarioU nVARCHAR(100),
@contraU nvarchar(100)
as
select USUARIO, CONTRA from G_USER where USUARIO = @usarioU and CONTRA = @contraU
go

create proc Sp_combo
@action nvarchar(2),
@Id int = null
as
	begin
	set nocount on;
		if(@action = 'Ed')
			begin
				select* from EDIFICIOS
			end
		if (@action = 'Au')
			Begin
				select AULA from AULAS
				where Edificio = @Id
				end
	end  
go



create proc SP_listar_por_edificios
@edificio nvarchar(100)
as
select * from VISITOR where EDIFICIO like @edificio +'%'


insert into G_USER values ('pepe','lopez','2002-01-01','general','test','test01') 
insert into EDIFICIOS values ('edificio 2')
insert into AULAS values ('AULA MULTIMEDIA03', 2)
select * from G_USER
select * from AULAS
select * from EDIFICIOS
 
 insert into VISITOR values('DANIELA', 'MEDINA', 'SOFTWARE','DANIMEDI@HOTMAIL.COM','EDIFICIO 1','2022-12-18 19:45:00.000', '2022-12-18 19:47:00.000', 'ESTUDIAR', 'AULA SOFTWARE04')


Sp_combo 'Au', 6

select * from VISITOR

SP_listar_por_edificios 

select * from G_USER
select * from G_ADMIN

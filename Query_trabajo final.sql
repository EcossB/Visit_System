USE [master]
GO
/****** Object:  Database [VISITOR_DB]    Script Date: 12/18/2022 10:04:11 PM ******/
CREATE DATABASE [VISITOR_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VISITOR_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VISITOR_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VISITOR_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VISITOR_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VISITOR_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VISITOR_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VISITOR_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VISITOR_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VISITOR_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VISITOR_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VISITOR_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [VISITOR_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VISITOR_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VISITOR_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VISITOR_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VISITOR_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VISITOR_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VISITOR_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VISITOR_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VISITOR_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VISITOR_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VISITOR_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VISITOR_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VISITOR_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VISITOR_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VISITOR_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VISITOR_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VISITOR_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VISITOR_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [VISITOR_DB] SET  MULTI_USER 
GO
ALTER DATABASE [VISITOR_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VISITOR_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VISITOR_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VISITOR_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VISITOR_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VISITOR_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VISITOR_DB', N'ON'
GO
ALTER DATABASE [VISITOR_DB] SET QUERY_STORE = OFF
GO
USE [VISITOR_DB]
GO
/****** Object:  User [GWTN141-10\erwin]    Script Date: 12/18/2022 10:04:11 PM ******/
CREATE USER [GWTN141-10\erwin] FOR LOGIN [GWTN141-10\erwin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[AULAS]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AULAS](
	[IDAULA] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO]  AS ('AU'+right('00'+CONVERT([varchar],[IDAULA]),(2))),
	[AULA] [nvarchar](100) NOT NULL,
	[Edificio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDAULA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[AULA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EDIFICIOS]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EDIFICIOS](
	[IDEDIFICIO] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO]  AS ('ED'+right('00'+CONVERT([varchar],[IDEDIFICIO]),(2))),
	[EDIFICIO] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEDIFICIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[EDIFICIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[G_ADMIN]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[G_ADMIN](
	[IDADMIN] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO]  AS ('G_A'+right('00'+CONVERT([varchar],[IDADMIN]),(2))),
	[NOMBRE] [nvarchar](100) NOT NULL,
	[APELLIDO] [nvarchar](100) NOT NULL,
	[FECHA_NACIMIENTO] [date] NOT NULL,
	[TIPO_USUARIO] [nvarchar](14) NOT NULL,
	[USUARIO] [nvarchar](100) NOT NULL,
	[CONTRA] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDADMIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CONTRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[G_USER]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[G_USER](
	[IDUSER] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO]  AS ('G_U'+right('00'+CONVERT([varchar],[IDUSER]),(2))),
	[NOMBRE] [nvarchar](100) NOT NULL,
	[APELLIDO] [nvarchar](100) NOT NULL,
	[FECHA_NACIMIENTO] [date] NOT NULL,
	[TIPO_USUARIO] [nvarchar](8) NOT NULL,
	[USUARIO] [nvarchar](100) NOT NULL,
	[CONTRA] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUSER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CONTRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VISITOR]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VISITOR](
	[IDVISITOR] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO]  AS ('G_A'+right('00'+CONVERT([varchar],[IDVISITOR]),(2))),
	[NOMBRE] [nvarchar](100) NOT NULL,
	[APELLIDO] [nvarchar](100) NOT NULL,
	[CARRERA] [nvarchar](100) NOT NULL,
	[CORREO] [nvarchar](100) NOT NULL,
	[EDIFICIO] [nvarchar](100) NOT NULL,
	[HORA_ENT] [datetime] NULL,
	[HORA_SALIDA] [datetime] NULL,
	[MOTIVO] [nvarchar](240) NOT NULL,
	[AULA] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDVISITOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AULAS]  WITH CHECK ADD  CONSTRAINT [FK_edificio] FOREIGN KEY([Edificio])
REFERENCES [dbo].[EDIFICIOS] ([IDEDIFICIO])
GO
ALTER TABLE [dbo].[AULAS] CHECK CONSTRAINT [FK_edificio]
GO
/****** Object:  StoredProcedure [dbo].[Sp_combo]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_combo]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_Consultar_aulas]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---procedimientos almacenados para la tabla aula

create proc [dbo].[SP_Consultar_aulas]
@buscar nvarchar(100)
as 
select * from AULAS where AULA like @buscar +'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_Consultar_edificios]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---procedimientos almacenados para la tabla G_USER 

create proc [dbo].[SP_Consultar_edificios]
@buscar nvarchar(100)
as 
select * from EDIFICIOS
where EDIFICIO like @buscar +'%'

GO
/****** Object:  StoredProcedure [dbo].[SP_Consultar_G_ADMIN]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Consultar_G_ADMIN]
@buscar_u nvarchar(100)
as 
select * from G_ADMIN where USUARIO like @buscar_u  +'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_Consultar_G_USER]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Consultar_G_USER]
@buscar_u nvarchar(100)
as 
select * from G_USER where USUARIO like @buscar_u  +'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_Consultar_visitas]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar vistantes
Create proc [dbo].[SP_Consultar_visitas]
@buscar nvarchar(100)
as 
select * from VISITOR
where NOMBRE like @buscar +'%'

GO
/****** Object:  StoredProcedure [dbo].[SP_editar_aulas]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_editar_aulas]
@Id_AULAS int,
@aula nvarchar(100), 
@edificio int
as
UPDATE AULAS SET AULA = @aula, Edificio = @edificio where IDAULA = @Id_AULAS
GO
/****** Object:  StoredProcedure [dbo].[SP_Editar_Edificios]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Editar_Edificios] 
@ID_EDIFICIO int,
@edificio nvarchar(100)
as
UPDATE EDIFICIOS set EDIFICIO = @edificio where IDEDIFICIO = @ID_EDIFICIO
GO
/****** Object:  StoredProcedure [dbo].[SP_Editar_G_ADMIN]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Editar_G_ADMIN]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_Editar_G_USER]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Editar_G_USER]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARVISITANTES]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---Procedimiento editar visitantes 
create proc [dbo].[SP_EDITARVISITANTES]
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
/****** Object:  StoredProcedure [dbo].[SP_eliminar_aula]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_eliminar_aula]
@idaula int
as
Delete AULAS where IDAULA = @idaula 
GO
/****** Object:  StoredProcedure [dbo].[SP_eliminar_Edificios]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_eliminar_Edificios]
@ID_EDIFICIOS int 
as 
Delete EDIFICIOS where IDEDIFICIO = @ID_EDIFICIOS
GO
/****** Object:  StoredProcedure [dbo].[SP_Eliminar_G_ADMIN]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Eliminar_G_ADMIN]
@id_admin int 
as 
delete G_ADMIN where IDADMIN = @id_admin
GO
/****** Object:  StoredProcedure [dbo].[SP_Eliminar_G_User]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Eliminar_G_User]
@id_user int 
as 
delete G_USER where IDUSER = @id_user
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARVISITANTE]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- procedimiento para eliminar visitante
create proc [dbo].[SP_ELIMINARVISITANTE]
@IDVISITOR int
as 
Delete VISITOR
where IDVISITOR = @IDVISITOR
GO
/****** Object:  StoredProcedure [dbo].[SP_insertar_aulas]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_insertar_aulas]
@aula nvarchar(100),
@edificio int
as
insert into AULAS values (@aula,@edificio)
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_edificios]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Insertar_edificios]
@edificio nvarchar(100)
as
insert into EDIFICIOS values (@edificio)
GO
/****** Object:  StoredProcedure [dbo].[SP_insertar_G_admin]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---procesos almacenados para la tabla G_admin
create proc [dbo].[SP_insertar_G_admin]
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@FECHA_NACIMIENTO DATE ,
@TIPO_USUARIO nVARCHAR(8) ,
@USUARIO nVARCHAR(100) ,
@CONTRA nVARCHAR (100)
as
insert into G_ADMIN values (@NOMBRE, @APELLIDO, @FECHA_NACIMIENTO, @TIPO_USUARIO, @USUARIO, @CONTRA)
GO
/****** Object:  StoredProcedure [dbo].[SP_insertar_G_USER]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_insertar_G_USER]
@NOMBRE nVARCHAR(100), 
@APELLIDO nVARCHAR(100),
@FECHA_NACIMIENTO DATE ,
@TIPO_USUARIO nVARCHAR(8) ,
@USUARIO nVARCHAR(100) ,
@CONTRA nVARCHAR (100)
as
insert into G_USER values (@NOMBRE, @APELLIDO, @FECHA_NACIMIENTO, @TIPO_USUARIO, @USUARIO, @CONTRA)
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Visitos]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_Insertar_Visitos]
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
/****** Object:  StoredProcedure [dbo].[SP_listar_por_edificios]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_listar_por_edificios]
@edificio nvarchar(100)
as
select * from VISITOR where EDIFICIO like @edificio +'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_login]
@usarioU nVARCHAR(100),
@contraU nvarchar(100)
as
select USUARIO, CONTRA from G_USER where USUARIO = @usarioU and CONTRA = @contraU
GO
/****** Object:  StoredProcedure [dbo].[SP_loginA]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_loginA]
@usarioA nVARCHAR(100),
@contraA nvarchar(100)
as
select top 1 count(*) from G_ADMIN where G_ADMIN.USUARIO = @usarioA and G_ADMIN.CONTRA  = @contraA

GO
/****** Object:  StoredProcedure [dbo].[SP_loginU]    Script Date: 12/18/2022 10:04:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_loginU]
@usarioU nVARCHAR(100),
@contraU nvarchar(100)
as
select top 1 count(*) from G_USER where G_USER.USUARIO = @usarioU and G_USER.CONTRA  = @contraU
GO
USE [master]
GO
ALTER DATABASE [VISITOR_DB] SET  READ_WRITE 
GO

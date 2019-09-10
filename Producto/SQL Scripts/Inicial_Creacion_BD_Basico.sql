-- ####################################################################################
-- ############			INICIO CREACION DE LA BASE DE DATOS			############
-- ####################################################################################

USE [master]
GO

/****** Object:  Database [64429Pav1]    Script Date: 09/04/2019 18:42:57 ******/
CREATE DATABASE [64429Pav1] ON  PRIMARY 
( NAME = N'64429Pav1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\64429Pav1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'64429Pav1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\64429Pav1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [64429Pav1] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [64429Pav1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [64429Pav1] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [64429Pav1] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [64429Pav1] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [64429Pav1] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [64429Pav1] SET ARITHABORT OFF 
GO

ALTER DATABASE [64429Pav1] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [64429Pav1] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [64429Pav1] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [64429Pav1] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [64429Pav1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [64429Pav1] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [64429Pav1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [64429Pav1] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [64429Pav1] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [64429Pav1] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [64429Pav1] SET  DISABLE_BROKER 
GO

ALTER DATABASE [64429Pav1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [64429Pav1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [64429Pav1] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [64429Pav1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [64429Pav1] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [64429Pav1] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [64429Pav1] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [64429Pav1] SET  READ_WRITE 
GO

ALTER DATABASE [64429Pav1] SET RECOVERY FULL 
GO

ALTER DATABASE [64429Pav1] SET  MULTI_USER 
GO

ALTER DATABASE [64429Pav1] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [64429Pav1] SET DB_CHAINING OFF 
GO
;


-- ####################################################################################
-- ############			FIN CREACION DE LA BASE DE DATOS						############
-- ############			INICIO CREACION TABLAS DE USUARIO_PERFIL_MENU			############
-- ####################################################################################

USE [64429Pav1];
CREATE TABLE USUARIO (
	usuario_id		INT NOT NULL IDENTITY(1,1),
	nombre_usuario	VARCHAR(30) NOT NULL,
	pass			VARCHAR(30) NOT NULL,
	
	CONSTRAINT PK_USUARIO PRIMARY KEY(usuario_id),
	CONSTRAINT U_nombre_usuario UNIQUE(nombre_usuario)
);

CREATE TABLE PERFIL (
	perfil_id		INT NOT NULL IDENTITY(1,1),
	nombre_perfil	VARCHAR(30) NOT NULL,
	descripcion		VARCHAR(50),
	fecha_alta		DATE NOT NULL,
	fecha_baja		DATE,
	
	CONSTRAINT PK_PERFIL PRIMARY KEY(perfil_id),
	CONSTRAINT U_nombre_perfil UNIQUE(nombre_perfil)
);

CREATE TABLE USUARIO_PERFIL (
	usuario_id		INT NOT NULL,
	perfil_id		INT NOT NULL,
	
	CONSTRAINT PK_USUARIO_PERFIL PRIMARY KEY(usuario_id, perfil_id),
	CONSTRAINT FK_USUARIO_USUARIO_PERFIL FOREIGN KEY(usuario_id) 
		REFERENCES USUARIO(usuario_id) ON DELETE CASCADE,
	CONSTRAINT FK_PERFIL_USUARIO_PERFIL FOREIGN KEY(perfil_id) 
		REFERENCES PERFIL(perfil_id) ON DELETE CASCADE
);

CREATE TABLE MENU (
	menu_id			INT NOT NULL,
	padre_menu_id	INT,
	nombre_menu		VARCHAR(30) NOT NULL,
	es_final		BIT NOT NULL,
	aplicacion		VARCHAR(30),
	
	CONSTRAINT PK_MENU PRIMARY KEY(menu_id),
	CONSTRAINT FK_MENU_PADRE FOREIGN KEY(padre_menu_id)
		REFERENCES MENU(menu_id),
	CONSTRAINT U_nombre_menu UNIQUE(nombre_menu)
);

CREATE TABLE PERFIL_MENU (
	perfil_id		INT NOT NULL,
	menu_id			INT NOT NULL,
	
	CONSTRAINT PK_PERFIL_MENU PRIMARY KEY(perfil_id, menu_id),
	CONSTRAINT FK_PERFIL_PEFIL_MENU FOREIGN KEY(perfil_id)
		REFERENCES PERFIL(perfil_id) ON DELETE CASCADE,
	CONSTRAINT FK_MENU_PERFIL_MENU FOREIGN KEY(menu_id)
		REFERENCES MENU(menu_id) ON DELETE CASCADE
);

-- ####################################################################################
-- ############			FIN CREACION TABLAS DE USUARIO_PERFIL_MENU			############
-- ############			INICIO CREACION TABLAS DE PERSONA_PRESTAMO_EQUIPO ############
-- ####################################################################################

USE [64429Pav1];

CREATE TABLE TIPO_DOCUMENTO (
	tipo_documento_id		INT NOT NULL IDENTITY(1,1),
	nombre_tipo_documento			VARCHAR(30) NOT NULL,
	descripcion				VARCHAR(50) NOT NULL,
	
	CONSTRAINT PK_TIPO_DOCUMENTO PRIMARY KEY(tipo_documento_id),
	CONSTRAINT U_tipo_documento UNIQUE(tipo_documento)
);

CREATE TABLE PERSONA (
	persona_id			INT NOT NULL IDENTITY(1,1),
	legajo				INT,
	numero_documento	INT NOT NULL,
	tipo_documento_id	INT NOT NULL,
	apellido			VARCHAR(30) NOT NULL,
	nombre				VARCHAR(30) NOT NULL,
	telefono			INT,
	mail				VARCHAR(30),
	calle				VARCHAR(30),
	numero_calle		INT,
	piso				INT,
	departamento		VARCHAR(30),
	observaciones		VARCHAR(30),
	
	CONSTRAINT PK_PERSONA PRIMARY KEY(persona_id),
	CONSTRAINT U_legajo UNIQUE(legajo),
	CONSTRAINT U_tipo_y_numero_doc UNIQUE(numero_documento, tipo_documento_id),
	CONSTRAINT FK_TIPO_DOCUMENTO_PERSONA FOREIGN KEY(tipo_documento_id)
		REFERENCES TIPO_DOCUMENTO(tipo_documento_id)
);

CREATE TABLE PRESTAMO (
	prestamo_id			INT NOT NULL IDENTITY(1,1),
	persona_id			INT NOT NULL,
	fecha_desde			DATE NOT NULL,
	fecha_hasta			DATE,
	
	CONSTRAINT PK_PRESTAMO PRIMARY KEY(prestamo_id),
	CONSTRAINT FK_PERSONA_PRESTAMO FOREIGN KEY(persona_id)
		REFERENCES PERSONA(persona_id)
);

CREATE TABLE TIPO_EQUIPO (
	tipo_equipo_id		INT NOT NULL IDENTITY(1,1),
	tipo_equipo			VARCHAR(20) NOT NULL,
	descripcion			VARCHAR(50),
	
	CONSTRAINT PK_TIPO_EQUIPO PRIMARY KEY(tipo_equipo_id),
	CONSTRAINT U_tipo_equipo UNIQUE(tipo_equipo)
);

CREATE TABLE EQUIPO (
	equipo_id			INT NOT NULL IDENTITY(1,1),
	codigo				VARCHAR(20) NOT NULL,
	nombre				VARCHAR(30) NOT NULL,
	tipo_equipo_id		INT NOT NULL,
	descripcion			VARCHAR(50),
	
	CONSTRAINT PK_EQUIPO PRIMARY KEY(equipo_id),
	CONSTRAINT FK_TIPO_EQUIPO_EQUIPO FOREIGN KEY(tipo_equipo_id)
		REFERENCES TIPO_EQUIPO(tipo_equipo_id),
	CONSTRAINT U_codigo UNIQUE(codigo) -- nose esto ?
);

CREATE TABLE DETALLE_PRESTAMO (
	detalle_prestamo_id		INT NOT NULL,
	prestamo_id				INT NOT NULL,
	equipo_id				INT NOT NULL,
	fecha_devuelto			DATE,
	
	CONSTRAINT PK_DETALLE_PRESTAMO PRIMARY KEY(prestamo_id, detalle_prestamo_id),
	CONSTRAINT FK_PRESTAMO_DETALLE_PRESTAMO FOREIGN KEY(prestamo_id)
		REFERENCES PRESTAMO(prestamo_id) ON DELETE CASCADE,
	CONSTRAINT FK_EQUIPO_DETALLE_PRESTAMO FOREIGN KEY(equipo_id)
		REFERENCES EQUIPO(equipo_id)
);


-- ####################################################################################
-- ############			FIN CREACION TABLAS DE PERSONA_PRESTAMO_EQUIPO			############
-- ####################################################################################
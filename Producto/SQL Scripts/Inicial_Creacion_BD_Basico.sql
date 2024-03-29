-- ####################################################################################
-- ############			INICIO CREACION DE LA BASE DE DATOS			############
-- ####################################################################################

USE master;
IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = '[64429Pav1]')))
	ALTER DATABASE [64429Pav1] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [64429Pav1];

CREATE DATABASE [64429Pav1];

-- ####################################################################################
-- ############			FIN CREACION DE LA BASE DE DATOS						############
-- ############			INICIO CREACION TABLAS DE USUARIO_PERFIL_MENU			############
-- ####################################################################################

USE [64429Pav1];
CREATE TABLE USUARIO (
	usuario_id		INT NOT NULL IDENTITY(1,1),
	nombre_usuario	VARCHAR(30) NOT NULL,
	pass			VARCHAR(50) NOT NULL,
	forzar_password	BIT NOT NULL,
	fecha_alta		DATETIME NOT NULL,
	fecha_baja		DATETIME,
	
	CONSTRAINT PK_USUARIO PRIMARY KEY(usuario_id),
	CONSTRAINT U_nombre_usuario UNIQUE(nombre_usuario)
);

CREATE TABLE PERFIL (
	perfil_id		INT NOT NULL IDENTITY(1,1),
	nombre_perfil	VARCHAR(30) NOT NULL,
	descripcion		VARCHAR(50),
	fecha_alta		DATETIME NOT NULL,
	fecha_baja		DATETIME,
	
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
	nombre_menu		VARCHAR(30) NOT NULL,
	padre_menu_id	INT,
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

CREATE TABLE TIPO_DOCUMENTO (
	tipo_documento_id		INT NOT NULL IDENTITY(1,1),
	nombre_tipo_documento	VARCHAR(30) NOT NULL,
	descripcion				VARCHAR(50) NOT NULL,
	
	CONSTRAINT PK_TIPO_DOCUMENTO PRIMARY KEY(tipo_documento_id),
	CONSTRAINT U_tipo_documento UNIQUE(nombre_tipo_documento)
);

CREATE TABLE CARRERA (
	carrera_id			INT NOT NULL IDENTITY (1,1),
	nombre_carrera		VARCHAR(100) NOT NULL,
	
	CONSTRAINT PK_CARRERA PRIMARY KEY(carrera_id),
	CONSTRAINT U_nombre_carrera UNIQUE(nombre_carrera)
);

CREATE TABLE UNIVERSIDAD (
	universidad_id		INT NOT NULL IDENTITY (1,1),
	nombre_universidad	VARCHAR(100) NOT NULL,
	
	CONSTRAINT PK_UNIVERSIDAD PRIMARY KEY(universidad_id),
	CONSTRAINT U_nombre_universidad UNIQUE(nombre_universidad)
);

CREATE TABLE PERSONA (
	persona_id			INT NOT NULL IDENTITY(1,1),
	numero_documento	INT NOT NULL,
	tipo_documento_id	INT NOT NULL,
	apellido			VARCHAR(30) NOT NULL,
	nombre				VARCHAR(30) NOT NULL,
	legajo				INT, -- Le quito UNIQUE y NOT NULL porque hay profesores y gente de otras universidades
	universidad_id		INT,
	carrera_id			INT,
	telefono			VARCHAR(30),
	mail				VARCHAR(30),
	calle				VARCHAR(30),
	numero_calle		INT,
	piso				INT,
	departamento		VARCHAR(30),
	observaciones		VARCHAR(30),
	fecha_alta			DATETIME NOT NULL,
	fecha_baja			DATETIME,
	
	CONSTRAINT PK_PERSONA PRIMARY KEY(persona_id),
	-- CONSTRAINT U_legajo UNIQUE(legajo),
	CONSTRAINT U_tipo_y_numero_doc UNIQUE(numero_documento, tipo_documento_id),
	CONSTRAINT FK_TIPO_DOCUMENTO_PERSONA FOREIGN KEY(tipo_documento_id)
		REFERENCES TIPO_DOCUMENTO(tipo_documento_id),
	CONSTRAINT FK_UNIVERSIDAD_PERSONA FOREIGN KEY(universidad_id)
		REFERENCES UNIVERSIDAD(universidad_id),
	CONSTRAINT FK_CARRERA_PERSONA FOREIGN KEY(carrera_id)
		REFERENCES CARRERA(carrera_id)
);

CREATE TABLE ESTADO (				
	estado_id		INT NOT NULL IDENTITY(1,1),
	nombre_estado	VARCHAR(30) NOT NULL,
	ambito			VARCHAR(30) NOT NULL,
	deshabilita		BIT NOT NULL,
	editable		BIT NOT NULL,
	
	CONSTRAINT PK_ESTADO PRIMARY KEY(estado_id),
	CONSTRAINT U_nombre_estado UNIQUE(nombre_estado)	
);									


CREATE TABLE PRESTAMO (
	prestamo_id				INT NOT NULL IDENTITY(1,1),
	persona_id				INT NOT NULL,
	estado_id				INT NOT NULL,
	fecha_desde				DATETIME NOT NULL,
	fecha_hasta				DATETIME,
	fecha_hasta_estimada	DATE NOT NULL,
	fecha_cancelacion		DATETIME,
	
	CONSTRAINT PK_PRESTAMO PRIMARY KEY(prestamo_id),
	CONSTRAINT FK_PERSONA_PRESTAMO FOREIGN KEY(persona_id)
		REFERENCES PERSONA(persona_id),
	CONSTRAINT FK_ESTADO_PRESTAMO FOREIGN KEY(estado_id)
		REFERENCES ESTADO(estado_id)
);

CREATE TABLE TIPO_EQUIPO (
	tipo_equipo_id		INT NOT NULL IDENTITY(1,1),
	tipo_equipo			VARCHAR(20) NOT NULL,
	descripcion			VARCHAR(50),
	codigo_recomendado	VARCHAR(20),
	
	CONSTRAINT PK_TIPO_EQUIPO PRIMARY KEY(tipo_equipo_id),
	CONSTRAINT U_tipo_equipo UNIQUE(tipo_equipo)
);

CREATE TABLE EQUIPO (
	equipo_id			INT NOT NULL IDENTITY(1,1),
	codigo				VARCHAR(20) NOT NULL,
	nombre				VARCHAR(30) NOT NULL,
	tipo_equipo_id		INT NOT NULL,
	estado_id			INT NOT NULL,
	descripcion			VARCHAR(50),
	fecha_alta			DATETIME NOT NULL,
	fecha_baja			DATETIME,
	
	CONSTRAINT PK_EQUIPO PRIMARY KEY(equipo_id),
	CONSTRAINT FK_TIPO_EQUIPO_EQUIPO FOREIGN KEY(tipo_equipo_id)
		REFERENCES TIPO_EQUIPO(tipo_equipo_id),
	CONSTRAINT FK_ESTADO_EQUIPO FOREIGN KEY(estado_id)		
		REFERENCES ESTADO(estado_id),						
	CONSTRAINT U_codigo UNIQUE(codigo) -- nose esto ?
);

CREATE TABLE DETALLE_PRESTAMO (
	detalle_prestamo_id		INT NOT NULL IDENTITY(1,1),
	prestamo_id				INT NOT NULL,
	equipo_id				INT NOT NULL,
	fecha_devuelto			DATETIME,
	
	CONSTRAINT PK_DETALLE_PRESTAMO PRIMARY KEY(prestamo_id, detalle_prestamo_id),
	CONSTRAINT FK_PRESTAMO_DETALLE_PRESTAMO FOREIGN KEY(prestamo_id)
		REFERENCES PRESTAMO(prestamo_id) ON DELETE CASCADE,
	CONSTRAINT FK_EQUIPO_DETALLE_PRESTAMO FOREIGN KEY(equipo_id)
		REFERENCES EQUIPO(equipo_id)
);




-- ####################################################################################
-- ############			FIN CREACION TABLAS DE PERSONA_PRESTAMO_EQUIPO			############
-- ####################################################################################
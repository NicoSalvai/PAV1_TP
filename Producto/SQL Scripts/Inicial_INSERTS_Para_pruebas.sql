-- ####################################################################################
-- ############			INICIO CARGA INICIAL									############
-- ####################################################################################
-- ################################################################ Basico
USE [64429Pav1];
INSERT INTO USUARIO (nombre_usuario, pass, forzar_password, fecha_alta)
	VALUES('admin', '21232f297a57a5a743894a0e4a801fc3', 0, GETDATE()); -- administrador

INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES ('Administrador', '', GETDATE());

INSERT INTO USUARIO_PERFIL (usuario_id, perfil_id)
	VALUES(1,1);
-- ################################################################	MODULO PERSONAS
USE [64429Pav1];
INSERT INTO MENU (menu_id, padre_menu_id, nombre_menu, es_final, aplicacion)
VALUES(1, NULL, 'Personas', 0, ''),
			(2, 1, 'Gestionar Personas', 1, 'Personas'),
			(3, 1, 'Consultar Personas', 1, 'ConsultarPersonas');
	
INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES ('Encargado Personas', '', GETDATE());

INSERT INTO PERFIL_MENU (perfil_id, menu_id)
	VALUES(2,2),(2,3),		-- Personas
			(1,2),(1,3);	-- Administrador

INSERT INTO TIPO_DOCUMENTO(nombre_tipo_documento, descripcion)
	VALUES('DNI', 'Documento Nacional de Identidad');

INSERT INTO UNIVERSIDAD(nombre_universidad)
	VALUES('UNIVERSIDAD TECNOLOGICA NACIONAL - FACULTAD REGIONAL DE CORDOBA');

INSERT INTO CARRERA(nombre_carrera)
	VALUES('Ingenieria en Sistemas de Informacion'),
		('Ingenieria Electronica');
-- ################################################################	MODULO EQUIPOS
USE [64429Pav1];
INSERT INTO MENU (menu_id, padre_menu_id, nombre_menu, es_final, aplicacion)
VALUES(4, NULL, 'Equipos', 0, ''),
			(5, 4, 'Gestionar Equipos', 1, 'Equipos'),
			(6, 4, 'Gestionar Tipos de Equipos', 1, 'TiposEquipos');
			
INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES('Encargado Equipos', '', GETDATE());

INSERT INTO ESTADO(nombre_estado, ambito, deshabilita, editable)
	VALUES('DISPONIBLE','EQUIPO',0, 1),
		('PRESTADO','EQUIPO',1, 0),
		('FUERA DE SERVICIO','EQUIPO',1, 1);
	
INSERT INTO PERFIL_MENU (perfil_id, menu_id)
VALUES(3,5),(3,6),		-- Equipos
		(1,5),(1,6);	-- Administrador
		
INSERT INTO TIPO_EQUIPO(tipo_equipo, descripcion, codigo_recomendado)
	VALUES('Generico', '', 'Gen-XX');
		
-- ################################################################	MODULO Usuarios
USE [64429Pav1];
INSERT INTO MENU (menu_id, padre_menu_id, nombre_menu, es_final, aplicacion)
VALUES(11, NULL, 'Usuarios', 0, ''),
			(12, 11, 'Gestionar Usuarios', 1, 'Usuarios'),
			(13, 11, 'Gestionar Perfiles', 1, 'Perfiles');
			

INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES ('Encargado Usuarios', '', GETDATE()),
			('Encargado Perfiles', '', GETDATE());

INSERT INTO PERFIL_MENU (perfil_id, menu_id)
VALUES(4,12),			-- Usuarios
		(5,13),			-- Perfiles
		(1,12),(1,13);	-- Administrador

-- ################################################################	MODULO Prestamos
USE [64429Pav1];
INSERT INTO MENU (menu_id, padre_menu_id, nombre_menu, es_final, aplicacion)
VALUES(7, NULL, 'Prestamos', 0, ''),
			(8, 7, 'Iniciar Prestamos', 1, 'InicioPrestamos'),
			(9, 7, 'Finalizar Prestamos', 1, 'FinPrestamos'),
			(10, 7, 'Consultar Prestamos', 1, 'ConsultarPrestamos');

INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES ('Encargado Prestamos', '', GETDATE());

INSERT INTO PERFIL_MENU (perfil_id, menu_id)
VALUES(6,8),(6,9),(6,10),	-- Prestamos
		(1,8),(1,9),(1,10); -- Administrador
		
INSERT INTO ESTADO(nombre_estado, ambito, deshabilita, editable)	-- aca no me importa el editable por eso pongo siempre 0
	VALUES('EN CURSO','PRESTAMO',0, 0),
		('DEVUELTO PARCIAL','PRESTAMO',0, 0),
		('DEVUELTO','PRESTAMO',1, 0),
		('CANCELADO','PRESTAMO',1, 0);
		
-- ####################################################################################
-- ############			INICIO CARGA EJEMPLOS									############
-- ####################################################################################
USE [64429Pav1];
INSERT INTO PERSONA(numero_documento, tipo_documento_id, apellido, nombre, legajo, universidad_id, carrera_id, telefono, mail, calle, numero_calle, piso, departamento, observaciones, fecha_alta)
	VALUES(39072672,1,'Salvai','Nicolas',64429,1,1,35130941,'example@example.com','Calle Falsa', 123, 1, 'F', 'Observaciones', GETDATE());

INSERT INTO EQUIPO(codigo, nombre, tipo_equipo_id, estado_id, descripcion, fecha_alta)
	VALUES('Ej-01', 'Ejemplo XXX', 1, 1, '...', GETDATE()),
	('Ej-02', 'Ejemplo XXY', 1, 1, '...', GETDATE());

INSERT INTO PRESTAMO(persona_id, estado_id, fecha_desde, fecha_hasta_estimada)
	VALUES(1, 4, GETDATE(), GETDATE());

INSERT INTO DETALLE_PRESTAMO(prestamo_id, equipo_id)
	VALUES(1, 1);

INSERT INTO USUARIO (nombre_usuario, pass, forzar_password, fecha_alta)
	VALUES('nico','410ec15153a6dff0bed851467309bcbd', 0, GETDATE());
	
INSERT INTO USUARIO_PERFIL (usuario_id, perfil_id)
	VALUES(2,2),(2,3);
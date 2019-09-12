-- ####################################################################################
-- ############			BORRAR BASE DE DATOS									############
-- ####################################################################################
/*	-- Eliminar Base de Datos (Para resetear)
USE [master]
DROP DATABASE [64429Pav1];*/


-- ####################################################################################
-- ############			INICIO CARGA INICIAL									############
-- ####################################################################################
USE [64429Pav1];
INSERT INTO MENU (menu_id, padre_menu_id, nombre_menu, es_final, aplicacion)
     VALUES (1, NULL, 'Menu Principal', 0, ''),
		(2, 1, 'Personas', 0, ''),
			(3, 2, 'Gestionar Personas', 1, 'Personas'),
			(4, 2, 'Consultar Personas', 1, 'ConsultarPersonas'),
		(5, 1, 'Prestamos', 0, ''),
			(6, 5, 'Iniciar Prestamos', 1, 'InicioPrestamos'),
			(7, 5, 'Finalizar Prestamos', 1, 'FinPrestamos'),
			(8, 5, 'Consultar Prestamos', 1, 'ConsultarPrestamos'),
		(9, 1, 'Equipos', 0, ''),
			(10, 9, 'Gestionar Equipos', 1, 'Equipos'),
			(11, 9, 'Gestionar Tipos de Equipos', 1, 'TiposEquipos');


INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES ('Administrador', '', GETDATE()),
			('Encargado Personas', '', GETDATE()),
			('Encargado Prestamos', '', GETDATE()),
			('Encargado Equipos', '', GETDATE());


INSERT INTO PERFIL_MENU (perfil_id, menu_id)
	VALUES (1,3),(1,4),(1,6),(1,7),(1,8),(1,10),(1,11), -- Administrador
			(2,3),(2,4), -- Personas
			(3,6),(3,7),(3,8), -- Prestamos
			(4,10),(4,11); -- Equipos

INSERT INTO USUARIO (nombre_usuario, pass, fecha_alta)
	VALUES('administrador', '91f5167c34c400758115c2a6826ec2e3', GETDATE()), -- administrador
		('NicoSalvai', '91f5167c34c400758115c2a6826ec2e3', GETDATE()); -- administrador

INSERT INTO USUARIO_PERFIL (usuario_id, perfil_id)
	VALUES(1,1), (2,2), (2,4);
	
	
	

INSERT INTO TIPO_EQUIPO(tipo_equipo, descripcion, fecha_alta)
	VALUES('Generico2', 'Tipo de equipo generico2', GETDATE());
	
INSERT INTO TIPO_DOCUMENTO(nombre_tipo_documento, descripcion)
	VALUES('DNI', 'Documento Nacional de Identidad');
	




INSERT INTO PERSONA(legajo, numero_documento, tipo_documento_id, apellido, nombre, telefono, mail, calle, numero_calle, piso, departamento, observaciones, fecha_alta)
	VALUES(64429,39072672,1,'Salvai','Nicolas',35130941,'example@example.com','Calle Falsa', 123, 1, 'F', 'Observaciones', GETDATE());

INSERT INTO PRESTAMO(persona_id, fecha_desde)
	VALUES(1,GETDATE());

USE [64429Pav1];
INSERT INTO EQUIPO(codigo, nombre, tipo_equipo_id, descripcion, fecha_alta)
	VALUES('G-01', 'voltimetro XXX', 2, '...', GETDATE());
	
	
INSERT INTO DETALLE_PRESTAMO(detalle_prestamo_id, prestamo_id, equipo_id)
	VALUES(1,1,1);
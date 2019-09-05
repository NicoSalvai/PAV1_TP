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
     VALUES (1, NULL, 'Menu Principal', 0, NULL),
		(2, 1, 'Personas', 0, NULL),
			(3, 2, 'Alta Personas', 1, NULL),
			(4, 2, 'Modificar Personas', 1, NULL),
			(5, 2, 'Consultar Personas', 1, NULL),
		(6, 1, 'Prestamos', 0, NULL),
			(7, 6, 'Iniciar Prestamos', 1, NULL),
			(8, 6, 'Finalizar Prestamos', 1, NULL),
			(9, 6, 'Consultar Prestamos', 1, NULL),
		(10, 1, 'Equipos', 0, NULL),
			(11, 10, 'Alta Equipos', 1, NULL),
			(12, 10, 'Modificar Equipos', 1, NULL),
			(13, 10, 'Consultar Equipos', 1, NULL),
			(14, 10, 'Baja Equipos', 1, NULL);


INSERT INTO PERFIL (nombre_perfil, descripcion, fecha_alta)
	VALUES ('Administrador', '', GETDATE()),
			('Encargado Personas', '', GETDATE()),
			('Encargado Prestamos', '', GETDATE()),
			('Encargado Equipos', '', GETDATE());


INSERT INTO PERFIL_MENU (perfil_id, menu_id)
	VALUES (1,3),(1,4),(1,5),(1,7),(1,8),(1,9),(1,11),(1,12),(1,13),(1,14), -- Administrador
			(2,3),(2,4),(2,5), -- Personas
			(3,7),(3,8),(3,9), -- Prestamos
			(4,11),(4,12),(4,13),(4,14); -- Equipos
			
INSERT INTO USUARIO (nombre_usuario, pass)
	VALUES('administrador', 'administrador'),
		('NicoSalvai', 'NicoSalvai');
	
INSERT INTO USUARIO_PERFIL (usuario_id, perfil_id)
	VALUES(1,1), (2,2), (2,4);
	
	
	

INSERT INTO TIPO_EQUIPO(tipo_equipo, descripcion)
	VALUES('Generico', 'Tipo de equipo generico');
	
INSERT INTO TIPO_DOCUMENTO(tipo_documento, descripcion)
	VALUES('DNI', 'Documento Nacional de Identidad');
	




INSERT INTO PERSONA(legajo, numero_documento, tipo_documento_id, apellido, nombre, telefono, mail, calle, numero_calle, piso, departamento, observaciones)
	VALUES(64429,39072672,1,'Salvai','Nicolas',35130941,'example@example.com','Calle Falsa', 123, 1, 'F', 'Observaciones');

INSERT INTO PRESTAMO(persona_id, fecha_desde)
	VALUES(1,GETDATE());

INSERT INTO EQUIPO(codigo, nombre, tipo_equipo_id, descripcion)
	VALUES('VM-01', 'voltimetro XXX', 1, '...');
	
INSERT INTO DETALLE_PRESTAMO(detalle_prestamo_id, prestamo_id, equipo_id)
	VALUES(1,1,1);
	
	
-- ####################################################################################
-- ############			INICIO CONSULTAS										############
-- ####################################################################################

-- ##############################################		UN SELECT PARA LA TABLA QUE SE ME CANTE
SELECT *
FROM MENU;


-- ##############################################		PERFILES DE CADA USUARIO
SELECT U.nombre_usuario,
		P.nombre_perfil
FROM USUARIO U
	JOIN USUARIO_PERFIL UP ON UP.usuario_id = U.usuario_id
	JOIN PERFIL P ON P.perfil_id = UP.perfil_id
WHERE P.fecha_baja IS NULL;


-- ##############################################		 MENUS HABILITADOS PARA CADA PERFIL
SELECT P.nombre_perfil,
		P.descripcion,
		M.nombre_menu,
		M.aplicacion
FROM PERFIL P 
	JOIN PERFIL_MENU PM ON P.perfil_id = PM.perfil_id
	JOIN MENU M ON M.menu_id = PM.menu_id
WHERE P.fecha_baja IS NULL;


-- ##############################################		 MENUS HABILITADOS PARA CADA USUARIO
SELECT U.nombre_usuario,
		M.nombre_menu,
		M.aplicacion
FROM USUARIO U
	JOIN USUARIO_PERFIL UP ON UP.usuario_id = U.usuario_id
	JOIN PERFIL P ON P.perfil_id = UP.perfil_id
	JOIN PERFIL_MENU PM ON PM.perfil_id = P.perfil_id
	JOIN MENU M ON M.menu_id = PM.menu_id
WHERE P.fecha_baja IS NULL;
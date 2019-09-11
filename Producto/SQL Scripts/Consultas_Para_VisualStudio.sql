-- ####################################################################################
-- ############			INICIO CONSULTAS										############
-- ####################################################################################

-- ################################ Class: MenuDao 
-- GetMenuById()
USE [64429Pav1];
SELECT M.menu_id,
	M.padre_menu_id,
	M.nombre_menu,
	M.es_final,
	M.aplicacion
FROM MENU M
WHERE M.menu_id = 1;


-- ################################ Class: PerfilDao 
-- GetPerfilById()
SELECT 	P.perfil_id,
		P.nombre_perfil,
		P.descripcion,	
		P.fecha_alta,
		P.fecha_baja		
FROM PERFIL P
WHERE P.perfil_id = 1;

-- GetPerfilMenus()
SELECT PM.menu_id
FROM PERFIL_MENU PM
WHERE PM.perfil_id = 1;


-- ################################ Class: UsuarioDao
-- GetUsuarioById()
USE [64429Pav1];
SELECT 	U.usuario_id,
		U.nombre_usuario,
		U.pass,
		U.fecha_alta,
		U.fecha_baja
FROM USUARIO U
WHERE U.usuario_id = 1;

-- GetUsuarioPerfiles()
SELECT UP.perfil_id
FROM USUARIO_PERFIL UP
WHERE UP.usuario_id = 1;


-- ############################ Class : TipoEquipoDao
-- GetTipoEquipoById()
USE [64429Pav1]
SELECT TE.tipo_equipo_id,
	TE.tipo_equipo,
	TE.descripcion,
	TE.fecha_alta,
	TE.fecha_baja
FROM TIPO_EQUIPO TE
WHERE TE.tipo_equipo_id = 1;

-- ############################ Class : EquipoDao
-- GetEquipoById()
SELECT E.equipo_id,
	E.codigo,
	E.nombre,
	E.tipo_equipo_id,
	E.descripcion,
	E.fecha_alta,
	E.fecha_baja
FROM EQUIPO E
WHERE E.equipo_id = 1;

-- ############################ Class : PrestamoDao
-- GetPrestamoById()
SELECT P.prestamo_id,
		P.fecha_desde,
		P.fecha_hasta,
		P.fecha_cancelacion
FROM PRESTAMO P
WHERE P.prestamo_id = 1;


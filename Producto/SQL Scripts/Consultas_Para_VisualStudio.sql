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
WHERE P.perfil_id = 

-- GetPerfilMenus()
SELECT PM.menu_id
FROM PERFIL_MENU PM
WHERE PM.perfil_id = 


-- ################################ Class: UsuarioDao
-- GetUsuarioById()
SELECT 	U.usuario_id
		U.nombre_usuario
		U.pass
FROM USUARIO U
WHERE U.usuario_id = 

-- GetUsuarioPerfiles()
SELECT UP.perfil_id
FROM USUARIO_PERFIL UP
WHERE UP.usuario_id = 
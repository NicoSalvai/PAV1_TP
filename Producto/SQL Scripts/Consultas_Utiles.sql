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
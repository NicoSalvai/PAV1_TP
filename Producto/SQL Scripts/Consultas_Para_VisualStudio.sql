-- ####################################################################################
-- ############			INICIO CONSULTAS										############
-- ####################################################################################

-- ################################ Class: MenuDao 
-- GetMenuById()
USE [64429Pav1];
SELECT M.menu_id,
	M.nombre_menu,
	MP.nombre_menu AS 'padre_menu_nombre',
	M.padre_menu_id,
	M.es_final,
	M.aplicacion
FROM MENU M
LEFT JOIN MENU MP ON MP.menu_id = M.padre_menu_id
WHERE M.menu_id = 1;

-- GetMenuByFilters()
SELECT M.menu_id,
	M.nombre_menu,
	MP.nombre_menu AS 'padre_menu_nombre',
	M.padre_menu_id,
	M.es_final,
	M.aplicacion
FROM MENU M

LEFT JOIN PERFIL_MENU PM ON PM.menu_id = M.menu_id

LEFT JOIN PERFIL P ON P.perfil_id = PM.perfil_id
LEFT JOIN USUARIO_PERFIL UP ON UP.perfil_id = P.perfil_id

LEFT JOIN MENU MP ON MP.menu_id = M.padre_menu_id
WHERE 1 = 1

AND (PM.perfil_id = 1) 
AND (UP.usuario_id = 1) ;

-- ################################ Class: PerfilDao 
-- GetPerfilById()
SELECT 	P.perfil_id,
		P.nombre_perfil,
		P.descripcion
FROM PERFIL P
WHERE P.perfil_id = 1;

-- ################################ Class: UsuarioDao
-- GetUsuarioById()
USE [64429Pav1];
SELECT 	U.usuario_id,
		U.nombre_usuario,
		U.pass,
		U.fecha_alta,
		U.fecha_baja
FROM USUARIO U
WHERE U.usuario_id = 1
AND U.fecha_baja IS NULL;

-- ############################ Class : TipoEquipoDao
-- GetTipoEquipoById()
USE [64429Pav1]
SELECT TE.tipo_equipo_id,
	TE.tipo_equipo,
	TE.descripcion,
	TE.codigo_recomendado
FROM TIPO_EQUIPO TE
WHERE TE.tipo_equipo_id = 1;

-- ############################ Class : EquipoDao
-- GetEquipoById()
SELECT E.equipo_id,
	E.codigo,
	E.nombre,
	TE.tipo_equipo,
	E.tipo_equipo_id,
	E.descripcion,
	E.fecha_alta,
	E.fecha_baja
FROM EQUIPO E
JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id
WHERE E.equipo_id = 1
AND E.fecha_baja IS NULL;

-- DeleteEquipoById()
UPDATE EQUIPO
SET fecha_baja = GETDATE()
WHERE equipo_id = 1;

-- UpdateEquipoById()
UPDATE EQUIPO
SET codigo = '',
	nombre = '',
	tipo_equipo_id = 1,
	descripcion = ''
WHERE equipo_id = 1;

-- InsertEquipo()
INSERT INTO EQUIPO(codigo, nombre, tipo_equipo_id, descripcion, fecha_alta)
VALUES();

-- ############################ Class : PersonaDao
-- GetPersonaById()
USE [64429Pav1];
SELECT P.persona_id,			
	P.legajo,				
	P.numero_documento,
	TD.nombre_tipo_documento,
	P.tipo_documento_id,
	P.apellido,
	P.nombre,
	P.telefono,
	P.mail,
	P.calle,
	P.numero_calle,
	P.piso,
	P.departamento,
	P.observaciones,
	P.fecha_alta,
	P.fecha_baja
FROM PERSONA P
	JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = P.tipo_documento_id
WHERE P.persona_id = 1
AND P.fecha_baja IS NULL;


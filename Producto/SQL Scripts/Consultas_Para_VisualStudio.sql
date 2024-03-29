-- ####################################################################################
-- ############			INICIO CONSULTAS										############
-- ####################################################################################
-- DeleteById()
-- UpdateById()
-- Insert()
-- ################################################################ Class: MenuDao 
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

LEFT JOIN PERFIL_MENU PM ON PM.menu_id = M.menu_id			-- IdPerfil

LEFT JOIN PERFIL P ON P.perfil_id = PM.perfil_id			-- IdUsuario
LEFT JOIN USUARIO_PERFIL UP ON UP.perfil_id = P.perfil_id	-- IdUSuario

LEFT JOIN MENU MP ON MP.menu_id = M.padre_menu_id
WHERE 1 = 1

AND (PM.perfil_id = 1)							-- IdPerfil
AND (UP.usuario_id = 1) ;						-- IdUsuario

-- ################################################################ Class: PerfilDao 
-- GetPerfilById()
SELECT 	P.perfil_id,
		P.nombre_perfil,
		P.descripcion
FROM PERFIL P
WHERE P.perfil_id = 1;

-- GetPerfilByFilters()
SELECT 	P.perfil_id,
		P.nombre_perfil,
		P.descripcion
FROM PERFIL P

RIGHT JOIN USUARIO_PERFIL UP ON UP.perfil_id = P.perfil_id	-- IdUsuario && IdUsuarioNot

WHERE 1 = 1

AND (UP.usuario_id = 1) ;								-- IdUsuario
AND (UP.usuario_id != 1) ;								-- IdUsuarioNot

-- ################################################################ Class: UsuarioDao
-- GetUsuarioById()
USE [64429Pav1];
SELECT 	U.usuario_id,
		U.nombre_usuario,
		U.pass,
		U.forzar_password,
		U.fecha_alta,
		U.fecha_baja
FROM USUARIO U
WHERE U.usuario_id = 1
AND U.fecha_baja IS NULL;

-- GetUsuarioByFilters()
SELECT 	U.usuario_id,
		U.nombre_usuario,
		U.pass,
		U.forzar_password,
		U.fecha_alta,
		U.fecha_baja
FROM USUARIO U

JOIN USUARIO_PERFIL UP ON UP.usuario_id = U.usuario_id -- IdPerfil

WHERE 1 = 1

AND UP.perfil_id = 1			-- IdPerfil
AND U.usuario_id = 1			-- IdUSuario
AND U.nombre_usuario = ''		-- NombreUsuario
AND U.fecha_baja IS NULL;		-- FechaBajaNotNull

-- DeleteUsuarioById()
UPDATE USUARIO
SET fecha_baja = GETDATE()
WHERE usuario_id = 1;

-- UpdateUSuarioById()
UPDATE USUARIO
SET nombre_usuario = '',
	pass = '',
	forzar_password = 0
WHERE usuario_id = 1;

-- InsertUSuario()
INSERT INTO USUARIO(nombre_usuario, pass, forzar_password, fecha_alta)
VALUES('', '', 0, GETDATE());

-- ################################################################ Class : TipoEquipoDao
-- GetTipoEquipoById()
USE [64429Pav1]
SELECT TE.tipo_equipo_id,
	TE.tipo_equipo,
	TE.descripcion,
	TE.codigo_recomendado
FROM TIPO_EQUIPO TE
WHERE TE.tipo_equipo_id = 1;

-- GetTipoEquipoByFilters()
SELECT TE.tipo_equipo_id,
	TE.tipo_equipo,
	TE.descripcion,
	TE.codigo_recomendado
FROM TIPO_EQUIPO TE
WHERE 1 = 1

AND TE.tipo_equipo LIKE ''		-- TipoEquipoLike
AND TE.descripcion LIKE '';		-- DescripcionLike

-- DeleteTipoEquipoById()

-- UpdateTipoEquipoById()
UPDATE TIPO_EQUIPO
SET tipo_equipo = '',
	descripcion = '',
	codigo_recomendado = ''
WHERE tipo_equipo_id = 1;

-- InsertTipoEquipo()
INSERT INTO TIPO_EQUIPO(tipo_equipo, descripcion, codigo_recomendado)
VALUES('', '', '');


-- ################################################################ Class : EstadoDao
-- GetEstadoById()
USE [64429Pav1]
SELECT EST.estado_id,
		EST.nombre_estado,
		EST.ambito,
		EST.deshabilita,
		EST.editable
FROM ESTADO EST
WHERE EST.estado_id = 1;

-- GetTipoEquipoByFilters()
SELECT EST.estado_id,
		EST.nombre_estado,
		EST.ambito,
		EST.deshabilita,
		EST.editable
FROM ESTADO EST
WHERE 1 = 1

AND EST.nombre_estado = ''		-- NombreEstado
AND EST.ambito = '';		-- Ambito

-- ################################################################ Class : EquipoDao
-- GetEquipoById()
SELECT E.equipo_id,
	E.codigo,
	E.nombre,
	TE.tipo_equipo,
	E.tipo_equipo_id,
	EST.nombre_estado,
	EST.deshabilita,
	EST.editable,
	E.estado_id,
	E.descripcion,
	E.fecha_alta,
	E.fecha_baja
FROM EQUIPO E
JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id
JOIN ESTADO EST ON EST.estado_id = E.estado_id
WHERE E.equipo_id = 1
AND E.fecha_baja IS NULL;

-- GetEquipoById()
SELECT E.equipo_id,
	E.codigo,
	E.nombre,
	TE.tipo_equipo,
	E.tipo_equipo_id,
	EST.nombre_estado,
	E.estado_id,
	E.descripcion,
	E.fecha_alta,
	E.fecha_baja
FROM EQUIPO E
JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id
JOIN ESTADO EST ON EST.estado_id = E.estado_id
WHERE 1 = 1

AND E.codigo LIKE ''			-- CodigoLike
AND E.codigo = ''				-- Codigo
AND E.nombre LIKE ''			-- NombreLike
AND E.tipo_equipo_id = 1		-- TipoEquipo
AND E.fecha_baja IS NULL;		-- FechaBajaNotNull

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
VALUES(1, '', 1, '', GETDATE());

-- ################################################################ Class : CarreraDao
-- GetCarreraById()
SELECT C.carrera_id,
		C.nombre_carrera
FROM CARRERA C
WHERE C.carrera_id = 1 ;

-- GetCarreraByFilters()
SELECT C.carrera_id,
		C.nombre_carrera
FROM CARRERA C
WHERE 1 = 1 ;

-- ################################################################ Class : UniversidadDao
-- GetCarreraById()
SELECT U.universidad_id,
		U.nombre_universidad
FROM UNIVERSIDAD U
WHERE U.universidad_id = 1 ;

-- GetCarreraByFilters()
SELECT U.universidad_id,
		U.nombre_universidad
FROM UNIVERSIDAD U
WHERE 1 = 1 ;

-- ################################################################ Class : TipoDocumentoDao
-- GetTipoDocumentoById()
SELECT TD.tipo_documento_id,
		TD.nombre_tipo_documento,
		TD.descripcion
FROM TIPO_DOCUMENTO TD
WHERE TD.tipo_documento_id = 1 ;

-- GetTipoDocumentoByFilters()
SELECT TD.tipo_documento_id,
		TD.nombre_tipo_documento,
		TD.descripcion
FROM TIPO_DOCUMENTO TD
WHERE 1 = 1 ;

-- ################################################################ Class : PersonaDao
-- GetPersonaById()
USE [64429Pav1];
SELECT P.persona_id,		
	P.numero_documento,
	P.tipo_documento_id,
	TD.nombre_tipo_documento,
	P.apellido,
	P.nombre,
	P.legajo,
	P.universidad_id,
	U.nombre_universidad,
	P.carrera_id,
	C.nombre_carrera,
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
	JOIN CARRERA C ON C.carrera_id = P.carrera_id
	JOIN UNIVERSIDAD U ON U.universidad_id = P.universidad_id
WHERE P.persona_id = 1
AND P.fecha_baja IS NULL;

-- GetPersonaByFilters()
USE [64429Pav1];
SELECT P.persona_id,		
	P.numero_documento,
	P.tipo_documento_id,
	TD.nombre_tipo_documento,
	P.apellido,
	P.nombre,
	P.legajo,
	P.universidad_id,
	U.nombre_universidad,
	P.carrera_id,
	C.nombre_carrera,
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
	JOIN CARRERA C ON C.carrera_id = P.carrera_id
	JOIN UNIVERSIDAD U ON U.universidad_id = P.universidad_id
WHERE 1 = 1

AND P.legajo = 1			-- Legajo
AND P.numero_documento = 1	-- NumeroDocumento
AND P.tipo_documento_id = 1 -- TipoDocumento
AND P.apellido LIKE ''		-- Apellido
AND P.nombre LIKE ''		-- Nombre
AND P.fecha_baja IS NULL;	-- FechaBajaNotNull


-- DeletePersonaById()
UPDATE PERSONA
SET fecha_baja = GETDATE()
WHERE persona_id = 1 ;

-- UpdatePersonaById()
UPDATE PERSONA
SET legajo = 1,				
	numero_documento = 1,
	tipo_documento_id = 1,
	apellido = '',
	nombre = '',
	telefono = 1,
	mail = '',
	calle = '',
	numero_calle = 1,
	piso = 1,
	departamento = '',
	observaciones = ''
WHERE persona_id = 1 ;

-- InsertPersona()
INSERT INTO PERSONA(legajo, numero_documento, tipo_documento_id, apellido, nombre, telefono, 
		mail, calle, numero_calle, piso, departamento, observaciones, fecha_alta)
VALUES(1, 1, 1, '', '', 1, '', '', 1, 1, '', '', GETDATE());



-- ################################################################ Class : PrestamoDao
-- GetPrestamoById()
USE [64429Pav1];
SELECT P.prestamo_id,
		P.persona_id,
		PER.numero_documento,
		PER.tipo_documento_id,
		TD.nombre_tipo_documento,
		PER.apellido,
		PER.nombre,
		PER.legajo,
		P.estado_id,
		EST.nombre_estado,
		P.fecha_desde,
		P.fecha_hasta_estimada,
		P.fecha_hasta,
		P.fecha_cancelacion
FROM PRESTAMO P
JOIN PERSONA PER ON PER.persona_id = P.persona_id
JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = PER.tipo_documento_id
JOIN ESTADO EST ON EST.estado_id = P.estado_id
WHERE P.prestamo_id = 1;

SELECT DP.detalle_prestamo_id,
		DP.prestamo_id,
		E.equipo_id,
		E.codigo,
		E.nombre,
		TE.tipo_equipo_id,
		TE.tipo_equipo,
		DP.fecha_devuelto
FROM DETALLE_PRESTAMO DP
JOIN EQUIPO E ON E.equipo_id = DP.equipo_id
JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id


-- GetPrestamoByFilters()
SELECT P.prestamo_id,
		P.persona_id,
		PER.numero_documento,
		PER.tipo_documento_id,
		TD.nombre_tipo_documento,
		PER.apellido,
		PER.nombre,
		PER.legajo,
		P.estado_id,
		EST.nombre_estado,
		P.fecha_desde,
		P.fecha_hasta_estimada,
		P.fecha_hasta,
		P.fecha_cancelacion
FROM PRESTAMO P
JOIN PERSONA PER ON PER.persona_id = P.persona_id
JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = PER.tipo_documento_id
JOIN ESTADO EST ON EST.estado_id = P.estado_id
WHERE 1 = 1

AND P.persona_id = 1				-- IdPersona
AND PER.tipo_documento_id = 1		-- TipoDocumentoId
AND TD.nombre_tipo_documento = ''	-- TipoDocumento
AND PER.numero_documento = 1		-- NumeroDocumento
AND PER.nombre = ''					-- Nombre
AND PER.apellido = ''				-- Apellido
AND PER.legajo = 1					-- Legajo
AND P.estado_id = 1					-- IdEstado
AND EST.nombre_estado = ''			-- NombreEstado
AND P.fecha_desde = ''				-- FechaDesde
AND P.fecha_hasta_estimada = ''		-- FechaHastaEstimada
AND P.fecha_hasta = ''				-- FechaHasta
AND P.fecha_cancelacion = ''		-- FechaCancelacion
AND P.fecha_hasta IS NULL			-- FechaHastaNull
AND P.fecha_cancelacion IS NULL;	-- FechaCancelacionNull

-- DeletePrestamoById()

-- UpdatePrestamoById()
UPDATE PRESTAMO
SET fecha_hasta = '',
	fecha_cancelacion = ''
WHERE prestamo_id = 1;

-- InsertPrestamo()
INSERT INTO PRESTAMO(persona_id, estado_id, fecha_desde, fecha_hasta_estimada)
	VALUES(1, 4, GETDATE(), GETDATE());

INSERT INTO DETALLE_PRESTAMO(prestamo_id, equipo_id)
VALUES(1, 1);	-- algo como un for


-- ################################################################ Class : DetallePrestamoDao
-- GetDetallePrestamoByPrestamoId()
SELECT DP.detalle_prestamo_id,
		DP.prestamo_id,
		DP.equipo_id,
		E.codigo,
		E.nombre,
		E.tipo_equipo_id,
		TE.tipo_equipo,
		DP.fecha_devuelto
FROM DETALLE_PRESTAMO DP
JOIN EQUIPO E ON E.equipo_id = DP.equipo_id
JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id
WHERE prestamo_id = 1;

-- GetDetallePrestamoByFilters()

-- DeleteDetallePrestamoById()

-- UpdateDetallePrestamoById()
BEGIN TRANSACTION 
USE[64429Pav1] 

UPDATE DETALLE_PRESTAMO 
SET fecha_devuelto = GETDATE() 
WHERE detalle_prestamo_id = 27 

UPDATE EQUIPO 
SET estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'DISPONIBLE') 
WHERE equipo_id = 1 

IF((SELECT COUNT(*) FROM DETALLE_PRESTAMO WHERE prestamo_id = @IdPrestamo AND fecha_devuelto IS NULL GROUP BY prestamo_id ) IS NULL) 
	UPDATE PRESTAMO SET fecha_hasta = GETDATE(), estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'DEVUELTO') WHERE prestamo_id = @IdPrestamo; 
ELSE 
	UPDATE PRESTAMO SET estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'DEVUELTO PARCIAL') WHERE prestamo_id = @IdPrestamo;  
	
IF(1 = 1) 
	COMMIT; 
ELSE 
	ROLLBACK; 
	
	
-- InsertDetallePrestamo()
BEGIN TRANSACTION
USE [64429Pav1]

INSERT INTO PRESTAMO(persona_id, estado_id, fecha_desde, fecha_hasta_estimada)
	VALUES(@IdPersona, @IdEstado, GETDATE(), GETDATE());

DECLARE @IdPrestamo INT;  
SELECT @IdPrestamo = @@IDENTITY;

INSERT INTO DETALLE_PRESTAMO(prestamo_id, equipo_id)
	VALUES(@IdPrestamo, @IdEquipo);
	
IF ((SELECT COUNT(*) FROM DETALLE_PRESTAMO WHERE prestamo_id = @IdPrestamo) = 1)
	COMMIT;
ELSE
	ROLLBACK;
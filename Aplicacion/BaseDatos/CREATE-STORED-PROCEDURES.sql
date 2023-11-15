CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_SET_CATEGORIA (
        IN p_ID_CATEGORIA SMALLINT,
        IN p_DESCRIPCION VARCHAR(25)
    ) 
BEGIN
    DECLARE v_row_count INT;
    
    -- Intenta actualizar la categoría existente
    UPDATE SCHEMA_TIENDA.TBL_CATEGORIAS
    SET DESCRIPCION = p_DESCRIPCION
    WHERE ID_CATEGORIA = p_ID_CATEGORIA;
    
    -- Obtiene el número de filas afectadas por la actualización
    SET v_row_count = ROW_COUNT;
    
    -- Si no se actualizó ninguna fila, entonces intenta insertar una nueva categoría
    IF v_row_count = 0 THEN
        INSERT INTO SCHEMA_TIENDA.TBL_CATEGORIAS (DESCRIPCION)
        VALUES (p_DESCRIPCION);
        
        -- Obtiene el número de filas afectadas por la inserción
        SET v_row_count = ROW_COUNT;
        
        -- Si no se insertó ninguna fila, lanza una excepción
        IF v_row_count = 0 THEN
        	ROLLBACK;
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pudo actualizar ni insertar la categoría.';
        END IF;
    END IF;
    
    COMMIT;
END

CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_GET_CATEGORIA ()
	DYNAMIC RESULT SETS 1
BEGIN
	DECLARE P_CURSOR CURSOR WITH RETURN for
		    SELECT ID_CATEGORIA, DESCRIPCION
    FROM SCHEMA_TIENDA.TBL_CATEGORIAS
    ORDER BY ID_CATEGORIA;

	OPEN P_CURSOR;
END

CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_GET_USUARIOS ()
  SPECIFIC SP_GET_USUARIOS
  LANGUAGE SQL 
  DYNAMIC RESULT SETS 1

  Re:  BEGIN

    DECLARE P_CURSOR CURSOR WITH RETURN FOR
    SELECT *
    FROM SCHEMA_TIENDA.TBL_USUARIOS
    ORDER BY ID_USUARIO;

    OPEN P_CURSOR;

  END Re 


CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_SET_USUARIO (
    IN p_ID_USUARIO INTEGER,
    IN p_NOMBRES VARCHAR(40),
    IN p_APELLIDO_PATERNO VARCHAR(40),
    IN p_APELLIDO_MATERNO VARCHAR(40),
    IN p_NOMBRE_COMPLETO VARCHAR(100),
    IN p_DNI VARCHAR(15),
    IN p_SEXO CHAR(1),
    IN p_TELEFONO VARCHAR(15),
    IN p_USUARIO_REGISTRO INTEGER
)
SPECIFIC SP_SET_USUARIO
LANGUAGE SQL 
BEGIN
    DECLARE v_row_count INT;

    -- Intenta actualizar el usuario existente
    UPDATE SCHEMA_TIENDA.TBL_USUARIOS
    SET 
        NOMBRES = p_NOMBRES,
        APELLIDO_PATERNO = p_APELLIDO_PATERNO,
        APELLIDO_MATERNO = p_APELLIDO_MATERNO,
        NOMBRE_COMPLETO = p_NOMBRE_COMPLETO,
        DNI = p_DNI,
        SEXO = p_SEXO,
        TELEFONO = p_TELEFONO
    WHERE ID_USUARIO = p_ID_USUARIO;

    -- Obtiene el número de filas afectadas por la actualización
    GET DIAGNOSTICS v_row_count = ROW_COUNT;

    -- Si no se actualizó ninguna fila, entonces intenta insertar un nuevo usuario
    IF v_row_count = 0 THEN
        INSERT INTO SCHEMA_TIENDA.TBL_USUARIOS (
            NOMBRES, APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRE_COMPLETO, DNI, SEXO, TELEFONO, FECHA_REGISTRO, USUARIO_REGISTRO
        )
        VALUES (
            p_NOMBRES, p_APELLIDO_PATERNO, p_APELLIDO_MATERNO, p_NOMBRE_COMPLETO, p_DNI, p_SEXO, p_TELEFONO, CURRENT_TIMESTAMP, p_USUARIO_REGISTRO
        );

        -- Obtiene el número de filas afectadas por la inserción
        GET DIAGNOSTICS v_row_count = ROW_COUNT;

        -- Si no se insertó ninguna fila, lanza una excepción
        IF v_row_count = 0 THEN
            ROLLBACK;
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pudo actualizar ni insertar el usuario.';
        END IF;
    END IF;

    COMMIT;
END 

CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_GET_CUENTAS ()
  SPECIFIC SP_GET_CUENTAS
  LANGUAGE SQL 
  DYNAMIC RESULT SETS 1

  Re:  BEGIN

    DECLARE P_CURSOR CURSOR WITH RETURN FOR
    SELECT *
    FROM SCHEMA_TIENDA.TBL_CUENTAS
    ORDER BY ID_CUENTA;

    OPEN P_CURSOR;

  END Re 

CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_SET_CUENTA (
    IN p_ID_CUENTA INTEGER,
    IN p_ID_USUARIO INTEGER,
    IN p_CUENTA VARCHAR(25),
    IN p_CONTRASEÑA VARCHAR(25),
    IN p_TIPO_CUENTA CHAR(1),
    IN p_FLAG_ACTIVIDAD NUMERIC(1,0),
    IN p_USUARIO_REGISTRO INTEGER
)
SPECIFIC SP_SET_CUENTA
LANGUAGE SQL 
BEGIN
    DECLARE v_row_count INT;

    -- Intenta actualizar la cuenta existente
    UPDATE SCHEMA_TIENDA.TBL_CUENTAS
    SET 
        ID_USUARIO = p_ID_USUARIO,
        CUENTA = p_CUENTA,
        CONTRASEÑA = p_CONTRASEÑA,
        TIPO_CUENTA = p_TIPO_CUENTA,
        FLAG_ACTIVIDAD = p_FLAG_ACTIVIDAD
    WHERE ID_CUENTA = p_ID_CUENTA;

    -- Obtiene el número de filas afectadas por la actualización
    GET DIAGNOSTICS v_row_count = ROW_COUNT;

    -- Si no se actualizó ninguna fila, entonces intenta insertar una nueva cuenta
    IF v_row_count = 0 THEN
        INSERT INTO SCHEMA_TIENDA.TBL_CUENTAS (
            ID_USUARIO, CUENTA, CONTRASEÑA, TIPO_CUENTA, FLAG_ACTIVIDAD, USUARIO_REGISTRO, FECHA_REGISTRO
        )
        VALUES (
            p_ID_USUARIO, p_CUENTA, p_CONTRASEÑA, p_TIPO_CUENTA, p_FLAG_ACTIVIDAD, p_USUARIO_REGISTRO, CURRENT_TIMESTAMP
        );

        -- Obtiene el número de filas afectadas por la inserción
        GET DIAGNOSTICS v_row_count = ROW_COUNT;

        -- Si no se insertó ninguna fila, lanza una excepción
        IF v_row_count = 0 THEN
            ROLLBACK;
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pudo actualizar ni insertar la cuenta.';
        END IF;
    END IF;

    COMMIT;
END 


CREATE OR REPLACE PROCEDURE SCHEMA_TIENDA.SP_VALIDAR_CREDENCIALES (
    IN p_USUARIO VARCHAR(25),
    IN p_CONTRASENA VARCHAR(25)
)
SPECIFIC SP_VALIDAR_CREDENCIALES
LANGUAGE SQL 
DYNAMIC RESULT SETS 1
BEGIN
    DECLARE v_usuario_id INTEGER;
    DECLARE v_flag_actividad NUMERIC(1, 0);
    DECLARE v_contrasena VARCHAR(25);
    DECLARE P_CURSOR CURSOR WITH RETURN FOR
    SELECT CUENTAS.ID_CUENTA, CUENTAS.CUENTA, CUENTAS.TIPO_CUENTA, USUARIOS.*    	     
      FROM SCHEMA_TIENDA.TBL_CUENTAS CUENTAS
        INNER JOIN SCHEMA_TIENDA.TBL_USUARIOS USUARIOS ON CUENTAS.ID_USUARIO = USUARIOS.ID_USUARIO
    WHERE CUENTAS.ID_USUARIO = v_usuario_id AND CUENTAS.CUENTA = p_USUARIO;

	-- Validar que los parámetros no sean nulos o vacíos
    IF p_USUARIO IS NULL OR p_CONTRASENA IS NULL OR p_USUARIO = '' OR p_CONTRASENA = '' THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Usuario y contraseña son obligatorios.';
    END IF;

	-- Obtener el ID del usuario y datos necesarios
    SELECT ID_USUARIO, FLAG_ACTIVIDAD, CONTRASEÑA 
      INTO v_usuario_id, v_flag_actividad, v_contrasena
      FROM SCHEMA_TIENDA.TBL_CUENTAS
     WHERE CUENTA = p_USUARIO;

	-- Validar que el usuario exista
    IF v_usuario_id IS NULL THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'La cuenta no existe.';
    END IF;

	-- Validar que la contraseña sea correcta
    IF v_contrasena <> p_CONTRASENA THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'La contraseña no es correcta.';
    END IF;

	-- Validar que la cuenta esté activa
    IF v_flag_actividad = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'La cuenta ha sido inhabilitada. Comuníquese con el administrador.';
    END IF;

    OPEN P_CURSOR;
END 
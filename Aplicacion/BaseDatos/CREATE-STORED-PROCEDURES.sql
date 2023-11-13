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
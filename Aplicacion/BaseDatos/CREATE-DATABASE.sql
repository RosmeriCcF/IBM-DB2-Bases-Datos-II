--Sentencia para crear la base de datos. Establecer el nombre final.
--En este caso la base de datos se crea con un SCHEMA, también pendiente de definir un nombre final. 
--Además, se establece al usuario ADMIN como DBA u owner.
CREATE DATABASE DBTIENDA AUTOMATIC STORAGE YES ALIAS DBTIENDA USING CODESET UTF -8 TERRITORY Lat CREATE SCHEMA SCHEMA_TIENDA AUTHORIZATION ADMIN;

--Sentencias para asignar permisos a un usuario para el SCHEMA.
--GRANT ALTERIN ON SCHEMA SCHEMA_TIENDA TO USER ADMIN WITH GRANT OPTION;
--GRANT CREATEIN ON SCHEMA SCHEMA_TIENDA TO USER ADMIN WITH GRANT OPTION;
--GRANT DROPIN ON SCHEMA SCHEMA_TIENDA TO USER ADMIN WITH GRANT OPTION;

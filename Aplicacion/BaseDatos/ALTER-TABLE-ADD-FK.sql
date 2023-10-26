
/*
ALTER TABLE SCHEMA_TIENDA.TBL_COLABORADORES DROP CONSTRAINT FK_COLABORADOR_USUARIO;
ALTER TABLE SCHEMA_TIENDA.TBL_COLABORADORES DROP CONSTRAINT FK_COLABORADOR_CARGO;
ALTER TABLE SCHEMA_TIENDA.TBL_COLABORADORES DROP CONSTRAINT FK_COLABORADOR_TURNO;
ALTER TABLE SCHEMA_TIENDA.TBL_CARGOS DROP CONSTRAINT FK_CARGO_DEPARTAMENTO;
ALTER TABLE SCHEMA_TIENDA.TBL_CUENTAS DROP CONSTRAINT FK_CUENTA_USUARIO;
ALTER TABLE SCHEMA_TIENDA.TBL_PRODUCTOS DROP CONSTRAINT FK_PRODUCTO_CATEGORIA;
ALTER TABLE SCHEMA_TIENDA.TBL_PRODUCTOS DROP CONSTRAINT FK_PRODUCTO_PROVEEDOR;
ALTER TABLE SCHEMA_TIENDA.TBL_MOVIMIENTOS_MERCADERIA DROP CONSTRAINT FK_MOVIMIENTO_PRODUCTO;
ALTER TABLE SCHEMA_TIENDA.TBL_CLIENTES DROP CONSTRAINT FK_CLIENTE_USUARIO;
ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS DROP CONSTRAINT FK_VENTA_CLIENTE;
ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS DROP CONSTRAINT FK_VENTA_COLABORADOR;
ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS_PRODUCTOS DROP CONSTRAINT FK_VENTAS_PRODUCTOS_PRODUCTO;
ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS_PRODUCTOS DROP CONSTRAINT FK_VENTAS_PRODUCTOS_VENTA;
*/

ALTER TABLE SCHEMA_TIENDA.TBL_COLABORADORES
ADD CONSTRAINT FK_COLABORADOR_USUARIO FOREIGN KEY (ID_USUARIO) REFERENCES SCHEMA_TIENDA.TBL_USUARIOS(ID_USUARIO);

ALTER TABLE SCHEMA_TIENDA.TBL_COLABORADORES
ADD CONSTRAINT FK_COLABORADOR_CARGO FOREIGN KEY (ID_CARGO) REFERENCES SCHEMA_TIENDA.TBL_CARGOS(ID_CARGO);

ALTER TABLE SCHEMA_TIENDA.TBL_COLABORADORES
ADD CONSTRAINT FK_COLABORADOR_TURNO FOREIGN KEY (ID_TURNO) REFERENCES SCHEMA_TIENDA.TBL_TURNOS(ID_TURNO);

ALTER TABLE SCHEMA_TIENDA.TBL_CARGOS
ADD CONSTRAINT FK_CARGO_DEPARTAMENTO FOREIGN KEY (ID_DEPARTAMENTO) REFERENCES SCHEMA_TIENDA.TBL_DEPARTAMENTOS(ID_DEPARTAMENTO);

ALTER TABLE SCHEMA_TIENDA.TBL_CUENTAS
ADD CONSTRAINT FK_CUENTA_USUARIO FOREIGN KEY (ID_USUARIO) REFERENCES SCHEMA_TIENDA.TBL_USUARIOS(ID_USUARIO);

ALTER TABLE SCHEMA_TIENDA.TBL_PRODUCTOS
ADD CONSTRAINT FK_PRODUCTO_CATEGORIA FOREIGN KEY (ID_CATEGORIA) REFERENCES SCHEMA_TIENDA.TBL_CATEGORIAS(ID_CATEGORIA);

ALTER TABLE SCHEMA_TIENDA.TBL_PRODUCTOS
ADD CONSTRAINT FK_PRODUCTO_PROVEEDOR FOREIGN KEY (ID_PROVEEDOR) REFERENCES SCHEMA_TIENDA.TBL_PROVEEDORES(ID_PROVEEDOR);

ALTER TABLE SCHEMA_TIENDA.TBL_MOVIMIENTOS_MERCADERIA
ADD CONSTRAINT FK_MOVIMIENTO_PRODUCTO FOREIGN KEY (ID_PRODUCTO) REFERENCES SCHEMA_TIENDA.TBL_PRODUCTOS(ID_PRODUCTO);

ALTER TABLE SCHEMA_TIENDA.TBL_CLIENTES
ADD CONSTRAINT FK_CLIENTE_USUARIO FOREIGN KEY (ID_USUARIO) REFERENCES SCHEMA_TIENDA.TBL_USUARIOS(ID_USUARIO);

ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS
ADD CONSTRAINT FK_VENTA_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES SCHEMA_TIENDA.TBL_CLIENTES(ID_USUARIO);

ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS
ADD CONSTRAINT FK_VENTA_COLABORADOR FOREIGN KEY (ID_COLABORADOR) REFERENCES SCHEMA_TIENDA.TBL_COLABORADORES(ID_USUARIO);

ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS_PRODUCTOS
ADD CONSTRAINT FK_VENTAS_PRODUCTOS_PRODUCTO FOREIGN KEY (ID_PRODUCTO) REFERENCES SCHEMA_TIENDA.TBL_PRODUCTOS(ID_PRODUCTO);

ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS_PRODUCTOS
ADD CONSTRAINT FK_VENTAS_PRODUCTOS_VENTA FOREIGN KEY (ID_VENTA) REFERENCES SCHEMA_TIENDA.TBL_VENTAS(ID_VENTA);

ALTER TABLE SCHEMA_TIENDA.TBL_VENTAS_PRODUCTOS
ADD CONSTRAINT FK_VENTAS_PRODUCTOS_MOVIMIENTO FOREIGN KEY (ID_MOVIMIENTO) REFERENCES SCHEMA_TIENDA.TBL_MOVIMIENTOS_MERCADERIA(ID_MOVIMIENTO);
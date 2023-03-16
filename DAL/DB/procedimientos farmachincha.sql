USE FARMACHINCHA
GO


create procedure spu_usuarios_login(
@nomusuarios	VARCHAR(30)

)
as
begin
	select	usuarios.idusuario,
	personas.idpersona,
			usuarios.nomusuarios, usuarios.claveacceso,
			usuarios.estado
	from usuarios INNER JOIN personas on usuarios.idpersona = usuarios.idusuario
	where	usuarios.nomusuarios = @nomusuarios AND
			
			usuarios.estado = 1
end
go

exec spu_usuarios_login 'eduin11' 
go

-- LISTAR PRODUCTOS -- ELIMINAR Y VOLVER A EJECUTAR


CREATE PROCEDURE SPU_PRODUCTOS_LISTAR
AS
		SELECT idlaboratorio, idcategoria, nombreproducto, descripcion, cantidad, precio, fechaproduccion,
				fechavencimiento, numlote, recetamedica, barcode
		FROM productos

GO

EXEC SPU_PRODUCTOS_LISTAR 
GO

CREATE PROCEDURE  SPU_REGISTRAR_PRODUCTOS	
	@idlaboratorio	INT,
	@idcategoria	INT,
	@nombreproducto	VARCHAR(50),
	@descripcion	VARCHAR(100),
	@precio			DECIMAL(7,2),
	@cantidad		SMALLINT,
	@fechaproduccion	DATE,
	@fechavencimiento	DATE,
	@numlote			VARCHAR(15),
	@recetamedica	CHAR(1),
	@barcode	VARCHAR(20)

AS BEGIN

	INSERT INTO productos(idlaboratorio, idcategoria,  nombreproducto, descripcion, precio, cantidad, fechaproduccion, fechavencimiento, numlote, recetamedica, barcode)
		VALUES(@idlaboratorio, @idcategoria,  @nombreproducto, @descripcion, @precio, @cantidad,@fechaproduccion, @fechavencimiento, @numlote, @recetamedica, @barcode)
END
GO

exec SPU_REGISTRAR_PRODUCTOS 3, 1 , 'Paracetamol 500mg','Dolor leve o moderado y fiebre ', 50 , 10.00 , '02/11/2022','02/11/2025', 'G-1','N',90000000009

create procedure SPU_PRODUCTOS_BUSCAR(
	@idproducto	int
)
as
begin
		select nombreproducto, descripcion, cantidad, precio, fechavencimiento, recetamedica
		from productos
		where idproducto = @idproducto
end
go

SELECT * FROM productos
go

create procedure spu_ventas_listar(
	@fechaventa date,
	@tipocomprobante varchar(20)
)
as
begin
	select idventa,
			@fechaventa,
			@tipocomprobante
		from ventas where fechaventa = @fechaventa
end
go

create procedure spu_ventas_buscar(
	@idproducto	INT	
)
as
begin
	select nombreproducto, descripcion, cantidad, precio, fechavencimiento, recetamedica
		from productos
		where idproducto = @idproducto
end
go

create procedure spu_ventas_registrar(
	@idventa int,
	@idcliente int,
	@fechaventa datetime,
	@tipocomprobante varchar(20)
)
as
begin
	insert into ventas (idventa, idcliente, fechaventa, tipocomprobante) values (@idventa, @idcliente, @fechaventa, @tipocomprobante)
end
go



-- ACTUALIZAR INVENTARIO (CAMBIAMOS LA CANTIDAD DEL PRODUCTO
-- DEPENDIENDO DE LA SUMA )
 
CREATE PROCEDURE SPU_INVENTARIO_ACTUALIZAR
@idpersona	INT,
@cantidad	SMALLINT

AS
	UPDATE productos SET
	cantidad = @cantidad
	WHERE idproducto = @idpersona

GO

EXEC SPU_INVENTARIO_ACTUALIZAR 3, 20
GO


-- LISTAR COMPRAS (PARA ACTUALIZAR EL INVENTARIO)

CREATE PROCEDURE SPU_COMPRAS_LISTAR
AS

	SELECT	PRO.idproducto,PRO.nombreproducto, 
			SUM(PRO.cantidad) +  SUM (DC.cantidad) AS totalInventario			
	FROM productos PRO
	INNER JOIN detalle_compras DC ON DC.idproducto = PRO.idproducto
	WHERE DAY(DC.fechadetalle) = DAY(GETDATE())
	GROUP BY PRO.idproducto, PRO.nombreproducto, DC.fechadetalle ,PRO.cantidad, DC.cantidad
	
GO


-- BUSCAR PRODUCTO POR BARCODE 

CREATE PROCEDURE SPU_BARCODE_BUSCAR
		@barcode VARCHAR(20)
AS
SELECT 
	CONCAT(nombreproducto,'/ ', descripcion)as Producto ,
	cantidad , precio 
	

	FROM productos
	WHERE barcode = @barcode
GO

exec SPU_BARCODE_BUSCAR '10000000001'
go

CREATE PROCEDURE SPU_PERSONAS_BUSCAR
	@dni	CHAR(8)
AS
SELECT 
	CONCAT(apellidos,', ',nombres) 
	FROM personas
	WHERE dni = @dni
GO

EXEC SPU_PERSONAS_BUSCAR '73196921'
GO

CREATE PROCEDURE SPU_EMPRESAS_BUSCAR
	@ruc	CHAR(11)
AS
	SELECT nombre
	FROM empresas
	WHERE ruc = @ruc
GO

EXEC SPU_EMPRESAS_BUSCAR '20693023598'
GO


-- REGISTRAR CLIENTE
CREATE PROCEDURE SPU_CLIENTE_REGISTRAR
	@nombres	VARCHAR(40),
	@apellidos	VARCHAR(40),
	@dni		CHAR(8)

AS
	INSERT INTO personas (nombres, apellidos, dni) VALUES
				(@nombres, @apellidos, @dni)

GO





--Procedimiento agregar Empresa 

CREATE PROCEDURE SPU_EMPRESA_REGISTRAR
(
	@nombre VARCHAR(50),
	@ruc	CHAR(20)
)
AS
BEGIN
	INSERT INTO empresas (nombre, ruc)
			VALUES (@nombre,@ruc)
END
GO

exec SPU_EMPRESA_REGISTRAR 'Real', 12345708905 
go


-- procedimiento registrar ventas

CREATE PROCEDURE SPU_REGISTRAR_VENTA
(	
	@idcliente		INT,
	@idusuario		INT,
	@idempresa		INT,
	@tipocomprobante VARCHAR(20),
	@idventa		INT,
	@idproducto		INT,
	@cantidad		SMALLINT, 
	@unidad			VARCHAR(30),
	@precioventa	DECIMAL(7,2)

)
AS
BEGIN
	INSERT INTO ventas (idcliente,idusuario,idempresa,tipocomprobante)
	VALUES(@idcliente,@idusuario,@idempresa,@tipocomprobante)
	INSERT INTO detalle_ventas(idventa,idproducto,cantidad,unidad,precioventa)
	VALUES(@idventa,@idproducto,@cantidad,@unidad,@precioventa)
END 

GO

EXEC SPU_REGISTRAR_VENTA  6, 1, NULL,'BLETA',1, 2, 1, 'BLISTER', 1.70

SELECT * FROM ventas
SELECT * FROM detalle_ventas


CREATE PROCEDURE	SPU_PERSONAS_REGISTRAR
	@nombres	VARCHAR(40),
	@apellidos	VARCHAR(40),
	@dni		CHAR(8),
	@telefono	CHAR(9)

AS
	INSERT INTO personas (nombres, apellidos, dni, telefono) VALUES
				(@nombres, @apellidos, @dni, @telefono)

GO


Create PROCEDURE SPU_PERSONAS_LISTAR
as
select top(1) idpersona, nombres , apellidos , dni, telefono
from personas
order by idpersona desc


go




CREATE  PROCEDURE SPU_USUARIO_REGISTRAR
	@idpersona INT,
	@nomusuarios VARCHAR(30),
	@claveacceso  VARCHAR(100)
AS
	INSERT INTO usuarios(idpersona, nomusuarios, claveacceso) values
	(@idpersona, @nomusuarios, @claveacceso)
	go




	
	





	

create procedure SPU_USUARIOS_LISTAR
as
select * from usuarios
go



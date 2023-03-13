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
@estado	BIT

AS
BEGIN
	SELECT 	idproducto, nombreproducto,descripcion, precio,
			cantidad, fechaproduccion, fechavencimiento,
			numlote, recetamedica
	FROM productos
	WHERE estado = @estado

END 
GO

EXEC SPU_PRODUCTOS_LISTAR 1
GO

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

EXEC SPU_CLIENTE_REGISTRAR 'Adriana Maria','Cuenca Palma','22223240'
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


CREATE TYPE [dbo].[detalle_Venta] AS TABLE(	
	[idproducto]	INT			NOT NULL,
	[cantidad]		SMALLINT	NOT NULL,
	[unidad]		VARCHAR(30)	NOT NULL,
	[precioVenta]	DECIMAL(7,2)NOT NULL
)
GO


CREATE PROCEDURE SPU_VENTA_REGISTRAR

@idcliente			INT ,
@idusuario			INT ,
@idempresa			INT ,
@tipocomprobante	VARCHAR(20)	,
@detalleVenta [detalle_Venta] READONLY
AS
	BEGIN TRY

		DECLARE @idventa  INT = 0
	
		-- REGISTRA TEMPORALMENTE LOS DATOS 
		BEGIN TRANSACTION registro

		INSERT INTO ventas (idcliente, idusuario, idempresa, tipocomprobante)
					VALUES(@idcliente, @idusuario, @idempresa, @tipocomprobante)
		
		-- ALMACENAMOS EL ID QUE SE GENERA EN VENTAS
		SET @idventa = SCOPE_IDENTITY()

		INSERT INTO detalle_ventas (idventa, idproducto, cantidad, unidad, precioventa)
		-- HACEMOS UNA CONSULTA AL PARAMETRO @detalleVenta
		SELECT @idventa, idproducto, cantidad, unidad, precioVenta  FROM @detalleVenta

		UPDATE PRO SET PRO.cantidad = PRO.cantidad - DV.cantidad
		FROM productos PRO
		INNER JOIN detalle_ventas DV ON DV.idproducto = PRO.idproducto

			
		-- SI LAS OPERACIONES TIENEN UN ERROR SE ELIMINA LOS REGISTROS TEMPORALES
		-- SI EL REGISTRO FUE CORRECTO PROCEDE A REGISTRARSE EN LA BD
		COMMIT TRANSACTION registro

	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION registro
	END CATCH

GO




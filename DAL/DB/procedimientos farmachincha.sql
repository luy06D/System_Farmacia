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

exec spu_usuarios_login 'Luy06' , 12345
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




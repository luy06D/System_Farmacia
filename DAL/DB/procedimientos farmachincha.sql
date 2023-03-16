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
SELECT	idproducto,
		CONCAT(nombreproducto,'/ ', descripcion)as Producto ,
		cantidad , precio 
		FROM productos
		WHERE barcode = @barcode
GO

exec SPU_BARCODE_BUSCAR '10000000001'
go

-- BUSCAR CLIENTE
CREATE PROCEDURE SPU_PERSONAS_BUSCAR
AS BEGIN
	SELECT idpersona,nombres, apellidos, dni, telefono
		FROM personas
		ORDER BY apellidos, nombres	
END
GO

EXEC SPU_PERSONAS_BUSCAR 
GO


-- BUSCAR PRODUCTOS PARA LA VENTA
CREATE PROCEDURE SPU_PRODUCTOS_LISTARVENTA
AS BEGIN 
		SELECT	idproducto,
				CONCAT(nombreproducto, ' ' ,descripcion) 'descripcion',
				cantidad, precio, recetamedica
		FROM productos
		WHERE cantidad > 0 
END
GO

EXEC SPU_PRODUCTOS_LISTARVENTA
GO


-- BUSCAR UNA EMPRESA EN FRMVENTAS
CREATE PROCEDURE SPU_EMPRESAS_BUSCAR
AS BEGIN

	SELECT idempresa, nombre , ruc
	FROM empresas
END
GO

EXEC SPU_EMPRESAS_BUSCAR 
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


-- procedimiento registrar ventas

CREATE PROCEDURE SPU_REGISTRAR_VENTA

@idventa			INT OUTPUT, -- VARIABLE DE SALIDA
@idcliente			INT,
@tipocomprobante	VARCHAR(20)
AS BEGIN 
		IF @idcliente = -1 SET @idcliente = NULL
	

		INSERT INTO ventas (idcliente, tipocomprobante)
			VALUES(@idcliente,  @tipocomprobante)

		-- Obtenemos el ultimo ID generado
		SET @idventa = @@IDENTITY
END
GO

-- Procedimiento para registrar el detalle de venta
CREATE PROCEDURE SPU_REGISTRAR_DETVENTA
	@idventa		INT,
	@idproducto		INT,
	@cantidad		SMALLINT,
	@unidad			VARCHAR(30),
	@precioventa	DECIMAL(7,2)
AS BEGIN 
	INSERT INTO detalle_ventas (idventa, idproducto, cantidad, unidad, precioventa)
		VALUES(@idventa, @idproducto, @cantidad, @unidad, @precioventa)

		UPDATE productos SET cantidad = cantidad - @cantidad WHERE idproducto = @idproducto
END
GO

-- Registrar persona para usuario
CREATE PROCEDURE	SPU_PERSONAS_REGISTRAR
	@nombres	VARCHAR(40),
	@apellidos	VARCHAR(40),
	@dni		CHAR(8),
	@telefono	CHAR(9)

AS
	INSERT INTO personas (nombres, apellidos, dni, telefono) VALUES
				(@nombres, @apellidos, @dni, @telefono)

GO


-- listar ultima persona registrada para usuario
Create PROCEDURE SPU_PERSONAS_LISTAR
as
select top(1) idpersona, nombres , apellidos , dni, telefono
from personas
order by idpersona desc

go


-- registrar una persona como usuario

CREATE  PROCEDURE SPU_USUARIO_REGISTRAR
	@idpersona INT,
	@nomusuarios VARCHAR(30),
	@claveacceso  VARCHAR(100)
AS
	INSERT INTO usuarios(idpersona, nomusuarios, claveacceso) values
	(@idpersona, @nomusuarios, @claveacceso)
GO


-- REGISTRA LOS PRODUCTOS 
CREATE PROCEDURE  SPU_REGISTRAR_PRODUCTOS    
    @idlaboratorio   	INT,
    @idcategoria   		INT,
    @nombreproducto   	VARCHAR(50),
    @descripcion   		VARCHAR(100),
    @precio           	DECIMAL(7,2),
    @cantidad       	SMALLINT,
    @fechaproduccion   	DATE,
    @fechavencimiento   DATE,
    @numlote            VARCHAR(15),
    @recetamedica   	CHAR(1),
    @barcode    VARCHAR(20)

AS BEGIN    	

			INSERT INTO productos(idlaboratorio, idcategoria,  nombreproducto, descripcion, precio, cantidad, fechaproduccion, fechavencimiento, numlote, recetamedica, barcode)
       				VALUES(@idlaboratorio, @idcategoria,  @nombreproducto, @descripcion, @precio, @cantidad,@fechaproduccion, @fechavencimiento, @numlote, @recetamedica, @barcode)
END
GO

-- LISTA LOS PRODUCTOS REGISTRADOS

CREATE PROCEDURE SPU_LISTAR_PRODUCTO
AS
        SELECT	idlaboratorio, idcategoria, nombreproducto, descripcion, 
				cantidad, precio, fechaproduccion,
                fechavencimiento, numlote, recetamedica, barcode
        FROM productos
GO

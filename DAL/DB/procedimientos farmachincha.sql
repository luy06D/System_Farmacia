use FARMACHINCHA
go

create procedure spu_usuarios_login(
@nomusuarios	VARCHAR(30),
@claveacceso	VARCHAR(100)
)
as
begin
	select	usuarios.idusuario,
			usuarios.nomusuarios, usuarios.claveacceso,
			personas.nombres, personas.apellidos
	from usuarios INNER JOIN personas on personas.idpersona = usuarios.idusuario
	where	usuarios.nomusuarios = @nomusuarios AND
			usuarios.claveacceso = @claveacceso AND
			usuarios.estado = 1
end
go

create procedure SPU_PRODUCTOS_LISTAR
as
begin
	select idproducto, nombreproducto, descripcion, cantidad, precio, fechavencimiento, recetamedica
	from productos
	where estado = 1
end
go

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


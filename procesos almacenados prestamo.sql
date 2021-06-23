--Procedimiento Listar
create proc Prestamo_listar
as
select idprestamo as ID,  nombre_docente as Docente, fecha_prestamo as Fecha
from Prestamo
order by idprestamo desc
go

--Procedimiento Buscar
create proc Prestamo_buscar
@valor varchar(50)
as
select idprestamo as ID, nombre_docente as Docente, fecha_prestamo as Fecha
from Prestamo
where nombre_docente like '%' + @valor + '%'
order by nombre_docente asc
go

--Procedimiento Insertar
create proc prestamo_insertar
@nombre varchar(50),
@fecha_prestamo datetime,
@fecha_vencimiento datetime
as
insert into Prestamo(nombre_docente,fecha_prestamo,fecha_vencimiento) values (@nombre,@fecha_prestamo,@fecha_vencimiento)
go

--Procedimiento Actualizar
create proc prestamo_actualizar
@idprestamo int,
@nombre_docente varchar(100),
@fecha_prestamo varchar(255),
@fecha_vencimiento varchar(255)
as
update Prestamo set nombre_docente=@nombre_docente, fecha_prestamo=@fecha_prestamo, fecha_vencimiento=@fecha_vencimiento
where idprestamo=@idprestamo
go

--Procedimiento Eliminar
create proc prestamo_eliminar
@idprestamo int
as
delete from Prestamo
where idprestamo=@idprestamo
go


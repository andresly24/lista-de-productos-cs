-- Usar la BASE de Datos de Objetos

use objetos;

-- CTRL KC - KU 

-- CREACION DE TABLAS
create table objetos(
id int identity (1,1) primary key,
item nvarchar(100),
precio float
)

-- INSERTION DE TABLAS

Insert into objetos values('Audifonos','9')

-- VER TABLAS

select * from objetos


-- Storaged Parameter

-- CREAR PROC

--create proc MostrarItems
--as
--select * from objetos
--go

--create proc InsertarItems
--@item nvarchar(100),
--@precio float
--as
--insert into objetos values (@item,@precio)
--go

--create proc EditarItems
--@id int,
--@item nvarchar(100),
--@precio float
--as
--update objetos set item=@item,precio=@precio
--where id=@id
--go

--create proc EliminarItems
--@iditem int
--as
--delete from objetos where id=@iditem
--go


--create proc ResetTable
--as
--begin
--	if Object_id('objetos','U') is not null
--	begin
--		drop table objetos;
--	end

--	create table objetos
--	(
--	id int identity (1,1) primary key,
--	item nvarchar(100),
--	precio float
--	)
--end

--create proc ResetTable
--as
--truncate table objetos;
--go


exec ResetTable
exec MostrarItems
exec EliminarItems 1
exec InsertarItems 'string','123'
exec EditarItems 1,'string','123'

-- ELIMINAR PROC
drop PROCEDURE ResetTable2


-- PERMISOS 
select * from fn_my_permissions(NULL, 'DATABASE');


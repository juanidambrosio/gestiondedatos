----- Creaci�n de Esquema ------

create schema ROAD_TO_PROYECTO
GO

----- Funciones -----
create function ROAD_TO_PROYECTO.SacarTildes(@Usuario nvarchar(255))
returns nvarchar(255)
as begin
return (replace(replace(replace(replace(replace (@Usuario, '�', 'a'),'�','e'),'�','i'),'�','o'),'�','u'))
end
GO

create function ROAD_TO_PROYECTO.SacarDosPuntos(@DosPuntos nvarchar(255))
returns nvarchar(255)
as begin
return replace(@DosPuntos,':',0)
end
GO

create function ROAD_TO_PROYECTO.OfertaGanadora(@Publicacion int, @Oferta numeric(18,2) )
returns int 
as begin
IF exists (select Publicacion_Cod from gd_esquema.Maestra where publicacion_cod=@Publicacion group by publicacion_cod having count(*)= 1)
  return 1
ELSE IF (select max(Oferta_Monto) from gd_esquema.Maestra where Publicacion_Cod = @Publicacion) = @Oferta
  return 1
  return 0
  end
 GO

------ Creaci�n de Tablas -----
PRINT 'Creando Tablas...'

--Domicilio
create table ROAD_TO_PROYECTO.Domicilio(
DomiId int identity(1,1) PRIMARY KEY,
Calle nvarchar(100),
Numero numeric(18,0),
Piso numeric(18,0),
Depto nvarchar(50),
CodPostal nvarchar(50),
Localidad nvarchar(100),
)
GO

--Usuario
create table ROAD_TO_PROYECTO.Usuario (
Usuario nvarchar(255) PRIMARY KEY,
Contrase�a nvarchar(255) NOT NULL,
Mail nvarchar(50),
Habilitado bit default 1,
Nuevo bit default 1,
Reputacion numeric(18,2),
FechaCreacion datetime,
Domicilio int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Domicilio,
LogsFallidos TinyInt
)
GO

--Rubro
create table ROAD_TO_PROYECTO.Rubro(
RubrId int identity(1,1) PRIMARY KEY,
DescripCorta nvarchar(80),
DescripLarga nvarchar(255)
)
GO

--Cliente
create table ROAD_TO_PROYECTO.Cliente (
ClieId int identity(1,1) PRIMARY KEY,
TipoDocumento nvarchar(5),
NroDocumento numeric(18,0),
Apellido nvarchar(255),
Nombres nvarchar(255),
FechaNacimiento datetime,
Telefono numeric(18,0),
CONSTRAINT Cliente_Tipo_Nro_Doc UNIQUE (TipoDocumento, NroDocumento)
)
GO

--Empresa
create table ROAD_TO_PROYECTO.Empresa(
EmprId int identity(1,1) PRIMARY KEY,
RazonSocial nvarchar(255),
CUIT nvarchar(50),
FechaCreacion datetime,
NombreContacto nvarchar(100),
Rubro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rubro,
Telefono numeric(18,0),
CONSTRAINT Empresa_Tipo_Nro_Doc UNIQUE (RazonSocial, CUIT)
) 
GO

--Rol
create table ROAD_TO_PROYECTO.Rol(
RolId int identity(1,1) PRIMARY KEY,
Nombre nvarchar(255) NOT NULL,
Habilitado bit default 1
)
GO

--Funciones
create table ROAD_TO_PROYECTO.Funcion(
FuncId int identity(1,1) PRIMARY KEY,
Descripcion nvarchar(255),
Funcion text
)
GO

--Funciones_Por_Rol
create table ROAD_TO_PROYECTO.Funciones_Por_Rol(
RolId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rol,
FuncId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Funcion,
PRIMARY KEY (RolId, FuncId)
)
GO

--Roles_Por_Usuario
create table ROAD_TO_PROYECTO.Roles_Por_Usuario(
UserId nvarchar(255) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario,
RolId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rol,
IdExterno int,
PRIMARY KEY (UserId, RolId)
)
GO

--Visibilidad
create table ROAD_TO_PROYECTO.Visibilidad(
VisiId int PRIMARY KEY,
Descripcion nvarchar(255),
ComiFija numeric (18,2),
ComiVariable numeric (18,2)
)
GO

--Estado
create table ROAD_TO_PROYECTO.Estado(
EstadoId int identity(1,1) PRIMARY KEY,
Descripcion nvarchar(50)
)
GO

--Tipo_Publicacion
create table ROAD_TO_PROYECTO.Tipo_Publicacion(
TipoPubliId int identity (1,1) PRIMARY KEY,
Descripcion nvarchar(255),
EnvioHabilitado bit default 0,
Comienvio numeric (18,2) default 0
)
GO

--Publicacion
create table ROAD_TO_PROYECTO.Publicacion(
PublId int PRIMARY KEY,
Descipcion nvarchar(255) NOT NULL,
Stock numeric(18,0) NOT NULL,
FechaInicio datetime NOT NULL,
FechaFin datetime NOT NULL,
Precio numeric(18,2) NOT NULL,
Visibilidad int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Visibilidad NOT NULL,
Rubro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rubro NOT NULL,
Tipo int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Tipo_Publicacion NOT NULL,
Estado int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Estado NOT NULL,
UserId nvarchar(255) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario NOT NULL
)
GO

--Transaccion
create table ROAD_TO_PROYECTO.Transaccion(
TranId int identity(1,1) PRIMARY KEY,
TipoTransac nvarchar(50),
Fecha datetime,
Cantidad numeric(18,0),
Monto numeric(18,2),
Ganadora bit default 0,
PubliId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Publicacion,
ClieId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Cliente
)
GO

--Calificacion
create table ROAD_TO_PROYECTO.Calificacion(
CaliId int PRIMARY KEY,
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion,
CantEstrellas numeric(18,0),
Descipcion nvarchar(255)
)
GO

--Factura
create table ROAD_TO_PROYECTO.Factura(
FactNro numeric(18,0) PRIMARY KEY,
PubliId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Publicacion,
Fecha datetime,
Monto numeric(18,2),
FormaPago nvarchar(255),
)
GO

--Item_Factura
create table ROAD_TO_PROYECTO.Item_Factura(
ItemId int identity(1,1) PRIMARY KEY,
FactNro numeric(18,0) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Factura,
Cantidad numeric(18,0),
Detalle nvarchar(255),
Monto numeric(18,2)
)
GO

----- Migraci�n de Datos -----
PRINT 'Comenzando Migraci�n de Datos...'

--Domicilios
PRINT 'Migrando Domicilios...'
insert into ROAD_TO_PROYECTO.Domicilio
select publ_empresa_dom_calle, publ_empresa_nro_calle,publ_empresa_piso,publ_empresa_depto,publ_empresa_cod_postal, NULL
from gd_esquema.Maestra
where publ_empresa_dom_calle is not null
group by publ_empresa_dom_calle, publ_empresa_nro_calle,publ_empresa_piso,publ_empresa_depto,publ_empresa_cod_postal
UNION
select Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal, NULL
from gd_esquema.Maestra
where Cli_Dom_Calle is not null
group by Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal
GO

--Usuarios 
PRINT 'Asignando Usuarios...'
insert into ROAD_TO_PROYECTO.Usuario
select ROAD_TO_PROYECTO.SacarTildes(LOWER(Cli_Apeliido+RIGHT(Cli_Nombre,1))),'password',Cli_Mail,1,0,NULL,getdate() as Fecha, (select DomiId from ROAD_TO_PROYECTO.Domicilio where RTRIM(Calle) like RTRIM(Cli_Dom_Calle) and Numero = Cli_Nro_Calle and Piso = Cli_Piso and Depto = Cli_Depto and CodPostal = Cli_Cod_Postal) as Domicilio, 0 
from gd_esquema.Maestra
where Cli_Apeliido is not null and Cli_Nombre is not null
group by Cli_Apeliido,Cli_Nombre,Cli_Mail,Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso,cli_depto,Cli_Cod_Postal
UNION
select ROAD_TO_PROYECTO.SacarDosPuntos(LOWER('razonsocial'+RIGHT(publ_empresa_razon_social,2))),'password',publ_empresa_mail,1,0,NULL,getdate(), (select DomiId from ROAD_TO_PROYECTO.Domicilio where RTRIM(Calle) like RTRIM(Publ_Empresa_Dom_Calle) and Numero = Publ_Empresa_Nro_Calle and Piso = Publ_Empresa_Piso and Depto = Publ_Empresa_Depto and CodPostal = Publ_Empresa_Cod_Postal), 0
from gd_esquema.Maestra
where publ_empresa_razon_social is not null
group by publ_empresa_razon_social,publ_empresa_mail, Publ_Empresa_Dom_Calle,Publ_empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal

--Rubros
PRINT 'Migrando Rubros...'
insert into ROAD_TO_PROYECTO.Rubro
select NULL,publicacion_rubro_descripcion
from gd_esquema.Maestra
where publicacion_rubro_descripcion is not null
group by Publicacion_Rubro_Descripcion
GO
  
--Cliente
PRINT 'Migrando Clientes...'
insert into ROAD_TO_PROYECTO.Cliente
select 'DNI', Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, NULL
from gd_esquema.Maestra
where Cli_Dni is not null
group by Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac
GO

--Empresa
PRINT 'Migrando Empresas...'
insert into ROAD_TO_PROYECTO.Empresa
select Publ_Empresa_Razon_Social, Publ_Empresa_Cuit, Publ_Empresa_Fecha_Creacion, NULL, NULL, NULL
from gd_esquema.Maestra
where Publ_Empresa_Cuit is not null
group by Publ_Empresa_Razon_Social, Publ_Empresa_Cuit, Publ_Empresa_Fecha_Creacion
order by Publ_Empresa_Razon_Social
GO

--Tal vez pueda determinar el rubro de la empresa segun el rubro de las publicaciones, igual es relativo

--Rol
PRINT 'Creando Roles...'
insert into ROAD_TO_PROYECTO.Rol values('Administrador',1)
insert into ROAD_TO_PROYECTO.Rol values('Cliente',1)
insert into ROAD_TO_PROYECTO.Rol values('Empresa',1)
GO

--Funciones
PRINT 'Creando Funciones...'
insert into ROAD_TO_PROYECTO.Funcion values('ABM Rol','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('ABM Usuario','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('ABM Visibilidad','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('ABM Rubro','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Generar Publicaci�n','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Comprar/Ofertar','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Historial de Cliente','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Calificar al Vendedor','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Consulta de facturas realizadas al vendedor','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Listado Estad�stico','Codigo en C# que habilite esta funcion')

--Funciones por rol
PRINT 'Creando Funciones Por Rol...'
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol select RolId,FuncId from ROAD_TO_PROYECTO.Rol,ROAD_TO_PROYECTO.Funcion where Nombre = 'Administrador' and Descripcion in ('ABM Rubro','ABM Rol','ABM Visibilidad','ABM Usuario')
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol select RolId,FuncId from ROAD_TO_PROYECTO.Rol,ROAD_TO_PROYECTO.Funcion where nombre = 'Cliente' and Descripcion in ('Generar Publicaci�n','Comprar/Ofertar','Historial de Cliente','Calificar al Vendedor','Consulta de facturas realizadas al vendedor','Listado Estad�stico')
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol select RolId,FuncId from ROAD_TO_PROYECTO.Rol,ROAD_TO_PROYECTO.Funcion where nombre = 'Empresa' and Descripcion in ('Generar Publicaci�n','Consulta de facturas realizadas al vendedor','Listado Estad�stico')
--Roles por usuario
PRINT 'Creando Roles por Usuario...'
insert into ROAD_TO_PROYECTO.Roles_Por_Usuario
select ROAD_TO_PROYECTO.SacarTildes(LOWER(Apellido+RIGHT(Nombres,1))), (select RolId from ROAD_TO_PROYECTO.Rol where Nombre = 'Cliente'), ClieId
from ROAD_TO_PROYECTO.Cliente
UNION
select ROAD_TO_PROYECTO.SacarDosPuntos(LOWER('razonsocial'+RIGHT(RazonSocial,2))), (select RolId from ROAD_TO_PROYECTO.Rol where Nombre = 'Empresa'), EmprId
from ROAD_TO_PROYECTO.Empresa
GO

--Visibilidad
PRINT 'Migrando Visibilidades...'
insert into ROAD_TO_PROYECTO.Visibilidad
select Publicacion_Visibilidad_Cod, Publicacion_Visibilidad_Desc, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
from gd_esquema.Maestra
where Publicacion_Visibilidad_Cod is not null
group by publicacion_visibilidad_cod, Publicacion_Visibilidad_Desc, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
GO

--Estado
PRINT 'Migrando Estados de publicaciones...'
insert into ROAD_TO_PROYECTO.Estado values('Borrador')
insert into ROAD_TO_PROYECTO.Estado values('Activa')
insert into ROAD_TO_PROYECTO.Estado values('Pausada')
insert into ROAD_TO_PROYECTO.Estado values('Finalizada')
GO

--Tipo_Publicacion
PRINT 'Migrando Tipos de publicaciones...'
insert into ROAD_TO_PROYECTO.Tipo_Publicacion
select Publicacion_Tipo, 0, 0
from gd_esquema.Maestra
where Publicacion_Tipo is not null
group by Publicacion_Tipo
GO

--Publicacion
PRINT 'Migrando publicaciones...'
insert into ROAD_TO_PROYECTO.Publicacion
select Publicacion_Cod, Publicacion_Descripcion, Publicacion_Stock, Publicacion_Fecha, Publicacion_Fecha_Venc, Publicacion_Precio, Publicacion_Visibilidad_Cod, (select RubrId from ROAD_TO_PROYECTO.Rubro where publicacion_rubro_descripcion = DescripLarga) as Rubro, (select TipoPubliId from ROAD_TO_PROYECTO.Tipo_Publicacion where Publicacion_Tipo = Descripcion) as TipoPublicacion, 3 as Estado, (select Usuario from ROAD_TO_PROYECTO.Usuario where Mail = Publ_Cli_Mail or Mail = Publ_Empresa_Mail) as Usuario
from gd_esquema.Maestra
where Publicacion_Cod is not null
group by Publicacion_Cod, Publicacion_Descripcion, Publicacion_Stock, Publicacion_Fecha, Publicacion_Fecha_Venc, Publicacion_Precio, Publicacion_Visibilidad_Cod, Publicacion_Rubro_Descripcion,Publ_Cli_Mail, Publicacion_Tipo, Publ_Empresa_Mail
GO

--Transaccion
PRINT 'Migrando transacciones...'
insert into ROAD_TO_PROYECTO.Transaccion
select 'Compra', Compra_Fecha, Compra_Cantidad, null, null, Publicacion_Cod, (select ClieId from ROAD_TO_PROYECTO.Cliente where Cli_Dni = NroDocumento)
from gd_esquema.Maestra
where Publicacion_Tipo = 'Compra Inmediata' and Compra_Fecha is not null 
group by publicacion_cod, Compra_Fecha, Compra_Cantidad, Cli_Dni
union
select 'Oferta', Oferta_Fecha, 1, Oferta_Monto, 0, Publicacion_Cod, (select ClieId from ROAD_TO_PROYECTO.Cliente where Cli_Dni = NroDocumento)
from gd_esquema.Maestra
where Publicacion_Tipo = 'Subasta' and Oferta_Fecha is not null
group by Publicacion_Cod, Oferta_Fecha, Oferta_Monto, Cli_Dni
GO

update t1 set Ganadora = 1
from ROAD_TO_PROYECTO.Transaccion t1
where TipoTransac = 'Oferta' and TranId in (select top 1 t2.TranId 
											from ROAD_TO_PROYECTO.Transaccion t2
											where t2.TipoTransac = 'Oferta' and t1.PubliId = t2.PubliId
											order by t2.PubliId, t2.Monto desc)

--Calificacion
insert into ROAD_TO_PROYECTO.Calificacion
select Calificacion_Codigo, t.TranId,Calificacion_Cant_Estrellas,Calificacion_Descripcion
from gd_esquema.Maestra gd,ROAD_TO_PROYECTO.TRANSACCION t,ROAD_TO_PROYECTO.Cliente c
where t.PubliId = gd.Publicacion_Cod and t.clieid = c.ClieId and c.NroDocumento = gd.Cli_Dni and t.fecha = Compra_Fecha and t.cantidad = Compra_Cantidad and gd.Calificacion_Cant_Estrellas is not null and (t.ganadora = 1 or t.tipotransac = 'Compra') 
GO

--Factura
insert into ROAD_TO_PROYECTO.Factura
select gd.Factura_Nro,Publicacion_Cod, gd.factura_fecha,gd.factura_total, gd.forma_pago_desc
from gd_esquema.Maestra gd
where  Factura_nro is not null 
group by factura_nro,Factura_Fecha,Factura_Total,Forma_Pago_Desc,Publicacion_Cod
GO

--FUNCIONES PARA MIGRAR ITEMS

create function ROAD_TO_PROYECTO.EspecificarDetalle(@Cantidad numeric(18,0), @Monto numeric(18,2), @PrecioVisibilidad numeric(18,2), @PorcentajeComision numeric(18,2), @PrecioPublicacion numeric(18,2))
returns nvarchar(255)
as begin
if @Monto = @PrecioVisibilidad
return 'Precio por tipo publicaci�n'
else if ROUND(@Monto,0) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0)
 or ROUND(@Monto,0) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0,1)
 or ROUND(@Monto,0,1) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0)
 or ROUND(@Monto,0,1) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0,1)
return 'Comisi�n por productos vendidos'
return NULL
end 
GO

--Item Factura
insert into ROAD_TO_PROYECTO.Item_Factura
select f.FactNro, gd.Item_Factura_Cantidad,ROAD_TO_PROYECTO.EspecificarDetalle(gd.Item_Factura_Cantidad,gd.Item_Factura_Monto,gd.Publicacion_Visibilidad_Precio,gd.Publicacion_Visibilidad_Porcentaje,gd.Publicacion_Precio), gd.Item_Factura_Monto
from gd_esquema.Maestra gd,ROAD_TO_PROYECTO.Factura f
where gd.Factura_Nro is not null and f.FactNro = gd.Factura_Nro and ROAD_TO_PROYECTO.EspecificarDetalle(gd.Item_Factura_Cantidad,gd.Item_Factura_Monto,gd.Publicacion_Visibilidad_Precio,gd.Publicacion_Visibilidad_Porcentaje,gd.Publicacion_Precio) is not null
GO

----- Stored Procedures -----
--Listado Roles
CREATE PROCEDURE ROAD_TO_PROYECTO.ListaRoles
	as
	begin
		select RolId, Nombre 
		from ROAD_TO_PROYECTO.Rol
		where Habilitado = 1
	end
GO

--Alta Rol
--CREATE PROCEDURE ROAD_TO_PROYECTO.AltaRol
--@Nombre nvarchar(255)
--@Funcion

--Listado Rubros
CREATE PROCEDURE ROAD_TO_PROYECTO.ListaRubros
	as
	begin
		select DescripLarga
		from ROAD_TO_PROYECTO.Rubro
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Usuario_Logs_Fallidos
	@Usuario nvarchar(255),
	@Contrase�a nvarchar(255)
	as
	begin
	if(select habilitado from ROAD_TO_PROYECTO.Usuario where @Usuario = Usuario)=1
	begin
		update ROAD_TO_PROYECTO.Usuario set LogsFallidos = LogsFallidos + 1
		where Usuario = @Usuario and Contrase�a != @Contrase�a
		update ROAD_TO_PROYECTO.Usuario set LogsFallidos = 0
		where Usuario = @Usuario and Contrase�a = @Contrase�a
	end
		update ROAD_TO_PROYECTO.Usuario set Habilitado = 0
		where LogsFallidos = 3
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Usuario_Login
	@username nvarchar(255),
	@password nvarchar(255)
	as
	begin 
		execute ROAD_TO_PROYECTO.Usuario_Logs_Fallidos @Usuario = @username, @Contrase�a = @password
		select u.Usuario as username, u.Contrase�a as password, u.Habilitado as habilitado, rpu.RolId as rol 
		from ROAD_TO_PROYECTO.Usuario u, ROAD_TO_PROYECTO.Roles_Por_Usuario rpu
		where Usuario = @username and Contrase�a = @password
		and u.Usuario = rpu.UserId
		
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Domicilio
	@Calle nvarchar(100),
	@Numero numeric(18,0),
	@Piso numeric(18,0),
	@Depto nvarchar(50),
	@CodPostal nvarchar(50),
	@Localidad nvarchar(100)
	as
	begin
		if(not exists(select * from ROAD_TO_PROYECTO.Domicilio where @Calle = Calle and @Numero = Numero and @Piso = Piso and @Depto = Depto and @CodPostal = CodPostal and @Localidad = Localidad))
		insert into ROAD_TO_PROYECTO.Domicilio
		values (@Calle, @Numero, @Piso, @Depto, @CodPostal, @Localidad)
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Cliente_Empresa
	@Usuario nvarchar(255),
	@RolAsignado nvarchar(255),
	@TipoDocumento nvarchar(5),
	@NroDocumento numeric(18,0),
	@Apellido nvarchar(255),
	@Nombres nvarchar(255),
	@FechaNacimiento datetime,
	@Telefono1 numeric(18,0),
	@RazonSocial nvarchar(255),
	@CUIT nvarchar(50),
	@FechaCreacion datetime,
	@NombreContacto nvarchar(100),
	@Rubro int,
	@Telefono2 numeric(18,0)

	as
	begin
		declare	@IdExterno int

		if(@RolAsignado = 'Cliente')
		begin
			insert into ROAD_TO_PROYECTO.Cliente (TipoDocumento, NroDocumento, Apellido, Nombres, FechaNacimiento, Telefono)
			values (@TipoDocumento, @NroDocumento, @Apellido, @Nombres, @FechaNacimiento, @Telefono1)
			
			select @IdExterno = SCOPE_IDENTITY()

			insert into ROAD_TO_PROYECTO.Roles_Por_Usuario (UserId, RolId, IdExterno)
			values (@Usuario, (select RolId from ROAD_TO_PROYECTO.Rol r where r.Nombre = @RolAsignado), @IdExterno)
		end
		if(@RolAsignado = 'Empresa')
		begin
			insert into ROAD_TO_PROYECTO.Empresa (RazonSocial, CUIT, FechaCreacion, NombreContacto, Rubro, Telefono)
			values (@RazonSocial, @CUIT, @FechaCreacion, @NombreContacto, (select RubrId from ROAD_TO_PROYECTO.Rubro r where r.DescripLarga = @Rubro), @Telefono2)
			
			select @IdExterno = SCOPE_IDENTITY()

			insert into ROAD_TO_PROYECTO.Roles_Por_Usuario (UserId, RolId, IdExterno)
			values (@Usuario, (select RolId from ROAD_TO_PROYECTO.Rol r where r.Nombre = @RolAsignado), @IdExterno)
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Usuario
	@Usuario nvarchar(255),
	@Contrase�a nvarchar(255),
	@Mail nvarchar(50),
	@RolAsignado nvarchar(255)
	as
	begin
		if(not exists(select * from ROAD_TO_PROYECTO.Usuario u where u.Usuario = @Usuario))
		begin
			insert into ROAD_TO_PROYECTO.Usuario (Usuario, Contrase�a, Mail, Habilitado, Nuevo, Reputacion, FechaCreacion,/*Domicilio,*/ LogsFallidos)
			values (@Usuario, @Contrase�a, @Mail, 1, 1, null, GETDATE(), 0)
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Domicilio_Usuario
	@Usuario nvarchar(255),
	@Calle nvarchar(100),
	@Numero numeric(18,0),
	@Piso numeric(18,0),
	@Depto nvarchar(50),
	@CodPostal nvarchar(50),
	@Localidad nvarchar(100)
	as
	begin
		update ROAD_TO_PROYECTO.Usuario 
		set Domicilio = (select top 1 DomiId from ROAD_TO_PROYECTO.Domicilio
						where Calle = @Calle and Numero = @Numero and Piso = @Piso and Depto = @Depto and CodPostal = @CodPostal and Localidad = @Localidad)
		where Usuario = @Usuario
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Cambiar_Contrase�a
	@Usuario nvarchar(255),
	@Contrase�a nvarchar(255),
	@Contrase�aNueva nvarchar(255)
	as
	begin
		if(exists(select * from ROAD_TO_PROYECTO.Usuario where @Usuario = Usuario and @Contrase�a = Contrase�a))
		begin
			update ROAD_TO_PROYECTO.Usuario set Contrase�a = @Contrase�aNueva
			where @Usuario = Usuario and @Contrase�a = Contrase�a
		end
	end
GO

----- Triggers -----
----- Creación de Esquema ------

create schema ROAD_TO_PROYECTO
GO

------ Creación de Tablas -----

--Usuario
create table ROAD_TO_PROYECTO.Usuario (
Usuario nvarchar(50) PRIMARY KEY,
Contraseña nvarchar(50) NOT NULL,
Mail nvarchar(50),
Habilitado bit default 1,
Nuevo bit default 1,
Reputacion numeric(18,2),
FechaCreacion datetime,
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

--Cliente
create table ROAD_TO_PROYECTO.Cliente (
ClieId int identity(1,1) PRIMARY KEY,
TipoDocumento nvarchar(5),
NroDocumento numeric(18,0),
Apellido nvarchar(255),
Nombres nvarchar(255),
FechaNacimiento datetime,
Telefono numeric(18,0),
Domicilio int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Domicilio,
CONSTRAINT Unique_Tipo_Nro_Doc UNIQUE (TipoDocumento, NroDocumento)
)
GO

--Empresa
create table ROAD_TO_PROYECTO.Empresa(
EmprId int identity(1,1) PRIMARY KEY,
RazonSocial nvarchar(255),
CUIT nvarchar(50),
NombreContacto nvarchar(100),
Rubro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rubro,
Telefono numeric(18,0),
Domicilio int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Domicilio
CONSTRAINT Unique_Tipo_Nro_Doc UNIQUE (RazonSocial, CUIT)
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
UserId nvarchar(50) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario,
RolId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rol,
IdExterno int,
PRIMARY KEY (UserId, RolId)
)
GO

--Visibilidad
create table ROAD_TO_PROYECTO.Visibilidad(
VisiId int PRIMARY KEY,
ComiFija numeric (18,2),
ComiVariable numeric (18,2),
EnvioHabilitado bit default 0,
Comienvio numeric (18,2)
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
Tipo nvarchar(255) NOT NULL,
Estado nvarchar(20) NOT NULL,
Preguntas bit default 0,
Costo numeric(18,2),
UserId nvarchar(50) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario NOT NULL
)
GO

--Transaccion
create table ROAD_TO_PROYECTO.Transaccion(
TranId int identity(1,1) PRIMARY KEY,
Fecha datetime,
PubliId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Publicacion,
ClieId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Cliente
)
GO

--Oferta
create table ROAD_TO_PROYECTO.Oferta(
OferId int identity(1,1) PRIMARY KEY,
Monto numeric(18,2),
Ganadora bit default 0,
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion
)
GO

--Compra
create table ROAD_TO_PROYECTO.Compra(
CompId int identity(1,1) PRIMARY KEY,
Cantidad numeric(18,0),
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion
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
FactNro numeric(18,0) identity(1,1) PRIMARY KEY,
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion,
Fecha datetime,
Monto numeric(18,2),
FormaPago nvarchar(255),
)
GO

--Item_Factura
create table ROAD_TO_PROYECTO.Item_Factura(
FactNro numeric(18,0) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Factura,
NroRenglon int,
Cantidad numeric(18,0),
Detalle nvarchar(255),
Monto numeric(18,2)
PRIMARY KEY (FactNro, NroRenglon)
)
GO

----- Migración de Datos -----

--Usuarios
insert into ROAD_TO_PROYECTO.Usuario
select ROAD_TO_PROYECTO.SacarTildes(LOWER (Cli_Apellido+RIGHT(Cli_Nombre,1))),'password',Cli_Mail,1,0,NULL,getdate(),0 
from gd_esquema.Maestra
where Cli_Apellido is not null and Cli_Nombre is not null
group by Cli_Apellido,Cli_Nombre,Cli_Mail
UNION
select ROAD_TO_PROYECTO.SacarDosPuntos(LOWER('razonsocial'+RIGHT(publ_empresa_razon_social,2))),'password',publ_empresa_mail,1,0,NULL,getdate(),0
from gd_esquema.Maestra
where publ_empresa_razon_social is not null
group by publ_empresa_razon_social,publ_empresa_mail

--Rubros
insert into ROAD_TO_PROYECTO.Rubro
select NULL,publicacion_rubro_descripcion
from gd_esquema.Maestra
group by Publicacion_Rubro_Descripcion
GO

--Domicilios
insert into ROAD_TO_PROYECTO.Domicilio
select publ_cli_dom_calle,publ_cli_nro_calle,publ_cli_piso,publ_cli_depto,Publ_Cli_Cod_Postal, NULL
from gd_esquema.Maestra
where publ_cli_dom_calle is not null
group by publ_cli_dom_calle,publ_cli_nro_calle,publ_cli_piso,publ_cli_depto,Publ_Cli_Cod_Postal
UNION
select publ_empresa_dom_calle, publ_empresa_nro_calle,publ_empresa_piso,publ_empresa_depto,publ_empresa_cod_postal, NULL
from gd_esquema.Maestra
where publ_empresa_dom_calle is not null
group by publ_empresa_dom_calle, publ_empresa_nro_calle,publ_empresa_piso,publ_empresa_depto,publ_empresa_cod_postal
GO  
-- CAPAZ HABRIA QUE VALIDAR SI YA EXISTE EL DOMICILIO PERO EN LA TABLA MAESTRA SON NADA QUE VER LOS DOM DE EMPRESA CON LOS DE CLIENTES

--Cliente
--Empresa

--Rol
insert into ROAD_TO_PROYECTO.Rol values('Administrador',1)
insert into ROAD_TO_PROYECTO.Rol values('Cliente',1)
insert into ROAD_TO_PROYECTO.Rol values('Empresa',1)
GO

--Funciones
--Funciones por rol
--Roles por usuario
--Visibilidad
--Publicacion
--Transaccion
--Oferta
--Compra
--Calificacion
--Factura
--Item Factura




----- Stored Procedures -----

----- Triggers -----

----- Funciones -----
create function ROAD_TO_PROYECTO.SacarTildes(@Usuario nvarchar(255))
returns nvarchar(255)
as begin
return (replace(replace(replace(replace(replace (@Usuario, 'á', 'a'),'é','e'),'í','i'),'ó','o'),'ú','u'))
end
GO

create function ROAD_TO_PROYECTO.SacarDosPuntos(@DosPuntos nvarchar(255))
returns nvarchar(255)
as begin
return replace(@DosPuntos,':',0)
end
GO
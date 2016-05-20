----- Creación de Esquema ------

create schema ROAD_TO_PROYECTO
GO

------ Creación de Tablas -----

--Usuario
create table ROAD_TO_PROYECTO.Usuario (
Username nvarchar(50) PRIMARY KEY,
Password nvarchar(50),
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
Nombre nvarchar(255),
Habilitado bit
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
VisiId int identity(1,1) PRIMARY KEY,
ComiFija numeric (18,2),
ComiVariable numeric (18,2),
EnvioHabilitado bit,
Comienvio numeric (18,2)
)
GO

--Publicacion
create table ROAD_TO_PROYECTO.Publicacion(
PublId int identity(1,1) PRIMARY KEY,
Descipcion nvarchar(255),
Stock numeric(18,0),
FechaInicio datetime,
FechaFin datetime,
Precio numeric(18,2),
Visibilidad int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Visibilidad,
Rubro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rubro,
Tipo nvarchar(255),
Estado nvarchar(20),
Preguntas bit,
Costo numeric(18,2),
UserId nvarchar(50) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario
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
Ganadora bit,
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
CaliId int identity(1,1) PRIMARY KEY,
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion,
CantEstrellas numeric(18,0),
Descipcion nvarchar(255)
)
GO

--Factura
create table ROAD_TO_PROYECTO.Factura(
FactNro int identity(1,1) PRIMARY KEY,
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion,
Fecha datetime,
Monto numeric(18,2),
FormaPago nvarchar(255),
)
GO

--Item_Factura
create table ROAD_TO_PROYECTO.Item_Factura(
FactNro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Factura,
NroRenglon int,
Cantidad numeric(18,0),
Detalle nvarchar(255),
Monto numeric(18,2)
PRIMARY KEY (FactNro, NroRenglon)
)
GO

----- Migración de Datos -----

----- Stored Procedures -----

----- Triggers -----

----- Funciones -----


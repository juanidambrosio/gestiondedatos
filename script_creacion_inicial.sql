-- Creación de Esquema

create schema ROAD_TO_PROYECTO
GO

-- Creación de Tablas

--Cliente
create table ROAD_TO_PROYECTO.Cliente (
Cliente int identity (1,1),
TipoDocumento char(3),
NroDocumento int,
Apellido varchar(50),
Nombres varchar (50),
FechaNacimiento datetime,
Telefono int,
Domicilio int
)
GO

alter table ROAD_TO_PROYECTO.Cliente add constraint PK_Cliente PRIMARY KEY (Cliente,TipoDocumento,NroDocumento)
GO
--Empresa
create table ROAD_TO_PROYECTO.Empresa(
Empresa int identity (1,1) PRIMARY KEY,
RazonSocial varchar(100),
CUIT char(13),
NombreContacto varchar(50),
Rubro int,
Telefono numeric (30,0),
Domicilio int
) 
GO



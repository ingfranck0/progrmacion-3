CREATE DATABASE empresa;
use empresa;
CREATE TABLE CLIENTES(
Dni INT IDENTITY(1,1)  PRIMARY KEY not null,
Nombre varchar(50) not null,
Apellidos varchar(50) not null,
FechaNac date not null,
Tlfn varchar(10) not null,
CONSTRAINT  CHK_TEL CHECK (ISNUMERIC(Tlfn) =1)
);
CREATE TABLE PROVEDORES(
Nif INT IDENTITY (1,1) PRIMARY KEY  not null,
Nombre Varchar(50) not null,
Direccion varchar(100)
);
CREATE TABLE PRODUCTOS(
Codigo INT IDENTITY(1,1) PRIMARY  KEY not null,
Nombre Varchar(50) not null,
precio money,
nifProvedor int not null,
CONSTRAINT fk_nifProvedor FOREIGN KEY (nifProvedor) references PROVEDORES (Nif)
);
CREATE TABLE COMPRA(
 DniCliente int not null,
 CodProducto int not null,
CONSTRAINT fk_DniCliente FOREIGN KEY (DniCliente) references CLIENTES (Dni),
CONSTRAINT fk_CodProducto FOREIGN KEY (CodProducto) references PRODUCTOS (Codigo)
);
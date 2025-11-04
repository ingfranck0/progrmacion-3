create database UNI;
use  UNI;

-- Tabla Catálogo de Centros de Trabajo
CREATE TABLE CentroTrabajo (
    NumeroCentro CHAR(6) PRIMARY KEY,
    NombreCentro VARCHAR(100),
    Ciudad VARCHAR(100)
);

-- Tabla Base: Empleados
CREATE TABLE Empleado (
    NumeroEmpleado INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    ApellidoPaterno NVARCHAR(50) NOT NULL,
    ApellidoMaterno NVARCHAR(50),
    FechaNacimiento DATE NOT NULL,
    RFC AS (
        UPPER(LEFT(ApellidoPaterno, 2) + 
              LEFT(ApellidoMaterno, 1) + 
              LEFT(Nombre, 1) + 
              RIGHT(CONVERT(CHAR(8), FechaNacimiento, 112), 6)
        )
    ) PERSISTED,
    NumeroCentro INT NOT NULL,
    ID_Puesto INT NOT NULL,
    Directivo BIT DEFAULT 0,



CREATE TABLE Directivo (
    NumeroEmpleado INT PRIMARY KEY,
    CentroQueSupervisa CHAR(6),
    PrestacionCombustible BIT,
    FOREIGN KEY (NumeroEmpleado) REFERENCES Empleado(NumeroEmpleado),
    FOREIGN KEY (CentroQueSupervisa) REFERENCES CentroTrabajo(NumeroCentro)
);


CREATE TABLE Puesto(
NPuesto INT PRIMARY KEY,
Puesto varchar(50),
Descripcion varchar(100)
);
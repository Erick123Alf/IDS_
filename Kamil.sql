CREATE DATABASE Kamil
GO

USE Kamil

CREATE TABLE Empleado(
NumeroEmpleado INT PRIMARY KEY NOT NULL,
Nombre VARCHAR (100) NOT NULL,
ApellidoPaterno VARCHAR (50) NOT NULL,
ApellidoMaterno VARCHAR (50),
FechaNacimiento DATE NOT NULL,
RFC VARCHAR(20) NOT NULL,
CentroTrabajo VARCHAR (15) NOT NULL,
Puesto VARCHAR (100) NOT NULL,
DescripPuesto VARCHAR (100) NOT NULL,
Directivo BIT NOT NULL
);



CREATE TABLE Directivo (
NumeroEmpleado INT PRIMARY KEY NOT NULL,
Centro_Supervision INT NOT NULL,
Prestacion_Combustible BIT NOT NULL
);

CREATE TABLE Catalogo(
NumeroCentro INT PRIMARY KEY NOT NULL, 
NombreCentro VARCHAR(100) NOT NULL,
Ciudad VARCHAR(100) NOT NULL
);

INSERT INTO Catalogo(NumeroCentro, NombreCentro, Ciudad) 
VALUES ('000201', 'Tiendas Angel Flores Ropa', 'Culiacan'),
		('000202', 'Tiendas Angel Flores Muebles', 'Culiacan'),
		('000203', 'Tiendas Angel Flores Cajas', 'Culiacan'),
		('049001', 'La Primavera Ropa', 'Culiacan'),
		('049002', 'La Primavera Muebles', 'Cualiacan'),
		('049003', 'La Pimavera Cajas', 'Culiacan');



SELECT * FROM Empleado;
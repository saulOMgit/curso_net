--CREAR TABLA
CREATE TABLE Alumnos
(
Codigo int NOT NULL PRIMARY KEY Identity(1,1),
Nombre varchar(30) NOT NULL,
DNI varchar(10) NOT NULL,
Turno varchar(10) NOT NULL,
Sexo varchar(10),
Repetidor bit,
Modulo varchar(10) NOT NULL,
Especialidad varchar(25)
);
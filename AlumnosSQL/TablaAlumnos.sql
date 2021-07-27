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


--Procedimientos
	--1 El proceso de gestón de dar bajas, altas y modificaciones de alumnos
	--utilizar comandos de SQL y cadena conexión

	--2 El usuario podrá realizar búsquedas por código y por DNIA, tambien con procedimientos de comando SQL.
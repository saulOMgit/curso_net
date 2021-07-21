--Insertar
CREATE PROCEDURE insertarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
INSERT INTO Clientes(Nombre,Apellido1,Apellido2,Telefno)
VALUES(@Nombre,@Apellido1,@Apellido2,@telefono)
GO
EXEC insertarcliente 'ANTONIO','HALCÓN','PATINAMOGOLLÓN','1980'

--Modificar
CREATE PROCEDURE Modificarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
UPDATE Clientes
SET Nombre=@Nombre,Apellido1=@Apellido1,Apellido2=@Apellido2,Telefno=@telefono
WHERE Nombre=@Nombre

EXEC Modificarcliente 'PEPE','EL','GRIS','XXXXXX'

--ELIMINAR
CREATE PROCEDURE EliminarCliente
@Nombre varchar(50)
AS
DELETE FROM Clientes WHERE @Nombre=Nombre

EXEC EliminarCliente 'PEPE'

--BUSCAR
CREATE PROCEDURE buscarcliente
@Nombre varchar(50)
AS
SELECT * FROM Clientes WHERE Nombre LIKE '%'+@Nombre+'%'

EXEC buscarcliente 'PEPE'
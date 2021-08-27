use EXAMEN
--Procedimiento para Añadir
CREATE PROCEDURE sp_AñadirProducto
@NOMPROD varchar(20),
@PRECIO decimal(20,2),
@STOCK int
AS
INSERT PRODUCTOS(NombreProducto,PrecioUnidad,UnidadStock)
VALUES(@NOMPROD,@PRECIO,@STOCK)
GO
EXEC sp_AñadirProducto 'Aprobado',10,99
--Procedimiento para modificar
CREATE PROCEDURE sp_ModificaProducto
@NOMPROD varchar(20),
@PRECIO decimal(20,2),
@STOCK int
AS
UPDATE PRODUCTOS
SET NombreProducto=@NOMPROD,PrecioUnidad=@PRECIO,UnidadStock=@STOCK
WHERE NombreProducto=@NOMPROD
--Procedimiento para eliminar
CREATE PROCEDURE sp_EliminarProducto
@NOMPROD varchar(20)
AS
DELETE FROM PRODUCTOS WHERE @NOMPROD=NombreProducto
--Procedimiento para buscar
CREATE PROCEDURE sp_BuscarCliente
@NOMPROD varchar(20)
AS
SELECT * FROM PRODUCTOS WHERE NombreProducto LIKE '%'+@NOMPROD+'%'
GO
EXEC sp_BuscarCliente 'Aprobado'

--Procedimiento para el grid
CREATE PROCEDURE ListarTodos
AS
SELECT * 
FROM PRODUCTOS

--Procedimiento para el combo

CREATE PROCEDURE listarCombo
AS
SELECT NombreProducto
FROM PRODUCTOS
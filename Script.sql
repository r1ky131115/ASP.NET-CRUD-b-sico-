﻿USE MVC_DAPPER

CREATE TABLE Productos (
	Id int IDENTITY(1,1) not null,
	Nombre VARCHAR(50),
	Precio DECIMAL (18,2)
)

CREATE PROCEDURE InsertarProducto
@Nombre VARCHAR(50),
@Precio DECIMAL (18,2)
AS BEGIN
INSERT INTO Productos VALUES(@Nombre, @Precio)
END


CREATE PROCEDURE EliminarProducto
@Id INT
AS BEGIN
DELETE FROM Productos WHERE Id=@Id
END


CREATE PROCEDURE ActualizarProducto
@Id INT,
@Nombre VARCHAR(50),
@Precio DECIMAL (18,2)
AS BEGIN
UPDATE Productos SET Nombre=@Nombre, Precio=@Precio WHERE Id=@Id
END

CREATE PROCEDURE ObtenerProductoPorId
@Id INT
AS BEGIN
SELECT * FROM Productos WHERE Id=@Id
END


CREATE PROCEDURE ObtenerProductos
AS BEGIN
SELECT * FROM Productos
END

CREATE TABLE Clientes (
    IdCliente INT IDENTITY PRIMARY KEY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Documento NVARCHAR(20),
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15)
);

CREATE TABLE Articulos (
    IdArticulo INT IDENTITY PRIMARY KEY,
    Codigo NVARCHAR(50),
    Nombre NVARCHAR(50),
    Descripcion NVARCHAR(200),
    Precio FLOAT,
    Stock INT
);

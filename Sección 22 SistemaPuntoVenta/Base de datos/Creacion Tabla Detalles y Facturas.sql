USE [SistemaPuntoDeVenta];
GO

-- ========================================
-- 🧾 TABLA FACTURAS
-- ========================================
IF OBJECT_ID('dbo.Facturas', 'U') IS NOT NULL
    DROP TABLE dbo.Facturas;
GO

CREATE TABLE dbo.Facturas (
    NumeroFactura INT IDENTITY(1,1) PRIMARY KEY,  -- 🔑 Clave primaria autoincremental
    FechaFactura DATE NOT NULL DEFAULT GETDATE(), -- 📅 Fecha por defecto actual
    CodigoCliente INT NOT NULL,                   -- 🔗 FK con Clientes
    CONSTRAINT FK_Facturas_Clientes FOREIGN KEY (CodigoCliente)
        REFERENCES dbo.Clientes(IdCliente)
);
GO

-- ========================================
-- 📦 TABLA DETALLES
-- ========================================
IF OBJECT_ID('dbo.Detalles', 'U') IS NOT NULL
    DROP TABLE dbo.Detalles;
GO

CREATE TABLE dbo.Detalles (
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,     -- 🔑 Clave primaria
    NumeroFactura INT NOT NULL,                  -- 🔗 FK con Facturas
    CodigoProducto INT NOT NULL,                 -- 🔗 FK con Productos
    PrecioVenta FLOAT NOT NULL,
    CantidadVendida FLOAT NOT NULL,
    CONSTRAINT FK_Detalles_Facturas FOREIGN KEY (NumeroFactura)
        REFERENCES dbo.Facturas(NumeroFactura),
    CONSTRAINT FK_Detalles_Productos FOREIGN KEY (CodigoProducto)
        REFERENCES dbo.Articulos(IdArticulo)
);
GO

USE [SistemaPuntoDeVenta];
GO

IF OBJECT_ID('dbo.DatosFactura', 'P') IS NOT NULL
    DROP PROCEDURE dbo.DatosFactura;
GO

CREATE PROCEDURE dbo.DatosFactura
    @NumeroFactura INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        F.NumeroFactura,
        F.FechaFactura,
        C.IdCliente,
        C.Nombre AS NombreCliente,
        C.Apellido AS ApellidoCliente,
        A.IdArticulo AS CodigoProducto,
        A.Nombre AS NombreProducto,
        D.PrecioVenta,
        D.CantidadVendida,
        (D.PrecioVenta * D.CantidadVendida) AS TotalDetalle
    FROM Facturas F
        INNER JOIN Detalles D ON F.NumeroFactura = D.NumeroFactura
        INNER JOIN Articulos A ON D.CodigoProducto = A.IdArticulo
        INNER JOIN Clientes C ON F.CodigoCliente = C.IdCliente
    WHERE F.NumeroFactura = @NumeroFactura;
END;
GO

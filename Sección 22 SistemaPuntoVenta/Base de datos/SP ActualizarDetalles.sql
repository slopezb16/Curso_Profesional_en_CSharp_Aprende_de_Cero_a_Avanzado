USE [SistemaPuntoDeVenta];
GO

IF OBJECT_ID('dbo.ActualizarDetalles', 'P') IS NOT NULL
    DROP PROCEDURE dbo.ActualizarDetalles;
GO

CREATE PROCEDURE dbo.ActualizarDetalles
    @NumeroFactura INT,
    @CodigoProducto INT,
    @PrecioVenta FLOAT,
    @CantidadVendida FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Detalles (NumeroFactura, CodigoProducto, PrecioVenta, CantidadVendida)
    VALUES (@NumeroFactura, @CodigoProducto, @PrecioVenta, @CantidadVendida);
END;
GO

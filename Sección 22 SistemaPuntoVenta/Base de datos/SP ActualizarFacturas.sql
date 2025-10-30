USE [SistemaPuntoDeVenta];
GO

IF OBJECT_ID('dbo.ActualizarFacturas', 'P') IS NOT NULL
    DROP PROCEDURE dbo.ActualizarFacturas;
GO

CREATE PROCEDURE dbo.ActualizarFacturas
    @CodigoCliente INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NumeroFactura INT;

    -- 🧮 Crear nueva factura
    INSERT INTO Facturas (FechaFactura, CodigoCliente)
    VALUES (GETDATE(), @CodigoCliente);

    -- 📋 Obtener el número generado (IDENTITY)
    SET @NumeroFactura = SCOPE_IDENTITY();

    -- 🔙 Devolver la factura recién creada
    SELECT * FROM Facturas WHERE NumeroFactura = @NumeroFactura;
END;
GO

CREATE PROCEDURE EliminarClientes
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Clientes
    WHERE IdCliente = @IdCliente;
END;
GO

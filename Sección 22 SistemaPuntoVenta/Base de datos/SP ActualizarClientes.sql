CREATE PROCEDURE ActualizarClientes
    @IdCliente INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Si no existe el cliente, lo inserta
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE IdCliente = @IdCliente)
    BEGIN
        INSERT INTO Clientes (Nombre, Apellido)
        VALUES (@Nombre, @Apellido);
    END
    ELSE
    BEGIN
        -- Si existe, actualiza los datos
        UPDATE Clientes
        SET Nombre = @Nombre,
            Apellido = @Apellido
        WHERE IdCliente = @IdCliente;
    END
END;
GO

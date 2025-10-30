CREATE PROCEDURE ActualizarArticulos
    @IdArticulo INT,
    @Codigo NVARCHAR(50),
    @Nombre NVARCHAR(50),
    @Descripcion NVARCHAR(200),
    @Precio FLOAT,
    @Stock INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Si el artículo no existe, se inserta
    IF NOT EXISTS (SELECT 1 FROM Articulos WHERE IdArticulo = @IdArticulo)
    BEGIN
        INSERT INTO Articulos (Codigo, Nombre, Descripcion, Precio, Stock)
        VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock);
    END
    ELSE
    BEGIN
        -- Si existe, se actualiza
        UPDATE Articulos
        SET Codigo = @Codigo,
            Nombre = @Nombre,
            Descripcion = @Descripcion,
            Precio = @Precio,
            Stock = @Stock
        WHERE IdArticulo = @IdArticulo;
    END
END;
GO

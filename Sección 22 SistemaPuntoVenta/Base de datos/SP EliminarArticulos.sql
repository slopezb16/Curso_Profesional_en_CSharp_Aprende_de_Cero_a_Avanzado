CREATE PROCEDURE EliminarArticulos
    @IdArticulo INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Articulos
    WHERE IdArticulo = @IdArticulo;
END;
GO

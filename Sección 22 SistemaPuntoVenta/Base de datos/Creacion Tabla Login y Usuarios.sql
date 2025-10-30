USE SistemaPuntoDeVenta;
GO

-- 1️⃣ Crear la tabla Usuarios
CREATE TABLE dbo.Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Account NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);
GO

-- 2️⃣ Insertar usuario administrador
INSERT INTO dbo.Usuarios (Username, Account, Password)
VALUES ('Administrador', 'admin', 'admin123');
GO

-- 3️⃣ Verificar que se haya insertado correctamente
SELECT * FROM dbo.Usuarios;
GO

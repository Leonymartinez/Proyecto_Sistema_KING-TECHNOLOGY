CREATE DATABASE KingTechnologyDB;
GO

USE KingTechnologyDB;
GO

CREATE TABLE Categorias (
    IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(80) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    FechaRegistro DATETIME NOT NULL,
    IdCategoria INT NOT NULL,
    FOREIGN KEY (IdCategoria) REFERENCES Categorias(IdCategoria)
);
GO

INSERT INTO Categorias (Nombre, Descripcion) VALUES
('Computación', 'Computadoras y monitores'),
('Accesorios', 'Teclados, mouse y memorias'),
('Impresión', 'Impresoras y suministros'),
('Redes', 'Cables y equipos de red');
GO

INSERT INTO Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria) VALUES
('Teclado mecánico', 25000.00, 15, GETDATE(), 2),
('Mouse inalámbrico', 12000.00, 30, GETDATE(), 2),
('Monitor 24 pulgadas', 95000.00, 8, GETDATE(), 1),
('Impresora multifunción', 120000.00, 5, GETDATE(), 3),
('Cable de red 5 metros', 3500.00, 50, GETDATE(), 4),
('Memoria USB 64GB', 6000.00, 40, GETDATE(), 2);
GO
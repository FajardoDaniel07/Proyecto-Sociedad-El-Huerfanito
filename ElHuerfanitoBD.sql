-- 1. CREACIÓN DE LA BASE DE DATOS CON NUEVO NOMBRE
CREATE DATABASE SociedadElHuerfanito;
GO
USE SociedadElHuerfanito;
GO



CREATE TABLE Rol (
    id_rol INT PRIMARY KEY, -- Se ingresará manualmente
    nombre VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Usuario (
    id_usuario INT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    id_rol INT NOT NULL,

    CONSTRAINT FK_Usuario_Rol
    FOREIGN KEY (id_rol)
    REFERENCES Rol(id_rol)
);
GO

CREATE TABLE TipoMascota (
    id_tipo INT PRIMARY KEY, -- Corregida la coma faltante aquí
    nombre VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Mascota (
    id_mascota INT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    id_tipo INT NOT NULL,
    raza VARCHAR(100),
    edad_meses INT,
    sexo VARCHAR(20),
    estado VARCHAR(50) DEFAULT 'Disponible',

    CONSTRAINT FK_Mascota_Tipo
    FOREIGN KEY (id_tipo)
    REFERENCES TipoMascota(id_tipo)
);
GO

CREATE TABLE Adoptante (
    id_adoptante INT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    direccion VARCHAR(150)
);
GO

CREATE TABLE Adopcion (
    id_adopcion INT PRIMARY KEY,
    id_mascota INT NOT NULL,
    id_adoptante INT NOT NULL,
    fecha DATE NOT NULL,
    estado VARCHAR(50) DEFAULT 'Activa',

    CONSTRAINT FK_Adopcion_Mascota
    FOREIGN KEY (id_mascota)
    REFERENCES Mascota(id_mascota),

    CONSTRAINT FK_Adopcion_Adoptante
    FOREIGN KEY (id_adoptante)
    REFERENCES Adoptante(id_adoptante)
);
GO

-- 3. CREACIÓN DE LA VISTA
CREATE VIEW vw_MascotasDisponibles
AS
SELECT 
    m.id_mascota,
    m.nombre,
    t.nombre AS tipo,
    m.raza,
    m.edad_meses,
    m.sexo,
    m.estado
FROM Mascota m
INNER JOIN TipoMascota t
ON m.id_tipo = t.id_tipo
WHERE m.estado = 'Disponible';
GO

-- 4. INSERCIÓN DE DATOS (Especificando los IDs manualmente)

INSERT INTO Rol(id_rol, nombre)
VALUES 
(1, 'Administrador'),
(2, 'Empleado');
GO

INSERT INTO Usuario(id_usuario, username, password_hash, id_rol)
VALUES
(1, 'admin', '123456', 1),
(2, 'empleado1', '123456', 2);
GO

INSERT INTO TipoMascota(id_tipo, nombre)
VALUES
(1, 'Perro'),
(2, 'Gato'),
(3, 'Conejo');
GO

INSERT INTO Mascota(id_mascota, nombre, id_tipo, raza, edad_meses, sexo)
VALUES
(1, 'Max', 1, 'Labrador', 24, 'Macho'),
(2, 'Luna', 2, 'Siames', 12, 'Hembra'),
(3, 'Coco', 3, 'Mini Lop', 8, 'Macho');
GO

INSERT INTO Adoptante(id_adoptante, nombre, telefono, direccion)
VALUES
(1, 'Carlos Perez', '3001234567', 'Medellin'),
(2, 'Ana Gomez', '3019876543', 'Envigado');
GO

-- Nota: Usamos GETDATE() para la fecha actual
INSERT INTO Adopcion(id_adopcion, id_mascota, id_adoptante, fecha)
VALUES
(1, 1, 1, CAST(GETDATE() AS DATE));
GO

-- 5. PRUEBAS Y VERIFICACIÓN

-- Ver mascotas disponibles (Deberían salir Max, Luna y Coco)
SELECT * FROM vw_MascotasDisponibles;
GO

-- Actualizar estado de Max porque ya fue adoptado
UPDATE Mascota SET estado = 'Adoptada' WHERE id_mascota = 1;
GO

-- Ver mascotas disponibles nuevamente (Ya no debería salir Max)
SELECT * FROM vw_MascotasDisponibles;
GO
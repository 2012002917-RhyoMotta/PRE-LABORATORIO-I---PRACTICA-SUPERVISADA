-- CREACIÓN DE LA BASE DE DATOS:
-- CREATE DATABASE: Comando para crear una nueva base de datos en MySQL
-- IF NOT EXISTS: Cláusula condicional que evita errores si la BD ya existe
-- sistema_renta_peliculas: Nombre asignado a nuestra base de datos
-- Los paréntesis son opcionales en CREATE DATABASE pero se incluyen para claridad
-- El punto y coma (;) marca el final de esta instrucción SQL
CREATE DATABASE IF NOT EXISTS sistema_renta_peliculas;

-- SELECCIÓN DE LA BASE DE DATOS:
-- USE: Comando para especificar qué base de datos usaremos en las siguientes operaciones
-- sistema_renta_peliculas: Nombre de la base de datos que acabamos de crear
-- El punto y coma (;) finaliza esta instrucción
USE sistema_renta_peliculas;

-- CREACIÓN DE TABLA direccion:
-- CREATE TABLE: Inicia la definición de una nueva tabla
-- direccion: Nombre de la tabla que almacenará información de ubicación
-- (): Los paréntesis encierran todas las definiciones de columnas
-- idDireccion: Primera columna que servirá como clave primaria
-- INT(11): Tipo de dato entero con display width de 11 dígitos
-- PRIMARY KEY: Especifica que esta columna identificará registros únicos
-- Direccion: Segunda columna para almacenar la dirección física
-- VARCHAR(45): Tipo de dato para cadenas de texto con máximo 45 caracteres
-- Ciudad: Tercera columna para el nombre de la ciudad
-- Pais: Cuarta columna para el nombre del país
-- Cada definición de columna está separada por comas (,)
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE direccion (
    idDireccion INT(11) PRIMARY KEY,
    Direccion VARCHAR(45),
    Ciudad VARCHAR(45),
    Pais VARCHAR(45)
);

-- CREACIÓN DE TABLA categoria:
-- CREATE TABLE: Inicia la definición de la tabla de categorías
-- categoria: Nombre de la tabla para clasificar películas
-- idCategoria: Clave primaria de tipo entero
-- Nombre: Campo para el nombre de la categoría (texto hasta 45 caracteres)
-- El punto y coma (;) finaliza la instrucción
CREATE TABLE categoria (
    idCategoria INT(11) PRIMARY KEY,
    Nombre VARCHAR(45)
);

-- CREACIÓN DE TABLA peliculas:
-- CREATE TABLE: Inicia la definición de la tabla principal
-- peliculas: Nombre de la tabla que almacenará información de películas
-- idPeliculas: Clave primaria de tipo entero
-- Nombre: Título de la película (texto hasta 45 caracteres)
-- Duracion: Duración en minutos (entero)
-- Descripcion: Campo de texto largo para la sinopsis
-- Año: Año de lanzamiento (entero)
-- Categoria_idCategoria: Clave foránea que relaciona con la tabla categoria
-- FOREIGN KEY: Define la relación con otra tabla
-- REFERENCES: Especifica la tabla (categoria) y columna (idCategoria) referenciada
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE peliculas (
    idPeliculas INT(11) PRIMARY KEY,
    Nombre VARCHAR(45),
    Duracion INT(11),
    Descripcion TEXT,
    Año INT(11),
    Categoria_idCategoria INT(11),
    FOREIGN KEY (Categoria_idCategoria) REFERENCES categoria(idCategoria)
);

-- CREACIÓN DE TABLA cliente:
-- CREATE TABLE: Inicia la definición de la tabla de clientes
-- cliente: Nombre de la tabla que almacenará información de clientes
-- idCliente: Clave primaria de tipo entero
-- Nombre: Primer nombre del cliente (texto hasta 45 caracteres)
-- Apellido: Apellido del cliente (texto hasta 45 caracteres)
-- Edad: Edad del cliente (entero)
-- Direccion_idDireccion: Clave foránea que relaciona con la tabla direccion
-- FOREIGN KEY: Define la relación con la tabla direccion
-- REFERENCES: Especifica la tabla (direccion) y columna (idDireccion) referenciada
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE cliente (
    idCliente INT(11) PRIMARY KEY,
    Nombre VARCHAR(45),
    Apellido VARCHAR(45),
    Edad INT(11),
    Direccion_idDireccion INT(11),
    FOREIGN KEY (Direccion_idDireccion) REFERENCES direccion(idDireccion)
);

-- CREACIÓN DE TABLA inventario:
-- CREATE TABLE: Inicia la definición de la tabla de inventario
-- inventario: Nombre de la tabla que controla las copias físicas
-- idCopiasPeliculas: Clave primaria de tipo entero
-- Peliculas_idPeliculas: Clave foránea que relaciona con la tabla peliculas
-- FOREIGN KEY: Define la relación con la tabla peliculas
-- REFERENCES: Especifica la tabla (peliculas) y columna (idPeliculas) referenciada
-- Disponible: Campo booleano (0 = no disponible, 1 = disponible)
-- TINYINT(1): Tipo de dato para valores booleanos en MySQL
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE inventario (
    idCopiasPeliculas INT(11) PRIMARY KEY,
    Peliculas_idPeliculas INT(11),
    Disponible TINYINT(1),
    FOREIGN KEY (Peliculas_idPeliculas) REFERENCES peliculas(idPeliculas)
);

-- CREACIÓN DE TABLA renta:
-- CREATE TABLE: Inicia la definición de la tabla de rentas
-- renta: Nombre de la tabla que registra las transacciones de alquiler
-- idRenta: Clave primaria de tipo entero
-- Fecha_Renta: Fecha cuando se alquiló la película (tipo DATE)
-- Fecha_Entrega: Fecha cuando se devolvió la película (tipo DATE)
-- Inventario_idCopiasPeliculas: Clave foránea a la tabla inventario
-- Cliente_idCliente: Clave foránea a la tabla cliente
-- Dos FOREIGN KEY: Para las dos relaciones con otras tablas
-- REFERENCES: Especifica tablas y columnas referenciadas en cada relación
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE renta (
    idRenta INT(11) PRIMARY KEY,
    Fecha_Renta DATE,
    Fecha_Entrega DATE,
    Inventario_idCopiasPeliculas INT(11),
    Cliente_idCliente INT(11),
    FOREIGN KEY (Inventario_idCopiasPeliculas) REFERENCES inventario(idCopiasPeliculas),
    FOREIGN KEY (Cliente_idCliente) REFERENCES cliente(idCliente)
);

-- CREACIÓN DE TABLA actores (NUEVA TABLA):
-- CREATE TABLE: Inicia la definición de la tabla de actores
-- actores: Nombre de la nueva tabla para el punto 7 del requerimiento
-- idActor: Clave primaria de tipo entero
-- Nombre: Primer nombre del actor (texto hasta 45 caracteres)
-- Apellido: Apellido del actor (texto hasta 45 caracteres)
-- FechaNacimiento: Fecha de nacimiento (tipo DATE)
-- Nacionalidad: País de origen del actor (texto hasta 45 caracteres)
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE actores (
    idActor INT(11) PRIMARY KEY,
    Nombre VARCHAR(45),
    Apellido VARCHAR(45),
    FechaNacimiento DATE,
    Nacionalidad VARCHAR(45)
);

-- CREACIÓN DE TABLA peliculas_actores (NUEVA TABLA):
-- CREATE TABLE: Inicia la definición de la tabla de relación
-- peliculas_actores: Nombre de la tabla que relaciona películas con actores
-- idRelacion: Clave primaria de tipo entero
-- Peliculas_idPeliculas: Clave foránea a la tabla peliculas
-- Actores_idActor: Clave foránea a la tabla actores
-- Personaje: Nombre del personaje que interpretó el actor (texto hasta 45 caracteres)
-- Dos FOREIGN KEY: Para las relaciones con películas y actores
-- REFERENCES: Especifica tablas y columnas referenciadas en cada relación
-- El punto y coma (;) finaliza la creación de la tabla
CREATE TABLE peliculas_actores (
    idRelacion INT(11) PRIMARY KEY,
    Peliculas_idPeliculas INT(11),
    Actores_idActor INT(11),
    Personaje VARCHAR(45),
    FOREIGN KEY (Peliculas_idPeliculas) REFERENCES peliculas(idPeliculas),
    FOREIGN KEY (Actores_idActor) REFERENCES actores(idActor)
);

-- INSERCIÓN DE DATOS EN TABLA direccion:
-- INSERT INTO: Comando para insertar nuevos registros en una tabla
-- direccion: Nombre de la tabla destino
-- (idDireccion, Direccion, Ciudad, Pais): Lista de columnas que recibirán valores
-- VALUES: Palabra clave que precede a los valores a insertar
-- Cada conjunto de valores va entre paréntesis y separado por comas
-- 5 registros de ejemplo con información de direcciones
-- Cada registro tiene: id (entero), dirección (texto), ciudad (texto), país (texto)
-- El punto y coma (;) finaliza la instrucción de inserción
INSERT INTO direccion (idDireccion, Direccion, Ciudad, Pais) VALUES
(1, 'Calle Principal 123', 'Ciudad de México', '12345'),
(2, 'Avenida Revolución 456', 'Guadalajara', '67890'),
(3, 'Boulevard Los Heroes 789', 'Monterrey', '54321'),
(4, 'Calle Morelos 321', 'Puebla', '98765'),
(5, 'Avenida Juárez 654', 'Tijuana', '13579');

-- INSERCIÓN DE DATOS EN TABLA categoria:
-- INSERT INTO: Comando para insertar en tabla categoria
-- (idCategoria, Nombre): Columnas que recibirán valores
-- VALUES: Precede los 5 registros de categorías de películas
-- Cada registro tiene: id (entero) y nombre de categoría (texto)
-- El punto y coma (;) finaliza la instrucción
INSERT INTO categoria (idCategoria, Nombre) VALUES
(1, 'Acción'),
(2, 'Comedia'),
(3, 'Drama'),
(4, 'Ciencia Ficción'),
(5, 'Animación');

-- INSERCIÓN DE DATOS EN TABLA peliculas:
-- INSERT INTO: Comando para insertar en tabla peliculas
-- Se especifican todas las columnas: id, nombre, duración, descripción, año y categoría
-- VALUES: Precede los 5 registros de películas de ejemplo
-- Cada registro tiene valores para todos los campos en el orden especificado
-- Categoria_idCategoria debe coincidir con IDs existentes en tabla categoria
-- El punto y coma (;) finaliza la instrucción
INSERT INTO peliculas (idPeliculas, Nombre, Duracion, Descripcion, Año, Categoria_idCategoria) VALUES
(1, 'POKEMON1', 120, 'Aventuras de Pikachu y sus amigos', 1998, 5),
(2, 'El Viaje de Juliana', 95, 'Drama familiar', 2020, 3),
(3, 'Rápidos y Furiosos', 110, 'Carreras ilegales', 2001, 1),
(4, 'Risas Eternas', 88, 'Comedia familiar', 2019, 2),
(5, 'Galaxia Lejana', 135, 'Aventura espacial', 2022, 4);

-- INSERCIÓN DE DATOS EN TABLA cliente:
-- INSERT INTO: Comando para insertar en tabla cliente
-- (idCliente, Nombre, Apellido, Edad, Direccion_idDireccion): Columnas destino
-- VALUES: Precede los 5 registros de clientes de ejemplo
-- Cada registro tiene: id, nombre, apellido, edad y referencia a dirección
-- Direccion_idDireccion debe coincidir con IDs existentes en tabla direccion
-- El punto y coma (;) finaliza la instrucción
INSERT INTO cliente (idCliente, Nombre, Apellido, Edad, Direccion_idDireccion) VALUES
(1, 'Juan', 'Pérez', 25, 1),
(2, 'María', 'Gómez', 30, 2),
(3, 'Juliana', 'Ramírez', 22, 3),
(4, 'Carlos', 'López', 28, 4),
(5, 'Ana', 'Martínez', 35, 5);

-- INSERCIÓN DE DATOS EN TABLA inventario:
-- INSERT INTO: Comando para insertar en tabla inventario
-- (idCopiasPeliculas, Peliculas_idPeliculas, Disponible): Columnas destino
-- VALUES: Precede los 5 registros de copias de películas
-- Cada registro tiene: id, referencia a película y estado de disponibilidad (0/1)
-- Peliculas_idPeliculas debe coincidir con IDs existentes en tabla peliculas
-- El punto y coma (;) finaliza la instrucción
INSERT INTO inventario (idCopiasPeliculas, Peliculas_idPeliculas, Disponible) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 0),
(4, 4, 1),
(5, 5, 1);

-- INSERCIÓN DE DATOS EN TABLA renta:
-- INSERT INTO: Comando para insertar en tabla renta
-- (idRenta, Fecha_Renta, Fecha_Entrega, Inventario_idCopiasPeliculas, Cliente_idCliente): Columnas
-- VALUES: Precede los 5 registros de transacciones de alquiler
-- Cada registro tiene: id, fechas de renta y entrega, referencia a inventario y cliente
-- Las fechas en formato 'YYYY-MM-DD' (estándar SQL)
-- Las referencias deben coincidir con IDs existentes en tablas relacionadas
-- El punto y coma (;) finaliza la instrucción
INSERT INTO renta (idRenta, Fecha_Renta, Fecha_Entrega, Inventario_idCopiasPeliculas, Cliente_idCliente) VALUES
(1, '2023-01-15', '2023-01-20', 1, 1),
(2, '2023-02-10', '2023-02-15', 2, 2),
(3, '2023-03-05', '2023-03-10', 3, 3),
(4, '2023-04-20', '2023-04-25', 4, 4),
(5, '2023-05-15', '2023-05-20', 5, 5);

-- INSERCIÓN DE DATOS EN TABLA actores (NUEVA TABLA):
-- INSERT INTO: Comando para insertar en la nueva tabla actores
-- (idActor, Nombre, Apellido, FechaNacimiento, Nacionalidad): Columnas destino
-- VALUES: Precede los 5 registros de actores de ejemplo
-- Cada registro tiene: id, nombre, apellido, fecha de nacimiento y nacionalidad
-- Las fechas en formato 'YYYY-MM-DD' (estándar SQL)
-- El punto y coma (;) finaliza la instrucción
INSERT INTO actores (idActor, Nombre, Apellido, FechaNacimiento, Nacionalidad) VALUES
(1, 'Robert', 'Downey Jr.', '1965-04-04', 'Estadounidense'),
(2, 'Scarlett', 'Johansson', '1984-11-22', 'Estadounidense'),
(3, 'Juliana', 'Moore', '1960-12-03', 'Estadounidense'),
(4, 'Dwayne', 'Johnson', '1972-05-02', 'Estadounidense'),
(5, 'Margot', 'Robbie', '1990-07-02', 'Australiana');

-- INSERCIÓN DE DATOS EN TABLA peliculas_actores (NUEVA TABLA):
-- INSERT INTO: Comando para insertar en la nueva tabla de relación
-- (idRelacion, Peliculas_idPeliculas, Actores_idActor, Personaje): Columnas destino
-- VALUES: Precede los 5 registros que relacionan películas con actores
-- Cada registro tiene: id, referencia a película, referencia a actor y nombre de personaje
-- Las referencias deben coincidir con IDs existentes en tablas relacionadas
-- El punto y coma (;) finaliza la instrucción
INSERT INTO peliculas_actores (idRelacion, Peliculas_idPeliculas, Actores_idActor, Personaje) VALUES
(1, 3, 4, 'Luke Hobbs'),
(2, 2, 3, 'María González'),
(3, 5, 2, 'Capitana Vega'),
(4, 4, 5, 'Lisa Johnson'),
(5, 1, 1, 'Dr. Pikachu (voz)');

-- CONSULTA PARA MOSTRAR TODOS LOS DATOS:
-- SELECT * FROM: Comando para seleccionar todas las columnas de una tabla
-- Cada instrucción muestra el contenido completo de una tabla diferente
-- Se ejecutan secuencialmente para mostrar: direccion, categoria, peliculas, cliente,
-- inventario, renta, actores y peliculas_actores
-- Cada SELECT es una instrucción independiente terminada con punto y coma (;)
SELECT * FROM direccion;
SELECT * FROM categoria;
SELECT * FROM peliculas;
SELECT * FROM cliente;
SELECT * FROM inventario;
SELECT * FROM renta;
-- Adicion de 2 Tablas
SELECT * FROM actores;
SELECT * FROM peliculas_actores;

-- CONSULTA PARA BUSCAR "JULIANA" EN TABLAS RELEVANTES:
-- SELECT: Inicia una consulta para buscar coincidencias
-- 'Cliente' AS tipo: Crea columna temporal con valor constante 'Cliente'
-- idCliente AS id: Muestra el ID del cliente con alias 'id'
-- CONCAT(Nombre, ' ', Apellido) AS nombre: Combina nombre y apellido en una columna llamada nombre
-- FROM cliente: Especifica la tabla de origen
-- WHERE Nombre LIKE '%Juliana%': Filtra registros donde el nombre contenga 'Juliana'
-- '%Juliana%' significa:
--     1. El primer % = puede haber cualquier texto antes de "Juliana" (o nada)
--     2. "Juliana" = debe aparecer exactamente así en el nombre
--     3. El segundo % = puede haber cualquier texto después de "Juliana" (o nada)
-- UNION ALL: Combina con resultados de otra consulta similar (mantiene duplicados)
-- La segunda parte busca en películas donde el título contenga 'Juliana'
-- La tercera parte busca en actores cuyo nombre contenga 'Juliana'
-- Cada parte del UNION ALL debe tener el mismo número y tipo de columnas
-- El punto y coma (;) finaliza toda la instrucción compuesta
SELECT 'Cliente' AS tipo, idCliente AS id, CONCAT(Nombre, ' ', Apellido) AS nombre 
FROM cliente 
WHERE Nombre LIKE '%Juliana%'

UNION ALL

SELECT 'Película' AS tipo, idPeliculas AS id, Nombre 
FROM peliculas 
WHERE Nombre LIKE '%Juliana%'

UNION ALL

SELECT 'Actor/Actriz' AS tipo, idActor AS id, CONCAT(Nombre, ' ', Apellido) AS nombre
FROM actores
WHERE Nombre LIKE '%Juliana%';

-- ELIMINACIÓN LÓGICA DE POKEMON1 USANDO UPDATE:
-- UPDATE: Comando para modificar registros existentes
-- peliculas: Tabla que contiene los registros a modificar
-- SET Nombre = null: Asigna como vacía al campo Nombre (eliminación lógica)
-- WHERE Nombre = 'POKEMON1': Condición que selecciona solo ese registro específico
-- Esto mantiene todos los demás campos y relaciones intactas
-- El punto y coma (;) finaliza la instrucción
UPDATE peliculas 
SET Nombre = null 
WHERE Nombre = 'POKEMON1';

-- VERIFICACIÓN DEL CAMBIO:
-- SELECT * FROM peliculas: Muestra todo el contenido de la tabla peliculas
-- Permite confirmar visualmente que:
-- 1. El registro que era POKEMON1 ahora tiene nombre vacío
-- 2. Todos los demás campos (ID, duración, etc.) se mantienen igual
-- 3. La relación con categoría (ID 5 - Animación) se preserva
-- El punto y coma (;) finaliza la instrucción
SELECT * FROM peliculas;

-- CONSULTA PARA ORDENAR CATEGORÍAS ASCENDENTEMENTE:
-- SELECT * FROM categoria: Selecciona todas las columnas de la tabla categoria
-- ORDER BY Nombre ASC: Ordena los resultados por el campo Nombre en orden A-Z
-- ASC es opcional (es el orden por defecto) pero se incluye para claridad
-- El punto y coma (;) finaliza la instrucción
SELECT * FROM categoria ORDER BY Nombre ASC;

-- CONSULTA PARA ORDENAR PELÍCULAS POR AÑO DESCENDENTEMENTE:
-- SELECT * FROM peliculas: Selecciona todas las columnas de la tabla peliculas
-- ORDER BY Año DESC: Ordena los resultados por el campo Año en orden Z-A (nuevas primero)
-- DESC es necesario para invertir el orden por defecto (ascendente)
-- El punto y coma (;) finaliza la instrucción
SELECT * FROM peliculas ORDER BY Año DESC;
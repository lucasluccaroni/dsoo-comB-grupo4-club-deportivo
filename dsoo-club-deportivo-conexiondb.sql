/*
Comision B
Grupo 4
Integrantes:
	- Faigenbom, Ivan
	- Flores, Mauro
	- Grau, Judith
	- Jara, Matias
	- Luccaroni, Lucas
*/


-- ~~~~~~~~~~~~~~~~~~~~~~~~ CREACION Y USO DE LA DB ~~~~~~~~~~~~~~~~~~~~~~~~ 
-- DROP DATABASE IF EXISTS Dsoo_club_deportivo;
CREATE DATABASE Dsoo_club_deportivo;
USE Dsoo_club_deportivo;



-- ~~~~~~~~~~~~~~~~~~~~~~~~ ROLES ~~~~~~~~~~~~~~~~~~~~~~~~ 
-- Roles de usuarios que usen el sistema
CREATE TABLE Roles(
RolUsu INT,
NomRol VARCHAR(30),
CONSTRAINT pk_roles PRIMARY KEY (RolUsu)
);

INSERT INTO ROLES VALUES
(999, "Administrador");



-- ~~~~~~~~~~~~~~~~~~~~~~~~ USUARIOS ~~~~~~~~~~~~~~~~~~~~~~~~
-- Usuarios que usan el sistema
CREATE TABLE Usuario(
CodUsu INT AUTO_INCREMENT,
NombreUsu VARCHAR(20) NOT NULL,
PassUsu VARCHAR(15) NOT NULL,
RolUsu INT,
Activo BOOLEAN DEFAULT TRUE,
CONSTRAINT pk_usuario PRIMARY KEY (CodUsu),
CONSTRAINT fk_usuario FOREIGN KEY (RolUsu) REFERENCES Roles (RolUsu)
);

INSERT INTO Usuario (CodUsu, NombreUsu, PassUsu, RolUsu) VALUES
(001, "ivan.faigenbom", "ivan123", 999),
(002, "mauro.flores", "mauro123", 999),
(003, "judith.grau", "judith123", 999),
(004, "matias.jara", "matias123", 999),
(005, "lucas.luccaroni", "lucas123", 999);



-- ~~~~~~~~~~~~~~~~~~~~~~~~ SOCIOS ~~~~~~~~~~~~~~~~~~~~~~~~
-- DROP TABLE Socio;
-- Creacion de tabla Socios
CREATE TABLE Socio(
IdSocio INT,
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Email VARCHAR(30),
Dni VARCHAR(20),
Direccion VARCHAR(30),
FechaNac DATE,
Telefono INT,
FichaMedica TINYINT,
FechaInscripcion DATE,
CONSTRAINT pk_socio PRIMARY KEY (IdSocio)
);

-- SELECT * FROM Socio;



-- ~~~~~~~~~~~~~~~~~~~~~~~~ NO SOCIOS ~~~~~~~~~~~~~~~~~~~~~~~~
-- DROP TABLE NoSocio;
-- Creacion de tabla NoSocios
CREATE TABLE NoSocio(
IdNoSocio INT,
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Email VARCHAR (30),
Dni VARCHAR(20),
Direccion VARCHAR(30),
FechaNac DATE,
Telefono INT,
FichaMedica TINYINT,
CONSTRAINT pk_nosocio PRIMARY KEY (IdNoSocio)
);

-- SELECT * FROM NoSocio;



-- ~~~~~~~~~~~~~~~~~~~~~~~~ ACTIVIDADES ~~~~~~~~~~~~~~~~~~~~~~~~
-- Actividades
CREATE TABLE Actividad(
IdActividad INT,
Nombre VARCHAR(30),
CupoMaximo INT,
Precio FLOAT,
CONSTRAINT pk_actividad PRIMARY KEY (IdActividad)
);

-- Inserción de actividades
INSERT INTO Actividad VALUES
(8900, "Zumba", 20, 18000),
(8901, "Karate", 25, 20000),
(8902, "Pilates", 10, 19000),
(8903, "Spinning", 15, 18500),
(8904, "Elongación", 30, 15000),
(8905, "HIT", 15, 17000);
-- SELECT * FROM Actividad;
-- DROP TABLE Actividad;



-- ~~~~~~~~~~~~~~~~~~~~~~~~ PROFESORES ~~~~~~~~~~~~~~~~~~~~~~~~
-- DROP TABLE Profesor;
CREATE TABLE Profesor(
IdProfesor INT AUTO_INCREMENT,
Condicion VARCHAR(15),
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Email VARCHAR (30),
Dni VARCHAR(20),
Direccion VARCHAR(50),
FechaNac DATE,
Telefono INT,
FichaMedica TINYINT,
CONSTRAINT pk_profesor PRIMARY KEY (IdProfesor)
);

INSERT INTO Profesor VALUES
(1800, "Titular", "Carlos", "Perez", "carlosperez80@gmail.com", "29995712", "Santa Fe 1800, Belgrano, CABA", "1980-11-02", "1178553695", 1),
(1801, "Titular", "Josefina", "Aguirre", "jaguirre@gmail.com", "38662897", "M.J. Haedo 2524, Florida, Vicente Lopez", "1992-05-30", "1132147771", 1),
(1802, "Titular", "Sergio", "Malek", "maleksergio1@gmail.com", "35222443", "Av. Centenario 5569, San Isidro", "1985-07-12", "1155588702", 1),
(1803, "Titular", "Carla", "Sigmo", "sigmocar@gmail.com", "39001234", "Bulnes 1238, Saavedra, CABA", "1990-08-01", "1100965858", 1),
(1804, "Titular", "Juan", "Medina", "juan_medina80@gmail.com", "406981212", "Estanislao Del Campo, Almagro, CABA", "1995-01-20", "1161038801", 1),
(1805, "Titular", "Adrian", "Pineda", "adripineda80@gmail.com", "41885965", "Carlos Villate 1889, Munro, Vicente Lopez", "1999-03-10", "1178789699", 1),
(1806, "Suplente", "Micaela", "Monsalvo,", "mica_monsalvo@gmail.com", "47183221", "Juan B. Justo 4345, Beccar, San Iisdro", "2003-02-22", "1185296301", 1),
(1807, "Suplente", "Maximo", "Beltran,", "beltran_maximo1992@gmail.com", "36111211", "Nicolas Avellaneda 5587, Villa Devoto, CABA", "1992-09-28", "1174102536", 1),
(1808, "Suplente", "Nerea", "Orlami,", "nereaorlami@gmail.com", "41222958", "Carrasco 6565, Caballito, CABA", "2000-07-12", "1198674512", 1);
-- SELECT * FROM Profesor;



-- ~~~~~~~~~~~~~~~~~~~~~~~~ EDICION DE LAS ACTIVDADES ~~~~~~~~~~~~~~~~~~~~~~~~
CREATE TABLE EdicionActividad(
IdEdicion INT AUTO_INCREMENT,
IdActividad INT,
IdProfesor INT,
FechaActividad DATE,
CupoEdicion INT DEFAULT 0,
CONSTRAINT pk_edicion PRIMARY KEY (IdEdicion),
CONSTRAINT fk_edicion_actividad FOREIGN KEY (IdActividad) REFERENCES Actividad (IdActividad),
CONSTRAINT fk_edicion_profesor FOREIGN KEY (IdProfesor) REFERENCES Profesor (IdProfesor)
);


INSERT INTO EdicionActividad (IdEdicion, IdActividad, IdProfesor, FechaActividad) VALUES
(2500, 8900, 1803, "2025-11-03"),
(2501, 8901, 1802, "2025-11-03"),
(2502, 8902, 1801, "2025-11-04"),
(2503, 8903, 1805, "2025-11-04"),
(2504, 8904, 1804, "2025-11-05"),
(2505, 8905, 1800, "2025-11-05"),
(2506, 8900, 1803, "2025-11-10"),
(2507, 8901, 1802, "2025-11-10"),
(2508, 8902, 1801, "2025-11-11"),
(2509, 8903, 1805, "2025-11-11"),
(2510, 8904, 1804, "2025-11-12"),
(2511, 8905, 1800, "2025-11-12");

-- SELECT * FROM EdicionActividad;
-- DROP TABLE EdicionActividad;

-- INSERT INTO EdicionActividad(IdEdicion, IdActividad, IdProfesor, FechaActividad, CupoEdicion) VALUES (2512, 8902, 1801, "2025-11-14", 10);

--  ------------ Consultas de prueba ------------
-- SELECT a.Nombre, e.FechaActividad, CONCAT(p.Nombre, ' ', p.Apellido), a.Precio FROM Actividad a INNER JOIN EdicionActividad e ON a.IdActividad = e.IdActividad INNER JOIN Profesor p ON e.IdProfesor = p.IdProfesor WHERE e.FechaActividad > curdate() ORDER BY a.Nombre;SELECT a.Nombre, e.FechaActividad, CONCAT(p.Nombre, ' ', p.Apellido), a.Precio FROM Actividad a INNER JOIN EdicionActividad e ON a.IdActividad = e.IdActividad INNER JOIN Profesor p ON e.IdProfesor = p.IdProfesor WHERE e.FechaActividad > curdate() ORDER BY e.FechaActividad;
-- SELECT a.Nombre AS Actividad, e.FechaActividad, CONCAT(p.Nombre, ' ', p.Apellido) AS Profesor, a.Precio, a.CupoMaximo - e.CupoEdicion AS CuposDisponibles FROM Actividad a INNER JOIN EdicionActividad e ON a.IdActividad = e.IdActividad INNER JOIN Profesor p ON e.IdProfesor = p.IdProfesor WHERE e.FechaActividad > CURDATE() ORDER BY e.FechaActividad;



-- ~~~~~~~~~~~~~~~~~~~~~~~~ INSCRIPCION A ACTIVIDADES (NoSocios) ~~~~~~~~~~~~~~~~~~~~~~~~
-- Tabla de inscripcion a actividades para No Socios
CREATE TABLE InscripcionActividad(
IdInscripcion INT,
IdNoSocio INT,
IdEdicion INT,
fechaInscripcion DATE,
Pagado BOOL DEFAULT FALSE,
CONSTRAINT pk_inscripcion PRIMARY KEY (IdInscripcion),
CONSTRAINT fk_inscripcion_nosocio FOREIGN KEY (IdNoSocio) REFERENCES NoSocio (IdNoSocio),
CONSTRAINT fk_inscripcion_edicion FOREIGN KEY (IdEdicion) REFERENCES EdicionActividad (IdEdicion)
);

-- SELECT * FROM InscripcionActividad


-- ~~~~~~~~~~~~~~~~~~~~~~~~ PAGOS DE ACTIVIDADES ~~~~~~~~~~~~~~~~~~~~~~~~
-- Pagos de actividades (para NoSocios)
/*
CREATE TABLE PagoActividad(
IdPago INT,
IdActividad INT,
IdNoSocio INT,
MontoPagado FLOAT,
FechaPago DATE,
CONSTRAINT pk_pago_activdad PRIMARY KEY (IdPago),
CONSTRAINT fk_pago_actividad_act FOREIGN KEY (IdActividad) REFERENCES Actividad (IdActividad),
CONSTRAINT fk_pago_actividad_soc FOREIGN KEY (IdNoSocio) REFERENCES NoSocio (IdNoSocio)
);
*/


-- ~~~~~~~~~~~~~~~~~~~~~~~~ STORE PROCEDURES ~~~~~~~~~~~~~~~~~~~~~~~~

-- StoredProcedure para hacer el Login
DELIMITER //
CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
	SELECT NomRol
		FROM Usuario u INNER JOIN Roles r ON u.RolUsu = R.RolUsu
			WHERE NombreUsu = Usu and PassUsu = Pass
				AND Activo = 1;
END//
DELIMITER //
-- Test de que funciona el StoredProcedure ↓ 
CALL IngresoLogin("lucas.luccaroni", "lucas123");
CALL IngresoLogin("ivan.faigenbom", "ivan123");
-- SELECT * FROM Usuario;


-- Stored procedured para cargar un nuevo Socio
DELIMITER //
CREATE PROCEDURE NuevoSocio(
	IN nombre VARCHAR(30),
    IN apellido VARCHAR(30),
    IN email VARCHAR(30),
    IN dniSoc VARCHAR(20),
    IN direccion VARCHAR(30),
    IN fechaNac DATE,
    IN telefono INT,
    IN fichaMedica TINYINT,
    IN fechaInscripcion DATE,
    OUT respuesta INT)
BEGIN
	DECLARE filas INT DEFAULT 0;
	DECLARE existe INT DEFAULT 0;
        
	SET filas = (SELECT COUNT(*) FROM Socio);
    
    IF filas = 0 THEN
		SET filas = 100; -- Numero del primer socio
	ELSE
    		-- buscamos el ultimo numero de socio almacenado para sumarle una unidad y considerarla como primary key de la tabla (idSocio)
		SET filas = (SELECT max(IdSocio) + 1 FROM Socio);
        
        -- para saber si ya esta almacenado el socio
        SET existe = (SELECT COUNT(*) FROM Socio WHERE Dni = dniSoc);
	END IF;
    
    IF existe = 0 THEN
		INSERT INTO Socio VALUES (filas, nombre, apellido, email, dniSoc, direccion, fechaNac, telefono, fichaMedica, fechaInscripcion);
        SET respuesta = filas;
	ELSE
		SET respuesta = existe;
	END IF;
END//
DELIMITER //
-- SELECT * FROM Socio;


-- Stored procedured para cargar un nuevo NoSocio
DELIMITER //
CREATE PROCEDURE NuevoNoSocio(
	IN nombre VARCHAR(30),
    IN apellido VARCHAR(30),
    IN email VARCHAR(30),
    IN dniNoSoc VARCHAR(20),
    IN direccion VARCHAR(30),
    IN fechaNac DATE,
    IN telefono INT,
    IN fichaMedica TINYINT,   
    OUT respuesta INT)
BEGIN
	DECLARE filas INT DEFAULT 0;
	DECLARE existe INT DEFAULT 0;
        
	SET filas = (SELECT COUNT(*) FROM NoSocio);
    
    IF filas = 0 THEN
		SET filas = 500; -- Numero del primer NO Socio
	ELSE
    		-- buscamos el ultimo numero de NO Socio almacenado para sumarle una unidad y considerarla como primary key de la tabla (idNoSocio)
		SET filas = (SELECT max(IdNoSocio) + 1 FROM NoSocio);
        
        -- para saber si ya esta almacenado el No Socio
        SET existe = (SELECT COUNT(*) FROM NoSocio WHERE Dni = dniNoSoc);
	END IF;
    
    IF existe = 0 THEN
		INSERT INTO NoSocio VALUES (filas, nombre, apellido, email, dniNoSoc, direccion, fechaNac, telefono, fichaMedica);
        SET respuesta = filas;
	ELSE
		SET respuesta = existe;
	END IF;
END//
DELIMITER //

-- SELECT * FROM NoSocio;


-- Stored procedured para inscribir nuevo NoSocio a una actividad
-- DROP PROCEDURE IF EXISTS InscribirActividad;
DELIMITER //
CREATE PROCEDURE InscribirActividad(
	IN p_idEdicion INT,
    IN p_idNoSoc INT,
    OUT respuesta INT)
BEGIN
	DECLARE idInscrip INT;
    DECLARE fechaActual DATE;
    DECLARE existe INT DEFAULT 0;
    DECLARE boolPagado BOOL DEFAULT FALSE;
    DECLARE filas INT DEFAULT 0;
    SET fechaActual = CURDATE();
    
    SET filas = (SELECT COUNT(*) FROM InscripcionActividad);
    IF filas = 0 THEN
		SET idInscrip = 800; -- Primer id de las inscripciones (la 1er inscripcion)
	ELSE
		-- buscamos el ultimo numero de IdInscripcion almacenado para sumarle una unidad y considerarla como primary key de la tabla (IdInscripcion)
		SET idInscrip = (SELECT max(IdInscripcion) + 1 FROM InscripcionActividad);
        
         -- para saber si ya registrado el socio - existe será 0 si el NoSocio no está inscripto, y 1 si ya lo está
        SET existe = (
			SELECT COUNT(*)
				FROM InscripcionActividad i
					WHERE i.IdNoSocio = p_IdNoSoc
						AND i.IdEdicion = p_IdEdicion);
    END IF;
    
	IF existe = 0 THEN
		INSERT INTO InscripcionActividad(IdInscripcion, IdNoSocio, IdEdicion, fechaInscripcion) VALUES (idInscrip, p_idNoSoc, p_idEdicion, fechaActual);
        
        -- Actualizamos el cupo de la edicion
		UPDATE EdicionActividad
			SET CupoEdicion = CupoEdicion + 1
				WHERE IdEdicion = p_idEdicion;
        
        SET respuesta = idInscrip;
	ELSE
		SET respuesta = existe;
	END IF;
END//
DELIMITER //

-- SELECT * FROM InscripcionActividad;
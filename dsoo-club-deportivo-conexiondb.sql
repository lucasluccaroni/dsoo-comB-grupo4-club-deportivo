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

DROP DATABASE IF EXISTS Dsoo_club_deportivo;
CREATE DATABASE Dsoo_club_deportivo;
USE Dsoo_club_deportivo;

-- Roles de usuarios que usen el sistema
CREATE TABLE Roles(
RolUsu INT,
NomRol VARCHAR(30),
CONSTRAINT pk_roles PRIMARY KEY (RolUsu)
);

INSERT INTO ROLES VALUES
(999, "Administrador");

-- Usuarios que usan el sistema
CREATE TABLE Usuario(
CodUsu INT AUTO_INCREMENT,
NombreUsu VARCHAR(20),
PassUsu VARCHAR(15),
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


-- StoredProcedure para hacer el Login
DELIMITER //
CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
	SELECT NomRol
		FROM Usuario u INNER JOIN Roles r ON u.RolUsu = R.RolUsu
			WHERE NombreUsu = Usu and PassUsu = Pass
				AND Activo = 1;
END//

-- Test de que funciona el StoredProcedure ↓ 
CALL IngresoLogin("lucas.luccaroni", "lucas123");
CALL IngresoLogin("ivan.faigenbom", "ivan123");
SELECT * FROM Usuario;

DELIMITER //


-- Creacion de tabla Socios
CREATE TABLE Socio(
IdSocio INT AUTO_INCREMENT,
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Email VARCHAR(30),
Dni VARCHAR(20),
Direccion VARCHAR(30),
FechaNac DATETIME,
Telefono INT,
FichaMedica BOOL,
FechaInscripcion DATETIME,
CONSTRAINT pk_socio PRIMARY KEY (IdSocio)
);


-- Stored procedured para cargar un nuevo postulante
DELIMITER //
CREATE PROCEDURE NuevoSocio(
	IN nombre VARCHAR(30),
    IN apellido VARCHAR(30),
    IN email VARCHAR(30),
    IN dni VARCHAR(20),
    IN direccion VARCHAR(30),
    IN fechaNac DATETIME,
    IN telefono INT,
    IN fichaMedica BOOL,
    IN fechaInscripcion DATETIME,
    OUT rta INT)
BEGIN
	DECLARE filas INT DEFAULT 0;
	DECLARE existe INT DEFAULT 0;
        
	SET filas = (SELECT COUNT(*) FROM Socio);
    
    IF filas = 0 THEN
		SET filas = 100; -- Numero del primer socio
	ELSE
    		-- buscamos el ultimo numero de socio almacenado para sumarle una unidad y considerarla como primary key de la tabla
		SET filas = (SELECT max(IdSocio) + 1 FROM Socio);
        
        -- para saber si ya esta almacenado el socio
        SET existe = (SELECT COUNT(*) FROM Socio WHERE dni = Dni);
	END IF;
    
    IF existe = 0 THEN
		INSERT INTO Socio VALUES (filas, nombre, apellido, email, dni, direcion, fechaNac, telefono, fichaMedica, fechaInscripcion);
        SET rta = filas;
	ELSE
		SET rta = existe;
	END IF;
END//

DELIMITER //

SELECT * FROM Socio;
    

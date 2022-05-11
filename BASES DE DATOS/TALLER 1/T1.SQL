CREATE DATABASE Adsi_banco;

USE  Adsi_banco;

CREATE TABLE Banco(
    NitBanco INT(11) UNSIGNED PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Email VARCHAR(45)
);

CREATE TABLE Cliente(
    CodCliente INT(11) UNSIGNED PRIMARY KEY,
    Nombres VARCHAR(60) NOT NULL,
    Apellidos VARCHAR(60) NOT NULL,
    Direccion VARCHAR(30) NOT NULL,
    Salario FLOAT ,
    FechaNacimiento DATE,
    Estado BOOLEAN NOT NULL
);

CREATE TABLE Sucursal(
    IdSucursal INT(11) UNSIGNED PRIMARY KEY,
    Nombre VARCHAR(45) NOT NULL,
    Direccion VARCHAR(30) NOT NUll,
    Telefono VARCHAR(15),
    FK_NitBanco INT(11) UNSIGNED, 
    FOREIGN KEY(FK_NitBanco) REFERENCES Banco(NitBanco)
);
CREATE TABLE Prestamo(
    IdPrestamo INT(11) UNSIGNED PRIMARY KEY,
    FechaPrestamo DATE NOT NULL,
    CantidadPrestamo FLOAT NOT NULL,
    FK_CodCliente INT(11) UNSIGNED,
    FK_IdSucursal INT (11) UNSIGNED,
    FOREIGN KEY(FK_CodCliente) REFERENCES Cliente(CodCliente),
    FOREIGN KEY(FK_IdSucursal) REFERENCES Sucursal(IdSucursal)
 );

 CREATE TABLE Cuenta(
    NumCuenta INT(11) UNSIGNED PRIMARY KEY,
    TipoCuenta VARCHAR(45) NOT NULL,
    Saldo FLOAT(11) NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    FK_CodCliente INT(11) UNSIGNED NOT NULL,
    FK_IdSucursal INT(11) UNSIGNED NOT NULL,
    FOREIGN KEY(FK_CodCliente) REFERENCES Cliente(CodCliente),
    FOREIGN KEY(FK_IdSucursal) REFERENCES Sucursal(IdSucursal)
 );
 
 INSERT INTO Banco VALUE (12345, "bancoAndres", "bancoandres@gmail.com"),
                         (123456, "bancoDog", NULL);
                         
INSERT INTO Cliente VALUE(258, "juan","pantoja", "calle 53 numero 23 58", NULL, "1952/12/5", 1),
                         (259, "Alejandro","Ramirez", "calle 25 numero 32 - 89", 1200000, "1982/1/25", 0),
                         (260, "Pedro","Picapiedra", "calle 35 numero 85 58", 4000000, "1998/2/10", 1 ),
                         (261, "Vilma","Palma", "calle 32 numero 15 69", NULL, "1993/5/15",0 );

INSERT INTO Sucursal VALUE(331,"sucursal Del Centro","calle 23 numero 43 - 42", 8888552, 12345),
                          (332,"sucursal avenida palmas","calle 55 numero 8 - 22", NULL, 12345),
                          (333,"sucursal avenida centenares Centro","calle 62 numero 3 - 47", 8899636, 12345),
                          (334,"sucursal costa rica","calle 32 numero 12 - 63", NULL, 123456),
                          (335,"sucursal Monapes","calle 18 numero 43 - 89", 8822222, 123456);

INSERT INTO Prestamo VALUE(456,"2001/5/19",5000000,258,331),
                          (457,"2000/6/8",8000000,258,331),
                          (458,"2005/9/11",3000000,260,332),
                          (459,"2021/1/15",9000000,261,333);

INSERT INTO Cuenta VALUE(551,"AHORRO",500000,"1998/5/26 14:00:00",258,331),
                        (552,"CORRIENTE",5000000,"1998/5/27 14:00:00",258,331),
                        (553,"AHORRO",200000,"2000/2/10 12:00:00",259,333),
                        (554,"CORRIENTE",6000000,"2001/3/11 13:00:00",260,332),
                        (555,"AHORRO",1000000,"2002/6/15 15:00:00",261,335);

UPDATE Cliente SET Nombres = "JUANA", FechaNacimiento = "1953/12/6", Salario=2500000 WHERE CodCliente = 258;

UPDATE Cliente SET Estado = 0 WHERE CodCliente % 2 = 1;

DELETE FROM sucursal WHERE IdSucursal = 331;

SELECT  * FROM Cliente ORDER BY  Nombres  LIMIT 2,2;
SELECT  * FROM Cliente ORDER BY  Nombres DESC LIMIT 4;
SELECT  * FROM Cliente ORDER BY  Nombres DESC;

UPDATE Banco SET Email  = "no tiene email registrado" WHERE Email IS NULL;

UPDATE Prestamo SET FechaPrestamo = now() WHERE IdPrestamo = 456;

SELECT SUM(p.CantidadPrestamo) AS "prestamo por cliente", C.Nombres AS "nombre de la persona"
FROM Prestamo p RIGHT JOIN Cliente C
ON p.FK_CodCliente = C.CodCliente
GROUP BY Nombres;

SELECT *
FROM Cliente
WHERE Estado = 1 AND salario > 1500000 AND  FechaNacimiento > "1990/07/01";


SELECT AVG(P.CantidadPrestamo) AS "PROMEDIO PRESTAMOS", C.Nombres AS "NOMBRE"
FROM Prestamo P INNER JOIN Cliente C
ON P.FK_CodCliente = C.CodCliente
WHERE CodCliente = 258;

SELECT Nombre AS"Nombre", MAX(P.CantidadPrestamo)AS "prestamo con mayor valor", MIN(P.CantidadPrestamo)AS "prestamo con MENOR valor"
FROM Sucursal S INNER JOIN Prestamo P
ON S.IdSucursal=P.FK_IdSucursal
GROUP BY FK_IdSucursaL;

SELECT COUNT(P.IdPrestamo) AS "CANTIDAD DE PRESTAMOS", C.Nombres AS "NOMBRE"
FROM Cliente C INNER JOIN Prestamo P 
ON C.CodCliente = P.FK_CodCliente 
WHERE FechaPrestamo BETWEEN "2021/01/01" AND "2021/12/31" AND CodCliente = 261;

SELECT min(FechaPrestamo) AS "FECHA DEL PRIMER PRESTAMO EN LA SUCURSAL", S.nombre AS " nombre de la sucursal"
FROM prestamo P INNER JOIN Sucursal S
ON P.FK_IdSucursaL = S.IdSucursal
WHERE IdSucursal=331;

SELECT c.Nombres AS " informacion del cliente", P.CantidadPrestamo AS " informacion del prestamo del ciente" 
FROM Prestamo P RIGHT JOIN Cliente c
ON P.FK_CodCliente=c.CodCliente;

SELECT COUNT(P.IdPrestamo) AS " NUMERO DE PRESTAMOS", S.Nombre AS "NOMBRE DE LA SUCURSAL"
FROM Sucursal S INNER JOIN Prestamo P
ON P.FK_IdSucursaL=S.IdSucursal
GROUP BY IdSucursal;

SELECT SUM(p.CantidadPrestamo) AS"totla prestamo", b.Nombre AS"nombre del banco"
FROM Prestamo p INNER JOIN sucursal s 
ON P.FK_IdSucursaL=s.IdSucursal
INNER JOIN Banco b 
ON s.FK_NitBanco = b.NitBanco 
WHERE FechaPrestamo BETWEEN "2021/01/01" AND "2021/01/30" AND NitBanco = 12345;

SELECT (c.Saldo) AS"saldo de la cuenta", b.Nombre AS"nombre del banco", c.NumCuenta AS"numero de la cuenta"
FROM Cuenta c INNER JOIN sucursal s 
ON c.FK_IdSucursaL=s.IdSucursal
INNER JOIN Banco b 
ON s.FK_NitBanco = b.NitBanco 
WHERE  NitBanco = 12345;

SELECT (c.Salario) AS"salario del cliente", s.Nombre AS"nOMBRE DE LA SUCURSAL ", b.Nombre AS"nombre del banco "
FROM Cliente c INNER JOIN Cuenta p 
ON p.FK_CodCliente=c.CodCliente
INNER JOIN sucursal s
ON p.FK_IdSucursaL=s.IdSucursal
INNER JOIN Banco b
ON s.FK_NitBanco=b.NitBanco 
WHERE c.salario>1000000;

SELECT COUNT(DISTINCT B.NitBanco) AS"NUMERO DE BANCOS"
FROM Banco B INNER JOIN Sucursal S
ON S.FK_NitBanco=B.NitBanco
INNER JOIN Prestamo P
ON p.FK_IdSucursaL=s.IdSucursal AND P.CantidadPrestamo >= 1000000;

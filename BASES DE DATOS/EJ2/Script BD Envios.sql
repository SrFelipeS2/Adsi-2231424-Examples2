CREATE DATABASE ENVIOS

USE ENVIOS

CREATE TABLE camionero(
Dni INT(11) UNSIGNED PRIMARY KEY,
Nombre VARCHAR(21) NOT NULL,
Salario INT(11) UNSIGNED NOT NULL,
Telefono INT(11)  UNSIGNED NOT NULL,
Domicilio CHAR(80)
);

CREATE TABLE camion(
    Matricula INT(5) UNSIGNED PRIMARY  KEY,
    Tipo CHAR(10) NOT NULL,
    Modelo INT(4) UNSIGNED NOT NULL,
    Potencia INT(6) UNSIGNED,
    FKDni INT(11)  UNSIGNED NOT NULL,
    FOREIGN KEY (FKDni) REFERENCES camionero (Dni)
);

CREATE TABLE destinatario(
    Cod_Destinatario INT(11) UNSIGNED PRIMARY KEY,
    Nombre CHAR(21) NOT NULL,
    Direccion CHAR (80) NOT NULL
);

CREATE TABLE paquete(
    Cod_paquete INT(11) UNSIGNED PRIMARY KEY,
    Destinatario CHAR(100) NOT NULL,
    Direccion_Destinatario CHAR(80) NOT NULL,
    Descripcion CHAR (100) NOT NULL,
    FK_Dni INT(11) UNSIGNED not NULL,
    FK_Cod_Destinatario INT(11) UNSIGNED NOT NULL,
    FK_Cod_Provincia INT(11) UNSIGNED NOT NULL,
	FOREIGN KEY (FK_Dni) REFERENCES camionero (Dni),
	FOREIGN KEY (FK_Cod_Destinatario) REFERENCES destinatario (Cod_Destinatario),
    FOREIGN KEY (FK_Cod_Provincia) REFERENCES provincia (Cod_Provincia)
);

CREATE TABLE provincia(
    Cod_Provincia int(11) UNSIGNED PRIMARY KEY,
    Nombre CHAR(21) NOT NULL
    Fk_Cod_Paquete INT(11) NOT NULL UNSIGNED,
);




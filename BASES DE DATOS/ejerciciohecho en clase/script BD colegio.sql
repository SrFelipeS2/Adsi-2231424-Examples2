# Creacion de la base de datos
	CREATE DATABASE colegio;

USE colegio;

CREATE TABLE acudiente(
	CedAcudiente INT(11) UNSIGNED,
	Nombre VARCHAR(80) NOT NULL,
	Genero CHAR(1),
	PRIMARY KEY (CedAcudiente)
);

CREATE TABLE estudiante(
	CodEstudiante INT(11) UNSIGNED PRIMARY KEY,
	Nombre VARCHAR(25) NOT NULL,
	ApellidoMaterno VARCHAR(15),
	ApellidoPaterno VARCHAR(15),
	FechaNacimiento DATE NOT NULL,
	Email VARCHAR(150) NOT NULL UNIQUE,
	TipoDocumento CHAR(2) NOT NULL,
	DocumentoIdentidad VARCHAR(15) NOT NULL,
	Direccion VARCHAR(200) NOT NULL,
	FKCedAcudiente INT(11) UNSIGNED NOT NULL,
	FOREIGN KEY (FKCedAcudiente) REFERENCES acudiente (CedAcudiente)
);
CREATE TABLE materia(
	CodMateria INT(11) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Creditos INT(11)
);
CREATE TABLE profesor(
	CedulaProfesor INT(11) UNSIGNED PRIMARY KEY ,
	Nombre VARCHAR(50)NOT NULL,
	EstadoActivo BOOLEAN NOT NULL,
	Experiencia TINYINT UNSIGNED,
	FechaIngresoSistema DATETIME NOT NULL
);
CREATE TABLE curso(
	CodCurso INT(11) UNSIGNED PRIMARY KEY ,
	Nombre VARCHAR(50) NOT NULL,
	Duracion INT(11) NOT NULL,
	FKCedulaProfesor  INT(11) UNSIGNED,
	FOREIGN KEY(FKCedulaProfesor) REFERENCES profesor (CedulaProfesor)
);
CREATE TABLE estudiante_curso(
	CodEstudiante INT(11)UNSIGNED,
	CodCurso INT(11)UNSIGNED,
	NotaAprobacion FLOAT(11),
	FechaInicio DATE NOT NULL,
	FechaFin DATE,
	PRIMARY KEY (CodEstudiante, CodCurso),
	FOREIGN KEY (CodEstudiante) REFERENCES estudiante (CodEstudiante),
	FOREIGN KEY (CodCurso) REFERENCES curso (CodCurso)
);
CREATE TABLE curso_materia(
	CodCurso INT(11)UNSIGNED,
	CodMateria INT(11)UNSIGNED,
	PRIMARY KEY (CodCurso, CodMateria),
	FOREIGN KEY (CodCurso) REFERENCES curso (CodCurso),
	FOREIGN KEY (CodMateria) REFERENCES materia  (CodMateria)
);

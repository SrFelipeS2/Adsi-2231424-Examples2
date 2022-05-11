CREATE DATABASE Ej_Universidad;

USE Universidad;

CREATE TABLE Universidad(
    IdUiversidad INT(9) UNSIGNED PRIMARY KEY,
    NombreUniversidad CHAR(80) NOT NULL
);

CREATE TABLE Asignaturas(
    IdAsignaturas INT(9) UNSIGNED PRIMARY KEY,
    Nombre_Asignatura CHAR(80) NOT NULL,
    Creditos INT(3) UNSIGNED NOT NULL,
    Notas INT(2) UNSIGNED
);

CREATE TABLE Profesor(
    IdProfesor INT(9) UNSIGNED PRIMARY KEY,
    Nombre_profesor CHAR(80) NOT NULL
);

CREATE TABLE Curso(
    IdCurso INT(9) UNSIGNED PRIMARY KEY,
    Nombre_Curso CHAR(80) NOT NULL,
    FK_IdUniversidad INT(9) UNSIGNED NOT NULL, 
    FK_IdProfesor INT(9) UNSIGNED NOT NULL,
    FOREIGN KEY(FK_IdUiversidad) REFERENCES Universidad(IdUiversidad),
    FOREIGN KEY(FK_IdProfesor) REFERENCES Profesor(IdProfesor),
)

CREATE TABLE Alumno(
    IdAlumno INT(9) UNSIGNED   PRIMARY KEY,
    NombreAlumno CHAR(80) NOT NULL,
    FK_IdCurso INT(9) UNSIGNED NOT NULL
)

CREATE TABLE Curso_Asignatura(
	IdCurso INT(11)UNSIGNED,
	IdAsignaturas INT(11)UNSIGNED,
	PRIMARY KEY (IdCurso, IdAsignaturas),
	FOREIGN KEY (IdCurso) REFERENCES Curso (IdCurso),
	FOREIGN KEY (IdAsignaturas) REFERENCES Asignaturas  (IdAsignaturas)
);

CREATE TABLE Alumno_Asignatura(
	IdAlumno INT(11)UNSIGNED,
	IdAsignaturas INT(11)UNSIGNED,
	PRIMARY KEY (IdAlumno, IdAsignaturas),
	FOREIGN KEY (IdAlumno) REFERENCES Alumno (IdAlumno),
	FOREIGN KEY (IdAsignaturas) REFERENCES Asignaturas  (IdAsignaturas)
);

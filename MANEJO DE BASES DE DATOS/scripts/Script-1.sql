create table alumno(
codigo int auto_increment primary key,
nombre varchar(50),
mail varchar(70),
codigocurso int
);
create table cursos(
codigo int primary key auto_increment,
nombrecurso varchar(40)
);
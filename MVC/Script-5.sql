create table paciente(
     documento varchar(50) primary key,
 nombre varchar(80),
 direccion varchar(80),
 telefono varchar(20),
 fecha_nacimiento date,
 estado varchar(20),
 genero char,
 eps varchar(20),
 email varchar(80),
 password varchar(40)
);
create table especialidad(
     codigo varchar(50) primary key,
 nombre varchar(80),
 descripcion varchar(80)
);

UPDATE paciente set nombre = "julian", direccion = "calle 31 ", telefono = "123234345", fecha_nacimiento = "2022-04-12", estado = "Activo", genero = "M", eps = "senamas", email = "julian@gmail.com" WHERE documento = "1053864853";
/*creacion de tablas para la base de datos, principalmente se deberian de crear las tablas que no tienen llave foranea*/
create table proyecto(
NumeroProyecto int(11) unsigned primary key,
NombreProyecto varchar(50) not null,
Descripcion varchar(80)
);

create table producto(
NumeroProducto int(11) unsigned primary key,
Descripcion varchar(350),
PrecioActual float  unsigned not null
);

create table area(
NumeroArea int(11)  unsigned primary key,
NombreArea varchar(50) not null
);

create table empleado(
CedulaEmpleado varchar(11)  primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
FechaNacimiento date not null,
FechaIngreso date not null,
Direccion varchar(50),
Salario float,
AnnosExperiencia int,
Activo tinyint,
Sexo char(1),
FK_NumeroArea int(11) unsigned not null,
foreign key (FK_NumeroArea) references area(NumeroArea)
);

create table empleado_proyecto(
Fk_CedulaEmpleado varchar(11),
FK_NumeroProyecto int(11) unsigned,
HorasTrabajadas float,
FechaTrabajo datetime,
primary key (Fk_CedulaEmpleado,FK_NumeroProyecto),
foreign key (Fk_CedulaEmpleado) references empleado (CedulaEmpleado),
foreign key (Fk_NumeroProyecto) references proyecto (NumeroProyecto)
);

create table dependiente(
CedulaDependiente varchar(11) primary key,
NombreDependiente varchar(60) not null,
Sexo char(1), 
FechaNacimiento date not null,
Parentesco varchar(50) not null,
Fk_CedulaEmpleado varchar(11),
foreign key (Fk_CedulaEmpleado) references empleado (CedulaEmpleado)
);

create table venta(
NumeroVenta int(11) unsigned primary key,
FechaVenta date not null,
Fk_CedulaEmpleado varchar(11) not null,
foreign key (Fk_CedulaEmpleado) references empleado (CedulaEmpleado)
);

create table venta_producto(
Fk_NumeroVenta int(11) unsigned,
Fk_NumeroProducto int(11) unsigned,
Cantidad int(11)  unsigned not null,
PrecioUnitario float not null,
primary key (Fk_NumeroVenta, Fk_NumeroProducto),
foreign key (Fk_NumeroVenta) references venta (NumeroVenta),
foreign key (Fk_NumeroProducto) references producto (NumeroProducto)
);

create table jefe(
Fk_NumeroArea int(11) unsigned,
Fk_Cedulaempleado varchar(11),
FechaInicio date not null,
FechaFin date,
Estado varchar(15) not null,
primary key (Fk_NumeroArea, Fk_Cedulaempleado),
foreign key (FK_NumeroArea) references area (NumeroArea),
foreign key (Fk_Cedulaempleado) references empleado (CedulaEmpleado)
);
/* datos proyecto*/

insert into proyecto (NumeroProyecto, NombreProyecto, Descripcion) values 
(1, 'Econo', 'PROYECTO economia'),
(2, 'Erp', 'Implementaci�n erp'),
(3, 'Diagnostico', 'Diagnostico de ventas'),
('10', 'Automatizaci�n', 'Automatizaci�n de procesos'),
('20', 'Reorganizaci�n', 'Reorganizaci�n de dependencias'),
('30', 'Nuevos valores', 'Nuevos valores art�culos');

/* datos producto */

insert into producto (NumeroProducto, Descripcion, PrecioActual) values 
(1, 'Mouse', 50000), 
(2, 'SSD 4 Teras', 550000), 
(3, 'Teclado Mecanico', 295000),
(4, 'Cable HDMI', 35000), 
(5, 'Memoria Ram 16 Gb', 545000), 
(6, 'Soporte Pared Monitor', 135000), 
(7, 'Kit Limpieza Accesorios', 21000),
(8, 'Estabilizador', 72000), 
(9, 'Base Refrigerante', 85000), 
(10, 'Parlantes', 60000), 
(11, 'Usb 64 Gb', 45000);

/*datos Area*/

insert into area (NumeroArea, NombreArea) values 
(1,'Direcci�n'),
(2,'Ventas'), 
(3,'Investigaci�n'),
(4,'Sistemas');

/*datos empleado*/

insert into empleado (CedulaEmpleado,Nombre,Apellido,FechaNacimiento,FechaIngreso,Direccion,Salario,AnnosExperiencia,Activo,Sexo,FK_NumeroArea) values
('123456780','DANIELA','PEREZ','1975-07-20','2001-04-25','CRRA 12 14-19',1000000,2,1,'F',3),
('123456789','DANIEL','MEJIA','1980-02-04','2010-02-02',NULL,2000000,3,1,'M',2),
('304156911','CAROL', 'GARCIA', '1979-11-05', '2010-11-19', 'CRRA 11 7-25', '1500000', '2', '1', 'F', '2'),
('333445555','PEDRO','ALVAREZ','1989-02-28','2002-10-09','CRRA 12 14-19',5000000,15,0,'M',2),
('549751072','RAMON', 'VALDEZ', '1988-09-17', '2000-01-13', null, '1500000', '17', '1', 'M', '2'),
('666884444','DIEGO','OROZCO','1985-09-12','2011-09-12','CRRA 12 14-19',1500000,1,0,'M',2),
('888775555','MARIA JOSE','OSORIO','1981-10-12','1998-07-15',NULL,9000000,7,1,'F',1),
('987654321','DUVAN','VELEZ','1979-01-22','2009-08-14','CRRA 12 14-19',900000,1,0,'M',4),
('999887777','PABLO','DIAZ','1972-08-14','2003-01-01','CRRA 12 14-19',4000000,10,0,'M',3);


/* datos empleado_proyecto*/

insert into empleado_proyecto (Fk_CedulaEmpleado, FK_NumeroProyecto, HorasTrabajadas, FechaTrabajo) values 
('123456789',1,32.5,'2015-10-12 08:40:00'),
('123456789',2,7.5,'2015-10-12 15:35:00'), 
('333445555',2,10,'2015-04-10 09:27:00'),
('333445555',3,10,'2015-10-12 07:50:00'),
('333445555',10,10,'1988-04-12 12:03:00'),
('333445555',20,10,'2015-10-12 09:13:00'),
('549751072',1,20,'2015-10-02 00:00:00'),
('549751072',2,20,'2015-04-09 19:12:00'), 
('666884444',3,20,'2015-10-01 00:00:00'),
('888775555',20,12.6,'2015-04-20 16:10:00'), 
('987654321',20,15,'2015-04-19 00:00:00'),
('987654321',30,20,'2015-04-18 11:13:00'), 
('304156911',10,35,'2015-10-16 20:00:00'),
('304156911',30,5,'2015-04-17 13:43:00'), 
('999887777',10,10,'2015-10-13 21:12:00'),
('999887777',30,30,'2015-10-12 18:05:00');

/*datos dependiente*/

insert into dependiente (CedulaDependiente, NombreDependiente, Sexo, FechaNacimiento, Parentesco, Fk_CedulaEmpleado) values 
('1111','Alicia','F','1988-04-05','HIJA','333445555'),
('2222','Teodoro','M','1983-10-25','HIJO','333445555'),
('3333','Monica','F','1978-05-03','ESPOSA','333445555'),
('4444','Braulio','M','1988-02-28','ESPOSO','987654321'),
('5555','Michael','M','1988-06-04','SOBRINO','123456789'),
('6666','Petronila','F','1987-12-31','HIJA','123456789'),
('7777','Elizabeth','F','1978-08-10','ESPOSA','123456789'),
('8888','Andrea','M','2011-07-14','HIJO','888775555');

/*datos para ingresar de venta*/

insert into venta (NumeroVenta, Fk_CedulaEmpleado, FechaVenta) values
('1', '123456789', '2015-10-30'),
('2', '123456789', '2015-10-19'),
('3', '123456789', '2015-10-20'),
('4', '123456789', '2015-10-10'),
('5', '123456789', '2015-10-03'),
('6', '123456789', '2015-10-02'),
('7', '549751072', '2015-10-22'),
('8', '549751072', '2015-10-20'),
('9', '549751072', '2015-10-20'),
('10', '304156911', '2015-10-14'),
('11', '304156911', '2015-10-24'),
('12', '304156911', '2015-10-08'),
('13', '304156911', '2015-10-06'),
('14', '333445555', '2015-10-26'),
('15', '333445555', '2015-10-15'),
('16', '666884444', '2015-10-30'),
('17', '666884444', '2015-10-28'),
('18', '666884444', '2015-10-28'),
('19', '666884444', '2015-10-22'),
('20', '666884444', '2015-10-20'),
('21', '666884444', '2015-10-16'),
('22', '666884444', '2015-10-07'),
('23', '666884444', '2015-10-01');

/*datos venta_producto*/

insert into venta_producto (Fk_NumeroVenta, Fk_NumeroProducto, Cantidad, PrecioUnitario ) values
('1', '1', '7', '50000'),
('1', '2', '1', '550000'), 
('1', '10', '5', '60000'), 
('2', '11', '1', '45000'), 
('3', '1', '2', '50000'),
('4', '2', '5', '550000'), 
('5', '3', '3', '295000'),
('6', '8', '1', '72000'),
('6', '9', '6', '85000'), 
('6', '10', '1', '60000'), 
('7', '10', '4', '60000'), 
('8', '11', '2', '45000'),
('9', '4', '5', '35000'), 
('9', '5', '1', '545000'), 
('10', '6', '2', '135000'),
('10', '7', '11', '21000'), 
('11', '7', '20', '21000'), 
('12', '3', '1', '295000'), 
('13', '3', '1', '295000'), 
('14', '3', '1', '295000'), 
('14', '10', '5', '60000'),
('15', '10', '2', '60000'),
('16', '2', '4', '550000'), 
('16', '3', '1', '295000'),
('17', '9', '11', '85000'),
('17', '10', '9', '60000'), 
('18', '10', '8', '60000'),
('19', '6', '7', '135000'),
('19', '7', '2', '21000'),
('19', '8', '5', '72000'), 
('20', '4', '10', '35000'), 
('21', '5', '3', '545000'), 
('22', '11', '1', '45000'), 
('23', '1', '2', '50000'), 
('23', '2', '9', '550000'), 
('23', '3', '1', '295000'),
('23', '4', '5', '35000');

/* datos jefe*/

insert into jefe (Fk_NumeroArea, Fk_Cedulaempleado, FechaInicio, FechaFin, Estado) values 
(1,'888775555','1998-07-15',NULL,'activo'),
(2,'123456789','2000-01-01','2012-09-09','inactivo'),
(2,'333445555','2002-10-09',NULL,'activo'),
(3,'999887777','2003-01-01',NULL,'activo');



/*SOLUCION TALLER*/

/*Obtenga el promedio de horas trabajadas por proyecto, considerando sólo aquellos superiores a 15 horas.*/
select round(avg(HorasTrabajadas),2) as PromedioHorasTrabajadas, ep.FK_NumeroProyecto as CodigoDeProyecto, p.NombreProyecto  
from empleado_proyecto ep inner join proyecto p on ep.FK_NumeroProyecto = p.NumeroProyecto  
group by ep.FK_NumeroProyecto 
having PromedioHorasTrabajadas  > 15
;

/*2- Muestre la sumatoria de salarios agrupado por código del área, siempre que el valor no supere los 5.000.000 pesos, 
considerando sólo los empleados con dirección no nula.*/
select sum(e.Salario) as SumatoriaSalarios, a.NombreArea  as AreaEspecificaDeSalario
from empleado e inner join area a on e.FK_NumeroArea = a.NumeroArea 
where e.Direccion is not null
group by e.FK_NumeroArea 
having SumatoriaSalarios <= 5000000
;


/*3. Los empleados ganan comisiones dependiendo de las horas trabajadas en cada proyecto. 
 * Teniendo en cuenta que el valor de la comisión es de $11.000 por hora
 *  muestre por cada empleado el valor de la comisión,
 *  teniendo en cuenta solo aquellos empleados del área de investigación 
 * y solo las comisiones mayores a $25.000 .*/

select sum(ep.HorasTrabajadas*11000) as comisionesPorEmpleado, e.Nombre 
from empleado_proyecto ep inner join empleado e on ep.Fk_CedulaEmpleado = e.CedulaEmpleado 
where e.FK_NumeroArea = 3
group by e.CedulaEmpleado 
having comisionesPorEmpleado > 25000
;

/*4. Se desea conocer el empleado que realizó ventas por un total mayor a 500.000 en la semana
del 12 al 18 de octubre de 2015. Tenga en cuenta que el total de una venta corresponde a la
sumatoria de sus productos multiplicado por el valor unitario. PENDIENTE*/

select v.FechaVenta, e.Nombre, sum(vp.cantidad*vp.PrecioUnitario) as TotalDeVenta, e.CedulaEmpleado 
from venta_producto vp inner join  venta v on v.NumeroVenta = vp.Fk_NumeroVenta 
inner join empleado e on v.Fk_CedulaEmpleado = e.CedulaEmpleado 
where v.FechaVenta between "2015-10-12" and "2015-10-18" 
group by e.CedulaEmpleado 
having TotalDeVenta > 500000
;

/*5- Se desea conocer productos de los cuales se ha vendido al menos 5 unidades*/

select  p.Descripcion, sum(vp.cantidad) as suma, p.NumeroProducto 
from producto p inner join  venta_producto vp on p.NumeroProducto = vp.Fk_NumeroProducto
group by vp.Fk_NumeroProducto 
having  suma  > 5
;
/*6- Seleccione empleados que tengan más de 1 dependiente
 */
select e.Nombre, e.CedulaEmpleado, count(d.Fk_CedulaEmpleado) as parientes
from empleado e 
inner join dependiente d on d.Fk_CedulaEmpleado = e.CedulaEmpleado 
group by e.CedulaEmpleado 
having parientes > 1
;

/*
7- Obtenga el total de empleados agrupados por área y sexo sin considerar los que se encuentran
inactivos PENDIENTE*/

select count(e.CedulaEmpleado) as activos, a.NombreArea , e.FK_NumeroArea, e.Sexo  
from empleado e inner join area a on a.NumeroArea = e.FK_NumeroArea 
where e.Activo = 1
group by  e.Sexo, e.FK_NumeroArea
;

/*10- Muestre los distintos números de producto que han sido vendidos entre el 14 y 28 de octubre de 2015
 */

select distinct p.NumeroProducto, p.Descripcion 
from producto p 
inner join venta_producto vp on p.NumeroProducto = vp.Fk_NumeroProducto 
inner join venta v on v.NumeroVenta = vp.Fk_NumeroVenta 
where v.FechaVenta between "2015-10-14" and "2015-10-28"
;

/*
11- Obtenga el número y nombre de proyectos distintos para los cuales se han registrado horas trabajadas
*/

select distinct(p.NombreProyecto), ep.FK_NumeroProyecto 
from proyecto p inner join empleado_proyecto ep on p.NumeroProyecto = ep.FK_NumeroProyecto 
;

/*
12- Obtenga los distintos nombres de quienes han realizado ventas*/
select distinct e.Nombre 
from empleado e inner join venta v on e.CedulaEmpleado = v.Fk_CedulaEmpleado 
;

/*
13- Muestre la cantidad de veces que cada persona ha vendido el producto 10*/

select distinct e.Nombre, sum(vp.Cantidad) as sumatoriaDeVentas, e.CedulaEmpleado  
from venta_producto vp 
inner join venta v on vp.Fk_NumeroVenta = v.NumeroVenta 
inner join empleado e on v.Fk_CedulaEmpleado = e.CedulaEmpleado 
where Fk_NumeroProducto = 10
group by e.CedulaEmpleado 
;

/*
14- Muestre la cantidad de veces que cada persona ha vendido el producto 10 en distintas fechas:
Note que las dos últimas sentencias tienen una salida diferente. Una persona realizó 2 ventas del 
producto en el mismo día, en el punto 13 se cuenta, en el punto 14 no se cuenta porque
 solicitamos fechas diferentes.
 */

select distinct e.Nombre, sum(vp.Cantidad) as sumatoriaDeVentas, e.CedulaEmpleado, v.FechaVenta  
from venta_producto vp 
inner join venta v on vp.Fk_NumeroVenta = v.NumeroVenta 
inner join empleado e on v.Fk_CedulaEmpleado = e.CedulaEmpleado 
where Fk_NumeroProducto = 10
group by v.FechaVenta  
;

/*
15- Muestre los distintos parentescos registrados en la tabla de dependientes.*/

select distinct d.Parentesco 
from dependiente d
;
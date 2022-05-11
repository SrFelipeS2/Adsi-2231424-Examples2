<?php
//Importamos la clase Persona.
require_once './clases/Empleado.php';
//Creamos el objeto con los valores que se definen en el constructor.
$name = isset($_POST['nombre']) ? $_POST['nombre'] : null;
$sueldo = isset($_POST['sueldo']) ? $_POST['sueldo'] : null;
$email = isset($_POST['email']) ? $_POST['email'] : null;
$fecha = isset($_POST['fecha']) ? $_POST['fecha'] : null;
$peso = isset($_POST['peso']) ? $_POST['peso'] : null;
$altura = isset($_POST['altura']) ? $_POST['altura'] : null;
$empleado = new Empleado($name,$sueldo,$email,$fecha,$peso,$altura);
 echo $empleado->informacion();

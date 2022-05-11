<?php
//Importamos la clase Cuenta.
require_once '../clases/Cuenta.php';
require_once '../clases/conexion.php';
//Creamos el objeto con los valores que se definen en el constructor.
$name = isset($_POST['nombre']) ? $_POST['nombre'] : null;
$email = isset($_POST['email']) ? $_POST['email'] : null;
$docIdentidad = isset($_POST['Doc']) ? $_POST['Doc'] : null;
$tipoCuenta = isset($_POST['cuenta']) ? $_POST['cuenta'] : null;
$contraseña = isset($_POST['contra1']) ? $_POST['contra1'] : null;
$contraseñaConfirmada = isset($_POST['contra2']) ? $_POST['contra2'] : null;
$titular = isset($_POST['titulartarjeta']) ? $_POST['titulartarjeta'] : null;
$numtarjeta = isset($_POST['numtarjeta']) ? $_POST['numtarjeta'] : null;
$tipotarjeta1 = isset($_POST['tipo']) ? $_POST['tipo'] : null;



if ($contraseña == $contraseñaConfirmada) {
    $contraseñaFinal = $contraseña;
    $connObj = new Conexion();
    $conexion = $connObj->connect();
    $SQL = "INSERT INTO tarjeta (nombreTitular,númeroDeTarjeta,tipoDeTarjeta) VALUES
    ('$titular',$numtarjeta,'$tipotarjeta1')";
    
    mysqli_query($conexion, $SQL) or die("Problemas en el INSERT" .
        mysqli_error($conexion));



    $SQL2 = "SELECT codigoTarjeta from Tarjeta where númeroDeTarjeta = $numtarjeta";
    /* Se ejecuta el método que permite realizar una consulta a la BD.
            Se le envía como parámetros la conexión y la consulta */
    $codigotarjeta = mysqli_query($conexion, $SQL2) or die("Problemas en el INSERT" .
        mysqli_error($conexion));
    // Se cierra la conexión
   $respuesta=$codigotarjeta['codigoTarjeta'];

    $SQL3 = "INSERT INTO usuario(documentoIdentidad,nombre,contraseña,mail,tipoDeCuenta,FK_codigoTarjeta) VALUES ($docIdentidad,'$name','$contraseñaFinal','$email','$tipoCuenta',$respuesta)";
    
    mysqli_query($conexion, $SQL3) or die("Problemas en el INSERT" .
        mysqli_error($conexion));
    // Se cierra la conexión
    mysqli_close($conexion);
}

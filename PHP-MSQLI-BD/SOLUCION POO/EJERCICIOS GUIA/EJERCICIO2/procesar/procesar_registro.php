<?php
require_once "../clases/Cuenta.php";

session_start();
$usuario = isset($_POST['usuario']) ? $_POST['usuario'] : null;
$numero_de_cuenta = isset($_POST['numero_cuenta']) ? $_POST['numero_cuenta'] : null;
$nombre_titular = isset($_POST['nombre']) ? $_POST['nombre'] : null;
$saldo = 0;
$tipo_de_cuenta = isset($_POST['cuenta']) ? $_POST['cuenta'] : null;
$contraseña1 = isset($_POST['contra1']) ? $_POST['contra1'] : null;
$contraseña2 = isset($_POST['contra2']) ? $_POST['contra2'] : null;
$numero_tarjeta = isset($_POST['numero_tarjeta']) ? $_POST['numero_tarjeta'] : null;
$saldo_tarjeta = isset($_POST['saldo_tarjeta']) ? $_POST['saldo_tarjeta'] : null;
if ($contraseña1 == $contraseña2) {
    $contraseñafinal = $contraseña1;
    $cuenta = new Cuenta($usuario, $numero_de_cuenta, $nombre_titular, $saldo, $tipo_de_cuenta,$contraseñafinal,$numero_tarjeta,$saldo_tarjeta);
    if(isset($_SESSION["USUARIOS"])){
        array_push($_SESSION["USUARIOS"],$cuenta);
    }else{
        $_SESSION["USUARIOS"] = array($cuenta);
    }

}
header("Location: ../principal.php");

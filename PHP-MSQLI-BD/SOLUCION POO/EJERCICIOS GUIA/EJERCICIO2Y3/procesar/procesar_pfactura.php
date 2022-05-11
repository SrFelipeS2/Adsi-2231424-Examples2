<?php
require_once "../clases/Cuenta.php";
session_start();
$error=1;
$usuariob = isset($_POST['usuario']) ? $_POST['usuario'] : null;
$contraseña = isset($_POST['contraseña']) ? $_POST['contraseña'] : null;
$numero_de_cuenta = isset($_POST['cuenta']) ? $_POST['cuenta'] : null;
$numero_de_tarjeta = isset($_POST['numero_de_tarjeta']) ? $_POST['numero_de_tarjeta'] : null;
$numero_de_cuotas = isset($_POST['numero_de_cuotas']) ? $_POST['numero_de_cuotas'] : null;
$medio_pago = isset($_POST['pago']) ? $_POST['pago'] : null;
$pfactura = isset($_POST['monto']) ? $_POST['monto'] : null;
foreach($_SESSION['USUARIOS'] as $usuario){
    if($usuario -> getUsuario()==$usuariob && $usuario -> getContraseña()==$contraseña ){
        //$usuario -> aumentarSaldo($monto);
        if($usuario -> pagarFactura($medio_pago, $pfactura, $numero_de_tarjeta, $numero_de_cuenta)==true){
        $error=0;
        }
        break;
    }
}
if($error==0){
header("Location: ../principal.php");
}else{
    header("Location: ../pfactura.php?error=1");
}



?>
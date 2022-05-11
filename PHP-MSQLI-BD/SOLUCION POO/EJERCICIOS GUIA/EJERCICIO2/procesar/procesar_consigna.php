<?php
/*$name = isset($_POST['nombre']) ? $_POST['nombre'] : null;*/
require_once "../clases/Cuenta.php";
session_start();
$validado=false;
$usuario = isset($_POST['usuario']) ? $_POST['usuario'] : null;
$numero_de_cuenta = isset($_POST['numero_de_cuenta']) ? $_POST['numero_de_cuenta'] : null;
$monto = isset($_POST['monto']) ? $_POST['monto'] : null;
$contraseña = isset($_POST['contraseña']) ? $_POST['contraseña'] : null;
foreach($_SESSION['USUARIOS'] as $usuario){
    if($usuario -> getUsuario()==$usuario && $usuario -> getContraseña()==$contraseña && $usuario -> getNumerodeCuenta()==$numero_de_cuenta){
        $usuario -> aumentarSaldo($monto);
        $validado=true;
        break;
    }
    
}
if ($validado==true){
    header("Location: ../principal.php");
}
else{
    header("Location: ../consigna.php?error=1");
}
?>
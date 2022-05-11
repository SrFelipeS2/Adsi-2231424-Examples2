<?php
require_once "../clases/Cuenta.php";
session_start();
$error=1;
$usuariob = isset($_POST['usuario']) ? $_POST['usuario'] : null;
$numero_de_cuenta = isset($_POST['numero_de_cuenta']) ? $_POST['numero_de_cuenta'] : null;
$valorretiro = isset($_POST['monto']) ? $_POST['monto'] : null;
$contraseña = isset($_POST['contraseña']) ? $_POST['contraseña'] : null;

foreach($_SESSION['USUARIOS'] as $usuario){
    
    if($usuario -> getUsuario()==$usuariob && $usuario -> getContraseña()==$contraseña && $usuario -> getNumerodeCuenta()==$numero_de_cuenta){
        if($usuario -> getSaldo()>=$valorretiro){
           $usuario -> retirarSaldo($valorretiro);
           $error=0;
        }else{
            $error=2;
        }
        break;
    }
  
}
if ($error==0){
    header("Location: ../principal.php");
}
elseif($error==1){
    header("Location: ../retira.php?error=1");
}else{
    header("Location: ../retira.php?error=2");

}

?>
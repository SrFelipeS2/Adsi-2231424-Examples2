<?php
require_once "../clases/Cuenta.php";
session_start();
$error=1;
$usuario1 = isset($_POST['usuario1']) ? $_POST['usuario1'] : null;
$usuario2 = isset($_POST['usuario2']) ? $_POST['usuario2'] : null;
$contraseña = isset($_POST['contraseña']) ? $_POST['contraseña'] : null;
$numero_de_cuenta1 = isset($_POST['cuenta1']) ? $_POST['cuenta1'] : null;
$numero_de_cuenta2 = isset($_POST['cuenta2']) ? $_POST['cuenta2'] : null;
$monto_enviar = isset($_POST['monto']) ? $_POST['monto'] : null;
foreach($_SESSION['USUARIOS'] as $usuario){
    if($usuario -> getUsuario()==$usuario1 && $usuario -> getContraseña()==$contraseña && $usuario -> getNumerodeCuenta()==$numero_de_cuenta1 && $usuario -> getSaldo() >= $monto_enviar){
        
        foreach($_SESSION['USUARIOS'] as $usuario3){
            if($usuario3 -> getUsuario()==$usuario2 && $usuario3 -> getNumerodeCuenta()==$numero_de_cuenta2){

                $usuario -> retirarSaldo($monto_enviar);
                $usuario3 -> aumentarSaldo($monto_enviar);
                $error=0;

            break; 
            }
        }
      
        break;
    }
}
if($error==0){
header("Location: ../principal.php");
}else{
    header("Location: ../envia.php?error=1");
}



?>
<?php
/*$name = isset($_POST['nombre']) ? $_POST['nombre'] : null;*/
require_once "../clases/Cuenta.php";
session_start();
$validado=false;
$usuariob = isset($_POST['usuario']) ? $_POST['usuario'] : null;
$numero_de_cuenta = isset($_POST['numero_de_cuenta']) ? $_POST['numero_de_cuenta'] : null;
$contraseña = isset($_POST['contraseña']) ? $_POST['contraseña'] : null;

if(!isset($_SESSION['usuarioact'])){
    $_SESSION['usuarioact'] = array(
    );
}
foreach($_SESSION['USUARIOS'] as $usuario){
    if($usuario -> getUsuario()==$usuariob && $usuario -> getContraseña()==$contraseña && $usuario -> getNumerodeCuenta()==$numero_de_cuenta){
        $validado=true;
        $key = array_search($usuario, $_SESSION['USUARIOS']);
        
        /* $_SESSION['usuarioact']= array(
            "numeroCuenta" => $usuario -> getNumerodeCuenta(),
            "nombreUsuario" => $usuario -> getUsuario()
        ); */
        break;
    }
    
}

/* array_push($_SESSION['usuarioact'],$array_temp); */
if ($validado==true){
    header("Location: ../usuarios.php?validado=1&key=$key");
}
else{
    header("Location: ../usuarios.php?error=1");
}
?>
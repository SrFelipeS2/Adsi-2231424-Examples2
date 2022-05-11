<?php
    session_start();
    //para crear constatntes se usa el define()
    define('TIEMPO_SESION', 5);
    //para validar si las sesiones estan creadas
    if(isset($_SESSION['name']) && isset($_SESSION['timeout'])){
        // calcular tiempo de sesion
        $session_time = time() - $_SESSION['timeout'];
       
        if($session_time >= 60*TIEMPO_SESION){
            header('Location:loguin.php?error=2');
        }else{
            $_SESSION['timeout']=time();
        }
    }else{
        header('Location:loguin.php?error=3');
    }
?>
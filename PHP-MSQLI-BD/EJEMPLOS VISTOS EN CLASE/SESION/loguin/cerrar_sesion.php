<?php
    session_start();
    session_destroy();
    setcookie("comprasTxt", 0,time()-1000, "/");
    header('Location:loguin.php');
?>
<?php 
require_once 'sesion.php';
if ($_POST['comprasTxt']!=null) {
    setcookie("comprasTxt",$_POST['comprasTxt'],time()+60*TIEMPO_SESION,"/");
}
header('Location:compras.php');


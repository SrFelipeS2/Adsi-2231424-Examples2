<?php
require_once 'sesion.php';
$_SESSION['name'] = isset($_POST['userTxt']) ? $_POST['userTxt']:$_SESSION['name'];
header('Location:perfil.php');
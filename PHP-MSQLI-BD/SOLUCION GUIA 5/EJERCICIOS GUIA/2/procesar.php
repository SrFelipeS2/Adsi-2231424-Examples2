<?php
if(isset($_POST['radio'])){
    setcookie("titulo",$_POST['radio'],time()+60*60*24*365,"/");
}
?>
<html>
<head>
<title>Problema</title>
</head>
<body>
<br>
<a href="ejercicio2.php">Ir a la otra página</a>
</body>
</html>
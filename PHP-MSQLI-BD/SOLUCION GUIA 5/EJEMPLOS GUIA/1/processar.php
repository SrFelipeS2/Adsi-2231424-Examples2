<?php
    if ($_POST['radio']=="rojo")
    setcookie("color","#ff0000",time()+60*60*24*365,"/");
    elseif ($_POST['radio']=="verde")
    setcookie("color","#00ff00",time()+60*60*24*365,"/");
    elseif ($_POST['radio']=="azul")
    setcookie("color","#0000ff",time()+60*60*24*365,"/");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    se creo la cookie.
    <br>
    <a href="ejemplo1.php">
        ir a la otra pagina
    </a>
</body>
</html>
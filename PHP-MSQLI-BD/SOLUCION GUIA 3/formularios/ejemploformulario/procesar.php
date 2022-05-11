<?php
    // OPERADOR TERNARIO
    $nombre= isset($_POST['nombre']) ? $_POST['nombre'] : "";
    $email= isset($_POST['correo']) ? $_POST['correo'] : "";
    echo "Nombre: ".$nombre; 
    echo '<br>';
    echo "email: ".$email;
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Procesar</title>
</head>
<body>
    
</body>
</html>
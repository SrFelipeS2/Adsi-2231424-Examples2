<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $email= isset($_POST['email']) ? $_POST['email'] : "";
        $nombre= isset($_POST['nombre']) ? $_POST['nombre'] : "";
        $numero= isset($_POST['numero']) ? $_POST['numero'] : "";
        $ciudad= isset($_POST['ciudad']) ? $_POST['ciudad'] : "";
        $edad= isset($_POST['edad']) ? $_POST['edad'] : "";

        echo '<br>';
        echo "email: ".$email;
        echo '<br>';
        echo "Nombre: ".$nombre; 
        echo '<br>';
        echo "Numero telefonico: ".$numero; 
        echo '<br>';
        echo "Ciudad seleccionada: ".$ciudad;
        echo '<br>';
        echo "Edad: ".$edad; 
        echo '<br>';
        
        
    ?>
</body>
</html>
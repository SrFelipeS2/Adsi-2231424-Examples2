<?php  
    $email = isset($_POST['email']) ? $_POST['email'] : "";
    $nombre = isset($_POST['nombre']) ? $_POST['nombre'] : "";
    if(isset($email))
    {
        setcookie('email',$email,time()+60*60*24*365,"/");
    }
    if(isset($nombre))
    {
        setcookie('nombre',$nombre,time()+60*60*24*365,"/");
    }
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
    <a href="EJ1.php">                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        ir a la otra pagina
    </a>
</body>
</html>                                                                                                                                                                                                                                                                                                                         
<?php
require_once "sesion.php";
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Document</title>
    <style>
        body{
           background: #dee2e6; 
        }
        .container-form{
            border: 1px solid #fff;
            padding: 10px;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-4">
                <div class="container-form mt-5 text-center">
                    <a href="cerrar_sesion.php">cerrar Sesion</a>
                    <br>
                       Bienvenido Alumno/a: <?php echo $_SESSION['name'];?>
                </div>  
            </div>
        </div>
    </div>
</body>
</html>
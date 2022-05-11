<?php

$errorLoad = isset($_GET['error']) ? $_GET['error'] : "";


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Formulario 6</title>
</head>
<style>
    body#colores{
        background-color: #72C2D1;
    }
    body div div h3#color{
        background-color: #ffc107;
    }
</style>
<body id="colores">
<div class="row">
    <div class="col-md-8 offset-md-2" >
        <h3 class="mt-5 text-center rounded-pill" id="color">login</h3>
        <form action="procesar.php" method="POST">
            
            <div class="mb-3">
            <label for="Nombre" class="form-label"> User </label>
                <input  type="text" class="form-control" id="Nombre" name="usernombre" aria-describedby="emailHelp">
            </div>
            
            <div class="mb-3">
            <label for="Nombre" class="form-label"> Psword </label>
                <input  type="password" class="form-control" id="Nombre" name="userpass" aria-describedby="emailHelp">
            </div>

            <div class="mb-3">
            <label for="Nombre" class="form-label"> Confirm Your Psword </label>
                <input  type="password" class="form-control" id="Nombre" name="userpassconfirm" aria-describedby="emailHelp">
            </div>

            
            <button type="submit" class="btn btn-warning col-md-4 offset-md-4">
                <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
            </button>
            <div>
      
             <?php
                if ($errorLoad == 1){

                    echo "LAS CONTRASEÑAS NO COINCIDEN";
                }
                if ($errorLoad == 2){

                    echo "INTENTOS MAXIMOS SUPERADOS YA NO PUEDE INICIAR SESION";
                }
                if ($errorLoad == 3){

                    echo "UNO DE LOS CAMPOS ESTA VACIO Ó LOS DOS CAMPOS ESTAN VACIOS";
                }
             ?>
        </div>
        </form>
    </div>
</div>
</body>
</html>
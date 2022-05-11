<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Document</title>
</head>
<style>
body#colores{
        background-color: #72C2D1;
    }
    body div div #color{
        background-color: #ffc107;
    }
    body div div #color2{
        background-color: #B18457;
    }
    body div div #color1{
        background-color: #589670;
    }
</style>
<body id="colores">
<?php
        $email= isset($_POST['email']) ? $_POST['email'] : "";
        $nombre= isset($_POST['nombre']) ? $_POST['nombre'] : "";
        $numero= isset($_POST['numero']) ? $_POST['numero'] : "";
        $ciudad= isset($_POST['ciudad']) ? $_POST['ciudad'] : "";
        $edad= isset($_POST['edad']) ? $_POST['edad'] : "";
        
   ?>
<div class="row">
    <div class="col-md-8 offset-md-2" >
        <h3 class="mt-5 mb-5 text-center rounded-pill" id="color"> RESULTADO FORMULARIO #1 </h3>
            <div class="container overflow-hidden">
                <div class="row gy-5">
                    <div class="col-6 ">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                            <?php
                            echo "email: <br>".$email;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                        <?php
                            echo "nombre: <br>".$nombre;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                        <?php
                            echo "numero: <br>".$numero;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                        <?php
                            echo "ciudad: <br>".$ciudad;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                        <?php
                            echo "edad: <br>".$edad;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                     <?php
                        $edad >= 18 ? include "./mayoredad.php" : include "./menoredad.php";
                    ?>
                    </div>
                </div>
        </div>
    </div>
</div>
</body>
</html>

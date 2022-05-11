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
       
        $nombre= isset($_POST['nombre']) ? $_POST['nombre'] : "";
        $contrato=isset($_POST['contrato']) ? $_POST['contrato'] : "";
        
        
   ?>
<div class="row">
    <div class="col-md-8 offset-md-2" >
        <h3 class="mt-5 mb-5 text-center rounded-pill" id="color"> RESULTADO FORMULARIO #6 </h3>
            <div class="container overflow-hidden">
                <div class="row gy-5">
                    <div class="col-12 ">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                            <?php
                            echo "el nombre del trabajador es: <br>".$nombre;
                            ?>
                        </div>
                    </div>
                    <div class="col-12">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                        <?php
                            echo "el contrato esta firmado: <br>".$contrato;
                            ?>
                        </div>
                    </div>
                </div>
        </div>
    </div>
</div>
</body>
</html>

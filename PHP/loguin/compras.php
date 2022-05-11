<?php
require_once "sesion.php";
$compras = isset($_COOKIE['comprasTxt']) ? $_COOKIE['comprasTxt']: "0";
?>


<!DOCTYPE html>
<html lang="en">

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
<head>
</head>
<body>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-4">
                <div class="container-form mt-5 text-center">
                    <a href="main.php">Inicio</a>
                    <a href="perfil.php">Mi perfil</a>
                    <a href="cerrar_sesion.php">cerrar Sesion</a>
                    <br>
                    <form action="cantidad_compras.php"  method="POST">
                            <div class="my-3 text-center">
                               <h6>Ingrese las compras de <?php echo $_SESSION['name'];?> </h6> 
                            </div>
                            <div class="mb-3 form-floating">
                                <input  class="form-control" type="text" name="comprasTxt" id="comprasTxt" placeholder="nuevo Nombre">
                                <label for="comprasTxt"></label>
                            </div>
                            <div class="mb-3 form-floating justify-content-center">
                                <input type="submit" value="cambiar" class="btn  text-center btn-primary">
                            </div>
                            las comras de  <?php echo $_SESSION['name'];?> son:
                            <?php echo $compras ?>
                    </form>
                </div>  
            </div>
        </div>
    </div>
</body>
</html>
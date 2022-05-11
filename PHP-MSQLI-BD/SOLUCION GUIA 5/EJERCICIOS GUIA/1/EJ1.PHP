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
    body div div h3#color{
        background-color: #ffc107;
    }
</style>
<body id="colores">
<?php
        isset($_COOKIE['email']) ? $_COOKIE['email'] : "";
        isset($_COOKIE['nombre']) ? $_COOKIE['nombre'] : "";
?>
<div class="row">
    <div class="col-md-4 offset-md-4" >
        <h3 class="mt-5 text-center rounded-pill" id="color">FORMULARIO </h3>
        <form action="PROCESAR.PHP" method="POST">
            
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Name</label>
                <input type="text" name="nombre" class="form-control" id="exampleInputPassword1" value="
                <?php
                 if
                    (isset($_COOKIE['nombre'])) echo $_COOKIE['nombre'];
                ?>">
            </div>
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email address</label>
                <input type="email" name="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" <input type="text" name="mailusuario" value="
                <?php
                 if
                    (isset($_COOKIE['email'])) echo $_COOKIE['email'];
                ?>">
                <div id="emailHelp" class="form-text"></div>
            </div>
            
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    </div>
</div>
</body>
</html>





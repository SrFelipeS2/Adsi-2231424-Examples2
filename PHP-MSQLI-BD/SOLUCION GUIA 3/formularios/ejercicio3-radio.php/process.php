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
        background-color: #85629E;
    }
    body div div #color{
        background-color: #72C2D1;
    }
    #color1{
        border: 3px solid #72C2D1 ;
    }
   
    .custom1{
        background:#629E64;
    }
    .custom2{
        background: #629E9D;
    }
    .custom3{
        background: #62679E;
    }
    
</style>
<body id="colores">
<?php
        $nombre= isset($_POST['nombre']) ? $_POST['nombre'] : "";
        $email= isset($_POST['email']) ? $_POST['email'] : "";
        $telefono = isset($_POST['telefono']) ? $_POST['telefono'] : "";
        $cedula = isset($_POST['cedula']) ? $_POST['cedula'] : "";
        $VAR1 = isset($_POST['radio']) ? $_POST['radio'] : "";

        if ($VAR1=="Tecnico")
        {
        $resultado="Tecnico";
        $newclass="custom1";
        }
        if ($VAR1=="Universitario")
        {
        $resultado="Universitario";
        $newclass="custom2";

        }
        else
        if ($VAR1=="Bachillerato")
        {
        $resultado="Bachillerato";
        $newclass="custom3";

        }

        
       
       
            
?>
<div class="row">
    <div class="col-md-8 offset-md-2" >
        <h3 class="mt-5 mb-5 text-center rounded-pill" id="color"> RESULTADO FORMULARIO #2 </h3>
            <div class="container overflow-hidden">
                <div class="row gy-5">
                    <div class="col-4 ">
                        <div id="color1" class="p-3 rounded  bg-light">
                            <?php
                            echo "Nombre: <br>".$nombre;
                            ?>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="color1" class="p-3  rounded  bg-light">
                        <?php
                            echo "Email: <br>".$email;
                            ?>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="color1" class="p-3  rounded  bg-light">
                        <?php
                            echo "Telefono: <br>".$telefono;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                        <div id="color1" class="p-3  rounded  bg-light">
                        <?php
                            echo "Cedula: <br>".$cedula;
                            ?>
                        </div>
                    </div>
                    <div class="col-6">
                        <div id="color1" class="p-3  rounded  <?php echo $newclass ?>">
                        <?php
                            echo "Estudios: <br>".$resultado;
                            ?>
                        </div>
                    </div>
                    
                </div>
        </div>
    </div>
</div>
</body>
</html>
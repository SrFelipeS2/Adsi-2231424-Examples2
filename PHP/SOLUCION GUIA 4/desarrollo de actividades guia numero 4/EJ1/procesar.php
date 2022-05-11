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
        background: #6267;
    }
    .custom4{
        background: #629555;
    }
    .custom5{
        background: #62679F;
    }    
</style>
<body id="colores">
<?php
        $nombre= isset($_POST['nombre']) ? $_POST['nombre'] : "";
        


        if (isset($_POST['chek1']))
        {
            $onecheked="Futbol";
            $newclass1="custom1";
        }else{
            $onecheked ="N/A";
            $newclass1="bg-light";
        }
        if (isset($_POST['chek2']))
        {
            $twocheked="Baloncesto";
            $newclass2="custom2";
        }else{
            $twocheked ="N/A";
            $newclass2="bg-light";
        }
        if (isset($_POST['chek3']))
        {
            $threecheked="Natacion";
            $newclass3="custom3";
        }else{
            $threecheked="N/A";
            $newclass3="bg-light";
        }
        if (isset($_POST['chek4']))
        {
            $fourcheked="Ajedrez";
            $newclass4="custom4";
        }else{
            $fourcheked="N/A";
            $newclass4="bg-light";
        }
        if (isset($_POST['chek5']))
        {
            $fivecheked="Tenis";
            $newclass5="custom5";
        }else{
            $fivecheked="N/A";
            $newclass5="bg-light";
        }
        
       
       
?>
<div class="row">
    <div class="col-md-8 offset-md-2" >
        <h3 class="mt-5 mb-5 text-center rounded-pill" id="color"> RESULTADO FORMULARIO #3 </h3>
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
                        <div id="color1" class="p-3  rounded <?php echo $newclass1 ?> ">
                        <?php
                            echo "primer deporte: <br>".$onecheked;
                            ?>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="color1" class="p-3  rounded <?php echo $newclass2 ?> ">
                        <?php
                            echo "seguno deporte: <br>".$twocheked;
                            ?>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="color1" class="p-3  rounded <?php echo $newclass3 ?> ">
                        <?php
                            echo "tercer deporte: <br>".$threecheked;
                            ?>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="color1" class="p-3  rounded <?php echo $newclass4 ?> ">
                        <?php
                            echo "cuarto deporte: <br>".$fourcheked;
                            ?>
                        </div>
                    </div>
                    <div class="col-4">
                        <div id="color1" class="p-3  rounded <?php echo $newclass5 ?> ">
                        <?php
                            echo "quinto deporte <br>".$fivecheked;
                            ?>
                        </div>
                    </div>
                    
                </div>
        </div>
    </div>
</div>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Array</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<style>
    body#colores{
        background-color: #72C2D1;
    }
    body main div#color{
        background-color: #E5C565;
    }
</style>
<body id="colores">
    <main class="container-md mt-5 col-8 ">
        <div class="row text-center rounded-pill" id="color">
        <h3 class="mt-2"> esto es un archivo para mostrar un arra asociativo</h3>
            <div class="row text-center bg-secondary col-12 ms-0 rounded-pill ">
                <h4>
                <?php
                    $vector1['clave1']=13;
                    $vector1['clave2']=28;
                    $vector1['clave3']=38;
                    $vector1['clave4']=41;
                    $vector1['clave5']=51;

                    echo $vector1['clave1']
                                       
                ?>
                
                </h4>
            </div>
        </div>
    </main>
</body>
</html>
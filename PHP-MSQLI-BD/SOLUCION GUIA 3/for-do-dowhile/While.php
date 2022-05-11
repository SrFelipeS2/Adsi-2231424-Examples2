<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>while tabla de multiplicar 2</title>
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
        <h3 class="mt-2"> esto es un archivo para visualizar un ciclo While</h3>
            <div class="row text-center bg-secondary col-12 ms-0 rounded-pill ">
                <h4>
                    <?php
                        $resultado =20;
                        $inicio=2;
                        while($inicio<=$resultado)
                        {
                        echo $inicio;
                        echo "<br>";
                        $inicio+=2;
                        }
                    ?>
                </h4>
            </div>
        </div>
    </main>
</body>
</html>
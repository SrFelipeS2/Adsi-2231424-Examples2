<?php
include_once('./templates/links.php')
?>
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <title>Buscar Alumnos</title>
    </head>
    <style>
        body#colores{
            background-color: #72C2D1;
            color: #000000 !important;        
        }
        body h3#color{
            color: #000000;
        }
    </style>
    <body id="colores">
        <div class="row">
            <div class="col-md-4 offset-md-4 mt-5 border rounded">
                <h3 id="color" class="text-center">Busqueda de Alumnos</h3>
                <form action="./procesarDatos/buscarAlumno.php" method="POST">
                    <div class="mb-3">
                        <label for="Nombre"  class="form-label"> Ingrese el mail del alumno a consultar: </label>
                        <input type="text" class="form-control" id="Nombre" name="mail" >
                    </div>         
                
                    <button type="submit" class="btn btn-primary d-block mx-auto text-center">
                        <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
                    </button>
                </form>
            </div>
        </div>
    </body>
    </html>

</html>


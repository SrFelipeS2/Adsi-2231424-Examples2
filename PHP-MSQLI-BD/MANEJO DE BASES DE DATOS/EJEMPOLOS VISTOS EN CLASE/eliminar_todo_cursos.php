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
        <title>Eliminar todo Alumno</title>
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
                <h1 id="color" class="text-center warning">Borrado de toda la tabla de Cursos</h1>
                <form action="procesarDatos/eliminarTodoCursos.php" method="POST">
                    <div class="mb-3">
                        <label for="Nombre"  class="form-label">Si usted presiona el boton de abajo se elimina toda la informacion almacenada en la tabla de Cursos, debe de estar seguro en presionarlo </label>
                    </div>         
                
                    <button type="submit" class=" mb-3 btn btn-warning d-block mx-auto text-center">
                        <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
                    </button>
                </form>
            </div>
        </div>
    </body>
    </html>
</html>
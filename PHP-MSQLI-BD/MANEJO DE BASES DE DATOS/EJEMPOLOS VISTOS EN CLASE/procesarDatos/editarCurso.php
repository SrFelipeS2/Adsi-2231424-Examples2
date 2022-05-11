<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Actualizar Curso</title>
</head>
<style>
        body{
            background-color: #72C2D1;
            color: #000000 !important;        
        }
        body h3#color{
            color: #000000;
        }
    </style>
<body>
    <?php
    // Se incluye la clase Conexion
    require_once '../clases/Conexion.php';
    // Se crea un objeto de la clase Conexion
    $connObj = new Conexion();
    // Se llama al método connect, el cual permitirá abrir una conexión a una basede datos MySQL
    $conexion = $connObj->connect();
    $curso = isset($_POST["codigocurso"]) ? $_POST["codigocurso"] : "";
    $SQL = "SELECT * FROM cursos WHERE codigo='$curso'";
    $registros = mysqli_query($conexion, $SQL) or die("Problemas en el select:" .
        mysqli_error($conexion));
    if ($reg = mysqli_fetch_array($registros)) {
        $nombreviejo = $reg['nombrecurso'];
    ?>
    <div class="col-md-4 offset-md-4 mt-5 border rounded">
        <form action="actualizarAlumno.php" method="post">
        <div class="mb-3 col-10 mx-auto text-center">
            <label for="Nombre"  class="form-label"> Ingrese el nombre nuevo del curso </label>
            <input type="text" class="form-control" id="Nombre" name="nombrenuevocurso" value="<?php echo $nombreviejo; ?>">
            <input type="hidden" name="codigocurso" value="<?php echo $curso; ?>">
        </div>   
            <button type="submit" class="btn btn-primary d-block mx-auto text-center">
                        <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
            </button>
        </form>
    </div>
    <?php
    } else {
        echo "No existe curso con dicho ID";
    }
    mysqli_close($conexion);
    ?>
</body>
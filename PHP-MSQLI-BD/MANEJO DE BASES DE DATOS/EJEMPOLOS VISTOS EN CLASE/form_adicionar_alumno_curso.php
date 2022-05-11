<?php
include_once('./templates/links.php')
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Insertar Alumno</title>
</head>
<style>
        body{
            background-color: #72C2D1;
            color: #000000 !important;        
        }
       
    </style>
<body>
<div class="col-md-4 offset-md-4 mt-5 border rounded">
    <form action="procesarDatos/insertarAlumnoC.php" method="post">
        Ingrese nombre:
        <input class="inline-block mx-auto" type="text" name="nombre"><br>
        Ingrese mail:
        <input  class="inline-block mx-auto" type="text" name="mail"><br>
        Seleccione el curso:
        
            <?php
            // Se incluye la clase Conexion
            require_once './clases/Conexion.php';
            // Se crea un objeto de la clase Conexion
            $connObj = new Conexion();
            // Se llama al método connect, el cual permitirá abrir una conexión auna base de datos MySQL
            $conexion = $connObj->connect();
            $registros = mysqli_query($conexion, "SELECT codigo,nombrecurso FROM cursos") or
                die("Problemas en el select:" . mysqli_error($conexion));
                $contador = 0;
            while ($reg = mysqli_fetch_array($registros)) {
                $codigocurso = $reg['codigo'];
                $nombrecurso = $reg['nombrecurso'];
                
                echo "<div class='form-check'>
                <input class='form-check-input' type='radio' name='radio' value='$codigocurso' id='radio$contador' >
                <label class='form-check-label' for='radio$contador'>
                $nombrecurso
                </label>
                </div>";
                $contador++;
            }
            ?>
        </select>
        <br>
        <input type="submit" value="Registrar">
    </form>
</div>
</body>

</html>
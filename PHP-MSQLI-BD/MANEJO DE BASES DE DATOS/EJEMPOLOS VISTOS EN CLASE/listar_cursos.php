<?php
include_once('./templates/links.php');
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Listar Cursos</title>
</head>

<body>
    <?php
    // Se incluye la clase Conexion
    require_once 'clases/Conexion.php';
    // Se crea un objeto de la clase Conexion
    $connObj = new Conexion();
    // Se llama al método connect, el cual permitirá abrir una conexión a una base dedatos MySQL
    $conexion = $connObj->connect();
    $SQL = "SELECT codigo,nombrecurso FROM cursos";
    $registros = mysqli_query($conexion, $SQL) or
        die("Problemas en el select:" . mysqli_error($conexion));
    // Se recorren todos los registros de la Base de Datos
    while ($reg = mysqli_fetch_array($registros)) {
        echo "Codigo:" . $reg['codigo'] . "<br>";
        echo "Nombre:" . $reg['nombrecurso'] . "<br>";
        echo "<br>";
        echo "<hr>";
    }

    // Se cierra la conexión
    mysqli_close($conexion);
    ?>
</body>

</html>
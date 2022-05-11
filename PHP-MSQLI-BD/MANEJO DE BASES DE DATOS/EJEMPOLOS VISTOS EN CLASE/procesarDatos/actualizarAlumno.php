<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Actualizar Alumno</title>
</head>

<body>
    <?php
    // Se incluye la clase Conexion
    require_once '../clases/Conexion.php';
    // Se crea un objeto de la clase Conexion
    $connObj = new Conexion();
    // Se llama al método connect, el cual permitirá abrir una conexión a una base de datos MySQL
    $conexion = $connObj->connect();
    $nombrenuevocurso = isset($_POST["nombrenuevocurso"]) ? $_POST["nombrenuevocurso"] : "";
    $codigocurso = isset($_POST["codigocurso"]) ? $_POST["codigocurso"] : "";
    $SQL = "UPDATE cursos SET nombrecurso='$nombrenuevocurso' WHERE codigo='$codigocurso'";
    mysqli_query($conexion, $SQL) or die("Problemas en el select:" .
        mysqli_error($conexion));
    echo "El el nombre  DEL CURSO fue modificado con exito";
    mysqli_close($conexion);
    ?>
    
</body>

</html>
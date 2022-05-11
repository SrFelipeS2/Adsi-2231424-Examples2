<!DOCTYPE html>
<html lang="en">
<head>
 <meta charset="UTF-8">
 <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <meta http-equiv="X-UA-Compatible" content="ie=edge">
 <title>Eliminar Alumnos</title>
</head>
<body>
<?php
// Se incluye la clase Conexion
require_once '../clases/Conexion.php';
// Se crea un objeto de la clase Conexion
$connObj = new Conexion();
// Se llama al método connect, el cual permitirá abrir una conexión a una base dedatos MySQL
$conexion = $connObj->connect();
mysqli_query($conexion, "DELETE FROM cursos") or die("Problemas en el select:" .
mysqli_error($conexion));
echo "Se efectuó el borrado de todos los cursos.";
mysqli_close($conexion);
?>
</body>
</html>
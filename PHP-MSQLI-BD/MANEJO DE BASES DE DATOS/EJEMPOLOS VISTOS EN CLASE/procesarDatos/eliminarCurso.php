<!DOCTYPE html>
<html lang="en">
<head>
 <meta charset="UTF-8">
 <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <meta http-equiv="X-UA-Compatible" content="ie=edge">
 <title>Elminar alumno</title>
</head>
<body>
<?php
// Se incluye la clase Conexion
require_once '../clases/Conexion.php';
// Se crea un objeto de la clase Conexion
$connObj = new Conexion();
// Se llama al método connect, el cual permitirá abrir una conexión a una base de datos MySQL
$conexion = $connObj->connect();
$nombrecurso = isset($_POST["nombrecuro"]) ? $_POST["nombrecuro"] : "";
$SQL = "SELECT codigo FROM cursos WHERE nombrecurso='$nombrecurso'";
$registros = mysqli_query($conexion, $SQL) or
die("Problemas en el select:" . mysqli_error($conexion));
if ($reg = mysqli_fetch_array($registros)) {
 mysqli_query($conexion, "DELETE FROM cursos WHERE nombrecurso='$nombrecurso'") or
 die("Problemas en el select:" . mysqli_error($conexion));
 echo "Se efectuó el borrado del curso con dicho nombre.";
} else {
 echo "No existe un curso con ese nombre.";
}
mysqli_close($conexion);
?>
</body>
</html>

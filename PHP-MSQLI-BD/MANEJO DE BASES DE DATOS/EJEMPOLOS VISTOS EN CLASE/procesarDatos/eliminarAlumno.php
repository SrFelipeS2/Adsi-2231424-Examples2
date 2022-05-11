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
$mail = isset($_POST["mail"]) ? $_POST["mail"] : "";
$SQL = "SELECT codigo FROM alumno WHERE mail='$mail'";
$registros = mysqli_query($conexion, $SQL) or
die("Problemas en el select:" . mysqli_error($conexion));
if ($reg = mysqli_fetch_array($registros)) {
 mysqli_query($conexion, "DELETE FROM alumno WHERE mail='$mail'") or
 die("Problemas en el select:" . mysqli_error($conexion));
 echo "Se efectuó el borrado del alumno con dicho mail.";
} else {
 echo "No existe un alumno con ese mail.";
}
mysqli_close($conexion);
?>
</body>
</html>
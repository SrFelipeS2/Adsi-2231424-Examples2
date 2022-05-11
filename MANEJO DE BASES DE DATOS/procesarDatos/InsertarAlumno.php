<!DOCTYPE html>
<html lang="en">
<head>
 <meta charset="UTF-8">
 <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <meta http-equiv="X-UA-Compatible" content="ie=edge">
 <title>Insertar Alumno</title>
</head>
    <body>
        <?php
            // Se incluye la clase Conexion
            require_once('../clases/Conexion.php');
            // Se crea un objeto de la clase Conexion
            $connObj = new Conexion();
            // Se llama al método connect, el cual permitirá abrir una conexión a una base de datos MySQL
            $conexion = $connObj->connect();
            // Se reciben los datos del formulario
            $nombre = isset($_POST['nombre']) ? $_POST['nombre'] : "";
            $mail = isset($_POST['mail']) ? $_POST['mail'] : "";
            $coidgocurso = isset($_POST['codigocurso']) ? $_POST['codigocurso'] : "";
            // Se arma la sentencia SQL
            $SQL = "INSERT INTO alumno (nombre,mail,codigocurso) VALUES
            ('$nombre','$mail',$coidgocurso)";
            /* Se ejecuta el método que permite realizar una consulta a la BD.
            Se le envía como parámetros la conexión y la consulta */
            mysqli_query($conexion, $SQL) or die("Problemas en el INSERT" .
            mysqli_error($conexion));
            // Se cierra la conexión
            mysqli_close($conexion);
            echo "El alumno fue dado de alta.";
        ?>
    </body>
</html>

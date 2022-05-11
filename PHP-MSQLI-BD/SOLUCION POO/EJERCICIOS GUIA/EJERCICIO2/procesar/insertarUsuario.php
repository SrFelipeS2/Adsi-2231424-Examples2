<?php
        // Se incluye la clase Conexion
        require_once('../clases/conexion.php');
        // Se crea un objeto de la clase Conexion
        $connObj = new Conexion();
        // Se llama al método connect, el cual permitirá abrir una conexión a una base de datos MySQL
        $conexion = $connObj->connect();
        // Se reciben los datos del formulario
        $docIdentidad = isset($_POST['Doc']) ? $_POST['Doc'] : null;
        $nombre = isset($_POST['nombre']) ? $_POST['nombre'] : "";
        $mail = isset($_POST['mail']) ? $_POST['mail'] : "";
        $codigocurso = isset($_POST['radio']) ? $_POST['radio'] : "";
        // Se arma la sentencia SQL
        $SQL = "INSERT INTO alumno (nombre,mail,codigocurso) VALUES
            ('$nombre','$mail',$codigocurso)";
        /* Se ejecuta el método que permite realizar una consulta a la BD.
            Se le envía como parámetros la conexión y la consulta */
        mysqli_query($conexion, $SQL) or die("Problemas en el INSERT" .
            mysqli_error($conexion));
        // Se cierra la conexión
        mysqli_close($conexion);
        echo "
        <div class='col-md-4 offset-md-4'>
        <h3 class='text-center mt-5'>El Alumno fue dado de alta.</h3>
        </div>";

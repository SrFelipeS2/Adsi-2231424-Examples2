<?php
/*$dbPDO = new PDO("mysql:host=localhost;dbname=database_name",$dbuser,$dbpass);*/
define("DB_DRIVER", "mysql");
define("DB_HOST", "localhost");
define("DB_NAME", "universidad");
define("DB_USER", "root");
define("DB_PASS", "");
try { $dbCon = new PDO(DB_DRIVER . ':host=' . DB_HOST . ';dbname=' . DB_NAME, DB_USER, DB_PASS); $dbCon->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION); 
echo "ingrese";
} catch (PDOException $ex) { echo $ex->getMessage(); die(); }

$stmt = $dbCon->prepare("INSERT INTO alumno (nombre, mail, codigocurso) VALUES (?, ?, ?)");
$nombre = "Peter"; 
$mail = "spydy@gmail.com";
$codigo = 3;
$stmt->bindParam(1, $nombre);
$stmt->bindParam(2, $mail);
$stmt->bindParam(3, $codigo);

//$stmt->execute();

//OTRA MANERA DE INGRESAR VALORES A UNA BASE DE DATOS 
//$stmt = $dbh->prepare("INSERT INTO Clientes (nombre, ciudad) VALUES (:nombre, :ciudad)"); // Bind $nombre = "Charles"; $ciudad = "Valladolid"; $stmt->bindParam(':nombre', $nombre); $stmt->bindParam(':ciudad', $ciudad); // Excecute $stmt->execute(); // Bind $nombre = "Anne"; $ciudad = "Lugo"; $stmt->bindParam(':nombre', $nombre); $stmt->bindParam(':ciudad', $ciudad); // Execute $stmt->execute();

//array asociativo
//$stmt = $dbCon->prepare("INSERT INTO alumno (nombre, mail, codigocurso) VALUES (:nombre, :mail, :codigo)"); 
//$nombre = "Luis";
//$email = "luisitocomunica@misena.edu.co";
//$codigo=3; 
// Bind y execute: 
//if($stmt->execute(array(':nombre'=>$nombre, ':mail'=>$email, ':codigo'=>$codigo))) {
    //echo "Se ha creado el nuevo registro";
//}
 
// Prepare: 
$stmt = $dbCon->prepare("INSERT INTO alumno (nombre, eamil, codigocurso) VALUES (:nombre)"); $nombre = "Morgan"; 
// Bind 
$stmt->bindParam(':nombre', $nombre); // Se enlaza a la variable $nombre 
// Si ahora cambiamos el valor de $nombre: 
$nombre = "John"; $stmt->execute(); 
// Se insertará el cliente con el nombre John
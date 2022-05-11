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
?>
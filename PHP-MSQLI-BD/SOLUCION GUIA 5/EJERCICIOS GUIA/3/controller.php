<?php
session_start();

$user = isset($_POST['userTxt'])? $_POST['userTxt']: null;
$password = isset($_POST['passTxt'])? $_POST['passTxt']: null;
$user_array = array("name"=>$user, "password" => $password);


$users_bd_array = array(
     array("name"=> "Ana", "password"=>"ana@gmail.com"),
     array("name"=> "Felipe", "password"=>"pipe@gmail.com"),
     array("name"=> "Juan", "password"=>"juan@gmail.com"),
     array("name"=> "Bernardo", "password"=>"bernardo@gmail.com"),
     array("name"=> "Julian", "password"=>"julian@gmail.com"),
     array("name"=> "Manuel", "password"=>"manuel@gmail.com")
);

$user_found= false;
//Se busca el array completo dentro del array usarios 
if(in_array($user_array, $users_bd_array)){
 $user_found=true;
}

if($user_found){
    $_SESSION['name']=$user;
    $_SESSION['timeout']=time();
    header('Location:main.php');
}else{
    header('Location:loguin.php?error=1');
}
?>
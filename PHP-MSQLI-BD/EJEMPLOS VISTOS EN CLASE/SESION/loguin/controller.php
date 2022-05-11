<?php
session_start();

$user = isset($_POST['userTxt'])? $_POST['userTxt']: null;
$password = isset($_POST['passTxt'])? $_POST['passTxt']: null;
$user_array = array("name"=>$user, "password" => $password);


$users_bd_array = array(
     array("name"=> "Ana", "password"=>"123"),
     array("name"=> "Felipe", "password"=>"1234"),
     array("name"=> "Juan", "password"=>"1235"),
     array("name"=> "Bernardo", "password"=>"1236"),
     array("name"=> "Julian", "password"=>"1237"),
     array("name"=> "Manuel", "password"=>"1238")
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
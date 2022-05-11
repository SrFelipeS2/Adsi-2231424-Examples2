<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Document</title>
</head>
<style>
body#colores{
        background-color: #72C2D1;
    }
    body div div #color{
        background-color: #ffc107;
    }
    body div div #color2{
        background-color: #B18457;
    }
    body div div #color1{
        background-color: #589670;
    }
</style>
<body id="colores">
<?php
      session_start();

        $username = isset($_POST['usernombre']) ? $_POST['usernombre'] : "";
        $userPasword = isset($_POST['userpass']) ? $_POST['userpass'] : "";
        $userPaswordConfirm = isset($_POST['userpassconfirm']) ? $_POST['userpassconfirm'] : "";
        

    if(!isset($_SESSION['session'])) {
        $_SESSION['session']= array(
            'user_name' => $username,
            'user_password' => $userPasword,
            'user_password_confirm'=>$userPaswordConfirm,
            'user_tries' => 0
        );
    }
    
    
    
    
?>
<div class="row">
    <div class="col-md-8 offset-md-2" >
        <h3 class="mt-5 mb-5 text-center rounded-pill" id="color"> login</h3>
            <div class="container overflow-hidden">
                <div class="row gy-5">
                    <div class="col-12 ">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                            <?php
                            echo $_SESSION['session']['user_name'];
                            ?>
                        </div>
                    </div>
                    <div class="col-12">
                        <div class="p-3 border border-warning rounded border-3 bg-light">
                            <?php
                            echo "intentos de inicio de sesion: ".$_SESSION['session']['user_tries'];
                            echo "<br>";
                            if($userPasword=='' || $userPaswordConfirm==''){
                                header("Location:EJ6.php?error=3");
                            }
                            elseif($_SESSION['session']['user_tries'] <= 2 && ($userPasword == $userPaswordConfirm)){
                               
                                echo "INICIO DE SESION EXITOSO: ";
                                $_SESSION['session']['user_tries']=0;

                            }
                            elseif($_SESSION['session']['user_tries'] > 2){
                              
                                header("Location:EJ6.php?error=2");
                                $_SESSION['session']['user_tries']=0;
                                
                            }elseif($userPasword!=$userPaswordConfirm){
                                header("Location:EJ6.php?error=1");
                                $_SESSION['session']['user_tries']+=1;
                            }
                            ?>
                        </div>
                    </div>
                </div>
        </div>
    </div>
</div>
</body>
</html>

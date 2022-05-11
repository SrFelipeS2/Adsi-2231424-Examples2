<?php
$error = isset($_GET['error'])? $_GET['error'] : null;
    switch($error){
        case 1:
            $msg_error = "Usuario y/o contraseña incorrectos";
            break;
        case 2:
            $msg_error = "Tiempo de sesion expirado, inicie sesion nuevamente";
            break;
        case 3:
            $msg_error = "acceso denegado";
            break;
        default:
            $msg_error="";
            break;
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <style>
        body{
           background: #dee2e6; 
        }
        .container-form{
            border: 1px solid #fff;
            padding: 10px;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-4">
                <div class="container-form mt-3">
                    <form action="controller.php" method="post">
                        <div class="mb-3 mt-3 text-center">
                            <h3>Loguin Users</h3>
                        </div>
                        <div class="mb-3 form-floating">
                            <input type="text" name="userTxt" id="userTxt" class="form-control" placeholder="User">
                            <label for="userTxt">User</label>
                        </div>
                        <div class="mb-3 form-floating">
                            <input type="password" name="passTxt" id="passTxt" class="form-control" placeholder="Password">
                            <label for="passTxt">Password</label>
                        </div>
                        <?php if($error):?>

                            <div class="invalid-feedback mb-3 d-block">
                                <?php echo $msg_error;?>
                            </div>

                        <?php endif;?>
                        <div class="mb-3 text-center">
                            <input type="submit" name=""  value="submit"  id="" class="btn btn-info ">
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
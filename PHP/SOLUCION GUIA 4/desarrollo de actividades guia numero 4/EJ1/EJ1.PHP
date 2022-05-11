<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Formulario 3</title>
</head>
<style>
    body#colores{
        background-color: #72C2D1;
    }
    body div div h3#color{
        background-color: #ffc107;
    }
</style>
<body id="colores">
<div class="row">
    <div class="col-md-4 offset-md-4" >
        <h3 class="mt-5 text-center rounded-pill" id="color">FORMULARIO #3</h3>
        <form action="procesar.php" method="POST">
            <div class="mb-3">
            <label for="Nombre" class="form-label"> Nombre </label>
                <input  type="text" class="form-control" id="Nombre" name="nombre" aria-describedby="emailHelp">
            </div>
           
            <div class="form-check">
                <input class="form-check-input" type="checkbox" name="chek1"   id="onechecked">
                <label class="form-check-label" for="onechecked">
                    FUTBOL
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" name="chek2"   id="twochecked" >
                <label class="form-check-label" for="twochecked">
                    BALONCESTO
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" name="chek3"  id="threechecked">
                <label class="form-check-label" for="threechecked">
                    NATACION
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" name="chek4"  id="fourchecked" >
                <label class="form-check-label" for="fourchecked">
                    AJEDREZ
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" name="chek5"  id="fivechecked">
                <label class="form-check-label" for="fivechecked">
                    TENIS
                </label>
            </div>
        
            <button type="submit" class="btn btn-warning col-md-4 offset-md-4">
                <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
            </button>
        </form>
    </div>
</div>
</body>
</html>
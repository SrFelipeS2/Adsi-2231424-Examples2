<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Formulario 2</title>
</head>
<style>
    body#colores{
        background-color: #85629E;
    }
    #color{
        background-color: #72C2D1;
    }
</style>
<body id="colores">
<div class="row">
    <div class="col-md-4 offset-md-4" >
        <h3 class="mt-5 text-center rounded-pill" id="color">FORMULARIO </h3>
        <form action="procesar.php" method="POST">
            
            <div class="mb-3">
            <label for="Nombre" class="form-label"> Nombre: </label>
                <input  type="text" class="form-control" id="Nombre" name="nombre" aria-describedby="emailHelp">
            </div>
            
            <label for="numero" class="form-label mb-3">Que enunciado del periodico desea?, seleccione una de las siguientes opciones:</label>
            <div class="form-check">
                <input class="form-check-input" type="radio" name="radio" value="esto es una noticia politica" id="flexRadioDefault1" checked>
                <label class="form-check-label" for="radio">
                    Noticia Politica
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="radio" name="radio" value="esto es una noticia economica" id="flexRadioDefault2" checked>
                <label class="form-check-label" for="radio">
                    Noticia Economica
                </label>
            </div>
            <div class="form-check mb-3">
                <input class="form-check-input" type="radio" name="radio" value="esto es una noticia deportiva" id="flexRadioDefault2" checked>
                <label class="form-check-label" for="radio">
                    Noticia Depotiva
                </label>
            </div>
                <button type="submit" class="btn col-md-4 offset-md-4" id="color">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
                </button>
        </form>
    </div>
</div>
</body>
</html>
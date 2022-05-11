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
        <h3 class="mt-5 text-center rounded-pill" id="color">FORMULARIO #2</h3>
        <form action="process.php" method="POST">
            
            <div class="mb-3">
            <label for="Nombre" class="form-label"> Nombre: </label>
                <input  type="text" class="form-control" id="Nombre" name="nombre" aria-describedby="emailHelp">
            </div>
            <div class="mb-3">
                <label for="Email" class="form-label">Email address:</label>
                <input  type="email" class="form-control" id="Email" name="email" aria-describedby="emailHelp">
                <div id="emailHelp" class="">We'll never share your email with anyone else.</div>
            </div>
            <div class="mb-3">
                <label for="numero" class="form-label">Telefono:</label>
                <input  type="number" class="form-control" id="numero"  name="telefono" >
            </div>
            <div class="mb-3">
                <label for="numero" class="form-label">Cedula:</label>
                <input  type="number" class="form-control" id="numero"  name="cedula" >
            </div>
            <label for="numero" class="form-label mb-3">Nivel de estudios:</label>
            <div class="form-check">
                <input class="form-check-input" type="radio" name="radio" value="Bachillerato" id="flexRadioDefault1" checked>
                <label class="form-check-label" for="radio">
                    Bachillerato
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="radio" name="radio" value="Tecnico" id="flexRadioDefault2" checked>
                <label class="form-check-label" for="radio">
                    Tecnico
                </label>
            </div>
            <div class="form-check mb-3">
                <input class="form-check-input" type="radio" name="radio" value="Universitario" id="flexRadioDefault2" checked>
                <label class="form-check-label" for="radio">
                    Universitario
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
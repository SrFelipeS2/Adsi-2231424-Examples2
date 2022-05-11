<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Formulario 1</title>
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
        <h3 class="mt-5 text-center rounded-pill" id="color">FORMULARIO #1</h3>
        <form action="procesar2.php" method="POST">
            <div class="mb-3">
                <label for="Email" class="form-label">Email address</label>
                <input  type="email" class="form-control" id="Email" name="email" aria-describedby="emailHelp">
                <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
            </div>
            <div class="mb-3">
            <label for="Nombre" class="form-label"> Nombre </label>
                <input  type="text" class="form-control" id="Nombre" name="nombre" aria-describedby="emailHelp">
            </div>
            <div class="mb-3">
                <label for="numero" class="form-label">Telefono</label>
                <input  type="number" class="form-control" id="numero"  name="numero" >
            </div>
            <div class="mb-3">
                <label for="exampleselect" class="form-label">Seleccione su Ciudad</label>
                <select class="form-select" id="exampleselect" aria-label="Default select example" name="ciudad">
                    <option selected>Open this select menu</option>
                    <option value="Manizales">Manizales</option>
                    <option value="Bogota">Bogota</option>
                    <option value="Medellin">Medellin</option>
                    </select>
            </div>
            <div class="mb-3">
                <label for="edad" class="form-label">Edad</label>
                <input  type="number" class="form-control" id="edad"  name="edad" >
            </div>
                <button type="submit" class="btn btn-warning col-md-4 offset-md-4">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
                </button>
        </form>
    </div>
</div>
</body>
</html>
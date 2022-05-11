<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Formulario Empleado</title>
</head>
<style>
    body#colores{
        background-color: #72C2D1;
        color: #000000 !important;        
    }
    body h3#color{
        color: #000000;
    }
</style>
<body id="colores">
    <div class="row">
        <div class="col-md-4 offset-md-4">
            <h3 id="color" class="text-center mt-5">Formulario</h3>
            <form action="procesar.php" method="POST">
                <div class="mb-3">
                    <label for="Nombre"  class="form-label"> Nombre </label>
                    <input type="text" class="form-control" id="Nombre" name="nombre" aria-describedby="namelHelp">
                    <div id="namelHelp" class="form-text">you as an employee should fill out this field with your name</div>
                </div>
                <div class="mb-3">
                    <label for="Sueldo" class="form-label"> Sueldo</label>
                    <input type="number" class="form-control" id="Sueldo" name="sueldo" aria-describedby="sueldolHelp">
                    <div id="sueldolHelp" class="form-text">the information you provide here will be verified, so you must write your actual salary.</div>
                </div>
                <div class="mb-3">
                    <label for="Email" class="form-label">Email</label>
                    <input type="email" class="form-control" id="Email" name="email" aria-describedby="emailHelp">
                    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                </div>
                <div class="mb-3">
                    <label for="Fecha" class="form-label">Fecha de nacimiento</label>
                    <input type="date" class="form-control" id="Fecha" name="fecha" aria-describedby="fechalHelp">
                    <div id="fechaHelp" class="form-text">remember that the information must be truthful.</div>
                </div>
                <div class="mb-3">
                    <label for="Peso" class="form-label">Peso</label>
                    <input type="number" class="form-control" id="peso" name="peso" >
                </div>
                <div class="mb-3">
                    <label for="Altura" class="form-label">Altura</label>
                    <input type="number" class="form-control" id="Altura" name="altura">
                </div>
                <button type="submit" class="btn btn-primary d-block mx-auto text-center">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> Submit
                </button>

            </form>
        </div>
    </div>
</body>

</html>
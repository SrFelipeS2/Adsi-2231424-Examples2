<!doctype html>
<html lang="es">

<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css">
    <link rel="stylesheet" href="css/mycss.css">
</head>

<body>
    <header class="container-fluid">
        <div class="row">
            <div class="col-8">
                <nav class="navbar navbar-expand-lg navbar-light bg-light">
                    <div class="container-fluid">
                        <a class="navbar-brand" href="#">Navbar</a>
                        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"></span>
                        </button>
                        <div class="collapse navbar-collapse" id="navbarNavDropdown">
                            <ul class="navbar-nav">

                                <li class="nav-item">
                                    <a class="nav-link" href="index.php?controller=Paciente&action=index">Paciente</a>
                                </li>

                                <li class="nav-item">
                                    <a class="nav-link" href="index.php?controller=Especialidad&action=index">Especialidad</a>
                                </li>

                            </ul>
                        </div>
                    </div>
                </nav>
            </div>
            <div class="col-4">
                <nav class="navbar navbar-light bg-light">
                    <div class="container-fluid">
                        <i class="fa-regular fa-address-card"></i>
                    </div>
                </nav>
            </div>
        </div>
    </header>
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <form action="<?php echo "index.php?controller=paciente&action=editar"; ?>" method="POST">
                    <h2>Editar Paciente</h2>
                    <hr />
                    <div class="form-group">
                        <label for="txtDocumento">Documento: </label>
                        <input type="text" value="<?php echo $datos->documento ?>" class="form-control" id="txtDocumento" name="txtDocumento2">
                    </div>
                    <div class="form-group">
                        <label for="txtNombre">Nombre: </label>
                        <input type="text" value="<?php echo $datos->nombre ?>" class="form-control" id="txtNombre" name="txtNombre2" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtFechaNacimiento">Fecha Nacimiento: </label>
                        <input type="date" value="<?php echo $datos->fecha_nacimiento ?>" class="form-control" id="txtFechaNacimiento" name="txtFechaNacimiento2" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtDireccion">Dirección: </label>
                        <input type="text" value="<?php echo $datos->direccion ?>" class="form-control" id="txtDireccion" name="txtDireccion2" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtTelefono">Teléfono: </label>
                        <input type="text" value="<?php echo $datos->telefono ?>" class="form-control" id="txtTelefono" name="txtTelefono2" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtGenero">Género: </label>
                        <select class="form-control" id="txtGenero" name="txtGenero2">
                            <option value="M">Masculino</option>
                            <option value="F">Femenino</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="txtEstado">Estado: </label>
                        <select class="form-control" id="txtEstado" name="txtEstado2">
                            <option value="activo">Activo</option>
                            <option value="inactivo">Inactivo</option>
                            <option value="multado">Con multa</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="txtEps">EPS: </label>
                        <input type="text" value=" <?php echo $datos->eps ?> " class="form-control" id="txtEps" name="txtEps2" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtEmail">Email: </label>
                        <input type="text" value=" <?php echo $datos->email ?> " class="form-control" id="txtEmail" name="txtEmail2" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtPassword">Contraseña: </label>
                        <input type="password" class="form-control" id="txtPassword" name="txtPassword2" placeholder="">
                    </div>
                    <button type="submit" class="btn btn-success">Actualizar</button>
                </form>

            </div>
            <br><br>
        </div>
        <footer class="container-fluid backg1">
            Senamás - Ejemplo PHP con POO/MVC/PDO - <?php echo date("Y"); ?>
        </footer>

        <!-- Optional JavaScript -->
        <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="js/jquery.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap/bootstrap.min.js"></script>
</body>

</html>
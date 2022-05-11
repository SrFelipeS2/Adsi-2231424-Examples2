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
            <div class="col-lg-4">
                <form action="<?php echo "index.php?controller=paciente&action=create"; ?>" method="post">
                    <h2>Añadir Paciente</h2>
                    <hr />
                    <div class="form-group">
                        <label for="txtDocumento">Documento: </label>
                        <input type="text" class="form-control" id="txtDocumento" name="txtDocumento" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtNombre">Nombre: </label>
                        <input type="text" class="form-control" id="txtNombre" name="txtNombre" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtFechaNacimiento">Fecha Nacimiento: </label>
                        <input type="date" class="form-control" id="txtFechaNacimiento" name="txtFechaNacimiento" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtDireccion">Dirección: </label>
                        <input type="text" class="form-control" id="txtDireccion" name="txtDireccion" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtTelefono">Teléfono: </label>
                        <input type="text" class="form-control" id="txtTelefono" name="txtTelefono" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtGenero">Género: </label>
                        <select class="form-control" id="txtGenero" name="txtGenero">
                            <option value="M">Masculino</option>
                            <option value="F">Femenino</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="txtEstado">Estado: </label>
                        <select class="form-control" id="txtEstado" name="txtEstado">
                            <option value="activo">Activo</option>
                            <option value="inactivo">Inactivo</option>
                            <option value="multado">Con multa</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="txtEps">EPS: </label>
                        <input type="text" class="form-control" id="txtEps" name="txtEps" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtEmail">Email: </label>
                        <input type="text" class="form-control" id="txtEmail" name="txtEmail" placeholder="">
                    </div>
                    <div class="form-group">
                        <label for="txtPassword">Contraseña: </label>
                        <input type="password" class="form-control" id="txtPassword" name="txtPassword" placeholder="">
                    </div>
                    <button type="submit" class="btn btn-success">Guardar</button>
                </form>
            </div>
            <div class="col-lg-8">
                <div>
                    <h2>Pacientes</h2>
                    <hr />
                </div>
                <div class="row">
                    <div class="col-2 ">Documento</div>
                    <div class="col-3 ">Nombre</div>
                    <div class="col-3 ">Telefono</div>
                    <div class="col-2 ">Eps</div>
                    <div class="col-2 border border-2 border-warning ">Opciones</div>
                </div>
                <?php
                if (isset($allPacientes)) {
                    foreach ($allPacientes as $row) { //recorremos el array de objetos y obtenemos el valor de las propiedades
                ?>
                        <div class="row">
                            <div class="col-2 "><?php echo $row->documento ?></div>
                            <div class="col-3 "><?php echo $row->nombre; ?></div>
                            <div class="col-3 "><?php echo $row->telefono; ?></div>
                            <div class="col-2 "><?php echo $row->eps; ?></div>
                            <div class="col-2  d-flex border border-2 border-warning ">
                                <a href="<?php echo "index.php?controller=Paciente&action=borrar&id=" . $row->documento; ?>" class="btn btn-danger">Borrar</a>
                                <a href="<?php echo "index.php?controller=Paciente&action=selection&id=" . $row->documento; ?>" class="btn btn-info">editar</a>
                            </div>
                        </div>
                        <br>
                <?php
                    }
                }
                ?>
            </div>
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
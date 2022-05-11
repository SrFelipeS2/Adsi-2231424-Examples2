<?php
$error = isset($_GET["error"]) ? $_GET["error"] : null;
switch ($error) {
    case 1:
        $mensaje = "LAS CONTRASEÑAS NO COINCIDEN";
        break;
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/01d2baf51f.js" crossorigin="anonymous"></script>
    <title>Pagina Principal</title>
</head>
<style>
    body {
        background-color: #ffffff;
        background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='28' height='49' viewBox='0 0 28 49'%3E%3Cg fill-rule='evenodd'%3E%3Cg id='hexagons' fill='%230086f7' fill-opacity='0.4' fill-rule='nonzero'%3E%3Cpath d='M13.99 9.25l13 7.5v15l-13 7.5L1 31.75v-15l12.99-7.5zM3 17.9v12.7l10.99 6.34 11-6.35V17.9l-11-6.34L3 17.9zM0 15l12.98-7.5V0h-2v6.35L0 12.69v2.3zm0 18.5L12.98 41v8h-2v-6.85L0 35.81v-2.3zM15 0v7.5L27.99 15H28v-2.31h-.01L17 6.35V0h-2zm0 49v-8l12.99-7.5H28v2.31h-.01L17 42.15V49h-2z'/%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
    }

    body section div.color1 {
        background-color: #E5E8E8;

    }

    body header div.color1 {
        background-color: #E5E8E8;

    }

    body header div a.btnc-0 {
        background-color: #69BAEA;

    }

    body section div div button.BG-2:hover {
        background-color: #21CBCA;
    }
</style>
<body>
    <header class="row">
        <div class="row border border-5 border-dark border-primary shadow-lg mx-auto rounded col-8 mt-5 mb-3">
            <div class="col-2 mt-3 mb-2">
                <a class="bordr border-5 border-dark rounded btn p-2 btn mx-auto btnc-0 text-center mb-3" href="index.php" role="button">
                    <i class="fa-solid fa-backward-fast"></i> VOLVER
                </a>
            </div>
            <div class="col-8">
                <h2 class="text-center ">BIAV</h2>
                <h4 class="text-center">(Banco Interamericano Andres Valencia)</h4>
            </div>
        </div>
    </header>
    <section class="row">
        <div class="rounded border border-5  border-dark shadow-lg mx-auto mb-3 mt-3 col-8">

            <div class="border border-5  border-dark mx-auto mb-3 mt-3 color1 ">
                <br>
                <div class="container mb-3">
                    <h4>
                        <i class="fa-solid fa-user-astronaut"></i>
                        Bienvenido a BIAV, le agradecemos por preferirnos.
                    </h4>
                </div>
            </div>
            <div class="border border-5 container border-dark mx-auto mb-3 mt-3 color1 ">
            <form action="./procesar/procesar_registro.php" method="POST">
            <fieldset class="border border-2 border-dark p-4 my-3">
                    <legend>REGISTRARSE</legend>
                    <?php
                        if ($error) :
                        ?>
                            <div class="border border-5 text-center border-warning mx-auto mb-3 mt-3 ">
                            <?php
                            echo $mensaje;
                            echo "</div>";
                        endif;
                            ?>
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1">cual es su nombre completo?</span>
                        <input type="text" class="form-control" required name="nombre" placeholder="Usuario de BIAV" aria-label="Username" aria-describedby="basic-addon1">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1">Defina su Usuario</span>
                        <input type="text" class="form-control" required name="usuario" placeholder="Usuario de BIAV" aria-label="Username" aria-describedby="basic-addon1">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Numero de la Cuenta</span>
                        <input type="number" class="form-control" required name="numero_cuenta" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <label class="input-group-text" for="inputGroupSelect01">Seleccione el tipo de cuenta que desea</label>
                        <select class="form-select" required name="cuenta" id="inputGroupSelect01">
                            <option selected>Choose...</option>
                            <option value="Ahorros">Ahorros</option>
                            <option value="Corriente">Corriente</option>
                            <option value="Nomina">Nomina</option>
                        </select>
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Establezca su Contraseña</span>
                        <input type="password" class="form-control" required name="contra1" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Confirme su Contraseña</span>
                        <input type="password" class="form-control" required name="contra2" aria-label="Amount (to the nearest dollar)">
                    </div>
             
                    <div class="input-group mb-3">
                        <span class="input-group-text">Numero de la Tarjeta</span>
                        <input type="number" class="form-control"  required  name="numero_tarjeta" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Cuals es su Saldo en la Tarjeta?</span>
                        <input type="number" class="form-control" required name="saldo_tarjeta" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <label class="input-group-text" for="inputGroupSelect01">Seleccione el tipo de Tarjeta</label>
                        <select class="form-select" required name="tipo_tarjeta" id="inputGroupSelect01">
                            <option selected>Choose...</option>
                            <option value="Debito">Debito</option>
                            <option value="Credito">Credito</option>
                        </select>
                    </div>
                </fieldset>
                <button class=" mx-auto border border-4 border-dark btn d-block BG-2 text-center mb-3" >
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> REGISTRARSE
                </button>
            </form>    
            </div>
        </div>
    </section>
</body>

</html>
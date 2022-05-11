<?php
$error = isset($_GET["error"]) ? $_GET["error"]: null;
switch($error){
    case 1: $mensaje = "POR FAVOR VERIFIQUE LAS CREDENCIALES DE USUARIO";
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
        background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='80' height='105' viewBox='0 0 80 105'%3E%3Cg fill-rule='evenodd'%3E%3Cg id='death-star' fill='%23ebd45f' fill-opacity='0.32'%3E%3Cpath d='M20 10a5 5 0 0 1 10 0v50a5 5 0 0 1-10 0V10zm15 35a5 5 0 0 1 10 0v50a5 5 0 0 1-10 0V45zM20 75a5 5 0 0 1 10 0v20a5 5 0 0 1-10 0V75zm30-65a5 5 0 0 1 10 0v50a5 5 0 0 1-10 0V10zm0 65a5 5 0 0 1 10 0v20a5 5 0 0 1-10 0V75zM35 10a5 5 0 0 1 10 0v20a5 5 0 0 1-10 0V10zM5 45a5 5 0 0 1 10 0v50a5 5 0 0 1-10 0V45zm0-35a5 5 0 0 1 10 0v20a5 5 0 0 1-10 0V10zm60 35a5 5 0 0 1 10 0v50a5 5 0 0 1-10 0V45zm0-35a5 5 0 0 1 10 0v20a5 5 0 0 1-10 0V10z' /%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
    }

    body section div.color1 {
        background-color: #E5E8E8;
        text-align: justify;
    }

    body header div div a.btnc-0 {
        background-color: #69BAEA;

    }

    body section div div button.BG-1:hover {
        background-color: #CB2152;
    }

    body section div div a.BG-2:hover {
        background-color: #21CBCA;
    }
</style>

<body>
    <form action="procesar/procesar_consigna.php" method="POST">
    <header class="row">
        <div class="row border border-5 border-dark border-primary shadow-lg mx-auto rounded col-8 mt-5 mb-3">
            <div class="col-2 mt-3 mb-2">
                <a class="bordr border-5 border-dark rounded btn p-2 btn mx-auto btnc-0 text-center mb-3" href="principal.php" role="button">
                    <i class="fa-solid fa-backward-fast"></i> INICIO
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
                <div class="container mt-3 mb-3">

                    <h4>
                        <i class=" text-danger fa-solid fa-triangle-exclamation"></i>
                        Recuerde que nostros le brindamos a usted una terjeta fisica debito para retiros y credito para compras en linea, si usted quiere consignar dinero a su cuenta personal NO debe utilizar su tarjeta debito o credito otorgadas por el banco BIAV, si la tarjeta le pertenece a otro usario registrado en el banco BIAV si puede hacer la transferencia de dinero.
                    </h4>
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        A continuacion usted encontrara dos formularios, estos dos formularios se diligencian cuando usted desea hacer una transferencia bancaria a otras entidades financieras, como por ejemplos cuentas de otros bancos etc.

                    </h4>
                    <h4> <i class="fa-solid fa-circle-check"></i>
                        Recuerde que si usted no dispone de medios digitales siempre puede optar por generar codigo de seguridad, aqui lo explicamos mejor:
                        <br>
                        <i class="fa-solid fa-1"></i>:
                        Al momento de presionar el boton "Generar Codigo" usted debera diligenciar dos campos:
                        <br>
                        -el monto del dineroque va a depositar.
                        <br>
                        -la cuenta a la que va a ser depositado el dinero, es importante recalcar que se asegure de que la cuenta a la que este asociando su pago sea la personal, en caso tal de que se equivoque y diligencie mal este campo tiene 3 dias habiles para presentar una reclamacion ante el banco y poder recuperar su dinero.
                        <br>
                        <i class="fa-solid fa-2"></i>:
                        Al momento de usted generar esta clave esta habilitado para depositar el dinero en efectivo en un cajero que presente esta funcionalidad.
                        <br>
                        <i class="fa-solid fa-3"></i>:
                        Tiene 30 minutos para hacer esta operacion, en 30 minutos la clave se invalidara y el cajero automatico no le recibira ninguna suma de dinero.
                        <br>
                        <i class="fa-solid fa-4"></i>:
                        Le recordamos que tenemos oficinas las 24 horas de Lunes a Sabado y que en estas oficinas puede acercarce a hacer sus depositos de dinero con seguridad.
                    </h4>
                </div>
            </div>
            <div class="border border-5 container border-dark mx-auto mb-3 mt-3 color1 ">
                <fieldset class="border border-2 border-dark p-4 my-3">
                    <legend>Persona que Envia</legend>
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1">Nombre de Usuario</span>
                        <input type="text" class="form-control" name="usuario" placeholder="Usuario de BIAV" aria-label="Username" aria-describedby="basic-addon1">
                    </div>

                    <div class="input-group mb-3">
                        <span class="input-group-text">Numero de la Cuenta</span>
                        <input type="number" class="form-control"  name="numero_de_cuenta" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Monto a Enviar</span>
                        <input type="number" class="form-control" name="monto" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Contraseña</span>
                        <input type="password" class="form-control" name="contraseña" aria-label="Amount (to the nearest dollar)">
                        <?php
                         if($error): echo $mensaje;
                         endif;
                        ?>
                    </div>
                </fieldset>
               
                <button  type="submit" class=" border border-4 border-dark btn  mx-auto d-block BG-1 text-center mb-3">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> CONSIGNAR
                </button>
            </div>

        </div>
    </section>
    </form>
</body>

</html>
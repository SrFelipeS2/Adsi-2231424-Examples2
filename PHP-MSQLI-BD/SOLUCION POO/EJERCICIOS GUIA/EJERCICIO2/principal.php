<?php
require_once "clases/Cuenta.php";
session_start();
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
        background-color: #fefdff;
        background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='88' height='88' viewBox='0 0 88 88'%3E%3Cg fill='%23000000' fill-opacity='0.11'%3E%3Cpath fill-rule='evenodd' d='M29.42 29.41c.36-.36.58-.85.58-1.4V0h-4v26H0v4h28c.55 0 1.05-.22 1.41-.58h.01zm0 29.18c.36.36.58.86.58 1.4V88h-4V62H0v-4h28c.56 0 1.05.22 1.41.58zm29.16 0c-.36.36-.58.85-.58 1.4V88h4V62h26v-4H60c-.55 0-1.05.22-1.41.58h-.01zM62 26V0h-4v28c0 .55.22 1.05.58 1.41.37.37.86.59 1.41.59H88v-4H62zM18 36c0-1.1.9-2 2-2h10a2 2 0 1 1 0 4H20a2 2 0 0 1-2-2zm0 16c0-1.1.9-2 2-2h10a2 2 0 1 1 0 4H20a2 2 0 0 1-2-2zm16-26a2 2 0 0 1 2-2 2 2 0 0 1 2 2v4a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-4zm16 0a2 2 0 0 1 2-2 2 2 0 0 1 2 2v4a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-4zM34 58a2 2 0 0 1 2-2 2 2 0 0 1 2 2v4a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-4zm16 0a2 2 0 0 1 2-2 2 2 0 0 1 2 2v4a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-4zM34 78a2 2 0 0 1 2-2 2 2 0 0 1 2 2v6a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-6zm16 0a2 2 0 0 1 2-2 2 2 0 0 1 2 2v6a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-6zM34 4a2 2 0 0 1 2-2 2 2 0 0 1 2 2v6a2 2 0 0 1-2 2 2 2 0 0 1-2-2V4zm16 0a2 2 0 0 1 2-2 2 2 0 0 1 2 2v6a2 2 0 0 1-2 2 2 2 0 0 1-2-2V4zm-8 82a2 2 0 1 1 4 0v2h-4v-2zm0-68a2 2 0 1 1 4 0v10a2 2 0 1 1-4 0V18zM66 4a2 2 0 1 1 4 0v8a2 2 0 1 1-4 0V4zm0 72a2 2 0 1 1 4 0v8a2 2 0 1 1-4 0v-8zm-48 0a2 2 0 1 1 4 0v8a2 2 0 1 1-4 0v-8zm0-72a2 2 0 1 1 4 0v8a2 2 0 1 1-4 0V4zm24-4h4v2a2 2 0 1 1-4 0V0zm0 60a2 2 0 1 1 4 0v10a2 2 0 1 1-4 0V60zm14-24c0-1.1.9-2 2-2h10a2 2 0 1 1 0 4H58a2 2 0 0 1-2-2zm0 16c0-1.1.9-2 2-2h10a2 2 0 1 1 0 4H58a2 2 0 0 1-2-2zm-28-6a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm8 26a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm16 0a2 2 0 1 0 0-4 2 2 0 0 0 0 4zM36 20a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm16 0a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm-8-8a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm0 68a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm16-34a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm16-12a2 2 0 1 0 0 4 6 6 0 1 1 0 12 2 2 0 1 0 0 4 10 10 0 1 0 0-20zm-64 0a2 2 0 1 1 0 4 6 6 0 1 0 0 12 2 2 0 1 1 0 4 10 10 0 1 1 0-20zm56-12a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm0 48a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm-48 0a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm0-48a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm24 32a10 10 0 1 1 0-20 10 10 0 0 1 0 20zm0-4a6 6 0 1 0 0-12 6 6 0 0 0 0 12zm36-36a6 6 0 1 1 0-12 6 6 0 0 1 0 12zm0-4a2 2 0 1 0 0-4 2 2 0 0 0 0 4zM10 44c0-1.1.9-2 2-2h8a2 2 0 1 1 0 4h-8a2 2 0 0 1-2-2zm56 0c0-1.1.9-2 2-2h8a2 2 0 1 1 0 4h-8a2 2 0 0 1-2-2zm8 24c0-1.1.9-2 2-2h8a2 2 0 1 1 0 4h-8a2 2 0 0 1-2-2zM3 68c0-1.1.9-2 2-2h8a2 2 0 1 1 0 4H5a2 2 0 0 1-2-2zm0-48c0-1.1.9-2 2-2h8a2 2 0 1 1 0 4H5a2 2 0 0 1-2-2zm71 0c0-1.1.9-2 2-2h8a2 2 0 1 1 0 4h-8a2 2 0 0 1-2-2zm6 66a6 6 0 1 1 0-12 6 6 0 0 1 0 12zm0-4a2 2 0 1 0 0-4 2 2 0 0 0 0 4zM8 86a6 6 0 1 1 0-12 6 6 0 0 1 0 12zm0-4a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm0-68A6 6 0 1 1 8 2a6 6 0 0 1 0 12zm0-4a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm36 36a2 2 0 1 0 0-4 2 2 0 0 0 0 4z'/%3E%3C/g%3E%3C/svg%3E");
    }

    body section div.color1 {
        background-color: #E5E8E8;
        text-align: justify;
    }
    body section div div.border1 {
        border: dotted 5px #AA7537;
    }

    body section div div a.btnc-1 {
        background-color: #EBD45F ;
    }

    body section div div.border2 {
        border: dotted 5px #76AA37;
    }

    body section div div a.btnc-2 {
        background-color: #6DEB5F ;
    }

    body section div div.border3 {
        border: dotted 5px #3796AA;
    }

    body section div div a.btnc-3 {
        background-color: #5F8DEB ;
    }

    body section div div.border4 {
        border: dotted 5px #8733A2;
    }

    body section div div a.btnc-4 {
        background-color: #CC5FEB;
    }
    body section div div.border5 {
        border: dotted 5px #F60707 ;
    }

    body section div div a.btnc-5 {
        background-color: #F60707 ;
    }
</style>

<body>
    <header class="row ">
        <div class="border border-5 border-dark border-primary shadow-lg mx-auto rounded col-8 mt-5 mb-3">
            <h2 id="color" class="text-center ">BIAV</h2>
            <h4 id="color" class="text-center">(Banco Interamericano Andres Valencia)</h4>
        </div>
    </header>

    <section class="row">

        <div class="rounded border border-5  border-dark shadow-lg mx-auto mb-3 mt-3 col-8">

            <div class="border border-5  border-dark mx-auto mb-3 mt-3 color1 ">
                <br>
                <div class="container mb-3">
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        Bienvenido a la pagina principal del BIAV (Banco Interamericano Andres Valencia), como entidad bancara le recordamos hacer uso responsable de su informacion personal, hacemos enfasis en que no copie las claves de sus tarjetas de credito o debito, la clave asignada a cada usuario es de 4 digitos facil de recordar evitando asi la necesidad de compartirala con familiares y demas personas.
                    </h4>
                </div>
                <div class="container mt-3 mb-3">
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        Le recordamos que esta es nuestra pagina pincipal, nostros No hacemos llamadas ni enviamos mensajes de texto a nuestros clientes.
                    </h4>
                </div>
                <div class="container mb-3 mt-3">
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        Nuestros cajeros automaticos estan a dispocision en toda Latinoamerica y usted tiene acceso a el cambio de divisas automatico sin ningun costo y con valores lo mas aproximados al mercado actual.
                    </h4>
                </div>
            </div>

            <div class=" border border-5  border-dark container color1 mb-3 mt-3 p-4">
                <h4>
                    <i class="fa-solid fa-circle-check"></i>
                    En este espacio usted como Usuario debera seleccionar que accion desea hacer, abajo tendra los botones especificos para cada accion.
                </h4>
                <h4>
                    <i class="fa-solid fa-circle-check"></i>
                    Si necesita ayuda en el siguiente boton encontrara una descripcion detallada de cada uno de los botones que aparecen en el recuadro de abajo, le recomendamos leer atentamente.
                </h4>
                <a class=" bordr border-5 border-dark btn btn-info d-block mx-auto text-center" href="help.php" role="button">
                    <i class="fa-solid fa-circle-question"></i> AYUDA
                </a>
            </div>
            <div class=" border border-5  border-dark container color1 mb-3 mt-3 ">
                <div class="row  col-12 mb-3 mt-3  border1 p-4">
                    <div class="col-5">
                        <h3 class="d-inline">
                            Consignar Dinero
                            <i class="fa-solid fa-circle-arrow-right"></i>
                        </h3>
                    </div>
                    <div class="col-6">
                        <a class=" bordr border-5 border-dark btn btn mx-4 btnc-1 text-center" href="consigna.php" role="button">
                            <i class="fa-solid fa-circle-dollar-to-slot"></i> CONSIGNA
                        </a>
                    </div>
                </div>
                <div class="row col-12 mb-3 mt-3  border2 p-4">
                    <div class="col-5">
                        <h3 class="d-inline">
                            Retira Dinero.
                            <i class="fa-solid fa-circle-arrow-right"></i>
                        </h3>
                    </div>
                    <div class="col-6">
                        <a class=" bordr border-5 border-dark btn btn mx-4 btnc-2 text-center" href="retira.php" role="button">
                            <i class="fa-solid fa-hand-holding-dollar"></i> RETIRAR
                        </a>
                    </div>
                </div>
                <div class="row col-12 mb-3 mt-3  border3 p-4">
                    <div class="col-5">
                        <h3 class="d-inline">
                            Paga tus facturas.
                            <i class="fa-solid fa-circle-arrow-right"></i>
                        </h3>
                    </div>
                    <div class="col-6">
                        <a class=" bordr border-5 border-dark btn btn mx-4 btnc-3 text-center" href="pfactura.php" role="button">
                            <i class="fa-solid fa-file-invoice-dollar"></i> FACTURAS
                        </a>
                    </div>
                </div>
                <div class="row col-12 mb-3 mt-3  border4 p-4">
                    <div class="col-5">
                        <h3 class="d-inline">
                            Transferir Saldo
                            <i class="fa-solid fa-circle-arrow-right"></i>
                        </h3>
                    </div>

                    <div class="col-6">
                        <a class=" bordr border-5 border-dark btn btn mx-4 btnc-4 text-center" href="envia.php" role="button">
                            <i class="fa fa-paper-plane" aria-hidden="true"></i> TRANSFERIR
                        </a>
                    </div>
                </div>
                <div class="row col-12 mb-3 mt-3  border5 p-4">
                    <div class="col-5">
                        <h3 class="d-inline">
                            Cerrar Sesion
                            <i class="fa-solid fa-circle-arrow-right"></i>
                        </h3>
                    </div>

                    <div class="col-6">
                        <a class=" bordr border-5 border-dark btn btn mx-4 btnc-5 text-center" href="index.php" role="button">
                            <i class="fa fa-paper-plane" aria-hidden="true"></i> SALIR
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>

</html>
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
        background-image: url("data:image/svg+xml,%3Csvg width='180' height='180' viewBox='0 0 180 180' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath d='M81.28 88H68.413l19.298 19.298L81.28 88zm2.107 0h13.226L90 107.838 83.387 88zm15.334 0h12.866l-19.298 19.298L98.72 88zm-32.927-2.207L73.586 78h32.827l.5.5 7.294 7.293L115.414 87l-24.707 24.707-.707.707L64.586 87l1.207-1.207zm2.62.207L74 80.414 79.586 86H68.414zm16 0L90 80.414 95.586 86H84.414zm16 0L106 80.414 111.586 86h-11.172zm-8-6h11.173L98 85.586 92.414 80zM82 85.586L87.586 80H76.414L82 85.586zM17.414 0L.707 16.707 0 17.414V0h17.414zM4.28 0L0 12.838V0h4.28zm10.306 0L2.288 12.298 6.388 0h8.198zM180 17.414L162.586 0H180v17.414zM165.414 0l12.298 12.298L173.612 0h-8.198zM180 12.838L175.72 0H180v12.838zM0 163h16.413l.5.5 7.294 7.293L25.414 172l-8 8H0v-17zm0 10h6.613l-2.334 7H0v-7zm14.586 7l7-7H8.72l-2.333 7h8.2zM0 165.414L5.586 171H0v-5.586zM10.414 171L16 165.414 21.586 171H10.414zm-8-6h11.172L8 170.586 2.414 165zM180 163h-16.413l-7.794 7.793-1.207 1.207 8 8H180v-17zm-14.586 17l-7-7h12.865l2.333 7h-8.2zM180 173h-6.613l2.334 7H180v-7zm-21.586-2l5.586-5.586 5.586 5.586h-11.172zM180 165.414L174.414 171H180v-5.586zm-8 5.172l5.586-5.586h-11.172l5.586 5.586zM152.933 25.653l1.414 1.414-33.94 33.942-1.416-1.416 33.943-33.94zm1.414 127.28l-1.414 1.414-33.942-33.94 1.416-1.416 33.94 33.943zm-127.28 1.414l-1.414-1.414 33.94-33.942 1.416 1.416-33.943 33.94zm-1.414-127.28l1.414-1.414 33.942 33.94-1.416 1.416-33.94-33.943zM0 85c2.21 0 4 1.79 4 4s-1.79 4-4 4v-8zm180 0c-2.21 0-4 1.79-4 4s1.79 4 4 4v-8zM94 0c0 2.21-1.79 4-4 4s-4-1.79-4-4h8zm0 180c0-2.21-1.79-4-4-4s-4 1.79-4 4h8z' fill='%23cc5feb' fill-opacity='0.4' fill-rule='evenodd'/%3E%3C/svg%3E");
    }

    body section div.color1 {
        background-color: #E5E8E8;

    }
    body header div a.btnc-0 {
        background-color: #69BAEA;
    }
    body section div div a.btnc-1 {
        background-color: #EBD45F ;
    }
    body section div div a.BG-2:hover {
        background-color: #21CBCA;
    }
</style>

<body>
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
                <br>
                <div class="container mb-3">
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        Bienvenido a la pagina principal de trasnferencias entre usuarios BIAV le recordamos que esta funcion solamente es permitida entre usuarios BIAV, si usted quiere enviar dinero a otra entidad bacnaria, el tramite lo puede hacer por medio del boton:
                        <a class=" bordr border-5 border-dark btn btn mx-4 btnc-1 text-center" href="consigna.php" role="button">
                            <i class="fa-solid fa-circle-dollar-to-slot"></i> CONSIGNA
                        </a>
                        Ó tambien se puede acercar a nuestras oficinas alli tambien puede hacer cualquier tipo de tramite.
                    </h4>
                </div>
                
            </div> 
            <div class="border border-5 container border-dark mx-auto mb-3 mt-3 color1 ">
                <fieldset class="border border-2 border-dark p-4 my-3">
                    <legend>Usuario que envia</legend>
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1">Nombre de Usuario</span>
                        <input type="text" class="form-control" placeholder="Usuario de BIAV" aria-label="Username" aria-describedby="basic-addon1">
                    </div>
                    
                    <div class="input-group mb-3">
                        <span class="input-group-text">Numero de la Cuenta</span>
                        <input type="number" class="form-control" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Monto a Enviar</span>
                        <input type="number" class="form-control" aria-label="Amount (to the nearest dollar)">
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Contraseña</span>
                        <input type="password" class="form-control" aria-label="Amount (to the nearest dollar)">
                    </div>

                </fieldset>
               
                <fieldset class="border border-2 border-dark p-4 my-3">
                    <legend>Usuario que Recibe</legend>
                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1">Nombre de Usuario</span>
                        <input type="text" class="form-control" placeholder="Usuario de BIAV" aria-label="Username" aria-describedby="basic-addon1">
                    </div>

                    <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon2">Email Registrado en el Banco BIAV</span>
                        <input type="text" class="form-control" placeholder="Recipient's username" aria-label="Recipient's username" aria-describedby="basic-addon2">
                    </div>

                    <div class="input-group mb-3">
                        <span class="input-group-text">Numero de la Cuenta</span>
                        <input type="number" class="form-control" aria-label="Amount (to the nearest dollar)">
                    </div>

                </fieldset>
                <a class=" border border-4 border-dark btn d-block BG-2 text-center mb-3" href="envia.php">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> TRANSFERIR
                </a>
            </div>
            </div> 
        </div>          
    </section>
</body>

</html>
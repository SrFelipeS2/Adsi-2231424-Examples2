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
        background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='152' height='152' viewBox='0 0 152 152'%3E%3Cg fill-rule='evenodd'%3E%3Cg id='temple' fill='%23910000' fill-opacity='0.4'%3E%3Cpath d='M152 150v2H0v-2h28v-8H8v-20H0v-2h8V80h42v20h20v42H30v8h90v-8H80v-42h20V80h42v40h8V30h-8v40h-42V50H80V8h40V0h2v8h20v20h8V0h2v150zm-2 0v-28h-8v20h-20v8h28zM82 30v18h18V30H82zm20 18h20v20h18V30h-20V10H82v18h20v20zm0 2v18h18V50h-18zm20-22h18V10h-18v18zm-54 92v-18H50v18h18zm-20-18H28V82H10v38h20v20h38v-18H48v-20zm0-2V82H30v18h18zm-20 22H10v18h18v-18zm54 0v18h38v-20h20V82h-18v20h-20v20H82zm18-20H82v18h18v-18zm2-2h18V82h-18v18zm20 40v-18h18v18h-18zM30 0h-2v8H8v20H0v2h8v40h42V50h20V8H30V0zm20 48h18V30H50v18zm18-20H48v20H28v20H10V30h20V10h38v18zM30 50h18v18H30V50zm-2-40H10v18h18V10z'/%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
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

    body section div div a.BG-2:hover {
        background-color: #21CBCA;
    }
</style>

<body>
    <header class="row">
        <div class="row color1 border border-5 border-dark border-primary shadow-lg mx-auto rounded col-8 mt-5 mb-3">
            <h2 class="text-center ">BIAV</h2>
            <h4 class="text-center">(Banco Interamericano Andres Valencia)</h4>
        </div>
    </header>

    <section class="row">

        <div class="rounded border border-5  border-dark shadow-lg mx-auto mb-3 mt-3 col-8">

            <div class="border border-5  border-dark mx-auto mb-3 mt-3 color1 ">
                <br>
                <div class="container mb-3">
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        Bienvenido a BIAV si es un usuario nuevo debe registrarse
                    </h4>
                    <a class=" border border-4 border-dark btn d-block BG-2 text-center my-3" href="registro.php">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> REGISTRARSE
                </a>
                </div>
            </div>
            <div class="border border-5  border-dark mx-auto mb-3 mt-3 color1 ">
                <br>
                <div class="container mb-3">
                    <h4>
                        <i class="fa-solid fa-circle-check"></i>
                        Si ya es un usuario registrado pulse aqui
                    </h4>
                    <a class=" border border-4 border-dark btn d-block BG-2 text-center my-3" href="principal.php">
                    <i class="fa fa-paper-plane" aria-hidden="true"></i> CONTINUAR
                </a>
                </div>
            </div>
            
        </div>
    </section>
</body>

</html>
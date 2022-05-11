<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    #. Mostrar la fecha y hora del sistema en diferentes formatos
    $saltodelinea = '<br>';
    $fecha = date('w-d-F-o');
    echo "la distribucion de la fecha es la sigueiente: 1 dia de la semana, 2 dia especifico del mes, 3 mes, 4 año: $fecha";
    echo "$saltodelinea";
    echo "$saltodelinea";
    echo date(DATE_RSS);
    echo "$saltodelinea";
    echo "$saltodelinea";


    #. Inicializar las siguientes variables y con la ayuda de la función gettype() mostrar a que tipo de dato pertenecen.
    $a = 5;
    $b = "";
    $c = 5.5;
    $d = true;
    $tipodedatoA = gettype($a);
    $tipodedatoB = gettype($b);
    $tipodedatoC = gettype($c);
    $tipodedatoD = gettype($d);
    echo "el tipo de dato de la palabra A es: $tipodedatoA";
    echo "$saltodelinea";
    echo "el tipo de dato de la palabra B es: $tipodedatoB";
    echo "$saltodelinea";
    echo "el tipo de dato de la palabra C es: $tipodedatoC";
    echo "$saltodelinea";
    echo "el tipo de dato de la palabra D es: $tipodedatoD";
    echo "$saltodelinea";
    echo "$saltodelinea";



    #3. Mostrar el resultado de la función isset() teniendo como parámetro la variable $b.

    if(isset($b)){
        echo "la variable b esta definida";
    }  else {echo "la variable b no esta definida";}
    echo "$saltodelinea";
    echo "$saltodelinea";


    #. Aplicarle a la variable b la función unset(). Mostrar el resultado de la función isset() teniendo como parámetro la variable $b.

    unset($b);
    if(isset($b)){
        echo "la variable b esta definida";
    }else {echo "la variable b no esta definida"; }
    echo "$saltodelinea";
    echo "$saltodelinea";

    # Mostrar el resultado de la función empty() teniendo como parámetro la variable $c
    
    if(empty($c)){
        echo "vacio";
    }else {echo " lleno"; }
    echo "$saltodelinea";
    echo "$saltodelinea";

    #Crear el siguiente arreglo escalar en php.

    $arregloescolar = array("ANA", "JUAN", "PEDRO", "MARIA", "ESTEBAN", "LUIS", "JOSE", "ALEJANDRO");
    foreach ($arregloescolar as $key => $value) {
        echo "$key = $value $saltodelinea";
    }
    echo "$saltodelinea";

    sort($arregloescolar);
    echo "aqui aplicamos la funcion sort ";
    echo "$saltodelinea";
    foreach ($arregloescolar as $key => $value) {
        echo "$key = $value $saltodelinea";
    }
    echo "$saltodelinea";

    rsort($arregloescolar);
    echo "aqui aplicamos la funcion rsort ";
    echo "$saltodelinea";
    foreach ($arregloescolar as $key => $value) {
        echo "$key = $value $saltodelinea";   
    }
    echo "$saltodelinea";
    echo "$saltodelinea";

    $arregloasociativo = array("48"=>"camisa", "75"=>"pantalon", "26"=>"chaqueta", "35"=>"gorra", "45"=>"camiseta", "22"=>"media", "17"=>"correa", "15"=>"zapatos");
    foreach ($arregloasociativo as $key => $value) {
        echo "$key = $value $saltodelinea";   
    }
    echo "$saltodelinea";


    ksort($arregloasociativo);
    echo "aqui aplicamos la funcion ksort ";
    echo "$saltodelinea";
    foreach ($arregloasociativo as $key => $value) {
        echo "$key = $value $saltodelinea";
    }
    echo "$saltodelinea";

    krsort($arregloasociativo);
    echo "aqui aplicamos la funcion krsort ";
    echo "$saltodelinea";
    foreach ($arregloasociativo as $key => $value) {
        echo "$key = $value $saltodelinea";
    }
    echo "$saltodelinea";
    echo "$saltodelinea";

    /*. $cadena = “Devuelve una parte del string definida por los parametros start y 
    length.”.;
    Obtener en la variable $subcadena la frase “definida por los parámetros” a partir 
    de la variable $cadena*/
    $cadena = "Devuelve una parte del string definida por los parametros start y length";
    $subcadena = substr($cadena,30,27);
    echo $cadena;
    echo "$saltodelinea";
    echo $subcadena;
    echo "$saltodelinea";
    echo "$saltodelinea";

    /*Mostrar la cantidad de caracteres que tiene la frase. “El formulario de inscripción 
podrá imprimirse descargándose de la página institucional del SENA.”*/

    $frase = "El formulario de inscripción podrá imprimirse descargándose de la página institucional del SENA.";
    echo strlen($frase);
    echo "$saltodelinea";
    echo "$saltodelinea";

    /* Convertir el siguiente string en un arreglo. “Rosa*Juan*Pedro*Jose”. Mostrar el 
resultado. */

    $valor = "Rosa*Juan*Pedro*jose";
    $arraydestring = explode('*',$valor);
    echo $valor;
    echo "$saltodelinea";
    echo "con la funcion explode:";
    echo "$saltodelinea";
    foreach ($arraydestring as $key => $value) {
        echo "$key = $value $saltodelinea";
    }
    echo "$saltodelinea";
    echo "$saltodelinea";

    /*11. En la siguiente frase, reemplazar las vocales minúsculas por vocales mayúsculas.
“PHP es un lenguaje de programación interpretado, diseñado originalmente para la 
creación de páginas web dinámicas.”
*/
    $frasereemplazo = "PHP es un lenguaje de programación interpretado, diseñado originalmente para la 
    creación de páginas web dinámicas.";
    echo "vocales en miniscula: $frasereemplazo";
    echo "$saltodelinea";
    echo "$saltodelinea";
    $vocalesminusculas = array("a","e","i","o","u");
    $vocalesmayusculas = array("A","E","I","O","U");
    echo str_replace($vocalesminusculas,$vocalesmayusculas,$frasereemplazo);
    echo "$saltodelinea";
    echo "$saltodelinea";

/*mostrar el nombre con mayuscula inicial*/

    $minombrecompleto = "andres felipe valencia lopez";
    $nombreenmayuscula = ucwords($minombrecompleto);
    echo "mi nombre completo $saltodelinea $minombrecompleto";
    echo "$saltodelinea";
    echo $nombreenmayuscula;
    echo "$saltodelinea";
    echo "$saltodelinea";

/*mostrar el email en minusculas*/

    $miemailenmayusculas = "ANDRESVALENCIALOPEZ@GMAIL.COM";
    $miemaileneminusculas = strtolower($miemailenmayusculas);
    echo $miemailenmayusculas;
    echo "$saltodelinea";
    echo $miemaileneminusculas;
    echo "$saltodelinea";
    echo "$saltodelinea";

/*cuantas letras tiene mi nombre */

    $minombresincontar = "Andres felipe Valencia Lopez";
    echo strlen($minombresincontar);
    echo "$saltodelinea";
    echo "$saltodelinea";

/*mostrar los ultimos caracteres del nombre */
    $minombrerecortado = substr($minombresincontar,24,28);
    echo $minombrerecortado;
    echo "$saltodelinea";
    echo "$saltodelinea";


/* definic¿r un vector de nombres  y decir si el nombre de la persona ingresado ya existe */
    $nombremanual = "pepito";

    $nombresarray = array("veronica","pepito","juanchito");

    $nombreexiste = false;

    for($i=0; $i < count($nombresarray); $i++){
        if ($nombremanual==$nombresarray[$i]){
            $nombreexiste=true;
        }
    }
    if ($nombreexiste){
        echo "el nombre ya existe";
    }else{ echo " el nombre no existe ";}

    ?>
</body>
</html>
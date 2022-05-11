<?php
/* en esta linea de cogdigo llamamos la estructura de nuestrro Objeto en este ejemplo el ojeto Persona */
require_once 'clases/persona.php';
require_once 'clases/Producto.php';

/* en esta linea de codigo creamos el objeto como tal y lo incialiazmos*/
/*$UNDEFINED = null;
$persona = new Persona($UNDEFINED);
/*en esta linea de codigo seteamos las propiedades unicas del objeto conforme a la estructura del mismo*/
/*$persona->nombre = 'Fernando';
$persona->apellido = 'Gaitan';
$persona->edad = 26;
/*en esta linea mostramos lo que ya hemos gyuardado en el objeto  */
/*echo $persona -> saludar();

$persona1 = new Persona("Simon");

echo $persona1 -> nombre;
*/

/*$persona = new Persona("Juan","gaviria",38);


echo $persona -> saludar();*/

$producto = new Producto(111, 'Pendrive 8', 'Pendrive marca Kingston de
8GB', 150);
echo 'Id: ' . $producto->get_id() . '<br />';
echo 'Nombre: ' . $producto->get_nombre() . '<br />';
echo 'Descripción: ' . $producto->get_descripcion() . '<br />';
echo 'Precio: $' . $producto->get_precio() . '<br />';
$producto->set_nombre('Pendrive 16');
$producto->set_descripcion('Pendrive marca Kingston de 16GB');
$producto->set_precio(300);
echo '<hr />';
echo 'Id: ' . $producto->get_id() . '<br />';
echo 'Nombre: ' . $producto->get_nombre() . '<br />';
echo 'Descripción: ' . $producto->get_descripcion() . '<br />';
echo 'Precio: $' . $producto->get_precio() . '<br />';



?>
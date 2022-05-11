<?php
require_once 'Vehiculo.php';
class Moto extends Vehiculo {
public function __construct($cantidad_de_ruedas, $marca) {
 parent::__construct(0,$cantidad_de_ruedas,$marca);
}
}
?>
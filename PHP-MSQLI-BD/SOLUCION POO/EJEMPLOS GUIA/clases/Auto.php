<?php
require_once 'Vehiculo.php';
class Auto  extends Vehiculo {

public function __construct($cantidad_de_puertas, $cantidad_de_ruedas, $marca) {
    parent::__construct($cantidad_de_puertas, $cantidad_de_ruedas,$marca);
    }
    
    } ?>
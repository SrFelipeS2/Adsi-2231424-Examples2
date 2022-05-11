<?php
/*Crear una clase llamada cuenta con los atributos (número de cuenta, nombre titular, saldo,
tipo de cuenta). Crear métodos para ingresar dinero a la cuenta, retirar dinero de la cuenta
pagar una factura y transferir saldo a otro usuario. Se debe crear la interfaz para realizar
cada acción y mostrar el resultado*/
class Cuenta{
    private $usuario;
    private $numero_de_cuenta;
    private $nombre_titular;
    private $saldo;
    private $tipo_de_cuenta;
    private $contraseña;
    private $numero_tarjeta;
    private $saldo_tarjeta;
    public function __construct($usuario, $numero_de_cuenta, $nombre_titular, $saldo, $tipo_de_cuenta, $contraseña,$numero_tarjeta,$saldo_tarjeta) {
        $this->usuario = $usuario;
        $this->numero_de_cuenta = $numero_de_cuenta;
        $this->nombre_titular = $nombre_titular;
        $this->saldo = $saldo;
        $this->tipo_de_cuenta = $tipo_de_cuenta;
        $this->contraseña = $contraseña;
        $this -> numero_tarjeta = $numero_tarjeta;
        $this -> saldo_tarjeta = $saldo_tarjeta;
    }
    public function setUsuario($usuario)
    {
        $this -> usuario = $usuario;
    }
    public function getUsuario()
    {
        return $this -> usuario;
    }
    public function setNumerodeCuenta($numero_de_cuenta){
        $this -> numero_de_cuenta = $numero_de_cuenta;
    }
    public function getNumerodeCuenta(){
        return $this -> numero_de_cuenta;
    }
    public function setNombreTitular($nombre_titular){
        $this -> nombre_titular = $nombre_titular;
    }
    public function getNombreTitular(){
        return $this -> nombre_titular;
    }
    public function setSaldo($saldo_cuenta){
        $this -> saldo = $saldo_cuenta;
    }
    public function getSaldo(){
        return $this -> saldo;
    }
    public function setTipoCuenta($tipo_cuenta){
        $this -> tipo_de_cuenta = $tipo_cuenta;
    }
    public function getTipoCuenta(){
        return $this -> tipo_de_cuenta;
    }
    public function setContraseña($contraseña){
        $this -> contraseña = $contraseña;
    }
    public function getContraseña(){
        return $this -> contraseña;
    }
    public function setNumeroTarjeta($numero)
    {
        $this -> numero_tarjeta = $numero;
    }
    public function getNumeroTarjeta()
    {
        return $this -> numero_tarjeta;
    }
    public function setSaldoTarjeta($saldo)
    {
        $this -> saldo_tarjeta = $saldo;
    }
    public function getSaldoTarjeta()
    {
        return $this -> saldo_tarjeta;
    }
    public function aumentarSaldo($monto){
        $this -> saldo = $this->saldo + $monto;
    }
}
?>
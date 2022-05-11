<?php
class Empleado
{
    public $nombre;
    public $sueldo;
    public $email;
    public $fecha_de_nacimiento;
    public $peso;
    public $altura;
    public function __construct($nombre, $sueldo, $email, $fecha_de_nacimiento, $peso, $altura)
    {
        $this->nombre = $nombre;
        $this->sueldo = $sueldo;
        $this->email = $email;
        $this->fecha_de_nacimiento = $fecha_de_nacimiento;
        $this->peso = $peso;
        $this->altura = $altura;
    }
    public function informacion()
    {
        $sipaga = ' el debe pagar impuestos';
        $nopaga = ' el no debe pagar impuestos';

        return 'el nombre del empleado es: ' . $this->nombre . 'el sueldo del empleado es:' . $this->sueldo .
            'y ' . ($this->impuestos() ? $sipaga : $nopaga . 'y') . $this->edad() ;
    }
    private function impuestos()
    {
        return $this->sueldo > 2000000;
    }
    public function edad()
    {
        $fecha_nac = new DateTime($this->fecha_de_nacimiento);
        $fecha_actual = new DateTime(date('Y-m-d'));
        $edad_persona = $fecha_actual->diff($fecha_nac);
        $devolver = $edad_persona->format('%y') ;
        if ($devolver >= 18) {
            $devolver = $devolver . '  años esta habilitado para votar';
        } else {
            $devolver = $devolver . ' años no esta habilitado para votar';
        }
        return $devolver;
    }
}

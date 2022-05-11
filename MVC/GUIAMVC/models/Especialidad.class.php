<?php

class Especialidad extends BaseModel
{
    private $codigo;
    private $nombre;
    private $descripcion;


    public function __construct($codigo = null, $nombre = null, $descripcion = null,
    ){
        $this->table = "especialidad"; // tabla asociada en la base de datos
        $this->codigo = $codigo;
        $this->nombre = $nombre;
        $this->descripcion = $descripcion;
        parent::__construct();
    }
    public function getCodigo()
    {
        return $this->codigo;
    }
    public function getNombre()
    {
        return $this->nombre;
    } 
    public function getDescripcion()
    {
        return $this->descripcion;
    }
    public function setCodigo($codigo)
    {
        $this->codigo = $codigo;
        
    }
    public function setNombre($nombre)
    {
        $this->nombre = $nombre;
        return $this;
    }
    public function setDescripcion($descripcion)
    {
        $this->descripcion = $descripcion;
        return $this;
    }

    public function save()
    {
        // Preparar la consulta para insertar un paciente en la BD
        $sql = $this->dbConnection->prepare("INSERT INTO especialidad (codigo, nombre, descripcion) VALUES (?, ?, ?)");

        $codigo = $this->codigo;
        $nombre = $this->getNombre();
        $descripcion = $this->getDescripcion();
        

        $sql->bindParam(1, $codigo);
        $sql->bindParam(2, $nombre);
        $sql->bindParam(3, $descripcion);
        
        // Excecute
        $sql->execute();
    }
  /*   public function editar(){
        $sql = $this -> dbConnection -> prepare("UPDATE especialidad set nombre = ?, descripcion = ? WHERE codigo = ?");

        $codigo = $this->getCodigo();
        $nombre = $this->getNombre();
        $descripcion = $this->getDescripcion();
      
        //$pass = $this->getPassword();

        $sql->bindParam(1, $nombre);
        $sql->bindParam(2, $descripcion);
        $sql->bindParam(3, $codigo);

        
        // Excecute
        $sql->execute();

       

    } */
}

<?php
class BaseModel extends Connection 
{ 
    protected $table; 
    
    public function __construct()
    {
    // Se llama al constructor de la clase Padre 
    parent::__construct(); 
    }
    public function getAll() 
    {
        try {
             // FETCH_OBJ 
            $sql = $this->dbConnection->prepare("SELECT * FROM ".$this->table);
             
            // Ejecutamos 
            $sql->execute();
            $resultSet = null;
            // Ahora vamos a indicar el fetch mode cuando llamamos a fetch: 
            while ($row = $sql->fetch(PDO::FETCH_OBJ)) { 
                $resultSet[] = $row; 
            } 
            return $resultSet; 
        } catch (PDOException $ex) {
            echo $ex->getMessage();
            die(); 
        } 
    }
    public function selection($key_field, $id){
        $sql = $this -> dbConnection -> prepare("SELECT * from $this->table WHERE $key_field=?");
        $sql ->bindParam(1, $id);
        $sql -> execute();
        $resultSet= null;
        if ($row = $sql->fetch(PDO::FETCH_OBJ)) { 
            
            $resultSet = $row; 
        }
      return $resultSet; 
    } 
    public function borrar($key_field, $id){

        $sql = $this -> dbConnection -> prepare("DELETE from $this->table WHERE $key_field = ?");
        $sql ->bindParam(1, $id);
        $sql -> execute();
   
    }
    public function editar($array, $pk, $pkey){
        $identificacionDatos=[];
        $sentencia = "UPDATE $this->table set ";
        foreach($array as $key => $value){
            $sentencia.= $key."= ?, ";
            $identificacionDatos[]=$value; 
        }
        $sentencia1="";
        $sentencia1.= rtrim($sentencia, ", " ); 
        $sentencia1.= "WHERE ". $pk. "=?";
        $identificacionDatos[]=$pkey;
        echo $sentencia1;
        
        $sql = $this -> dbConnection -> prepare($sentencia1);
        $sql -> execute($identificacionDatos);
    }
      
     /* * Aqui podemos incluir los demás métodos que nos ayuden * a hacer operaciones con la base de datos de forma común */ 
}
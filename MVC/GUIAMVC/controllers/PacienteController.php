<?php
class PacienteController extends BaseController
{
    
    public function __construct()
    {
        parent::__construct(); 
    } 
    
    public function index() 
    {
        //Creamos el objeto usuario
        $paciente_obj = new Paciente();
        //Conseguimos todos los usuarios
        $allPacientes = $paciente_obj->getAll();
        
/*         $especialidad = new Especialidad();
        $lista_especialidades = $especialidad->getAll(); */
        require_once 'views/indexView.php'; 
    } 

    public function indexReloaded(){
        $paciente_obj = new Paciente();
        $pacientes = $paciente_obj->getAll();
        foreach($pacientes as $item){
            echo "Nombre ".$item->nombre."<br>";
            echo "Documento ".$item->nombre."<br>";
            echo "Fecha De N ".$item->nombre."<br>";
            echo "Nombre ".$item->nombre."<br>";

        }
    }

    public function create() 
    {
        if (isset($_POST["txtNombre"])) { 
            $nombre = isset($_POST['txtNombre']) ? $_POST['txtNombre'] : "";
            $documento = isset($_POST['txtDocumento']) ? $_POST['txtDocumento'] : "";
            $fecha_nac = isset($_POST['txtFechaNacimiento']) ? $_POST['txtFechaNacimiento'] : ""; 
            $direccion = isset($_POST['txtDireccion']) ? $_POST['txtDireccion'] : ""; 
            $telefono = isset($_POST['txtTelefono']) ? $_POST['txtTelefono'] : ""; 
            $estado = isset($_POST['txtEstado']) ? $_POST['txtEstado'] : ""; 
            $genero = isset($_POST['txtGenero']) ? $_POST['txtGenero'] : ""; 
            $eps = isset($_POST['txtEps']) ? $_POST['txtEps'] : ""; 
            $email = isset($_POST['txtEmail']) ? $_POST['txtEmail'] : ""; 
            $password = isset($_POST['txtPassword']) ? $_POST['txtPassword'] : "";
            
            // Crear Objeto Paciente con los datos del formulario 
            $paciente_obj = new Paciente($documento, $nombre, $direccion, $telefono, $fecha_nac, $estado, $genero, $eps, $email, $password); 
            
            // Se llama al metodo que inserta en la base de datos. 
            $paciente_obj->save();
        
        } 
        header("Location:index.php?controller=Paciente&action=index"); 
    } 
    
    public function hola() 
    { 
        echo "Hola ADSI día"; 
    } 

    public function Operacion(){
    $n1=8;
    $n2=22;

    echo "la suma es:" .$n1+$n2;

    }
    public function getOperacion(){
        $n1= isset($_GET["n1"]) ? $_GET["n1"]: 0;
        $n2= isset($_GET["n2"]) ? $_GET["n2"]: 0;
        $suma = $n1+$n2;
        echo "la suma es:" . $suma;
    
     }

    public function borrar(){
     $id=isset($_GET["id"]) ? $_GET["id"]: 0;
     $paciente = new Paciente($id);
     $paciente -> borrar("documento",$id);
     header("Location:index.php?controller=Paciente&action=index"); 
    }

    public function editar(){
        
        if(isset($_POST['txtDocumento2'])){
            $documento = isset($_POST['txtDocumento2']) ? $_POST['txtDocumento2'] : null;
            $nombre = isset($_POST['txtNombre2']) ? $_POST['txtNombre2'] : null;
            $fecha_nac = isset($_POST['txtFechaNacimiento2']) ? $_POST['txtFechaNacimiento2'] : null; 
            $direccion = isset($_POST['txtDireccion2']) ? $_POST['txtDireccion2'] : null; 
            $telefono = isset($_POST['txtTelefono2']) ? $_POST['txtTelefono2'] : null; 
            $estado = isset($_POST['txtEstado2']) ? $_POST['txtEstado2'] : null; 
            $genero = isset($_POST['txtGenero2']) ? $_POST['txtGenero2'] : null; 
            $eps = isset($_POST['txtEps2']) ? $_POST['txtEps2'] : null; 
            $email = isset($_POST['txtEmail2']) ? $_POST['txtEmail2'] : null;
            $array = array(
                "nombre"=>$nombre,
                "direccion"=>$direccion,
                "telefono"=>$telefono,
                "fecha_nacimiento"=>$fecha_nac,
                "estado"=>$estado,
                "genero"=>$genero,
                "eps"=>$eps,
                "email"=>$email

            ); 
            $paciente_obj = new Paciente(); 
            $paciente_obj -> editar($array, "documento", $documento);
            header("Location:index.php?controller=Paciente&action=index"); 
    
        }
        
    }
    public function selection(){
        $id=isset($_GET["id"]) ? $_GET["id"]: "";
        if($id){
         $paciente = new Paciente($id);
         $datos = $paciente -> selection("documento", $id);
         require_once "views/editar.php";
        }
    }

}
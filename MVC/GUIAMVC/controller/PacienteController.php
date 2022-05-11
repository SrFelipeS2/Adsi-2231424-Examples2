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
}
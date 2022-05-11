<?php
class EspecialidadController extends BaseController
{

    public function __construct()
    {
        parent::__construct();
    }

    public function index()
    {
        $especialidad = new Especialidad();
        $lista_especialidades = $especialidad->getAll();
        require_once 'views/IndexEspecialidad.php';
    }


    public function create()
    {
        if(!empty($_POST['txtCodigo'])){
            $codigo = isset($_POST['txtCodigo']) ? $_POST['txtCodigo'] : "";
            $nombre = isset($_POST['txtNombre']) ? $_POST['txtNombre'] : "";
            $descripcion = isset($_POST['txtDescripcion']) ? $_POST['txtDescripcion'] : "";
            $almacenado = false;
            $especialidad_obj = new Especialidad();
            $validacion = $especialidad_obj->getAll();
            foreach ($validacion as $val) {
                if ($val -> codigo == $codigo) {
                    $almacenado = true;
                    break;
                }
            };
            if ($almacenado == false) {
                // Crear Objeto Paciente con los datos del formulario 
                $especialidad_obj = new Especialidad($codigo, $nombre, $descripcion);
                echo $codigo . $nombre . $descripcion;
                // Se llama al metodo que inserta en la base de datos. 
                $especialidad_obj->save();
            }
        
        }
           
        header("Location:index.php?controller=Especialidad&action=index");
    }


    public function borrar()
    {
        $id = isset($_GET["id"]) ? $_GET["id"] : 0;
        $especialidad_obj = new Especialidad($id);
        $especialidad_obj->borrar("codigo", $id);
        header("Location:index.php?controller=Especialidad&action=index");
    }

    public function editar()
    {
        $codigo = isset($_POST['txtCodigo']) ? $_POST['txtCodigo'] : null;
        $nombre = isset($_POST['txtNombre']) ? $_POST['txtNombre'] : null;
        $descripcion = isset($_POST['txtDescripcion']) ? $_POST['txtDescripcion'] : null;

        $array = array(
            "nombre" => $nombre,
            "descripcion" => $descripcion
        );

        $especialidad_obj = new Especialidad();
        $especialidad_obj->editar($array, "codigo", $codigo);
        header("Location:index.php?controller=Especialidad&action=index");
    }
    public function selection()
    {
        $id = isset($_GET["id"]) ? $_GET["id"] : "";
        if ($id) {
            $especialidad = new Especialidad($id);
            $datos = $especialidad->selection("codigo", $id);
            require_once "views/editarEspecialidad.php";
        }
    }
}

document.getElementById("btn_enviar").addEventListener("click", ajax);

function ajax(){
    console.log("ejecucin funcion ajax");
    let data = new FormData();
    data.append("num1", 8);
    data.append("num2", 8);

    const XMLHttpRequestObject = new XMLHttpRequest();
    const url = 'XMLHttpReqProcess.php';

    XMLHttpRequestObject.onreadystatechange = function(){
        console.log("Codigo de estado de peticion:", this.readyState);
        if(this.readyState == 4){
            if(this.status == 200){
                console.log(this.responseText);
            }else{
                console.log("Error en el recurso")
            }
        }
    }    
    XMLHttpRequestObject.open('POST', url);
    XMLHttpRequestObject.send(data)
}
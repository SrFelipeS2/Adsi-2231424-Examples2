document.getElementById("btn_enviar").addEventListener("click", ajax);

function ajax(event){
    console.log("ejecucin funcion ajax");

    event.preventDefault();

    let myForm = document.getElementById("myForm");

    const url = 'XMLHttpReqProcess.php';
    const XMLHttpRequestObject = new XMLHttpRequest();

    XMLHttpRequestObject.addEventListener('load', result);
    XMLHttpRequestObject.open('POST', url);
    XMLHttpRequestObject.send(new FormData(myForm));

    /* let data = new FormData();
    data.append("num1", 8);
    data.append("num2", 8);

    const XMLHttpRequestObject = new XMLHttpRequest();
    const url = 'XMLHttpReqProcess.php';

    XMLHttpRequestObject.onreadystatechange = function(){
        console.log("Codifo de estado de peticion:", this.readyState);
        if(this.readyState == 4){
            if(this.status == 200){
                console.log(this.responseText);
            }else{
                console.log("Error en el recurso")
            }
        }
    }     
    XMLHttpRequestObject.open('POST', url);
    XMLHttpRequestObject.send(data) */
}
function result(){
    console.log("evento load>", this.readyState);
    if(this.readyState == 4){
        if(this.status == 200){
            console.log("Respuesta> ", this.responseText);
        }else{
            console.log("Error en el recurso")
        }
    }
}
document.getElementById("btn_enviar").addEventListener("click", ajax);
let myForm = document.getElementById("myForm");

function ajax(event){
    event.preventDefault();
    const url = "fetch.php";
    fetch(url,{
        method: 'POST',
        body: new FormData(myForm)   
    })
    .then(resp =>{
        if(resp.ok)
            return resp.text();
        else
            throw new Error("error en la llamada");
    })
    .then(data=>{
        document.getElementById('contenido').innerHTML = data
    })
}

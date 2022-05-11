let baseUrl ="https://restcountries.com/v3.1/";
document.getElementById('Listado').addEventListener("click", list);

function list(){
    document.getElementById("Api-Paises").innerHTML =`
    <div class="row">
        <h1> 
             List of Countries 
         </h1>
            <form>
                <select class="form-control" id="select-C">
                <option value="">seleccione un pais</option>
             </select>
            </form>
            <table class="table">
     <thead>
        <tr>
        <th scope="col">id</th>
        <th scope="col">Name</th>
        <th scope="col">population</th>
        <th scope="col">capital</th>
        <th scope="col">flag</th>
        </tr>
    </thead>
    <tbody id="contenidoLista">
    
    </tbody>
    </table>
    </div>
    `;
    
    document.querySelector('#select-C').addEventListener('change', getlist)
    traerPaises();
}

    function traerPaises(){
        fetch(baseUrl + 'all')
        .then(resp=>resp.json())
        .then(data=>{
            for (let item of data){
                document.getElementById('select-C').innerHTML +=`
                <option value="${item.name.common}">${item.name.common}</option>
                `
            }
        })
    };
   
    function getlist(){
        fetch( baseUrl + 'name/' + this.value)
        .then(resp=>{
            if(resp.ok)
                return resp.json();
            else
            throw new Error("Error en la llamada");
        })
        .then(data =>{
            document.getElementById("contenidoLista").innerHTML =`
            <tr>
                <th scope="row">${data[0].ccn3}</th>
                <td>${data[0].name.common}</td>
                <td>${data[0].population}</td>
                <td>${data[0].capital}</td>
                <td><img src="${data[0].flags.png}" alt="" wdith="100px" class="img-fluid"></td>
            </tr>
            `;
        })
        .catch(error => console.error(error));
    }





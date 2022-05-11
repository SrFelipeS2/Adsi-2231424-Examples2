const url = "https://min-api.cryptocompare.com/data/top/exchanges?fsym=BTC&tsym=USD";
document.getElementById("api").addEventListener("click", ()=>{
  document.getElementById("Api-Paises").innerHTML =`
    <div class="row text-info  mx-auto my-3 border border-danger border-4 rounded-3 lh-lg">
    <div class="container my-3">
        <h1> 
             List of Crypto
         </h1>
            <form>
                <select class="form-control" id="select-C">
                <option value="">seleccione una criptomoneda</option>
             </select>
            </form>
            <table class="table text-info">
     <thead> 
        <tr>
        <th scope="col">nombre</th>
        <th scope="col">calificacion</th>
        <th scope="col">precio</th>
        </tr>
    </thead>
    <tbody id="contenidoLista">
    
    </tbody>
    </table>
    </div>
    </div>
    `;
    document.querySelector('#select-C').addEventListener('change', getlist)
    traerPaises();    
  }) 
    function traerPaises(){
        fetch(url)
        .then(resp=>resp.json())
        .then(data=>{
            for (let item of data.Data){
                document.getElementById('select-C').innerHTML +=`
                <option value="${item.exchange}">${item.exchange}</option>
                `
            }
        })
    };
   
    function getlist(){
      console.log(this.value)
        fetch( url)
        .then(resp=>{
            if(resp.ok)
                return resp.json();
            else
            throw new Error("Error en la llamada");
        })
        .then(datos =>{
          console.log(datos)
          datos.Data.map((Excha =>{
            if(Excha.exchange == this.value){
              document.getElementById("contenidoLista").innerHTML =`
              <tr>
                  <th scope="row">${Excha.exchange}</th>
                  <td>${Excha.exchangeGradePoints}</td>
                  <td>${Excha.price}</td>
              </tr>
              `;
            }
          }))
        })
        .catch(error => console.error(error));
    }
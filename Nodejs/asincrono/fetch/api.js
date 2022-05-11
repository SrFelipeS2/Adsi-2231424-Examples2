document.getElementById("api").addEventListener("click", ()=>{

const url = "https://restcountries.com/v3.1/all";
fetch(url)
.then(info => info.json())
.then(datos => {
	let structure = "";
	console.log(datos);
	datos.map((pais =>{
		structure +=`
		
		<div class="mx-auto mb-2 my-3 text-wrap border border-warning rounded border-5 p-2">
		<img class="mb-2 img-fluid" src="${pais.flags.png}">					
		<p>Nombre: ${pais.name.common}</p>	
		<p>Capital: ${pais.capital}</p>	
		<p>Poblacion: ${pais.population}</p>	
		</div>`
		
	}))
	document.getElementById("Api-Paises").innerHTML=structure;
})
.catch(error => console.log(error))

})
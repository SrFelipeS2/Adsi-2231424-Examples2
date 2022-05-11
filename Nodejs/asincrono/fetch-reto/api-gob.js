document.getElementById("api").addEventListener("click", ()=>{

    const url = "https://db.ygoprodeck.com/api/v7/cardinfo.php?";
    fetch(url)
    .then(info => info.json())
    .then(datos => {
        let structure = "";
        console.log(datos);
         datos.data.map((x =>{
            structure +=`
            
            <div class="mx-auto mb-2 my-3 text-wrap text-info border border-warning rounded border-5 p-2">		
            <p>Nombre: ${x.name}</p>
            <p>departamen: ${x.species}</p>	
            <td><img src="${x.card_images[0].image_url}" alt="" wdith="100px" class="img-fluid"></td>
            </div>`
            
        }))
        document.getElementById("Api-Paises").innerHTML=structure; 
    })
    .catch(error => console.log(error))
    
})
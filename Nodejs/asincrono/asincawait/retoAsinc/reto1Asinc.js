document.getElementById("pag").addEventListener("change", getNumCardscalculate)
 function getNumCardscalculate(){
    console.log(this.value)
    app.paginationApiYugi(this.value)
}
/* document.getElementById("pag").addEventListener("change", ()=>{
    console.log(this.value)
}) */
const app={

    baseAll : 'https://db.ygoprodeck.com/api/v7/cardinfo.php?',
    
    getPictures : async function (num=10, offset=0){
        const resp = await fetch(`${this.baseAll}offset=${offset}&num=${num}`);
        const cards = await resp.json();
        console.log(cards)
        if(resp.status !== 200)
            throw Error(`Message: ${data.message}`);
        this.renderPicture(cards);
    },
    renderPicture:(data)=>{
        let structure = "";
        data.data.map((x =>{
            structure +=`
            <div class="mx-5 my-4  text-wrap  border border-warning rounded border-5 p-2 w-25 ">		
            <p class=" fw-bolder  text-wrap fst-italic color3  d-inline-block rounded w-100 ">Nombre: ${x.name}</p>
            <p class=" fw-bolder  text-wrap fst-italic color3  d-inline-block rounded w-100 ">Poder de ataque: ${x.atk}</p>
            <p class=" fw-bolder  text-wrap fst-italic color3  d-inline-block rounded w-100 ">Tipo de carta: ${x.archetype}</p>	
            <td><img src="${x.card_images[0].image_url}" alt="" class="h-60 my-auto w-30 d-block img-fluid mx-auto"></td>
            <p class="my-2 fw-bolder  text-wrap fst-italic color3  d-inline-block rounded w-100 ">Descripcion: ${x.desc.slice(0,30)}
            <a class="ms-3" target="#_blank" href="${x.card_images[0].image_url}">Show more</a>
            </p>	
            </div>`
        }))
        document.getElementById("Api-Paises").innerHTML=structure; 
    },
    paginationApiYugi:async function(paginationselected){
        const resp = await fetch(this.baseAll);
        const data = await resp.json();
        console.log(data.data.length);
        console.log(data.data)
        let allCards = data.data.length;
        let cardsforpage = paginationselected;
        let numPages = allCards / cardsforpage;
        let numPagesReal = Math.ceil(numPages);
        let it = 0;
        let pag=1;
        document.getElementById('pagination').innerHTML =``
        data.data.map((itemhtml=>{
            if(pag<=numPagesReal){
                document.getElementById('pagination').innerHTML +=`
                <a class="mb-2 tamaño d-inline-block cards page-link" href="javascript:void(0)" cardValue="${it}">${pag}</a>
                `
                it=it+parseInt(cardsforpage);
                pag++;
            }

            //como escuchar el value que se genera aqui en esta funcion y luego mostrarlo
        }))
        document.querySelectorAll(".cards").forEach(item =>{
            item.addEventListener('click', event =>{
                let offsetCards =(item.getAttribute("cardValue"));
                console.log(offsetCards)
                this.getPictures(cardsforpage,offsetCards)
            })
        })
        this.getPictures(cardsforpage)
    },
    

    
};
(async()=>{
    try{
        await app.getPictures();
        await app.paginationApiYugi(); 
    }catch(e){
        console.log(`Error-> ${e}`);
    }
})()

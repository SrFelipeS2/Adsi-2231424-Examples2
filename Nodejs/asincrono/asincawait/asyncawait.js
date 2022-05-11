async function getText1(){
    return 'hola Adsi';
}

function getText(){
    return Promise.resolve("Hola Adsi")
}

const baseURL ='https://restcountries.com/v3.1'
async function setCountries(){
    const resp = await fetch(`${baseURL}/all`);
    const data = await resp.json();
    console.log(data)
    return data;
}

async function infoCountry(pais){
    const resp = await fetch(`${baseURL}/alpha/${pais}`);
    const data = await resp.json();
    if(resp.status !== 200){
        throw Error(`Error ADSI: ${data.message}`)}
    return data;
}


(async()=>{
    try{
        const pais = await infoCountry('rus');
        console.log(pais);
    }catch (e){
        console.log(`Error-> ${e}`);
    }
})()
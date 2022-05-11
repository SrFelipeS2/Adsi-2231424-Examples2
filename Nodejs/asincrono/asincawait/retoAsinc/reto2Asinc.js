
const app={
    endpoint : 'https://api.binance.com/api/v3/ticker/price',
    getApiBinance: async function(){
        const resp = await fetch(`${this.endpoint}`);
        const data = await resp.json();
        if(resp.status !== 200)
        throw Error(`Message: ${data.message}`);
    this.renderData(data);
    },
    renderData: async function(data){
        console.log(data)
            let body = ''
            for (let i=0; i < data.length; i++) {
                body += `<tr><td>${data[i].symbol}</td><td>${data[i].price}</td></tr>`
            }
            document.getElementById('data').innerHTML = body
    

}    
};
(async()=>{
    try{
        await app.getApiBinance();
        await app.renderData();
    }catch(e){
        console.log(`Error-> ${e}`);
    }
})()

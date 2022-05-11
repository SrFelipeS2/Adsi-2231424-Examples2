const app={
    base : 'https://picsum.photos/v2/',
    getPictures : async function (){
        const resp = await fetch(`${this.base}list`);
        const data = await resp.json();
        if(resp.status !== 200)
            throw Error(`Message: ${data.message}`);
        this.renderPicture(data);
    },
    renderPicture:(data)=>{
        console.log(data);
    }
};
(async()=>{
    try{
        await app.getPictures();
    }catch(e){
        console.log(`Error-> ${e}`);
    }
})()

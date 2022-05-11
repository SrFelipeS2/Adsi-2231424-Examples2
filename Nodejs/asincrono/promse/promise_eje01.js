/* let promesaYes = ()=>{
    return new Promise((resolve,reject)=>{
        resolve(resolveFunc);
        reject(rejectFunc);
    })
}

promesaYes()
.then(()=>console.log("then"))
.catch(()=>console.log("catch")); */
const promise = new Promise((resolve,reject)=>{
    const number =  Math.floor(Math.random()*10);
    setTimeout(()=>{
        console.log("numero>"+number);
        if(number>5)
            resolve(number);
        else
            reject(new Error('Menor a 5'));
    },1000);
});

promise
    .then(number => console.log(number))
    .catch(error => console.log(error))
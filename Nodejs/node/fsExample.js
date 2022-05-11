const fs = require('fs');

function leer(ruta,cb){
    fs.readFile(ruta,(err, data)=>{
        cb(data.toString());
    })
}

function escribir(ruta, contenido, cb){
    fs.writeFile(ruta,contenido, (err)=>{
        if(err)
            console.error(`Error: ${err}`)
    })
}

escribir(__dirname + '/file.txt', "contenido del hola");
//leer(__dirname+'/file.txt', console.log);
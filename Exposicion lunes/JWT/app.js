
const { verify } = require("crypto");
const express = require("express");
const jwt     = require("jsonwebtoken");
const secretkey = "jkaksdfyhyk45456mdfijgl5n64lhdfghr75ghfr65yur"

const app = express();
 
app.get("/api", (req , res) => {
    res.json({
        mensaje: "Nodejs and JWT"
    });
});

app.post("/api/login", (req , res) => {
    const user = {
        id: 1,
        nombre : "Henry",
        email: "henry@email.com"
    }

    jwt.sign({user: user}, secretkey, {expiresIn: '32s'}, (err, token) => {
        res.json({
            token: token
        });
    });
    
});

app.post("/api/posts", verifyToken,(req , res) => {
    
    jwt.verify(req.token, secretkey, (error, authData) => {
        if(error){
            res.sendStatus(403);
        }
        res.json({
            mensaje: "Post fue creado",
            authData: authData
        });
    
    }); 
});

// Authorization: Bearer <token>
function verifyToken(req, res, next){
     const bearerHeader =  req.headers['authorization'];

    if(typeof bearerHeader === 'undefined'){
        res.sendStatus(403);
          
     }
    const bearerToken = bearerHeader.split(" ").pop();
    req.token  = bearerToken;
    next();
}
 
app.listen(3000, () => {
    console.log("nodejs app running...");
});
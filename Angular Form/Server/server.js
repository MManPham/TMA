const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');

const Port = 3000;

const app = express();

app.use(bodyParser.json());
app.use(cors());

app.get('/', function(req, res)
{
    res.send("Hello world")
});

app.post('/enroll', function(req, res)
{   
    console.log(req.body);
    res.status(401).send({"message":"data received"})
});

app.listen(Port, function(){
    console.log('server running port:'+ Port);
})
var http=require('http');
var app=http.createServer((req,res)=>{
    res.setHeader('Content-Type','application/json');
    let students=[
        {sid:1,sname:'Pradhan'},
        {sid:2,sname:'Ketaki'},
        {sid:3,sname:'Sandhya'},
        {sid:4,sname:'Rishi'},
        {sid:5,sname:'Rosy'},
    ]
   // res.end(JSON.stringify({eid:1,ename:'Pradan'}))
   res.end(JSON.parse(students))
}).listen(3002);
const http=require('http');
http.createServer((req,res)=>{
res.write('Hello World');
res.end(); //closing response
}).listen(1234);
console.log('Server is Running At: 127.0.0.1:1234');
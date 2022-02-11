const http = require('http'); //add http package to the js file
http.createServer(function (request, response) {
    // Send the HTTP header 
    // HTTP Status: 200 : OK
    // Content Type: text/json
    response.writeHead(200, { 'Content-Type': 'text/json' });
    // Send the response body as "Hello World"
    response.write("Hello World");
    response.end();

}).listen(8000);
// Console will print the message
console.log('Server running at http://127.0.0.1:8000/');
 
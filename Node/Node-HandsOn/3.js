const http = require('http'); //add http package to the js file
http.createServer(function (request, response) {
    // Send the HTTP header 
    // HTTP Status: 200 : OK
    // Content Type: text/html
    response.writeHead(200, { 'Content-Type': 'text/html' });
    // Send the response body as "Hello World"
    response.end('Hello World\n');

}).listen(8000);
// Console will print the message
console.log('Server running at http://127.0.0.1:8000/');
 
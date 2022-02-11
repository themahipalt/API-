"use strict";
exports.__esModule = true;
var Demo = /** @class */ (function () {
    function Demo() {
        var _this = this;
        //   Greet() {
        //       return this.firstName+this.lastName;
        //   }
        this.Greet = function () {
            return _this.firstName + _this.lastName;
        };
    }
    return Demo;
}());
var obj = new Demo();
obj.firstName = 'Rohan';
obj.lastName = 'Jain';
console.log(obj.firstName);
console.log(obj.lastName);
console.log(obj.Greet());

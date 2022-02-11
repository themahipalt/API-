var Student = /** @class */ (function () {
    function Student() {
    }
    //method
    Student.prototype.show = function () {
        console.log("Id:" + this.sId + " Name:" + this.sName);
    };
    return Student;
}());
//create object
var student = new Student();
//access class members using object
student.sId = 1;
student.sName = 'Rohan';
student.show();

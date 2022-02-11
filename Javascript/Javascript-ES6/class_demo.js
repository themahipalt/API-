class Person
{
    constructor() //default constructor
    {
        this.Pid=1;
        this.Pname='Ram';
        this.City='Bangalore'
    }
}
let person=new Person(); //initialize Person

console.log(person.Pid+" "+person.Pname+" "+person.City);
let person1=new Person();
person1.Pid=101;
person1.Pname='Ketaki';
person1.City='Pune';
console.log(person1.Pid+" "+person1.Pname+" "+person1.City);
class student
{
    constructor(name,age,city) //patameter consturctor
    {
        this.name=name;
        this.age=age; 
        this.city=city
    }
    display()
    {
console.log(this.name);
console.log(this.age);
console.log(this.city);
    }
}
var obj=new student('sachin',12,'Mumbai')
obj.display()
let obj2=new student('srikanth',11,'Bangloare');
obj2.display()
let obj3=new student();
obj3.city='Pune';
obj3.display();
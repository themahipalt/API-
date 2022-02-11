export interface IPerson
{
    //variables
    firstName:string;
    lastName:string;
    //methods
   Greet(); //abstract method
}
class Demo implements IPerson
{
  firstName: string;
  lastName: string;
//   Greet() {
//       return this.firstName+this.lastName;
//   }
Greet=()=> {
    return this.firstName+this.lastName;
}
}
let obj=new Demo();
obj.firstName='Rohan';
obj.lastName='Jain';
console.log(obj.firstName);
console.log(obj.lastName)
console.log(obj.Greet());


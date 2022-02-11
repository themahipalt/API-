//arrays
let nos:number[]=[12,23,34,45,56];
let names:string[]=['Rohan','Charan','Sunil','Dev']
//assing value to array
names[4]='Karan'
//access a value
// console.log(names[0])
console.log(names[8]) //undefined
//fetch array values using for loop
for(let k=0;k<names.length;k++)
{
    console.log(names[k])
}
let obj:any[]=[12,12.34,'Rohan',true,{'Name':'Suren','Dept':'IT'}]
console.log(obj[1]);
console.log(obj[3]);
console.log(obj[4].Name);
console.log(obj[4].Dept);
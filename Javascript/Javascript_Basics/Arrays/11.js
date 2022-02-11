//reduce function excutes callback function(reducer) for every array element
//reduce function returns a single value i.e functio accumulated value
//array.reduce(func(total,currentvalue,currentindex,arr),initialvalue)
let arr=[1,2,3,4,5];
let result=arr.reduce((sum,current)=>sum+current,0)
console.log(result);

//0+1=1
//1+2=3
//3+3=6
//6+4=10
//10+5=15
let ar=["Rose","Lilly","Jasmine"]
let r=ar.reduce((op,c)=>op+" "+c);
console.log(r);
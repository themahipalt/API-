class Customer
{
    //private variables
    private cId:number;
    private cname:string;
    // constructor() //default constctor
    // {
    //     this.cId=1000;
    //     this.cname='Jeson'
    // }
    constructor(cId:number,cname:string)
    {
        this.cId=cId;
        this.cname=cname;
    }
    public show() //methhod
    {
        console.log(`ID:${this.cId} Name:${this.cname}`)
    }
}
// let customer:Customer=new Customer(); //customer object
let customer=new Customer(101,'Rohan');
customer.show();
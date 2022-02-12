import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
@Component({
  selector: 'app-product-demo',
  templateUrl: './product-demo.component.html',
  styleUrls: ['./product-demo.component.css']
})
export class ProductDemoComponent implements OnInit {
product:Product
products:Product[]=[]; //empty array
  constructor() {
    this.product=new Product();
   }

  ngOnInit(): void {
  }
  Add():void
  {
    console.log(this.product)
    //add new product details to array
    this.products.push(this.product);
    console.log(this.products);
    this.product=new Product();
  }

}

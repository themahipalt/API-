import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
n1:number;
n2:number;
result:number;
  constructor() { }

  ngOnInit(): void {
  }
  Greet()
  {
    console.log('Hello World');
  }
  Sum()
  {
    this.result=Number(this.n1)+Number(this.n2);
    console.log(this.result);
  }


}

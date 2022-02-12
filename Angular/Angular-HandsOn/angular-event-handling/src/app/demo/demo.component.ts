import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
msg:string;
  constructor() { }

  ngOnInit(): void {
  }
  Greet():void
  {
    alert('Hello World')
  }
  Hello(name:string)
  {
    this.msg="Hello "+name;
  }

}

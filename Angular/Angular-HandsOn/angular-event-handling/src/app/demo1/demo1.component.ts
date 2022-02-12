import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
cities=["Chennai",'Pune','Kolkatha','Delhi','Mumbai'];
  constructor() { }

  ngOnInit(): void {
  }
  GetCity(city:string)
  {
    alert("Hello,Your from "+city);
  }

}

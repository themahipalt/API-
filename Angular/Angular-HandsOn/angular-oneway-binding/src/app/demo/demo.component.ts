import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  cities:string[]=['Bangloare','Chennai','Pune','Hyberabad','Delhi']
  covid_cases:number[]=[33232,3343,34334,33433];
  covid_case:any=[
    {"Country":'India','Cases':43039434},
    {"Country":'China','Cases':870909},
    {"Country":'US','Cases':3232323},
    {"Country":'UK','Cases':65656565},
  ]
  constructor() { }

  ngOnInit(): void {
  }

}

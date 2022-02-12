import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
title='Angular Property Binding Demo';
url_path='http://www.google.co.in';
img_path='../../assets/d1.jpg';
width=300;
height=300;
  constructor() { }

  ngOnInit(): void {
  }

}

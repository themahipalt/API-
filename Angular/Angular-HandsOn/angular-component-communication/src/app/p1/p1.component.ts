import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-p1',
  templateUrl: './p1.component.html',
  styleUrls: ['./p1.component.css']
})
export class P1Component implements OnInit {
title:string='Welcome back to Angular Programming';
  constructor() { }

  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/user';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
model:User;
  constructor() { 
    this.model=new User();
  }

  ngOnInit() {
  }
  Submit()
  {
    alert(JSON.stringify(this.model));
  }

}

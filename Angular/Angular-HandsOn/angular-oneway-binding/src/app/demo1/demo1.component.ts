import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
student_id:number=332;
student_name:string='Rohan';
student_dob:Date=new Date(2010,2,12)
student_school:string='DPS'
isStudent:boolean=true;
  constructor() { }

  ngOnInit(): void {
  }

}

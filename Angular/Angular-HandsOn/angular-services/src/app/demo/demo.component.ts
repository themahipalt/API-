import { Component, OnInit } from '@angular/core';
import { GreetService } from '../greet.service';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
user_name:string;
msg:string;
  constructor(private greetService:GreetService) { }

  ngOnInit(): void {
  }
  Greet()
  {
    //call the service method
    this.msg=this.greetService.Greet(this.user_name);

  }

}

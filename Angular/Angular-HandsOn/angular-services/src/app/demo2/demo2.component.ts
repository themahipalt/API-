import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../calculate.service';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css'],
  providers:[CalculateService]
})
export class Demo2Component implements OnInit {

  constructor(private calculateService:CalculateService) { }

  ngOnInit(): void {
  }

}

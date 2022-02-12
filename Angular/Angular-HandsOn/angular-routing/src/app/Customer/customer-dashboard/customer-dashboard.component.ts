import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-customer-dashboard',
  templateUrl: './customer-dashboard.component.html',
  styleUrls: ['./customer-dashboard.component.css']
})
export class CustomerDashboardComponent implements OnInit {
uname:string;
  constructor(private router:Router) {
    if(localStorage["un"]!=null)
    {
      this.uname=localStorage["un"]; //read value from local stroage
    }
    else
    {
      this.router.navigateByUrl('login')
    }
   }

  ngOnInit(): void {
  }
  LogOut()
  {
    localStorage.clear()
    this.router.navigateByUrl('login');
  }

}

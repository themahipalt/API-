import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent implements OnInit {
uname:string
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
    localStorage.clear(); //clear local storage values
    this.router.navigateByUrl('login');
  }

}

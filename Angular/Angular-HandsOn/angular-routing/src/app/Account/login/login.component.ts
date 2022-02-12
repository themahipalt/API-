import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
user:User
users:User[];
errMsg:string;
  constructor(private router:Router) {
    this.user=new User();
    this.users=[
      {name:'pramod',email:'pramod@gmail.com',password:'12345',role:'Customer'},
      {name:"srikanth",email:'sri@gmail.com',password:'12345',role:'Admin'},
      {name:'rashmi',email:'rashmi@gmail.com',password:'12345',role:'Customer'},
      {name:'ashiwini',email:'ashwini@gmail.com',password:'12345',role:'Admin'}
    ]
   }

  ngOnInit(): void {
  }
  Validate():void
  {
    console.log(this.user)
    let user:User=this.users.find(u=>u.email==this.user.email && u.password==this.user.password);
    console.log(user);
    if(user!=null)
    {
      let uname=user.name;
      localStorage["un"]=uname; //stored uname in localStorage
      if(user.role=="Customer")
      {
        
        //redirect to customer dashboard
        this.router.navigate(['customer-dashboard'])
      }
      else if(user.role='Admin')
      {
        this.router.navigateByUrl('admin-dashboard') //redirect to admin-dashboard
      }
    }
    else
    {
      this.errMsg='Invalid Credentials';
    }
  }

}

import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
users:User[];
user:User;
errMsg:string;
  constructor(private router:Router) { 
    this.user=new User();
    this.users=[
      {email:'yamini@gamil.com',password:'12345'},
      {email:'pramod@gmail.com',password:'12345'}
    ]
  }

  ngOnInit() {
  }
  Validate()
  {
    let user:User=this.users.find(u=>u.email==this.user.email && u.password==this.user.password);
    if(user!=null)
    {
      
        //set value in token
        sessionStorage["token"]=user.email;
        this.router.navigateByUrl('/dashboard')
      
    }
    else
    {
      this.errMsg='Invalid Credentails';
    }
   
   
  }

}

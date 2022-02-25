import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthserviceService } from './authservice.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService:AuthserviceService,private router:Router){

  }
  canActivate():boolean{
   if(this.authService.isLoggedIn())
      return true;
      else
      window.alert('You don\'t have permission to view this page');
      this.router.navigateByUrl('login'); //redirects to login
      return false;
     
  }
  
}

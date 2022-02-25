import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthserviceService {

  constructor() { }
  isLoggedIn(): boolean {
    if(sessionStorage["token"])
    return true;
    else
    return false;
  }
}

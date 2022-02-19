import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './REACTIVE/login/login.component';
import { RegisterComponent } from './REACTIVE/register/register.component';

import { Demo1Component } from './TEMPLATE/demo1/demo1.component';


const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'demo1',component:Demo1Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DemoComponent } from './demo/demo.component';
import { StudentCrudComponent } from './student-crud/student-crud.component';

const routes: Routes = [
  {path:'demo',component:DemoComponent},
  {path:'',component:StudentCrudComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

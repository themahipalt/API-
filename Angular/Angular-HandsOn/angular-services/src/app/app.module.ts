import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GreetService } from './greet.service';
import { DemoComponent } from './demo/demo.component';
import { FormsModule } from '@angular/forms';
import { CalculateService } from './calculate.service';
import { Demo2Component } from './demo2/demo2.component';
import { StudentService } from './student.service';
import { StudentCrudComponent } from './student-crud/student-crud.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    Demo2Component,
    StudentCrudComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [GreetService,StudentService],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Parent1Component } from './parent1/parent1.component';
import { Child1Component } from './child1/child1.component';
import { ChildComponent } from './child/child.component';
import { ParentComponent } from './parent/parent.component';
import { Parent2Component } from './parent2/parent2.component';
import { Child2Component } from './child2/child2.component';
import { C1Component } from './c1/c1.component';
import { P1Component } from './p1/p1.component';

@NgModule({
  declarations: [
    AppComponent,
    Parent1Component,
    Child1Component,
    ChildComponent,
    ParentComponent,
    Parent2Component,
    Child2Component,
    C1Component,
    P1Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [Parent2Component]
})
export class AppModule { }

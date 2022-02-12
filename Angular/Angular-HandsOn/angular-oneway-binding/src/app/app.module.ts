import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Demo1Component } from './demo1/demo1.component';
import { ViewBookComponent } from './view-book/view-book.component';
import { DemoComponent } from './demo/demo.component';
import { ViewBooksComponent } from './view-books/view-books.component';

@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    ViewBookComponent,
    DemoComponent,
    ViewBooksComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

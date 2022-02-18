import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './demo/demo.component';
import { SearchFilterPipe } from './search-filter.pipe';
import { StudentViewComponent } from './student-view/student-view.component';
import { FormsModule } from '@angular/forms';
import { TitlePipe } from './title.pipe';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    SearchFilterPipe,
    StudentViewComponent,
    TitlePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

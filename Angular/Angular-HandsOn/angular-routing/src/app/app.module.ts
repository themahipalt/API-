import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { AdminDashboardComponent } from './Admin/admin-dashboard/admin-dashboard.component';
import { ViewProductsComponent } from './Admin/view-products/view-products.component';
import { ViewCustomersComponent } from './Admin/view-customers/view-customers.component';
import { ReportsComponent } from './Admin/reports/reports.component';
import { SearchProductsComponent } from './Customer/search-products/search-products.component';
import { ViewCartComponent } from './Customer/view-cart/view-cart.component';
import { AddPaymentComponent } from './Customer/add-payment/add-payment.component';
import { CustomerDashboardComponent } from './Customer/customer-dashboard/customer-dashboard.component';
import { LoginComponent } from './Account/login/login.component';
import { RegisterComponent } from './Account/register/register.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    ContactComponent,
    AdminDashboardComponent,
    ViewProductsComponent,
    ViewCustomersComponent,
    ReportsComponent,
    SearchProductsComponent,
    ViewCartComponent,
    AddPaymentComponent,
    CustomerDashboardComponent,
    LoginComponent,
    RegisterComponent
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

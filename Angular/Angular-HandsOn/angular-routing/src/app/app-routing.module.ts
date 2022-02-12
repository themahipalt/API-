import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { AdminDashboardComponent } from './Admin/admin-dashboard/admin-dashboard.component';
import { ReportsComponent } from './Admin/reports/reports.component';
import { ViewCustomersComponent } from './Admin/view-customers/view-customers.component';
import { ViewProductsComponent } from './Admin/view-products/view-products.component';
import { ContactComponent } from './contact/contact.component';
import { AddPaymentComponent } from './Customer/add-payment/add-payment.component';
import { CustomerDashboardComponent } from './Customer/customer-dashboard/customer-dashboard.component';
import { SearchProductsComponent } from './Customer/search-products/search-products.component';
import { ViewCartComponent } from './Customer/view-cart/view-cart.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path:'info',component:HomeComponent},
  {path:'about',component:AboutComponent},
  {path:'contact',component:ContactComponent},
  {path:'admin-dashboard',component:AdminDashboardComponent,children:[
    {path:'reports',component:ReportsComponent},
    {path:'view-customers',component:ViewCustomersComponent},
    {path:'view-products',component:ViewProductsComponent}
  ]},
  {path:'customer-dashboard',component:CustomerDashboardComponent,children:[
    {path:'view-cart',component:ViewCartComponent},
    {path:'add-payment',component:AddPaymentComponent},
    {path:'search-product',component:SearchProductsComponent}

  ]},
  {path:'',redirectTo:'info',pathMatch:'full'}  //set the root component
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

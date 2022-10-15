import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
// import { ListOrdersComponent } from './orders/list-orders/list-orders.component';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { ListOrdersComponent } from './orders/list-orders/list-orders.component';
import { ViewAllProductsComponent } from './products/view-all-products/view-all-products.component';

const routes: Routes = [
  { path: 'products', loadChildren: () => import('./products/products.module').then(m => m.ProductsModule) },
  { path: 'orders', component: ListOrdersComponent},
  { path: 'view-all-products', component: ViewAllProductsComponent}
 
  


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [{provide: LocationStrategy, useClass: HashLocationStrategy}]
})
export class AppRoutingModule { }
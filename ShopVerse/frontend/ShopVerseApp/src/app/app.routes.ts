import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ProductDetailsComponent } from './components/products/product/product-details/product-details.component';

export const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'products/:productId', component: ProductDetailsComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' },
];

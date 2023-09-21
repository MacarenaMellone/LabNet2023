import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ListCategoriesComponent } from './components/Categories/list-categories/list-categories.component';
import { AddCategoriesComponent } from './components/Categories/add-categories/add-categories.component';
import { FormCategoriesComponent } from './components/Categories/form-categories/form-categories.component';

const routes: Routes = [
  //{path: '', pathMatch:'full', redirectTo:'home'},
  {path: 'home', component: HomeComponent},
  /* {
    path: 'dashboard',
    loadComponent:() => import('./components/dashboard/dashboard.module').then(
      (x) => x.DashboardModule)
  },
  {path: '** ', pathMatch: 'full', redirectTo:'home'} */
  {path:'list-categories', component: ListCategoriesComponent},
  {path:'list-categories/add-categories', component: AddCategoriesComponent},
  {path:'form-categories', component: FormCategoriesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

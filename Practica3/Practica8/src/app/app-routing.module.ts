import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ListCategoriesComponent } from './components/Categories/list-categories/list-categories.component';
import { AddCategoriesComponent } from './components/Categories/add-categories/add-categories.component';
import { ListShippersComponent } from './components/shippers/list-shippers/list-shippers.component';
import { AddShippersComponent } from './components/shippers/add-shippers/add-shippers.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path:'list-categories', component: ListCategoriesComponent},
  {path:'list-categories/add-categories', component: AddCategoriesComponent},
  {path:'list-shippers', component: ListShippersComponent},
  {path:'list-shippers/add-shippers', component: AddShippersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

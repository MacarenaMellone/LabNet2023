import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ListCategoriesComponent } from './components/Categories/list-categories/list-categories.component';
import { AddCategoriesComponent } from './components/Categories/add-categories/add-categories.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path:'list-categories', component: ListCategoriesComponent},
  {path:'list-categories/add-categories', component: AddCategoriesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

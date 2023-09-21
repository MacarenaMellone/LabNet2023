import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListCategoriesComponent } from './components/Categories/list-categories/list-categories.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './components/shared/shared.module';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './components/home/home.component';
import { AddCategoriesComponent } from './components/Categories/add-categories/add-categories.component';
import { DeleteCategoriesComponent } from './components/Categories/delete-categories/delete-categories.component';
import { ErrorDialogComponent } from './components/error-dialog/error-dialog.component';
import { ConfirmDialogComponent } from './components/confirm-dialog/confirm-dialog.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormCategoriesComponent } from './components/Categories/form-categories/form-categories.component';


@NgModule({
  declarations: [
    AppComponent,
    ListCategoriesComponent,
    HomeComponent,
    AddCategoriesComponent,
    DeleteCategoriesComponent,
    ErrorDialogComponent,
    ConfirmDialogComponent,
    FormCategoriesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

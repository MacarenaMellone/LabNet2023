import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CategoryName } from 'src/app/core/models/categoryName_model';
import { CategoriesService } from '../service/categories.service';
import { categoriesDto } from 'src/app/core/models/categoriesDto';
import { AddCategoriesComponent } from '../add-categories/add-categories.component';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { DeleteCategoriesComponent } from '../delete-categories/delete-categories.component';
import { HttpErrorResponse } from '@angular/common/http';
import { ErrorDialogComponent } from '../../error-dialog/error-dialog.component';
import { ConfirmDialogComponent } from '../../confirm-dialog/confirm-dialog.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-list-categories',
  templateUrl: './list-categories.component.html',
  styleUrls: ['./list-categories.component.css']
})
export class ListCategoriesComponent implements OnInit {
  public listCategories: Array<categoriesDto> = [] 

  displayedColumns: string[] = ['id', 'categoryName', 'description', 'actions'];
  dialogConfirm?: MatDialogRef<ConfirmDialogComponent>;
  dialogError?: MatDialogRef<ErrorDialogComponent>;
  dataSource = new MatTableDataSource(this.listCategories);
  page = 1;
  count = 0;
  tableSize = 5;

  

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private categoriesService : CategoriesService,
    private dialogRef: MatDialog,
    private snackBar: MatSnackBar,
    ) { } 

  ngOnInit(): void {
     this.getAllCategories();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  // MODAL
  openDialog(){
    this.dialogRef.open(AddCategoriesComponent, {
      data: {
        title: 'Agregar Categoría'
      }
    });
  }

  onClickEdit(categories : any){
    this.dialogRef.open(AddCategoriesComponent, {
      data: {
        title: 'Modificar Categoría'
      }
    });
  }

  editCategory(categoryName:string){
    console.log('Edit: ' ,categoryName);
  }
 
  addCategory(){
    console.log('Add: ');
  }

   getAllCategories(){
    this.categoriesService.getAllCategories().subscribe(res =>{
      this.listCategories = res;
      console.log(this.categoriesService.getAllCategories());
      console.log(this.listCategories); 
    }, (err: HttpErrorResponse)=>{ this.openErrorDialog("Status code: " + err.status + " - " + err.error)})

  } 
  openErrorDialog(messageError: string){
    this.dialogError = this.dialogRef.open(ErrorDialogComponent,{
      disableClose: false
    });
    this.dialogError.componentInstance.errorMessage = messageError;
  }

  onClickDelete(categories : any){
    this.dialogConfirm = this.dialogRef.open(ConfirmDialogComponent, {
      disableClose: false
    }); 
    this.dialogConfirm.componentInstance.confirmMessage = "Esta seguro que quiere eliminar la categoria " + categories.CategoryID + "?";
    this.dialogConfirm.afterClosed().subscribe(result => {
      if(result) {
        this.deleteCategory(categories.CategoryID);
      }
    });
  }
  private deleteCategory(categoryID: number){
    this.categoriesService.deleteCategories(categoryID).subscribe( categ =>{
      this.getAllCategories();
    },
    (err: HttpErrorResponse) => {this.openErrorDialog("Esta categoria esta asociada a un poducto y no se puede eliminar")})
  };

  onTableDataChange(event: any){
    this.page = event;
    this.getAllCategories();
  }

  
}

import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { categoriesDto } from 'src/app/core/models/categoriesDto';
import { CategoriesService } from '../service/categories.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CategoryName } from 'src/app/core/models/categoryName_model';
import { HttpErrorResponse } from '@angular/common/http';
import { ErrorDialogComponent } from '../../error-dialog/error-dialog.component';

@Component({
  selector: 'app-add-categories',
  templateUrl: './add-categories.component.html',
  styleUrls: ['./add-categories.component.css']
})
export class AddCategoriesComponent implements OnInit {
  inputData: any;
  addMode: boolean = true;
  categoriesForm!: FormGroup;
  updateData!: categoriesDto;
  modeTitle: string = 'Add';
  dialogError?: MatDialogRef<ErrorDialogComponent>;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data:any,
    public formBuilder: FormBuilder,
    private ref:MatDialogRef<AddCategoriesComponent>,
    private route: ActivatedRoute,
    private router: Router,
    private categoriesService: CategoriesService,
    private dialog: MatDialog) {
   }

  ngOnInit(): void {
   this.inputData = this.data;
   this.editOrAdd();
   this.categoriesForm = this.formBuilder.group({
    ID: [null],
    categoriesName: ['', [Validators.required, Validators.maxLength(15)]],
    description: ['', Validators.maxLength(100)],
  });
  }

/*   addForm = this.buildr.group({
    categoryName : this.buildr.control(''),
    description : this.buildr.control(''),
    status : this.buildr.control(true)
  });*/
  
  editOrAdd() {
    let id = Number(this.route.snapshot.paramMap.get('CategoryID'));
    if (id != 0) {
      this.UpdateData(id);
      this.addMode = false;
      this.modeTitle = 'Update';
    }
  }

  private UpdateData(CategoryID: number) {
    this.categoriesService.getCategoriesById(CategoryID).subscribe((res) => {
      this.updateData = res;
      this.categoriesForm.patchValue({
        ID: this.updateData.CategoryID,
        categoriesName: this.updateData.CategoryName,
        description: this.updateData.Description
      })
    },
    (err: HttpErrorResponse)=>{ this.openErrorDialog("Status code: " + err.status + " - " + err.error)});
  }

  saveCategory(){
    var categories = new categoriesDto();
    categories.CategoryID = this.categoriesForm.get('ID')?.value;
    categories.CategoryName = this.categoriesForm.get('categoriesName')?.value;
    categories.Description = this.categoriesForm.get('description')?.value;

    if (this.addMode) {
     this.addCategory(categories)
     this.categoriesService.getAllCategories();
    }
    else if (!this.addMode) {
      this.updateCategory(categories)
      this.categoriesService.getAllCategories();
    }
  } 

  private addCategory(categories: categoriesDto){
    this.categoriesService.postCategories(categories).subscribe((res) => {
    this.categoriesForm.reset();
    this.router.navigate(['list-categories']);
    },
    (err: HttpErrorResponse)=>{ this.openErrorDialog("Status code: " + err.status + " - " + err.error)});
  }

  private updateCategory(category: categoriesDto){
    this.categoriesService.updateCategories(category).subscribe((res) => {
      this.categoriesForm.reset();
      this.router.navigate(['list-categories']);
    },
    (err: HttpErrorResponse)=>{ this.openErrorDialog("Status code: " + err.status + " - " + err.error)});
  }

  openErrorDialog(messageError: string){
    this.dialogError = this.dialog.open(ErrorDialogComponent,{
      disableClose: false
    });
    this.dialogError.componentInstance.errorMessage = messageError;
  }
}

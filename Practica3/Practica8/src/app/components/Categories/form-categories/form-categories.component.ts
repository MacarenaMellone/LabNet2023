import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { categoriesDto } from 'src/app/core/models/categoriesDto';
import { ErrorDialogComponent } from '../../error-dialog/error-dialog.component';
import { CategoriesService } from '../service/categories.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-form-categories',
  templateUrl: './form-categories.component.html',
  styleUrls: ['./form-categories.component.css']
})
export class FormCategoriesComponent implements OnInit {

  categoriesForm!: FormGroup;
  categoriesDto!: categoriesDto;
  private categoryId: number = 0;

  get f(){
    return this.categoriesForm.controls;
  }

  constructor(
    private formBuilder: FormBuilder,
    private service: CategoriesService,
    private router: Router,
    private activatedRoute: ActivatedRoute){
      this.categoriesForm = this.formBuilder.group({
        id: undefined,
        name: ['',[Validators.required, Validators.maxLength(15)]],
        description: ['',[Validators.maxLength(40)]]
      });
  }

 
  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(p =>{
      this.categoryId = p['Id']
    });
    if(this.categoryId > 0){
      this.service.getCategoriesById(this.categoryId).subscribe(r =>{
        this.categoriesForm.setValue({
          id: r.CategoryID,
          name: r.CategoryName,
          description: r.Description
        });
      });
    }
  }

  onSubmit(): void{
   /*  var name = this.categoriesForm.get('name');
    var description = this.categoriesForm.get('description');
    if(name != null && description != null){
      var categories = new categoriesDto(name.value, description.value);
      if(this.categoryId > 0){
        categories.CategoryID = this.categoriesForm.get('id')?.value;
        this.service.updateCategories(this.categoryId, categories).subscribe(r =>{
          this.router.navigateByUrl('');
        });
      } 
      else{
        this.service.postCategories(categories).subscribe(r=>{
          this.router.navigateByUrl('');
        });
      }
    }*/
  } 
}

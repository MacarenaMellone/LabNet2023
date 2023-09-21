import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-delete-categories',
  templateUrl: './delete-categories.component.html',
  styleUrls: ['./delete-categories.component.css']
})
export class DeleteCategoriesComponent implements OnInit {

  constructor(
    public dialogRef : MatDialogRef<DeleteCategoriesComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }

  ngOnInit(): void {
  }

}

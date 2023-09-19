import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CategoryName } from 'src/app/core/models/categoryName_model';

const listCategories: CategoryName[] = [
  {id: 1, categoryName: 'Hydrogen', description: 'Hydrogen', actions: ''},
  {id: 2, categoryName: 'Helium', description: 'Hydrogen', actions: ''},
  {id: 3, categoryName: 'Lithium', description: 'Hydrogen', actions: ''},
  {id: 4, categoryName: 'Beryllium', description: 'Hydrogen', actions: ''},
  {id: 5, categoryName: 'Beryllium', description: 'Hydrogen', actions: ''},
  {id: 6, categoryName: 'Beryllium', description: 'Hydrogen', actions: ''},
  {id: 7, categoryName: 'Beryllium', description: 'Hydrogen', actions: ''},
  {id: 8, categoryName: 'Beryllium', description: 'Hydrogen', actions: ''},
];

@Component({
  selector: 'app-list-categories',
  templateUrl: './list-categories.component.html',
  styleUrls: ['./list-categories.component.css']
})
export class ListCategoriesComponent implements OnInit {
  displayedColumns: string[] = ['id', 'categoryName', 'description', 'actions'];
  // dataSource = listCategories;
  dataSource = new MatTableDataSource(listCategories);

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor() { }

  ngOnInit(): void {}

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  editCategory(categoryName:string){
    console.log('Edit: ' ,categoryName);
  }
  deleteCategory(categoryName:string){
    console.log('Del: ' ,categoryName);
  }
}

import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { shippersDto } from 'src/app/core/models/shippersDto';
import { ConfirmDialogComponent } from '../../confirm-dialog/confirm-dialog.component';
import { ErrorDialogComponent } from '../../error-dialog/error-dialog.component';
import { ShippersService } from '../service/shippers.service';
import { AddShippersComponent } from '../add-shippers/add-shippers.component';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-list-shippers',
  templateUrl: './list-shippers.component.html',
  styleUrls: ['./list-shippers.component.css']
})
export class ListShippersComponent implements OnInit {
  public listShippers: Array<shippersDto> = []
  
  displayedColumns: string[] = ['id', 'companyName', 'phone', 'actions'];
  dataSource = new MatTableDataSource<shippersDto>(this.listShippers);
  dialogConfirm?: MatDialogRef<ConfirmDialogComponent>;
  dialogError?: MatDialogRef<ErrorDialogComponent>;
  
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private shippersService : ShippersService,
    private dialogRef: MatDialog
    ) { } 

    ngOnInit(): void {
      this.getAllShippers();
   }
 
   ngAfterViewInit() {
     this.dataSource.paginator = this.paginator;
     this.dataSource.sort = this.sort;
   }

     // MODAL
  openDialog(){
    this.openPopUp(0, 'Agregar Shipper');
  }

  onClickEdit(shippers : any){
    this.openPopUp(shippers, 'Modificar Shipper');
  }

  openPopUp(shippers : any,title : any){
    this.dialogRef.open(AddShippersComponent, {
      data: {
        title: title,
        shippers: shippers
      }
    });
  }

  getAllShippers(){
    this.shippersService.getAllShippers().subscribe(res =>{
      this.listShippers = res;
    }, (err: HttpErrorResponse)=>{ this.openErrorDialog("Ha ocurrido un error: " + err.status + " - " + err.error)})
  }
  
  openErrorDialog(messageError: string){
    this.dialogError = this.dialogRef.open(ErrorDialogComponent,{
      disableClose: false
    });
    this.dialogError.componentInstance.errorMessage = messageError;
  }

  onClickDelete(shippers : any){
    this.dialogConfirm = this.dialogRef.open(ConfirmDialogComponent, {
      disableClose: false
    }); 
    this.dialogConfirm.componentInstance.confirmMessage = "Esta seguro que quiere eliminar la categoría " + shippers.ShipperID + "?";
    this.dialogConfirm.afterClosed().subscribe(result => {
      if(result) {
        this.deleteShippers(shippers.ShipperID);
      }
    });
  }

  private deleteShippers(shippersID: number){
    this.shippersService.deleteShippers(shippersID).subscribe( res =>{
      this.getAllShippers();
    },
    (err: HttpErrorResponse) => {this.openErrorDialog("Ha ocurrido un error")})
  };
}

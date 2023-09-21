import { Component, Inject, OnInit } from '@angular/core';
import { ErrorDialogComponent } from '../../error-dialog/error-dialog.component';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { shippersDto } from 'src/app/core/models/shippersDto';
import { ShippersService } from '../service/shippers.service';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-add-shippers',
  templateUrl: './add-shippers.component.html',
  styleUrls: ['./add-shippers.component.css']
})
export class AddShippersComponent implements OnInit {
  inputData: any;
  addMode: boolean = true;
  shippersForm!: FormGroup;
  updateData!: shippersDto;
  modeTitle: string = 'Add';
  dialogError?: MatDialogRef<ErrorDialogComponent>;
  
  constructor(
    @Inject(MAT_DIALOG_DATA) public data:any,
    public formBuilder: FormBuilder,
    private ref:MatDialogRef<AddShippersComponent>,
    private route: ActivatedRoute,
    private router: Router,
    private shippersService: ShippersService,
    private dialog: MatDialog) {
   }

   ngOnInit(): void {
    this.inputData = this.data;
    this.editOrAdd();
    this.shippersForm = this.formBuilder.group({
     ID: [null],
     companyName: ['', [Validators.required, Validators.maxLength(40)]],
     phone: ['', Validators.maxLength(24)],
   });
   }

   editOrAdd() {
    if (this.inputData.shippers>0) {
      this.UpdateData(this.inputData.shippers);
      this.addMode = false;
      this.modeTitle = 'Update';
    }
  }

  private UpdateData(ShipperID: number) {
    this.shippersService.getShippersById(ShipperID).subscribe((res) => {
      this.updateData = res;
      this.shippersForm.patchValue({
        ID: this.updateData.ShipperID,
        companyName: this.updateData.CompanyName,
        phone: this.updateData.Phone
      })
    },
    (err: HttpErrorResponse)=>{ this.openErrorDialog("Ha ocurrido un error: " + err.status + " - " + err.error)});
  }

  saveShipper(){
    var shippers = new shippersDto();
    shippers.ShipperID = this.shippersForm.get('ID')?.value;
    shippers.CompanyName = this.shippersForm.get('companyName')?.value;
    shippers.Phone = this.shippersForm.get('phone')?.value;

    if (this.addMode) {
     this.addShipper(shippers)
     this.shippersService.getAllShippers();
    }
    else if (!this.addMode) {
      this.updateShipper(shippers)
      this.shippersService.getAllShippers();
    }
  }

  private addShipper(shippers: shippersDto){
    this.shippersService.postShippers(shippers).subscribe((res) => {
    this.shippersForm.reset();
    this.router.navigate(['list-shippers']);
    },
    (err: HttpErrorResponse)=>{ this.openErrorDialog("Ha ocurrido un error: " + err.status + " - " + err.error)});
  }

  private updateShipper(shippers: shippersDto){
    this.shippersService.updateShippers(shippers).subscribe((res) => {
      this.shippersForm.reset();
      this.router.navigate(['list-shippers']);
    },
    (err: HttpErrorResponse)=>{ this.openErrorDialog("Ha ocurrido un error: " + err.status + " - " + err.error)});
  }
  
  openErrorDialog(messageError: string){
    this.dialogError = this.dialog.open(ErrorDialogComponent,{
      disableClose: false
    });
    this.dialogError.componentInstance.errorMessage = messageError;
  }
}

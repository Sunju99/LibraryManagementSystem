import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';


@Component({
  selector: 'app-add-edit-supplier',
  templateUrl: './add-edit-supplier.component.html',
  styleUrls: ['./add-edit-supplier.component.css']
})
export class AddEditSupplierComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() supplier:any;
  supplierId?:number;
  supplierName?:string;
  purchaseNumber?:number;

  ngOnInit(): void {
    this.supplierId=this.supplier.supplierId;
    this.supplierName=this.supplier.supplierName;
    this.purchaseNumber=this.supplier.purchaseNumber;
   
  }
  AddSupplier(){
    var val={
      supplierId:this.supplierId,
      supplierName:this.supplierName,
      purchaseNumber:this.purchaseNumber
    };
    this.service.addSupplier(val).subscribe(res=>{alert(res.toString());});
  }
  UpdateSupplier()
  {
    var val={
      supplierId:this.supplierId,
      supplierName:this.supplierName,
      purchaseNumber:this.purchaseNumber
    };
    this.service.updateSupplier(val).subscribe(res=>{alert(res.toString());});
  }

}

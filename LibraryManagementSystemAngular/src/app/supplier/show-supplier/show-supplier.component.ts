import { Component, OnInit } from '@angular/core';

import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-supplier',
  templateUrl: './show-supplier.component.html',
  styleUrls: ['./show-supplier.component.css']
})
export class ShowSupplierComponent implements OnInit {

  constructor(private service:SharedService) { }

  
  SupplierList:any=[];

  Modaltitle?:string;
  activateAddEditSupplierComp:boolean=false;
  supplier:any;
  supplierName:string="";
  ListWitoutFilter:any=[];
  ngOnInit(): void {
    this.refreshSupplierList();
  }

  addClick(){
    this.supplier={
      supplierId:0,
      supplierName:"",
      purchaseNumber:0,
     
    }
    this.Modaltitle="Add supplier";
    this.activateAddEditSupplierComp=true;
  }
  
  editClick(item:any)
  {
    this.supplier=item;
    this.Modaltitle="Edit supplier";
    this.activateAddEditSupplierComp=true;
  }

  Filter()
  {
    var supplierName=this.supplierName;
  
    this.SupplierList=this.ListWitoutFilter.filter(function(el:any){
    return el.supplierName.toString().toLowerCase().includes(supplierName.toString().trim().toLowerCase())
    });
  }
  deleteClick(item:any)
  {
    if(confirm('Are you sure want to delete this supplier'))
    {
      this.service.deleteSupplier(item.supplierId).subscribe(data=>{
        alert(data.toString());
        this.refreshSupplierList();
      });    }
  }

  closeClick()
  {
    this.activateAddEditSupplierComp=false;
    this.refreshSupplierList();
  }

  refreshSupplierList()
  {
    this.service.getSupplierList().subscribe(data=>{
      this.SupplierList=data;
      this.ListWitoutFilter=data;
    });
  }


}

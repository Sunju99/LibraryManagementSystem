import { Component, OnInit } from '@angular/core';

import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-sale',
  templateUrl: './show-sale.component.html',
  styleUrls: ['./show-sale.component.css']
})
export class ShowSaleComponent implements OnInit {

  constructor(private service:SharedService) { }
  
  SaleList:any=[];
  SaleList2:any=[];
  Modaltitle?:string;
  activateAddEditSaleComp:boolean=false;
  sale:any;
  saleId:number=0;

  ngOnInit(): void {
    this.refreshSaleList();
  }
  addClick(){
    this.sale={
      saleId:0,
      studentId:0,
      bookId:0,
      price:0
     
    }
    this.Modaltitle="Add sale";
    this.activateAddEditSaleComp=true;
  }
  Search(saleId:number)
  {
    this.SaleList2=[];
   if(saleId==0)
   {
     return this.refreshSaleList();
   }else
   {
   
     for(var val of this.SaleList)
     {
       
       if(val['saleId']==saleId)
       {
         this.SaleList2.push(val);
       }
     }
     this.SaleList=this.SaleList2;
      
   }
  }
  editClick(item:any)
  {
    this.sale=item;
    this.Modaltitle="Edit sale";
    this.activateAddEditSaleComp=true;
  }

  deleteClick(item:any)
  {
    if(confirm('Are you sure want to delete this supplier'))
    {
      this.service.deleteSale(item.saleId).subscribe(data=>{
        alert(data.toString());
        this.refreshSaleList();
      });    }
  }

  closeClick()
  {
    this.activateAddEditSaleComp=false;
    this.refreshSaleList();
  }


  refreshSaleList()
  {
    this.service.getSaleList().subscribe(data=>{
      this.SaleList=data;
    });
  }


}

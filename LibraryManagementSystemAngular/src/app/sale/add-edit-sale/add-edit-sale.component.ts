import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-sale',
  templateUrl: './add-edit-sale.component.html',
  styleUrls: ['./add-edit-sale.component.css']
})
export class AddEditSaleComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() sale:any;
      saleId?:number;
      studentId?:number;
      bookId?:number;
      price?:number;

  ngOnInit(): void {
    this.saleId=this.sale.saleId;
    
    this.studentId=this.sale.studentId;
    this.bookId=this.sale.bookId;
    this.price=this.sale.price;
    
  }
  AddSale(){
    var val={
      saleId:this.saleId,
      studentId:this.studentId,
      bookId:this.bookId,
      price:this.price
     
    };
    this.service.addSale(val).subscribe(res=>{alert(res.toString());});
  }
  UpdateSale()
  {
    var val={
      saleId:this.saleId,
      studentId:this.studentId,
      bookId:this.bookId,
      price:this.price
    };
    this.service.updateSale(val).subscribe(res=>{alert(res.toString());});
  }

}

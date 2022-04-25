import { Component, OnInit } from '@angular/core';

import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-ebook',
  templateUrl: './show-ebook.component.html',
  styleUrls: ['./show-ebook.component.css']
})
export class ShowEBookComponent implements OnInit {

  constructor( private service:SharedService) { }

  EBookList:any=[];
 
  Modaltitle?:string;
  activateAddEditEBookComp:boolean=false;
  eBook:any;
  eBookName:string="";
  ListWitoutFilter:any=[];

  ngOnInit(): void {
    this.refreshEBookList();
  }

  addClick(){
    this.eBook={
      eBookId:0,
      eBookName:"",
      isbn:"",
      description:"",
      publisher:"",
      author:""
    }
    this.Modaltitle="Add EBook";
    this.activateAddEditEBookComp=true;
  }
  Filter()
  {
    var eBookName=this.eBookName;
  
    this.EBookList=this.ListWitoutFilter.filter(function(el:any){
    return el.eBookName.toString().toLowerCase().includes(eBookName.toString().trim().toLowerCase())
    });
  }
  editClick(item:any)
  {
    this.eBook=item;
    this.Modaltitle="Edit EBook";
    this.activateAddEditEBookComp=true;
  }

  deleteClick(item:any)
  {
    if(confirm('Are you sure want to delete this EBook'))
    {
      this.service.deleteEBook(item.eBookId).subscribe(data=>{
        alert(data.toString());
        this.refreshEBookList();
      });    }
  }

  closeClick()
  {
    this.activateAddEditEBookComp=false;
    this.refreshEBookList();
  }

  refreshEBookList()
  {
    this.service.getEBookList().subscribe(data=>{
      this.EBookList=data;
      this.ListWitoutFilter=data;
    });
  }
}

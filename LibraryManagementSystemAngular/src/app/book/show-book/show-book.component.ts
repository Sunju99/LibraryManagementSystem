import { Component, OnInit } from '@angular/core';

import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-book',
  templateUrl: './show-book.component.html',
  styleUrls: ['./show-book.component.css']
})
export class ShowBookComponent implements OnInit {

  constructor( private service:SharedService) { }

  BookList:any=[];

  Modaltitle?:string;
  activateAddEditBookComp:boolean=false;
  book:any;
  bookName:string="";
 
  ListWitoutFilter:any=[];

  
  ngOnInit(): void {
    this.refreshBookList();
  }
  addClick(){
    this.book={
      bookId:0,
      bookName:"",
      isbn:"",
      description:"",
      publisher:"",
      author:"",
      location:"",
      quantity:0,
      issued:0,
      bookStatusId:0
    }
    this.Modaltitle="Add Book";
    this.activateAddEditBookComp=true;
  }

 
  Filter()
  {
    var bookName=this.bookName;
  
    this.BookList=this.ListWitoutFilter.filter(function(el:any){
    return el.bookName.toString().toLowerCase().includes(bookName.toString().trim().toLowerCase())
    });
  }
  editClick(item:any)
  {
    this.book=item;
    this.Modaltitle="Edit Book";
    this.activateAddEditBookComp=true;
  }

  deleteClick(item:any)
  {
    if(confirm('Are you sure want to delete this Book'))
    {
      this.service.deleteBook(item.bookId).subscribe(data=>{
        alert(data.toString());
        this.refreshBookList();
      });    }
  }

  closeClick()
  {
    this.activateAddEditBookComp=false;
    this.refreshBookList();
  }


  refreshBookList()
  {
    this.service.getBookList().subscribe(data=>{
      this.BookList=data;
      this.ListWitoutFilter=data;
    });
  }

}

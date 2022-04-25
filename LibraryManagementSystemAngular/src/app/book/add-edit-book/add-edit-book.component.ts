import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-book',
  templateUrl: './add-edit-book.component.html',
  styleUrls: ['./add-edit-book.component.css']
})
export class AddEditBookComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() book:any;
  bookId?:number;
  bookName?:string;
  isbn?:string;
  description?:string;
  publisher?:string;
  author?:string;
  location?:string;
  quantity?:number;
  issued?:number;
  bookStatusId?:number;

  ngOnInit(): void {
    this.bookId=this.book.bookId;
    this.bookName=this.book.bookName;
    this.isbn=this.book.isbn;
    this.description=this.book.description;
    this.publisher=this.book.publisher;
    this.author=this.book.author;
    this.location=this.book.location;
    this.quantity=this.book.quantity;
    this.issued=this.book.issued;
    this.bookStatusId=this.book.bookStatusId;
  }
  AddBook(){
    var val={
      bookId:this.bookId,
      bookName:this.bookName,
      isbn:this.isbn,
      description:this.description,
      publisher:this.publisher,
      author:this.author,
      location:this.location,
      quantity:this.quantity,
      issued:this.issued,
      bookStatusId:this.bookStatusId
    };
    this.service.addBook(val).subscribe(res=>{alert(res.toString());});
  }
  UpdateBook()
  {
    var val={
      bookId:this.bookId,
      bookName:this.bookName,
      isbn:this.isbn,
      description:this.description,
      publisher:this.publisher,
      author:this.author,
      location:this.location,
      quantity:this.quantity,
      issued:this.issued,
      bookStatusId:this.bookStatusId
    };
    this.service.updateBook(val).subscribe(res=>{alert(res.toString());});
  }
}

import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-ebook',
  templateUrl: './add-edit-ebook.component.html',
  styleUrls: ['./add-edit-ebook.component.css']
})
export class AddEditEBookComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() eBook:any;
  eBookId?:number;
  eBookName?:string;
  isbn?:string;
  description?:string;
  publisher?:string;
  author?:string;

  ngOnInit(): void {
    this.eBookId=this.eBook.eBookId;
    this.eBookName=this.eBook.eBookName;
    this.isbn=this.eBook.isbn;
    this.description=this.eBook.description;
    this.publisher=this.eBook.publisher;
    this.author=this.eBook.author;
  }
  AddEBook(){
    var val={
      eBookId:this.eBookId,
      eBookName:this.eBookName,
      isbn:this.isbn,
      description:this.description,
      publisher:this.publisher,
      author:this.author
    };
    this.service.addEBook(val).subscribe(res=>{alert(res.toString());});
  }
  UpdateEBook()
  {
    var val={
      eBookId:this.eBookId,
      eBookName:this.eBookName,
      isbn:this.isbn,
      description:this.description,
      publisher:this.publisher,
      author:this.author
    };
    this.service.updateEBook(val).subscribe(res=>{alert(res.toString());});
  }

}

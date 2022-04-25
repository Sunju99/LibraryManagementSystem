import { Component, OnInit,Input } from '@angular/core';

import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-add-edit-issue',
  templateUrl: './add-edit-issue.component.html',
  styleUrls: ['./add-edit-issue.component.css']
})
export class AddEditIssueComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() issue:any;
  issueId?:number;
  studentId?:number;
  bookId?:number;
  message?:string;
  
  ngOnInit(): void {
    this.issueId=this.issue.issueId;
    this.studentId=this.issue.studentId;
    this.bookId=this.issue.bookId;
    this.message=this.issue.message;
  }
  addIssue()
  {
      var val={
        issueId:this.issueId,
        studentId:this.studentId,
        bookId:this.bookId,
        message:this.message
      }
      this.service.addIssue(val).subscribe(res=>{
        alert(res.toString());
      });
  }
  updateIssue()
  {
    var val={
      issueId:this.issueId,
      studentId:this.studentId,
      bookId:this.bookId,
      message:this.message
    }
    this.service.updateIssue(val).subscribe(res=>{
      alert(res.toString());
    });
  }

}

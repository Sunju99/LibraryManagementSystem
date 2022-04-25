import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-faculty',
  templateUrl: './add-edit-faculty.component.html',
  styleUrls: ['./add-edit-faculty.component.css']
})
export class AddEditFacultyComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() faculty:any;
  facultyId?:number;
  facultyName?:string;
  facultyEmail?:string;
  facultyPhone?:string;
  facultyAddress?:string;
  designationId?:number;
      

  ngOnInit(): void {
    this.facultyId=this.faculty.facultyId;
    this.facultyName=this.faculty.facultyName;
    this.facultyEmail=this.faculty.facultyEmail;
    this.facultyPhone=this.faculty.facultyPhone;
    this.facultyAddress=this.faculty.facultyAddress;
    this.designationId=this.faculty.designationId;
   
  }
  AddFaculty(){
    var val={
      facultyId:this.facultyId,
      facultyName:this.facultyName,
      facultyEmail:this.facultyEmail,
      facultyPhone:this.facultyPhone,
      
      facultyAddress:this.facultyAddress,
      designationId:this.designationId,
    
    };
    this.service.addFaculty(val).subscribe(res=>{alert(res.toString());});
  }
  UpdateFaculty()
  {
    var val={
      facultyId:this.facultyId,
      facultyName:this.facultyName,
      facultyEmail:this.facultyEmail,
      facultyPhone:this.facultyPhone,
      
      facultyAddress:this.facultyAddress,
      designationId:this.designationId,
    };
    this.service.updateFaculty(val).subscribe(res=>{alert(res.toString());});
  }



}

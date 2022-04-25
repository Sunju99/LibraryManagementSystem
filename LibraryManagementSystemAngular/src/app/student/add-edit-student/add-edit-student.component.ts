import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-add-edit-student',
  templateUrl: './add-edit-student.component.html',
  styleUrls: ['./add-edit-student.component.css']
})
export class AddEditStudentComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() student:any;
      studentId?:number;
      studentName?:string;
      stunentEmail?:string;
      fatherName?:string;
      phone?:string;
      address?:string;
      class?:string;
      rollNo?:number;

  ngOnInit(): void {
    this.studentId=this.student.studentId;
    this.studentName=this.student.studentName;
    this.stunentEmail=this.student.stunentEmail;
    this.fatherName=this.student.fatherName;
    this.phone=this.student.phone;
    this.address=this.student.address;
    this.class=this.student.class;
    this.rollNo=this.student.rollNo;
  }
  AddStudent(){
    var val={
      studentId:this.studentId,
      studentName:this.studentName,
      stunentEmail:this.stunentEmail,
      fatherName:this.fatherName,
      address:this.address,
      phone:this.phone,
      class:this.class,
      rollNo:this.rollNo
    };
    this.service.addStudent(val).subscribe(res=>{alert(res.toString());});
  }
  UpdateStudent()
  {
    var val={
      studentId:this.studentId,
      studentName:this.studentName,
      stunentEmail:this.stunentEmail,
      fatherName:this.fatherName,
      address:this.address,
      phone:this.phone,
      class:this.class,
      rollNo:this.rollNo
    };
    this.service.updateStudent(val).subscribe(res=>{alert(res.toString());});
  }


}

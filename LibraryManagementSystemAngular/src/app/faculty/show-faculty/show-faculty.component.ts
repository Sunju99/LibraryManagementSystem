import { Component, OnInit } from '@angular/core';

import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-faculty',
  templateUrl: './show-faculty.component.html',
  styleUrls: ['./show-faculty.component.css']
})
export class ShowFacultyComponent implements OnInit {

  constructor(private service:SharedService) { }

  FacultyList:any=[];

  Modaltitle?:string;
  activateAddEditFacultyComp:boolean=false;
  faculty:any;
  facultyName:string="";
  ListWitoutFilter:any=[];
  ngOnInit(): void {
    this.refreshFacultyList();
  }
  addClick(){
    this.faculty={
      facultyId:0,
      facultyName:"",
      facultyEmail:"",
      facultyPhone:"",
      facultyAddress:"",
      designationId:0
      
    }
    this.Modaltitle="Add Faculty";
    this.activateAddEditFacultyComp=true;
  }

  
  editClick(item:any)
  {
    this.faculty=item;
    this.Modaltitle="Edit Faculty";
    this.activateAddEditFacultyComp=true;
  }

  deleteClick(item:any)
  {
    if(confirm('Are you sure want to delete this Faculty'))
    {
      this.service.deleteFaculty(item.facultyId).subscribe(data=>{
        alert(data.toString());
        this.refreshFacultyList();
      });    }
  }

  closeClick()
  {
    this.activateAddEditFacultyComp=false;
    this.refreshFacultyList();
  }


  Filter()
  {
    var  facultyName=this.facultyName;
  
    this.FacultyList=this.ListWitoutFilter.filter(function(el:any){
    return el.facultyName.toString().toLowerCase().includes(facultyName.toString().trim().toLowerCase())
    });
  }

  refreshFacultyList()
  {
    this.service.getFacultyList().subscribe(data=>{
      this.FacultyList=data;
      this.ListWitoutFilter=data;
    });
  }

}

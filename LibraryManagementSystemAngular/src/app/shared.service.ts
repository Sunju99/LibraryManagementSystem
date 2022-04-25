import { Injectable } from '@angular/core';

import{HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="https://localhost:44324/api";

  constructor(private http:HttpClient) { }
  
  getBookList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Book');
  }

  getBook(BookId:number):Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Book/'+BookId);
  }
  
  addBook(val:any)
  {
    return this.http.post(this.APIUrl+'/Book',val);
  }

  updateBook(val:any)
  {
    return this.http.put(this.APIUrl+'/Book',val);
  }
  deleteBook(val:any)
  {
    return this.http.delete(this.APIUrl+'/Book/'+val);
  }
  getEBookList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/EBook');
  }
  
  addEBook(val:any)
  {
    return this.http.post(this.APIUrl+'/EBook',val);
  }

  updateEBook(val:any)
  {
    return this.http.put(this.APIUrl+'/EBook',val);
  }
  deleteEBook(val:number)
  {
    return this.http.delete(this.APIUrl+'/EBook/'+val);
  }
  getFacultyList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Faculty');
  }
  
  addFaculty(val:any)
  {
    return this.http.post(this.APIUrl+'/Faculty',val);
  }

  updateFaculty(val:any)
  {
    return this.http.put(this.APIUrl+'/Faculty',val);
  }
  deleteFaculty(val:any)
  {
    return this.http.delete(this.APIUrl+'/Faculty/'+val);
  }
  getIssueList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Issue');
  }
  
  addIssue(val:any)
  {
    return this.http.post(this.APIUrl+'/Issue',val);
  }

  updateIssue(val:any)
  {
    return this.http.put(this.APIUrl+'/Issue',val);
  }
  deleteIssue(val:any)
  {
    return this.http.delete(this.APIUrl+'/Issue/'+val);
  }

  getSaleList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Sale');
  }
  
  addSale(val:any)
  {
    return this.http.post(this.APIUrl+'/Sale',val);
  }

  updateSale(val:any)
  {
    return this.http.put(this.APIUrl+'/Sale',val);
  }
  deleteSale(val:any)
  {
    return this.http.delete(this.APIUrl+'/Sale/'+val);
  }
  getStudentList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Student');
  }
  
  addStudent(val:any)
  {
    return this.http.post(this.APIUrl+'/Student',val);
  }

  updateStudent(val:any)
  {
    return this.http.put(this.APIUrl+'/Student',val);
  }
  deleteStudent(val:any)
  {
    return this.http.delete(this.APIUrl+'/Student/'+val);
  }

  getSupplierList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Supplier');
  }
  
  addSupplier(val:any)
  {
    return this.http.post(this.APIUrl+'/Supplier',val);
  }

  updateSupplier(val:any)
  {
    return this.http.put(this.APIUrl+'/Supplier',val);
  }
  deleteSupplier(val:any)
  {
    return this.http.delete(this.APIUrl+'/Supplier/'+val);
  }
}

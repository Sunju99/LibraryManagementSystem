import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { ShowBookComponent } from './book/show-book/show-book.component';
import { AddEditBookComponent } from './book/add-edit-book/add-edit-book.component';
import { FacultyComponent } from './faculty/faculty.component';
import { AddEditFacultyComponent } from './faculty/add-edit-faculty/add-edit-faculty.component';
import { ShowFacultyComponent } from './faculty/show-faculty/show-faculty.component';
import { SaleComponent } from './sale/sale.component';
import { ShowSaleComponent } from './sale/show-sale/show-sale.component';
import { AddEditSaleComponent } from './sale/add-edit-sale/add-edit-sale.component';
import { SupplierComponent } from './supplier/supplier.component';
import { AddEditSupplierComponent } from './supplier/add-edit-supplier/add-edit-supplier.component';
import { ShowSupplierComponent } from './supplier/show-supplier/show-supplier.component';
import { IssueComponent } from './issue/issue.component';
import { ShowIssueComponent } from './issue/show-issue/show-issue.component';
import { AddEditIssueComponent } from './issue/add-edit-issue/add-edit-issue.component';
import { EBookComponent } from './ebook/ebook.component';
import { AddEditEBookComponent } from './ebook/add-edit-ebook/add-edit-ebook.component';
import { ShowEBookComponent } from './ebook/show-ebook/show-ebook.component';
import { StudentComponent } from './student/student.component';
import { ShowStudentComponent } from './student/show-student/show-student.component';
import { AddEditStudentComponent } from './student/add-edit-student/add-edit-student.component';

import { SharedService } from './shared.service';
import{HttpClientModule} from '@angular/common/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { DashbordComponent } from './dashbord/dashbord.component';
import { BodyComponent } from './body/body.component';

@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    ShowBookComponent,
    AddEditBookComponent,
    FacultyComponent,
    AddEditFacultyComponent,
    ShowFacultyComponent,
    SaleComponent,
    ShowSaleComponent,
    AddEditSaleComponent,
    SupplierComponent,
    AddEditSupplierComponent,
    ShowSupplierComponent,
    IssueComponent,
    ShowIssueComponent,
    AddEditIssueComponent,
    EBookComponent,
    AddEditEBookComponent,
    ShowEBookComponent,
    StudentComponent,
    ShowStudentComponent,
    AddEditStudentComponent,
    DashbordComponent,
    BodyComponent
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }

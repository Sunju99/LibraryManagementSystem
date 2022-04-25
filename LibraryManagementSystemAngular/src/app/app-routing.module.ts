import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {BookComponent} from './book/book.component';
import { EBookComponent } from './ebook/ebook.component';
import { FacultyComponent } from './faculty/faculty.component';
import { IssueComponent } from './issue/issue.component';
import { SaleComponent } from './sale/sale.component';
import { StudentComponent } from './student/student.component';
import { SupplierComponent } from './supplier/supplier.component';
import { DashbordComponent } from './dashbord/dashbord.component';



const routes: Routes = [
  {path: '',redirectTo: 'dashbord', pathMatch:'full'},
  {path:'dashbord',component:DashbordComponent},
  {path:'book',component:BookComponent},
  {path:'ebook',component:EBookComponent},
  {path:'faculty',component:FacultyComponent},
  {path:'issue',component:IssueComponent},
  {path:'sale',component:SaleComponent},
  {path:'student',component:StudentComponent},
  {path:'supplier',component:SupplierComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

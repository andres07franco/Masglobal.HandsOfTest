import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeDetailScreenComponent } from './employee-detail-screen/employee-detail-screen.component';
import { EmployeeListScreenComponent } from './employee-list-screen/employee-list-screen.component';
import { EmployeeFilterComponent } from './employee-list-screen/employee-filter/employee-filter.component';
import { EmployeeListComponent } from './employee-list-screen/employee-list/employee-list.component';
import { RouterModule, Routes } from '@angular/router';
import { GetEmployeeService } from './shared/services/get-employee.service';
import { SharedModule } from 'src/app/shared/shared.module';
import { FormsModule } from '@angular/forms';


const routes: Routes = [
  { path: '', component: EmployeeListScreenComponent  },
  { path: ':id', component: EmployeeDetailScreenComponent },
];

@NgModule({
  declarations: [EmployeeDetailScreenComponent, EmployeeListScreenComponent, EmployeeFilterComponent, EmployeeListComponent],
  providers:[GetEmployeeService],
  imports: [
    CommonModule,
    FormsModule,
    SharedModule,
    RouterModule.forChild(routes)
  ]
})
export class EmployeesModule { }

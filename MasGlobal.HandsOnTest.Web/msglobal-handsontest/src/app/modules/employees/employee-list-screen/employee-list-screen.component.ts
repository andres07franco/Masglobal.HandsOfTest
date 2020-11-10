import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/core/models/employee.model';
import { GetEmployeeService } from '../shared/services/get-employee.service';

@Component({
  selector: 'app-employee-list-screen',
  templateUrl: './employee-list-screen.component.html',
  styleUrls: ['./employee-list-screen.component.scss']
})
export class EmployeeListScreenComponent implements OnInit {

  public employees:Employee[] = []

  constructor(public getEmployeeService:GetEmployeeService) { }

  ngOnInit() {
    this.refresh();
  }

  refresh(){
    this.getEmployeeService
    .getAll()
    .subscribe(
      employees => {
        this.employees = employees;
      },
    );
  }

  onSearchHandle(id:number){
    if(id==null){
      this.refresh();
    }
    else{
      this.getEmployeeService
      .getById(id)
      .subscribe(
        employee => {
          if(employee!=null){
            this.employees = [employee];
          }
          else{
            this.employees = []
          }
          
        },
      );
    }
  }

}

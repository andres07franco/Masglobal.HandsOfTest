import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {Location} from '@angular/common';
import { GetEmployeeService } from '../shared/services/get-employee.service';
import { Employee } from 'src/app/core/models/employee.model';

@Component({
  selector: 'app-employee-detail-screen',
  templateUrl: './employee-detail-screen.component.html',
  styleUrls: ['./employee-detail-screen.component.scss']
})
export class EmployeeDetailScreenComponent implements OnInit {

  public id:number;
  public employee:any = { Name : "", Role: {Name:""}};
  constructor(
    public getEmployeeService:GetEmployeeService,
    private route: ActivatedRoute, 
    private _location: Location) { }

  ngOnInit() {

    this.route.paramMap.subscribe( paramMap => {
      this.id = Number(paramMap.get('id'));
      this.refresh();
    });

  }

  refresh(){
    this.getEmployeeService
    .getById(this.id)
    .subscribe(
      employee => {
        this.employee = employee;
      },
    );
  }

  onPressBackButtomHandel(){
    this._location.back();
  }

}

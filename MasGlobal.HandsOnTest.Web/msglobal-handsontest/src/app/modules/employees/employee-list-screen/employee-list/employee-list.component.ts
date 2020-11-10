import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/core/models/employee.model';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements OnInit {

  @Input()
  public employees:Employee[];

  constructor(private router: Router ) { }

  ngOnInit() {
  }

  onPressButtomViewHandle(id:number){
    this.router.navigate(['employees/'+id]);
  }

}

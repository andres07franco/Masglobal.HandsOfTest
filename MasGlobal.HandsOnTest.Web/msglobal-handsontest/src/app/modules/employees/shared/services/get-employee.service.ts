import { Injectable } from '@angular/core';
import { DataAccesBaseService } from 'src/app/core/services/data-acces-base.service';
import { HttpClient} from '@angular/common/http';
import { Employee } from 'src/app/core/models/employee.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetEmployeeService extends DataAccesBaseService {

  constructor(public http: HttpClient) {
    super(http);
  }

  public getById(id:number):Observable<Employee> { 
    this.ResourcePath = 'Employee/'+id;
    return super.get<Employee>(id);
  }

  public getAll():Observable<Employee[]>{
    this.ResourcePath = 'Employee';
    return super.getList<Employee>({});
  }

}

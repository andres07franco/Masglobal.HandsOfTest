import { Component, EventEmitter, OnInit, Output } from '@angular/core';


@Component({
  selector: 'app-employee-filter',
  templateUrl: './employee-filter.component.html',
  styleUrls: ['./employee-filter.component.scss']
})
export class EmployeeFilterComponent implements OnInit {

  @Output()
  onSearch  = new EventEmitter<number>();

  searchText:string = '';
  searchTextError:boolean = false;

  constructor() { }

  ngOnInit() {
  }

  onPressShearchButtomHandle(){
    const search = this.searchText == ''?null:this.searchText;
    if(search != null && isNaN(parseInt(search))){
      this.searchTextError = true;
      return;
    }
 
    this.searchTextError = false;
    const searchNumber:number = search != null?parseInt(search):null;
    this.onSearch.emit(searchNumber);
  }

}

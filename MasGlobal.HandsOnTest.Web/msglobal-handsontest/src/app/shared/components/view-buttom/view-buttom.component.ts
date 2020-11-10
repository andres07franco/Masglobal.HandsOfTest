import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-view-buttom',
  templateUrl: './view-buttom.component.html'
})
export class ViewButtomComponent {

  @Output() onPress = new EventEmitter();

  onPressHandle(){
    this.onPress.emit();
  }

}

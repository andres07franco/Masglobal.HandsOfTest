import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-back-buttom',
  templateUrl: './back-buttom.component.html',
})
export class BackButtomComponent{

  @Output() onPress = new EventEmitter();

  onPressHandle(){
    this.onPress.emit();
  }
}

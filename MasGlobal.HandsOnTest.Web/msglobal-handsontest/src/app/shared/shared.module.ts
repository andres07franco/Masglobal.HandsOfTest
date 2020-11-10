import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ViewButtomComponent } from './components/view-buttom/view-buttom.component';
import { BackButtomComponent } from './components/back-buttom/back-buttom.component';


@NgModule({
  declarations: [ViewButtomComponent, BackButtomComponent],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  exports: [
    CommonModule,
    HttpClientModule,
    ViewButtomComponent,
    BackButtomComponent
  ],
})
export class SharedModule { }

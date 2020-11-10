import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutComponent } from './layout/layout.component';
import { EmployeesModule } from './modules/employees/employees.module';
import { NavbarNavComponent } from './layout/navbar-nav/navbar-nav.component';
import { TopBarComponent } from './layout/top-bar/top-bar.component';
import { FooterBarComponent } from './layout/footer-bar/footer-bar.component';
import { SharedModule } from './shared/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    NavbarNavComponent,
    TopBarComponent,
    FooterBarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EmployeesModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

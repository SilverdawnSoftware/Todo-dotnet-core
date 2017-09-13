// ALLOWOVERWRITE-7CD8602A74BD0E43680F55ED164E86E6

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule, MdNativeDateModule, MdTabsModule } from '@angular/material';
import { HttpModule }    from '@angular/http';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

import { AppComponent } from './app.component';


import { AdminRoutingModule } from "./modules/admin/AdminRoutingModule";

import {AppShell} from "./modules/shell/appshell";


import {UserIndex} from './modules/admin/User/Views/UserIndex';
import {UserEdit} from './modules/admin/User/Views/UserEdit';


import {TaskIndex} from './modules/admin/Task/Views/TaskIndex';
import {TaskEdit} from './modules/admin/Task/Views/TaskEdit';


@NgModule({
  imports: [BrowserModule, ReactiveFormsModule, BrowserAnimationsModule, MaterialModule, MdNativeDateModule, MdTabsModule,NgxDatatableModule, HttpModule, AdminRoutingModule],
  declarations: [AppShell 
  ,UserEdit,UserIndex
  ,TaskEdit,TaskIndex
  
  
  ],
  bootstrap: [AppShell]
})
export class AppModule {}

//platformBrowserDynamic().bootstrapModule(AppModule);

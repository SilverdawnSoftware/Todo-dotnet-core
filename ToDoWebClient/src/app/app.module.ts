import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule, MdNativeDateModule, MdTabsModule } from '@angular/material';
import { HttpModule }    from '@angular/http';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

import { AppComponent } from './app.component';

import {UserEdit} from './modules/admin/User/Views/UserEdit';
import { AdminRoutingModule } from "./modules/admin/AdminRoutingModule";
import {UserIndex} from "./modules/admin/User/Views/UserIndex";
import {AppShell} from "./modules/shell/appshell";
import {TaskEdit} from "./modules/admin/Task/Views/TaskEdit";
import {TaskIndex} from "./modules/admin/Task/Views/TaskIndex";


@NgModule({
  imports: [BrowserModule, ReactiveFormsModule, BrowserAnimationsModule, MaterialModule, MdNativeDateModule, MdTabsModule, HttpModule, AdminRoutingModule,NgxDatatableModule],
  declarations: [AppShell, UserEdit,UserIndex,TaskEdit,TaskIndex ],
  bootstrap: [AppShell]
})
export class AppModule {}

//platformBrowserDynamic().bootstrapModule(AppModule);

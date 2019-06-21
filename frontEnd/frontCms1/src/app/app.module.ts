import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { cityApiservice} from './Base/Base.apiservices/City.service';
import { LocationTypeApiservice} from './Base/Base.apiservices/LocationType.service';
import { HttpClientModule } from '@angular/common/http';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations' 
import {MatButtonModule, MatCheckboxModule} from '@angular/material';
import {MatListModule} from '@angular/material/list';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';


import {MatSortModule} from '@angular/material/sort';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';
import { Citycomponent} from './Base/City.component';
import { Citiescomponent} from './Base/Cities.component';
import{ locationTypeComponnet} from './Base/Locationtype.component';
import{ LocationTypescomponent} from './Base/LocationTypes.Component';

@NgModule({
  declarations: [
    AppComponent,Citycomponent,Citiescomponent,locationTypeComponnet,LocationTypescomponent
  ],
  imports: [
    BrowserModule,HttpClientModule,FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule, MatCheckboxModule,MatInputModule,MatCardModule,MatListModule,MatSortModule,MatTableModule
    ,MatPaginatorModule
    
  ],
  providers: [cityApiservice,LocationTypeApiservice],
  bootstrap: [AppComponent]
})
export class AppModule { }

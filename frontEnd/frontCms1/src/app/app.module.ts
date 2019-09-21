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
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatDividerModule} from '@angular/material/divider';

import { Navcomponent} from './nav.component'
import {MatSortModule} from '@angular/material/sort';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';
import { homeComponent }from './home.component'
import { Citycomponent} from './Base/City.component';
import { Citiescomponent} from './Base/Cities.component';
import{ locationTypeComponnet} from './Base/Locationtype.component';
import{ LocationTypescomponent} from './Base/LocationTypes.Component';
import {navCmscomponent} from './navCms.component';
import {navBasecomponent} from './Base/navBase.component';
import {cmsBasecomponent} from './cms/cmsBase.component'

import { RouterModule } from '@angular/router';
import { CityViewComponent } from './Base/city-view/city-view.component';
import { LocationTypeViewComponent } from './Base/location-type-view/location-type-view.component'

import { AccordionModule } from 'primeng/accordion';  
import {OrderListModule} from 'primeng/orderlist';
import {MenuItem} from 'primeng/api'; 
import {CarouselModule} from 'primeng/carousel';


import { ViewClinicHomeComponent } from './clinic/Home/view-clinic-home/view-clinic-home.component';
import { NavClinicComponent } from './clinic/Home/nav-clinic/nav-clinic.component';
import { SlideShowComponent } from './clinic/Home/slide-show/slide-show.component';
import { MatSidenavModule, MatIconModule } from "@angular/material";
import { FlexLayoutModule } from "@angular/flex-layout";
import { NavListComponent } from './clinic/Home/nav-list/nav-list.component';

import { SliderModule } from 'angular-image-slider';
import { SlideShow2Component } from './clinic/Home/slide-show2/slide-show2.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { SlideShow3Component } from './clinic/Home/slide-show3/slide-show3.component';

const routes =[
  {path: '',component :homeComponent},
  {path: 'Cms',component :cmsBasecomponent},
   {path: 'Cms/navbase',component :navBasecomponent},
  // {path: 'navcms',component :navCmscomponent},
  {path : 'Cms/City' ,component: CityViewComponent},
  {path : 'Cms/LocationType' ,component: LocationTypeViewComponent},
  {path : 'Cities', component : Citiescomponent},
  {path : 'LocationType' ,component: locationTypeComponnet},
  {path : 'LocationTypes' , component: LocationTypescomponent},
  {path : 'ClinicHome',component:ViewClinicHomeComponent}
]

@NgModule({
  declarations: [
    AppComponent,homeComponent,Citycomponent,Citiescomponent,locationTypeComponnet,LocationTypescomponent,
    Navcomponent,navCmscomponent,navBasecomponent,cmsBasecomponent, CityViewComponent,
    LocationTypeViewComponent, ViewClinicHomeComponent, NavClinicComponent, SlideShowComponent, NavListComponent, SlideShow2Component, SlideShow3Component
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,AccordionModule,OrderListModule,
    RouterModule.forRoot(routes),
    FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule, MatCheckboxModule,MatInputModule,MatCardModule,MatListModule,MatSortModule,MatTableModule
    ,MatPaginatorModule,MatToolbarModule
    ,MatSidenavModule, MatIconModule,FlexLayoutModule,SliderModule
    ,CarouselModule,NgbModule
    
  ],
  providers: [cityApiservice,LocationTypeApiservice],
  bootstrap: [AppComponent]
})
export class AppModule { }

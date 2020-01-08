import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule ,ReactiveFormsModule } from '@angular/forms';
import { cityApiservice} from './Base/city-view/CityService/City.service';
import { LocationTypeApiservice} from './Base/location-type-view/LocationtypeService/LocationType.service';
import { unitapiservice} from './base/unit-view/UnitService/Unit.Api.Service'
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Authservice } from './registers/reg.services/register.service';

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
import { Citycomponent} from './Base/city-view/CityComponent/City.component';
import { Citiescomponent} from './Base/city-view/CitiesComponent/Cities.component';
import{ locationTypeComponnet} from './Base/location-type-view/LocationTypeComponent/Locationtype.component';
import{ LocationTypescomponent} from './Base/location-type-view/LocationTypesComponent/LocationTypes.Component';
import {navCmscomponent} from './navCms.component';
import {navBasecomponent} from './Base/navBase.component';
import {cmsBasecomponent} from './cms/cmsBase.component';
import { LoginComponent } from './registers/login/login.component';
import { UnitViewComponent } from './Base/unit-view/unit-view.component';
import { UnitComponent } from './base/unit-view/unit/unit.component';
import { UnitsComponent } from './base/unit-view/units/units.component';
import { ViewClinicHomeComponent } from './clinic/Home/view-clinic-home/view-clinic-home.component';
import { NavClinicComponent } from './clinic/Home/nav-clinic/nav-clinic.component';
import { SlideShowComponent } from './clinic/Home/slide-show/slide-show.component';
import { NavListComponent } from './clinic/Home/nav-list/nav-list.component';
import { SlideShow2Component } from './clinic/Home/slide-show2/slide-show2.component';
import { SlideShow3Component } from './clinic/Home/slide-show3/slide-show3.component';
import { RegisterComponent } from './registers/register/register.component';
import { LocationTypeViewComponent } from './Base/location-type-view/location-type-view.component';
import { CityViewComponent } from './Base/city-view/city-view.component';

import { RouterModule } from '@angular/router';



import { AccordionModule } from 'primeng/accordion';  
import {OrderListModule} from 'primeng/orderlist';
import {MenuItem} from 'primeng/api'; 
import {CarouselModule} from 'primeng/carousel';

import { MatSidenavModule, MatIconModule } from "@angular/material";
import { FlexLayoutModule } from "@angular/flex-layout";


import { SliderModule } from 'angular-image-slider';

import {NgbModule} from '@ng-bootstrap/ng-bootstrap';


import { AuthInterceptor } from './registers/reg.services/auth.interseptor';


import {DropdownModule} from 'primeng/dropdown';
import {MatSelectModule} from '@angular/material/select';

const routes =[
  {path: '',component :homeComponent},
  {path: 'Cms',component :cmsBasecomponent},
   {path: 'Cms/navbase',component :navBasecomponent},
  // {path: 'navcms',component :navCmscomponent},
  {path : 'Cms/City' ,component: CityViewComponent},
  {path : 'Cms/LocationType' ,component: LocationTypeViewComponent},
  {path : 'Cms/Unit',component: UnitViewComponent},
  {path : 'Cities', component : Citiescomponent},
  {path : 'LocationType' ,component: locationTypeComponnet},
  {path : 'LocationTypes' , component: LocationTypescomponent},
  {path : 'ClinicHome',component:ViewClinicHomeComponent},
  {path : 'Register',component:RegisterComponent},
  {path : 'Login',component:LoginComponent}
]

@NgModule({
  declarations: [
    AppComponent,homeComponent,Citycomponent,Citiescomponent,locationTypeComponnet,LocationTypescomponent,
    Navcomponent,navCmscomponent,navBasecomponent,cmsBasecomponent, CityViewComponent,
    LocationTypeViewComponent, ViewClinicHomeComponent, NavClinicComponent, SlideShowComponent, NavListComponent
    , SlideShow2Component, SlideShow3Component, RegisterComponent, LoginComponent, UnitViewComponent
    , UnitComponent, UnitsComponent
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,AccordionModule,OrderListModule,
    RouterModule.forRoot(routes),
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule, MatCheckboxModule,MatInputModule,MatCardModule,MatListModule,MatSortModule,MatTableModule
    ,MatPaginatorModule,MatToolbarModule
    ,MatSidenavModule, MatIconModule,FlexLayoutModule,SliderModule
    ,CarouselModule,NgbModule,DropdownModule,MatSelectModule
    
  ],
  providers: [cityApiservice,LocationTypeApiservice,unitapiservice,Authservice, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
 
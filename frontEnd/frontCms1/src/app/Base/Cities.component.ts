import { Component } from "@angular/core";
import { cityApiservice} from './Base.apiservices/City.service';
import {Sort} from '@angular/material/sort';

export interface PeriodicElement {
    name: string;
    code: number;
    
  }
const ELEMENT_DATA: PeriodicElement[] = [
    {code: 1, name: 'Hydrogen'},
    {code: 2, name: 'Helium'},
    {code: 3, name: 'Lithium'},
    
  ];


@Component({
selector:'cities',
templateUrl:'./cities.Component.html'
})

export class Citiescomponent{
cities={}
displayedColumns: string[] = ['Code', 'Name'];
// dataSource = ELEMENT_DATA;

dataSource
constructor(private cityapi:cityApiservice){
    
}

ngOnInit(){
    //console.log("sssssss");
     this.cityapi.GetCities().subscribe(res => {this.dataSource=res})
}



}
import { Component, OnInit } from '@angular/core';
import { unitapiservice }from '../UnitService/Unit.Api.Service'
import {Unit} from '../UnitModel/Unit'
import {UnitType} from '../UnitModel/UnitType'
@Component({
  selector: 'app-unit',
  templateUrl: './unit.component.html',
  styleUrls: ['./unit.component.scss']
})
export class UnitComponent implements OnInit {

unit={}
items: {};
item: string;
ss={}
states:{}
  constructor(private UnitApi: unitapiservice) { 
    //this.states = [{ title: 'Hp' }, { title: 'Dell'}, { title: 'Lenovo' }];
    this.UnitApi.GetUnitType().subscribe(res=> {this.states= res} )
  }
  

  ngOnInit() {
    
   
   this.UnitApi.Unitselected.subscribe(City => this.unit=City); 
  }

  filter(filter)
  {
    //this.unit= filter.id;
    
    console.log(filter);
  
    console.log(this.unit);
    
  }

}

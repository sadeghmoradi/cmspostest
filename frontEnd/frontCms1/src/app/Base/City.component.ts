import { Component } from "@angular/core";
import { cityApiservice} from './Base.apiservices/City.service';
import { City } from './model/City';

@Component({
    selector : 'City',
templateUrl: './City.component.html'
})

export class Citycomponent
{
    City ={};
    constructor(private CityApi:cityApiservice){}

}

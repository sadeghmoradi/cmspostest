import { Component } from "@angular/core";
import { cityApiservice} from './Base.apiservices/City.service';


@Component({
    selector : 'City',
templateUrl: './City.component.html'
})

export class Citycomponent
{
    City ={};
    constructor(private CityApi:cityApiservice){}
ngOnInit(){
     
    this.CityApi.citiesselected.subscribe(City => this.City=City); 
    console.log(this.City)
}


}

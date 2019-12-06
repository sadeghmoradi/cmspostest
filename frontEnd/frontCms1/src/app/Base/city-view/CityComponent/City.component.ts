import { Component } from "@angular/core";
import { cityApiservice} from '../CityService/City.service';


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
    
}


}

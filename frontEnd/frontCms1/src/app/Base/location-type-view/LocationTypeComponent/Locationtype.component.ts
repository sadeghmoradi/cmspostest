import { Component } from "@angular/core";
import { LocationTypeApiservice} from '../LocationtypeService/LocationType.service';
import { LocationType} from '../LocationTypeMolde/LocationType'

@Component({
    selector:'LocationType',
    templateUrl: './LocationType.component.html'
})
export class locationTypeComponnet{
    
    LocationType ={}
     constructor(private locTypeApi:LocationTypeApiservice){}
 ngOnInit(){
     this.locTypeApi.locationTypeselected.subscribe(res =>{this.LocationType = res });
 }
}
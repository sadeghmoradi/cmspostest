import { Component ,ViewChild} from "@angular/core";
import {MatPaginator, MatSort} from '@angular/material';
import { LocationTypeApiservice} from './Base.apiservices/LocationType.service';
import {PageEvent} from '@angular/material/paginator';


@Component({
selector:'LocationTypes',
 templateUrl:'./LocationTypes.Component.html'
})

export class LocationTypescomponent{
LocationTypes={};
displayedColumns: string[] = ['Code', 'Name'];

 

 dataSource;

constructor(private locTypeApi:LocationTypeApiservice ){}

ngOnInit(){
    
    this.locTypeApi.GetLocationType().subscribe(res => {this.dataSource=res})
   
}



}
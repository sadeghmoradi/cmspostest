import { Injectable } from '@angular/core'
import { HttpClient ,HttpParams} from '@angular/common/http'
import { ApiAddress } from 'src/app/dataRefrence';
import {Observable, Subject} from 'rxjs';
import {map} from 'rxjs/operators';
import { LocationType } from '../LocationTypeMolde/LocationType';

@Injectable()

export class LocationTypeApiservice{
 
    private selectedLocationType = new Subject<any>();
    locationTypeselected  = this.selectedLocationType.asObservable();

constructor(private http:HttpClient){}

selectLocationType(LocationType){
    this.selectedLocationType.next(LocationType);
}

PutLocationType(LocationType){
    this.http.put(`${ApiAddress}LocationType/${LocationType.id}`,LocationType).subscribe(res => {console.log(res)})
};

PostLocationType(LocationType){
    this.http.post(ApiAddress+'LocationType',LocationType).subscribe(res => {console.log(res)})
};

GetLocationType(){

    return this.http.get(ApiAddress+'LocationType')
    
};



}
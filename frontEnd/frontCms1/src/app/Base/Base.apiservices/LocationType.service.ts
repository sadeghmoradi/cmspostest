import { Injectable } from '@angular/core'
import { HttpClient ,HttpParams} from '@angular/common/http'
import { ApiAddress } from 'src/app/dataRefrence';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';
import { LocationType } from '../model/LocationType';

@Injectable()

export class LocationTypeApiservice{
 
constructor(private http:HttpClient){
}

PostLocationType(LocationType){
    this.http.post(ApiAddress+'LocationType',LocationType).subscribe(res => {console.log(res)})
};

GetLocationType(){

    return this.http.get(ApiAddress+'LocationType')
    
};



}
import { Injectable } from '@angular/core'
import { HttpClient ,HttpParams} from '@angular/common/http'
import { ApiAddress } from '../../../dataRefrence';
import { Observable, Subject} from 'rxjs';
import {Unit} from '../UnitModel/Unit';



@Injectable() 

export class unitapiservice{
 
    private selectedUnits = new Subject<any>();
    Unitselected = this.selectedUnits.asObservable();

constructor(private http:HttpClient){}



PostUnit(unit){
    console.log(unit);
    this.http.post(ApiAddress+'Unit',unit).subscribe(res => {console.log(res)})
};

PutUnit(unit){
    this.http.put(`${ApiAddress}Unit/${unit.id}`,unit).subscribe(res => {console.log(res)})
};

GetUnit(){

    return this.http.get(ApiAddress+'Unit')
    
};

GetUnitType(){
    return this.http.get(ApiAddress+'UnitType')
}

selectUnits(unit){
    this.selectedUnits.next(unit)
   
};


findunit(
     filter = '', sortOrder = 'asc',
    pageNumber =0, pageSize =5){
console.log("ffffffffffff");
    return this.http.get(ApiAddress+'Unit', {
        params: new HttpParams()
            .set('filter', filter)
            .set('sortOrder', sortOrder)
            .set('pageNumber', pageNumber.toString())
            .set('pageSize', pageSize.toString())
    })
 }


}
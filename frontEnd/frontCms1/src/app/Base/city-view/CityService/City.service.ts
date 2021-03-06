import { Injectable } from '@angular/core'
import { HttpClient ,HttpParams} from '@angular/common/http'
import { ApiAddress } from 'src/app/dataRefrence';
import {Observable, Subject} from 'rxjs';
import {map} from 'rxjs/operators';
import {City} from '../CityModel/City';
import { $ } from 'protractor';


@Injectable() 

export class cityApiservice{
 
    private selectedCities = new Subject<any>();
    citiesselected = this.selectedCities.asObservable();


constructor(private http:HttpClient){}



PostCity(City){
    this.http.post(ApiAddress+'Cities',City).subscribe(res => {console.log(res)})
};

PutCity(City){
    this.http.put(`${ApiAddress}Cities/${City.id}`,City).subscribe(res => {console.log(res)})
};

GetCities(){

    return this.http.get(ApiAddress+'Cities')
    
};

selectCities(city){
    this.selectedCities.next(city)
   
};

// GetCities1(): Observable<City>{
//     return this.http.get(ApiAddress+'Cities',{
//         params: new HttpParams()
//     }).pipe(map(res=> res["ttt"])) 
// };


// findCities(
//     //courseId:number,
//      filter = '', sortOrder = 'asc',
//     pageNumber =1, pageSize =5):  Observable<City[]> {

//     return this.http.get(ApiAddress+'Cities/bypaging', {
//         params: new HttpParams()
//             //.set('courseId', courseId.toString())
//             .set('filter', filter)
//             .set('sortOrder', sortOrder)
//             .set('pageNumber', pageNumber.toString())
//             .set('pageSize', pageSize.toString())
//     }).pipe(
//         map(res => res.propertyIsEnumerable["name,code"])
        
//     )    ;
//  }



private countcity = new Subject<any>();
citycount = this.countcity.asObservable();
 findCities(
    //courseId:number,
     filter = '', sortOrder = 'asc',
    pageNumber =0, pageSize =5){

    return this.http.get(ApiAddress+'Cities', {
        params: new HttpParams()
            //.set('courseId', courseId.toString())
            .set('filter', filter)
            .set('sortOrder', sortOrder)
            .set('pageNumber', pageNumber.toString())
            .set('pageSize', pageSize.toString())
    });
 }



}
import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { ApiAddress } from 'src/app/dataRefrence';

@Injectable()

export class cityApiservice{

constructor(private http:HttpClient){}

PostCity(City){
    this.http.post(ApiAddress+'Cities',City).subscribe(res => {console.log(res)})
};

GetCities(){
    return this.http.get(ApiAddress+'Cities')
};

}
import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { ApiAddress } from 'src/app/dataRefrence';

@Injectable() 

export class Authservice{
rr="sssssssssssssssssssssss"
    constructor(private http:HttpClient){}
    register(credentials){
        console.log(this.rr)
        this.http.post(`https://localhost:44334/api/account`,credentials).subscribe((res:any) =>{
              localStorage.setItem('token',res)
            
        });
        //localStorage.setItem('token',"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.kGNaN8uYkQjvostoDz6gPO5nC1j_89eImltCG5pLX8U")
    }
}
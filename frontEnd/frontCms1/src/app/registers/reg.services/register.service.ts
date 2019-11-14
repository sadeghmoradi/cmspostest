import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { ApiAddress } from 'src/app/dataRefrence';
import { Token } from '../ModelRegister/Token';
import { Router} from '@angular/router'
import { from } from 'rxjs';

@Injectable() 

export class Authservice{

    constructor(private http:HttpClient ,private router : Router){}
    register(credentials){
        
        this.http.post(`https://localhost:44334/api/account`,credentials).subscribe((res:Token) =>{
              this.authenticate(res)
        });
       
    }
    Login(credentials){
        
        this.http.post(`https://localhost:44334/api/account/Login`,credentials).subscribe((res:Token) =>{
            this.authenticate(res)
        });
       
    }

    authenticate(res){
        localStorage.setItem('token',res.token)
        this.router.navigate(['/'])
    }
}
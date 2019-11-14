import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators} from '@angular/forms';
import { Authservice } from '../reg.services/register.service';


@Component({
  selector: 'app-Login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent  {
  
  form
  constructor( private auth:Authservice , private fb:FormBuilder  ) {
    this.form = fb.group({
      email:['',Validators.required],password:['',Validators.required]
    })


   }

}

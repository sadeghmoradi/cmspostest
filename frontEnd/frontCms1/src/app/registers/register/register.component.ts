import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators} from '@angular/forms';
import { Authservice } from '../reg.services/register.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent  {
  
  form
  constructor( private auth:Authservice , private fb:FormBuilder  ) {
    this.form = fb.group({
      email:['',Validators.required],password:['',Validators.required]
    })


   }

}

import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {MenuItem } from 'primeng/primeng';

@Component({
  selector: 'app-nav-clinic',
  templateUrl: './nav-clinic.component.html',
  styleUrls: ['./nav-clinic.component.scss']
})
export class NavClinicComponent implements OnInit {
  divaceClinic={};  
  @Output() public sidenavToggle = new EventEmitter();
  constructor() { }

  ngOnInit() {
    this.divaceClinic =[ {
     title :'خدمات',rute:""
    },
    {
      title :'پرونده پزشکی',rute:""
     }];
  }
  public onToggleSidenav = () => {
    this.sidenavToggle.emit();
  }
 

}

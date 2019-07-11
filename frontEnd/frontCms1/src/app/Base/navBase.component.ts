import { Component } from "@angular/core";

@Component({
selector:'navBase',
template:`
     <mat-toolbar style="writing-mode: vertical-lr;width:200px ;height: fit-content  ;margin: 10px 20px;background-color: hsla(195, 12%, 93%, 0.952);">
     <button mat-button  routerLink="../City">City</button>
     
     <button mat-button    routerLink="../LocationType">LocationType</button>
    
     </mat-toolbar>
    
  




    `
})

export class navBasecomponent{

}
import { Component } from "@angular/core";

@Component({
    selector:`navCms`,
    template:`
    <mat-toolbar style="background-color: rgba(78, 182, 223, 0.473)">
    <button mat-button routerLink="navbase" >Base</button>
    
    <button mat-button  >Order</button>
    <button mat-button  >Buy</button>
    <button mat-button  >Sale</button>
    
    </mat-toolbar>
    `
})

export class navCmscomponent{

}
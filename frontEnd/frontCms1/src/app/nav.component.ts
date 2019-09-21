import { Component } from "@angular/core";

@Component({
    selector : 'nav',
    template : `
    <mat-toolbar class="mat-elevation-z6" >
    <button mat-button routerLink="" >Home</button>
    <br>
    <button mat-button style="font-size:larger" routerLink="ClinicHome" >کلینیک</button>
    <br>
    <button mat-button routerLink="Cms" >Cms</button>
    
    </mat-toolbar>
    `
})
export class Navcomponent{

}
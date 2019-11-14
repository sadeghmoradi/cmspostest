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

    <span style="flex: 1 1 auto;"></span>
    <button mat-button routerLink="Register" >Register</button>
    <button mat-button routerLink="Login" >Login</button>
    
    </mat-toolbar>
    `
})
export class Navcomponent{

}
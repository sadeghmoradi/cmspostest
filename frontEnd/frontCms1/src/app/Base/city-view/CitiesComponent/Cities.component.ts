import { AfterViewInit, Component , ElementRef, OnInit ,ViewChild} from "@angular/core";
import {MatPaginator,MatTableDataSource} from '@angular/material';
import { MatSort } from "@angular/material/sort";
import { cityApiservice} from '../CityService/City.service';
import {PageEvent} from '@angular/material/paginator';
import { CityDataSource } from '../Citydatasource/city.datasource'
import {debounceTime, distinctUntilChanged,map, startWith, tap, delay} from 'rxjs/operators';
import {merge, fromEvent, observable} from "rxjs";
import { City } from '../CityModel/City';
import { from } from 'rxjs';
import { __values } from 'tslib';
import { onErrorResumeNextStatic } from 'rxjs/internal/operators/onErrorResumeNext';

@Component({
selector:'cities',
templateUrl:'./cities.Component.html'
})

export class Citiescomponent{
cities={};
displayedColumns: string[] = ['Code', 'Name'];
row;
//dataSource;

city :City;
dataSource : CityDataSource;
Cityqty:number ;
rr={}

 @ViewChild(MatPaginator,{static:true}) paginator :MatPaginator;
 @ViewChild(MatSort ,{static:true}) sort : MatSort ;


@ViewChild('input', { static: true }) input: ElementRef;
ttt:City[];
op:City;
gg={};
constructor(private cityapi:cityApiservice ){
  
}

ngOnInit(){
    //this.cityapi.GetCities().subscribe(res => {this.dataSource=res})
   // this.city = this.route.snapshot.data["City"];
   
    this.dataSource  = new CityDataSource(this.cityapi);
    this.dataSource.LoadCity( '', 'asc', 0, 5);
    // console.log("sssss");
    // console.log(this.dataSource.citycountt.source.pipe(res=> this.rr=res).subscribe((tt:City)=>tt));
    // console.log(this.rr );
    // console.log("sss");
    // this.dataSource.citycountt.source.pipe(city=> this.gg= city).subscribe(ww=> {console.log(this.ttt=ww)});
    // console.log("ddd");
    // this.dataSource.citycountt.source.subscribe(ww=> {this.ttt=ww});
    // console.log("sssss22");

     this.Cityqty = 20
    
    // var oo =this.ttt
    // console.log(this.gg);
    // this.dataSource.citycountt.source.subscribe(ww=> {console.log(this.op=ww[0])});
    // this.dataSource.citycountt.source.subscribe(ww=> this.op=ww[0]);
    //  console.log(this.op.cityCount)


    // this.dataSource.citycountt.source.subscribe(ww=> this.op=ww[0]);
    // this.Cityqty = this.op.cityCount;
    
}

ngAfterViewInit(){
    //this.sort.sortChange.subscribe(() => this.paginator.pageIndex = 0);
    fromEvent(this.input.nativeElement,'keyup')
    .pipe(
      debounceTime(250),
      distinctUntilChanged(),
      tap(() => {
          this.paginator.pageIndex = 0;
  
          this.loadcityPage();
      })
      ).subscribe();
  
      merge( this.paginator.page)
      .pipe(
          tap(() => this.loadcityPage())
      )
      .subscribe();
  
      
  }
  onSearch(){
    this.paginator.pageIndex = 0;
    
    this.loadcityPage();
     
  }
 
  loadcityPage() {
    this.dataSource.LoadCity(
        this.input.nativeElement.value,
        "",
        this.paginator.pageIndex,
        this.paginator.pageSize);
        this.dataSource.citycountt.source.subscribe(ww=> this.op=ww[0]);
       // console.log("shgdfs")
        //console.log(this.op.cityCount)
        //this.Cityqty = this.op.cityCount;
  }


}
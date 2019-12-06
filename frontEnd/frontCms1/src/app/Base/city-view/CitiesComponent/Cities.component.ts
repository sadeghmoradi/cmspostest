import { AfterViewInit, Component , ElementRef, OnInit ,ViewChild} from "@angular/core";
import {MatPaginator,MatTableDataSource} from '@angular/material';
import { MatSort } from "@angular/material/sort";
import { cityApiservice} from '../CityService/City.service';
import {PageEvent} from '@angular/material/paginator';
import { CityDataSource } from '../Citydatasource/city.datasource'
import {debounceTime, distinctUntilChanged,map, startWith, tap, delay} from 'rxjs/operators';
import {merge, fromEvent} from "rxjs";
import { City } from '../CityModel/City';
import { from } from 'rxjs';
import { __values } from 'tslib';


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

 @ViewChild(MatPaginator,{static:true}) paginator :MatPaginator;
 @ViewChild(MatSort ,{static:true}) sort : MatSort ;


@ViewChild('input', { static: true }) input: ElementRef;
ttt={}
constructor(private cityapi:cityApiservice ){

}

ngOnInit(){
    //this.cityapi.GetCities().subscribe(res => {this.dataSource=res})
  
    this.dataSource  = new CityDataSource(this.cityapi);
    this.dataSource.LoadCity( '', 'asc', 0, 5);

  
}

ngAfterViewInit(){
    //this.sort.sortChange.subscribe(() => this.paginator.pageIndex = 0);
    // fromEvent(this.input.nativeElement,'keyup')
    // .pipe(
    //   debounceTime(150),
    //   distinctUntilChanged(),
    //   tap(() => {
    //       this.paginator.pageIndex = 0;
  
    //       this.loadcityPage();
    //   })
    //   ).subscribe();
  
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
  }


}
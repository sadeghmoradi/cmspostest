import { AfterViewInit, Component , ElementRef, OnInit ,ViewChild} from "@angular/core";
import {MatPaginator, MatSort,MatTableDataSource} from '@angular/material';
import { cityApiservice} from './Base.apiservices/City.service';
import {PageEvent} from '@angular/material/paginator';
import { CityDataSource } from '../Base/Base.apiservices/datasource/city.datasource'
import {debounceTime, distinctUntilChanged, startWith, tap, delay} from 'rxjs/operators';
import {merge, fromEvent} from "rxjs";
import { City } from './model/City';
import { from } from 'rxjs';


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
@ViewChild(MatSort ,{static:true}) sort : MatSort;
@ViewChild('input', { static: true }) input: ElementRef;

constructor(private cityapi:cityApiservice ){

}

ngOnInit(){
    //this.cityapi.GetCities().subscribe(res => {this.dataSource=res})
  
    this.dataSource  = new CityDataSource(this.cityapi);
    this.dataSource.LoadCity( '', 'asc', 1, 5);
}

ngAfterViewInit(){
    //this.sort.sortChange.subscribe(() => this.paginator.pageIndex = 1);
    fromEvent(this.input.nativeElement,'keyup')
    .pipe(
      debounceTime(150),
      distinctUntilChanged(),
      tap(() => {
          this.paginator.pageIndex = 1;
  
          this.loadcityPage();
      })
      ).subscribe();
  
      merge( this.paginator.page)
      .pipe(
          tap(() => this.loadcityPage())
      )
      .subscribe();
  
  
  }
  
  
  loadcityPage() {
    this.dataSource.LoadCity(
        this.input.nativeElement.value,
        this.sort.direction,
        this.paginator.pageIndex,
        this.paginator.pageSize);
  }


}
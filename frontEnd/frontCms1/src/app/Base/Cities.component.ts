import { Component ,ViewChild} from "@angular/core";
import {MatPaginator, MatSort,MatTableDataSource} from '@angular/material';
import { cityApiservice} from './Base.apiservices/City.service';
import {PageEvent} from '@angular/material/paginator';
import { City } from './model/City';


@Component({
selector:'cities',
templateUrl:'./cities.Component.html'
})

export class Citiescomponent{
cities={};
displayedColumns: string[] = ['Code', 'Name'];

 @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
 @ViewChild(MatSort, { static: true }) sort: MatSort;
 row;
 dataSource;
 //dataSource:  MatTableDataSource<City>;


constructor(private cityapi:cityApiservice ){

}

ngOnInit(){
    
  
    this.cityapi.GetCities().subscribe(res => {this.dataSource=res})
   // this.cityapi.GetCities1().subscribe(res => {this.dataSource = res})
   // this.cityapi.GetCities1().subscribe(res => {console.log( res)})
}

 ngAfterViewInit() {
      // this.dataSource.paginator = this.paginator;
      // this.dataSource.sort = this.sort;
   }

  applyFilter(filterValue: string) {
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }
  
  rowclick(row){
console.log('row table',row);
  }

}
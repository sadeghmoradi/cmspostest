import { Component ,ViewChild} from "@angular/core";
import {MatPaginator, MatSort} from '@angular/material';
import { cityApiservice} from './Base.apiservices/City.service';
import {PageEvent} from '@angular/material/paginator';


@Component({
selector:'cities',
templateUrl:'./cities.Component.html'
})

export class Citiescomponent{
cities={};
displayedColumns: string[] = ['Code', 'Name'];

 @ViewChild(MatPaginator) paginator: MatPaginator;
 @ViewChild(MatSort) sort: MatSort;

 dataSource;

constructor(private cityapi:cityApiservice ){}

ngOnInit(){
    
    this.cityapi.GetCities().subscribe(res => {this.dataSource=res})
   
}

 ngAfterViewInit() {
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
   }

  applyFilter(filterValue: string) {
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }


}
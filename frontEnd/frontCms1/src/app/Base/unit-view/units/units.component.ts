import { AfterViewInit, Component , ElementRef, OnInit ,ViewChild } from '@angular/core';
import { unitapiservice} from '../UnitService/Unit.Api.Service';
import {MatPaginator,MatTableDataSource} from '@angular/material';
import { MatSort } from "@angular/material/sort";
import {debounceTime, distinctUntilChanged,map, startWith, tap, delay} from 'rxjs/operators';
import {merge, fromEvent, observable} from "rxjs";
import {Unit} from '../UnitModel/Unit';
import { UnitDataSource } from '../unit.dataSource/unit.datatSource'

@Component({
  selector: 'app-units',
  templateUrl: './units.component.html',
  styleUrls: ['./units.component.scss']
})
export class UnitsComponent implements OnInit {

  displayedColumns: string[] = ['Code', 'Name'];
  row;
  unit :Unit;
   dataSource : UnitDataSource;
  Unitqty:number ;
  @ViewChild(MatSort ,{static:true}) sort : MatSort ;
  @ViewChild(MatPaginator,{static:true}) paginator :MatPaginator;
  @ViewChild('input', { static: true }) input: ElementRef;

  ttt:Unit[];
  op:Unit;
  gg={};
  constructor( private unitApi:unitapiservice) { }

  ngOnInit() {
    this.dataSource  = new UnitDataSource(this.unitApi);
    this.dataSource.LoadUnit( '', 'asc', 0, 5);

    
     this.dataSource.Unitcountt.source.subscribe(ww=> this.op=ww[0]);
     this.Unitqty =  this.op==null?1:this.op.unitCount ;
  }

  
ngAfterViewInit(){
  //this.sort.sortChange.subscribe(() => this.paginator.pageIndex = 0);
  fromEvent(this.input.nativeElement,'keyup')
  .pipe(
    debounceTime(250),
    distinctUntilChanged(),
    tap(() => {
        this.paginator.pageIndex = 0;

        this.loadUnitPage();
    })
    ).subscribe();

    merge( this.paginator.page)
    .pipe(
        tap(() => this.loadUnitPage())
    )
    .subscribe();

    
}
onSearch(){
  this.paginator.pageIndex = 0;
  
  this.loadUnitPage();
   
}

loadUnitPage() {
  this.dataSource.LoadUnit(
      this.input.nativeElement.value,
      "",
      this.paginator.pageIndex,
      this.paginator.pageSize);
      this.dataSource.Unitcountt.source.subscribe(ww=> this.op=ww[0]);
     // console.log("shgdfs")
      //console.log(this.op.cityCount)
      this.Unitqty =  this.op.unitCount==null ?0:this.op.unitCount ;
}

}

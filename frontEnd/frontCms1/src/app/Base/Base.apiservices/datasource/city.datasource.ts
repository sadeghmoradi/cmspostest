import {CollectionViewer, DataSource} from "@angular/cdk/collections";
import {Observable, BehaviorSubject, of} from "rxjs";
import {cityApiservice} from "../City.service";
import {catchError, finalize} from "rxjs/operators";
import { City } from '../../model/City';


export class CityDataSource implements DataSource<City> {
    ss={};
    private citySubject = new BehaviorSubject<City[]>([]);
    private LoadingSubject = new BehaviorSubject<Boolean>(false);

    public Loding$  = this.LoadingSubject.asObservable();

    constructor(private cityapi:cityApiservice ){
        }

        LoadCity(filter:string,
            sort:string,
            pageindex:number,
            pagesize: number) {
                this.LoadingSubject.next(true);
// console.log("ssssss");

// this.cityapi.findCities(
//     filter,sort,pageindex,pagesize)
// .subscribe(s => this.ss=s);
// console.log( this.ss);
// console.log("ss");
                this.cityapi.findCities(
                    filter,sort,pageindex,pagesize
                ).pipe(
                    catchError(()=> of([])),
                    finalize(()=> this.LoadingSubject.next(false))
                )
                .subscribe(Citys => this.citySubject.next(Citys));
                
        }
 
        connect(collectionViewer :CollectionViewer  ) : Observable<City[]>{
            console.log("Connecting data source");
            return this.citySubject.asObservable();
        }

        disconnect(collectionViewer : CollectionViewer): void{
            this.citySubject.complete();
            this.LoadingSubject.complete();
        }
        
}
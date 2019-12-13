import {CollectionViewer, DataSource} from "@angular/cdk/collections";
import {Observable, BehaviorSubject, of, Subscriber} from "rxjs";
import {cityApiservice} from "../CityService/City.service";
import {catchError, finalize} from "rxjs/operators";
import { City } from '../CityModel/City';
import { Subject } from 'rxjs';


export class CityDataSource implements DataSource<City> {

    private citySubject = new BehaviorSubject<City[]>([]);
    private LoadingSubject = new BehaviorSubject<Boolean>(false);

    public Loding$  = this.LoadingSubject.asObservable();


    
    public citycountt = this.citySubject.asObservable();

    constructor(private cityapi:cityApiservice ){
        }

        LoadCity(filter:string,
            sort:string,
            pageindex:number,
            pagesize: number) {
                this.LoadingSubject.next(true);

                this.cityapi.findCities(
                    filter,sort,pageindex,pagesize
                )
                .pipe(
                    catchError(()=> of([])),
                    finalize(()=> this.LoadingSubject.next(false))
                )
                .subscribe((Citys:City[]) => this.citySubject.next(Citys) );
               
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
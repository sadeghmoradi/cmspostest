import {CollectionViewer, DataSource} from "@angular/cdk/collections";
import {Observable, BehaviorSubject, of, Subscriber} from "rxjs";
import {unitapiservice} from "../UnitService/Unit.Api.Service";
import {catchError, finalize} from "rxjs/operators";
import { Unit } from '../UnitModel/Unit';
import { Subject } from 'rxjs';


export class UnitDataSource implements DataSource<Unit> {

    private unitSubject = new BehaviorSubject<Unit[]>([]);
    private LoadingSubject = new BehaviorSubject<Boolean>(false);

    public Loding$  = this.LoadingSubject.asObservable();


    
    public Unitcountt = this.unitSubject.asObservable();

    constructor(private unitapi:unitapiservice ){
        }

        LoadUnit(filter:string,
            sort:string,
            pageindex:number,
            pagesize: number) {
                this.LoadingSubject.next(true);

                this.unitapi.findunit(
                    filter,sort,pageindex,pagesize
                )
                .pipe(
                    catchError(()=> of([])),
                    finalize(()=> this.LoadingSubject.next(false))
                )
                .subscribe((Units:Unit[]) => this.unitSubject.next(Units) );
               
        }
 
        connect(collectionViewer :CollectionViewer  ) : Observable<Unit[]>{
            console.log("Connecting data source");
            return this.unitSubject.asObservable();
        }

        disconnect(collectionViewer : CollectionViewer): void{
            this.unitSubject.complete();
            this.LoadingSubject.complete();
        }
        
}
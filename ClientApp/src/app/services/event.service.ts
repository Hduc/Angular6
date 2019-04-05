import { Injectable, Inject } from '@angular/core';
// import 'rxjs/add/operator/toPromise';
import { HttpClient, HttpParams } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../http-error-handler.service';

import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
// Ngan_06-09-2018: Load Data EnqueteSociete
export class EventService {
    private handleError: HandleError;
    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string,
        httpErrorHandler: HttpErrorHandler) {
        this.handleError = httpErrorHandler.createHandleError('EventService');
    }
    /* GET Load data EnqueteSociete in page event */
    LoadData_Event(idUser: string, societe: string): Observable<ObjectResult_EnqueteSociete> {
        var url = 'api/event/listevent';
        return this.http.get<ObjectResult_EnqueteSociete>(url, { params: { idUser: idUser, societe: societe }})
            .pipe(
                catchError(this.handleError<ObjectResult_EnqueteSociete>('LoadData_Event'))
            );
    }
    /* GET Load data combobox history event */
    LoadEvent_CbbHistory(idUser: string, societe: string): Observable<ObjectResult_EnqueteSociete> {
        var url = 'api/event/list-history';
        return this.http.get<ObjectResult_EnqueteSociete>(url, { params: { idUser: idUser, societe: societe } })
            .pipe(
                catchError(this.handleError<ObjectResult_EnqueteSociete>('LoadEvent_CbbHistory'))
            );
    }
    /* GET Load data event with count => login hduc */
    LoadEventWithCount(count: number): Observable<ObjectResult_EnqueteSociete> {
        var url = this.baseUrl + 'api/event/eventwithcount';
        const options = count.toString() ? { params: new HttpParams().set('count', count.toString()) } : {};
        return this.http.get<ObjectResult_EnqueteSociete>(url, options)
            .pipe(
                catchError(this.handleError<ObjectResult_EnqueteSociete>('LoadEventWithCount'))
            );
    }
    /* GET Load data company by ID*/
    LoadSociete_byID(id: string): Observable<ObjectResult_Intermediation> {
        var url = 'api/event/geteventbyid';
        const options = id.toString() ? { params: new HttpParams().set('idIntermediation', id.toString()) } : {};
        return this.http.get<ObjectResult_Intermediation>(url, options)
            .pipe(
                catchError(this.handleError<ObjectResult_Intermediation>('LoadSociete_byID'))
            );
    }

}

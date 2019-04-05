import { Injectable, Inject } from '@angular/core';
// import 'rxjs/add/operator/toPromise';
import { HttpClient, HttpParams } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../http-error-handler.service';

import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class QuestionService {
    private handleError: HandleError;
    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string,
        httpErrorHandler: HttpErrorHandler) {
        this.handleError = httpErrorHandler.createHandleError('EventService');
    }
    /* Get all company questions by event*/
    QuestionBySociete(idEnqueteSociete: string): Observable<ObjectResult_QuestionSociete> {
        var url = 'api/question/questionbysociete';
        return this.http.get<ObjectResult_QuestionSociete>(url, { params: { IDEnqueteSociete: idEnqueteSociete } })
            .pipe(
                catchError(this.handleError<ObjectResult_QuestionSociete>('questionbysociete'))
            );
    }
    // Add or update the company's response according to the event
    Response(idEnqueteSociete: string, idQuestion: string, question: string, idTypeStockageQuestion: string): Observable<ObjectResult_QuestionSociete> {
        var url = 'api/question/reponse';
        var formData = new FormData();
        formData.append('idEnqueteSociete', idEnqueteSociete);
        formData.append('idQuestion', idQuestion);
        formData.append('typeStockage', idTypeStockageQuestion);
        formData.append('question', question);
        return this.http.post<ObjectResult_QuestionSociete>(url, formData)
            .pipe(
                catchError(this.handleError<ObjectResult_QuestionSociete>('reponse'))
            );
    }

}

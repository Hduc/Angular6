import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../http-error-handler.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
//  Load Data participants
export class ContactService {
    private handleError: HandleError;
    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string,
        httpErrorHandler: HttpErrorHandler) {
        this.handleError = httpErrorHandler.createHandleError('ContactService');
    }
    /* GET Load data participants  */
    LoadData_Contact(idSociete: string): Observable<ObjectResult_Contact[]> {
        var url = 'api/participants/listcontact';
        const options = idSociete.toString() ? { params: new HttpParams().set('idSociete', idSociete.toString()) } : {};
        const params = new HttpParams()
        return this.http.get<ObjectResult_Contact[]>(url, options)
            .pipe(
                catchError(this.handleError<ObjectResult_Contact[]>('LoadData_Contact'))
            );
    }
    Insert_Contact(objContact: Obj_Contact): Observable<ObjectResult_Contact> {
        var url = this.baseUrl + 'api/participants/insertcontact';
        return this.http.post<ObjectResult_Contact>(url, objContact)
            .pipe(
                catchError(this.handleError<ObjectResult_Contact>('Insert_Contact'))
            );
    }
    Insert_Img_Contact(file:FileList, idContact: string) {
        debugger;
        var url = this.baseUrl + 'api/participants/insertImgContact';
        const formData = new FormData();
        formData.append("file", file[0]);
        formData.append("idContact", idContact);
        return this.http.post<string>(url, formData);
    }
    Update_Contact(objContact: Obj_Contact): Observable<ObjectResult_Contact> {
        var url = this.baseUrl + 'api/participants/updatecontact';
        return this.http.post<ObjectResult_Contact>(url, objContact)
            .pipe(
                catchError(this.handleError<ObjectResult_Contact>('Insert_Contact'))
            );
    }
    Delete_Contact1(idContact: string): Observable<ObjectResult_Contact> {
        var url = this.baseUrl + 'api/participants/deletedcontact';
        return this.http.post<ObjectResult_Contact>(url, idContact)
            .pipe(
                catchError(this.handleError<ObjectResult_Contact>('Delete_Contact'))
            );
    }
    Delete_Contact(idContact: string): Observable<ObjectResult_Contact> {
        var url = this.baseUrl + 'api/participants/deletedcontact';
        var formData = new FormData();
        formData.append('idContact', idContact.toString());

        return this.http.post<ObjectResult_Contact>(url, formData)
            .pipe(
                catchError(this.handleError<ObjectResult_Contact>('deleteorderchosen'))
            );
    }
    GetByUserName(idContact: string): Observable<ObjectResult_Liste_Utilisateur> {
        var url = this.baseUrl + 'api/participants/loaduserbyid';
        return this.http.get<ObjectResult_Liste_Utilisateur>(url, { params: { idContact: idContact } })
            .pipe(
                catchError(this.handleError<ObjectResult_Liste_Utilisateur>('GetByUserName'))
            );
    }
    /* Ngan-4-10-2018 GET Seach user by username */
    SearchUser(username: string, idSociete: string, idListeService: string): Observable<Object_Contact> {
        var url = this.baseUrl + 'api/participants/searchuserbyname';
        const options = (username.toString() != "" && idSociete != "") ? {
            params: new HttpParams()
                .set('prenom', username.toString())
                .set('idSociete', idSociete.toString())
                .set('idListeService', idListeService.toString())
        } : {};

        return this.http.get<Object_Contact>(url, options)
            .pipe(
                catchError(this.handleError<Object_Contact>('SearchUser'))
            );
    }
    /*  GET Load all user of Societe */
    LoadUserOfSociete(idSociete: string,idListeService:string): Observable<Result_Obj_Contact> {
        var url = this.baseUrl + 'api/participants/loaduserofsociete';
        const options = (idSociete.toString() != "" && idSociete != "") ? {
            params: new HttpParams()
                .set('idSociete', idSociete.toString())
                .set('idListeService', idListeService.toString())
        } : {};
        return this.http.get<Result_Obj_Contact>(url, options)
            .pipe(
                catchError(this.handleError<Result_Obj_Contact>('LoadUserOfSociete'))
            );
    }
    /*  GET Load all Fonction générique */
    LoadData_FamilleFonction(): Observable<Object_ListeFonction> {
        var url = this.baseUrl + 'api/participants/loadfamillefonction';
        return this.http.get<Object_ListeFonction>(url)
            .pipe(
                catchError(this.handleError<Object_ListeFonction>('LoadData_FamilleFonction'))
            );
    }
    /*  GET Load all Fonction générique */
    LoadData_FonctionGenerique(idTypeFonction: string): Observable<Object_ListeFonction> {
        var url = this.baseUrl + 'api/participants/loadfonctiongenerique';
        const options = (idTypeFonction.toString() != "" && idTypeFonction != "") ? {
            params: new HttpParams()
                .set('idTypeFonction', idTypeFonction.toString())
        } : {};
        return this.http.get<Object_ListeFonction>(url, options)
            .pipe(
                catchError(this.handleError<Object_ListeFonction>('LoadData_FonctionGenerique'))
            );
    }
    loadfonctiongenerique
}

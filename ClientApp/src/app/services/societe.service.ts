import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../http-error-handler.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
// Hduc_18-09-2018: Load Data Societe
export class SocieteService {
    private handleError: HandleError;
    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string,
        httpErrorHandler: HttpErrorHandler) {
        this.handleError = httpErrorHandler.createHandleError('SocieteService');
    }
    /* GET Load data LoadData_Societe  */
    LoadData_Societe(ID: string): Observable<obj_Societe> {
        var url = 'api/societe';
        return this.http.get<obj_Societe>(url, { params: { ID: ID}})
            .pipe(
                catchError(this.handleError<obj_Societe>('societe'))
            );
    }
    /* GET load logo in societe */
    LoadLogo(ID: string): Observable<Logo_Societe> {
        var url = 'api/societe/logo';
        return this.http.get<Logo_Societe>(url, { params: { ID: ID}})
            .pipe(
                catchError(this.handleError<Logo_Societe>('LoadLogo'))
            );
    }
    /*Ngan-21-09-2018 GET export file excel */
    ExportExcel(exportname: string): Observable<string> {
        var url = 'api/speedmeeting/export';
        return this.http.get<string>(url,  { params: { name: exportname }})
            .pipe(
                catchError(this.handleError<string>('ExportExcel'))
            );
    }

    ExportExcel1(exportname: string): Observable<any> {
        var url = 'api/speedmeeting/export-excel';
        return this.http.get<string>(url,  { params: { name: exportname }})
            .pipe(
                catchError(this.handleError<string>('ExportExcel1'))
            );
    }

    /* Ngan-4-10-2018 GET Seach user by username */
    SearchUser(username: string, idSociete: string): Observable<ObjectResult_LU> {
        var url = this.baseUrl + 'api/societe/searchuserbyname';
        const options = (username.toString() != "" && idSociete != "") ? {
            params: new HttpParams()
                .set('username', username.toString())
                .set('idSociete', idSociete.toString())
        } : {};

        return this.http.get<ObjectResult_LU>(url, options)
            .pipe(
                catchError(this.handleError<ObjectResult_LU>('SearchUser'))
            );
    }
    /* Ngan-5-10-2018 GET Load all user of Societe */
    LoadUserOfSociete(idSociete: string): Observable<ObjectResult_Liste_Utilisateur> {
        var url = this.baseUrl + 'api/societe/loaduserofsociete';
        const options = (idSociete.toString() != "" && idSociete != "") ? {
            params: new HttpParams()
                .set('idSociete', idSociete.toString())
        } : {};
        return this.http.get<ObjectResult_Liste_Utilisateur>(url, options)
            .pipe(
                catchError(this.handleError<ObjectResult_Liste_Utilisateur>('LoadUserOfSociete'))
            );
    }
    SpeedMeeting(idIntermediation: string, idUser: string, nomSociete: string): Observable<ObjectResult_Speed_Meeting> {
        var url = this.baseUrl + 'api/speedmeeting/getspeedmeeting';
        return this.http.get<ObjectResult_Speed_Meeting>(url, { params: { idIntermediation: idIntermediation, idUser: idUser, nomSociete: nomSociete } })
            .pipe(
                catchError(this.handleError<ObjectResult_Speed_Meeting>('getspeedmeeting'))
            );
    }

    SpeedMeetingChose(idEnquete: string, idEnqueteSociete: string): Observable<ObjectResult_Chose> {
        var url = this.baseUrl + 'api/speedmeeting/insertorderchosen';
        var formData = new FormData();
        formData.append('idEnquete', idEnquete.toString());
        formData.append('idEnqueteSociete', idEnqueteSociete.toString());

        return this.http.post<ObjectResult_Chose>(url, formData)
            .pipe(
                catchError(this.handleError<ObjectResult_Chose>('insertorderchosen'))
            );
    }
    SpeedMeetingDelete(arrIDEnqueteSociete: string, idEnquete: string): Observable<ObjectResult_Chose> {
        var url = this.baseUrl + 'api/speedmeeting/deleteorderchosen';
        var formData = new FormData();
        formData.append('arrIDEnqueteSociete', arrIDEnqueteSociete.toString());
        formData.append('idEnquete', idEnquete.toString());

        return this.http.post<ObjectResult_Chose>(url, formData)
            .pipe(
                catchError(this.handleError<ObjectResult_Chose>('deleteorderchosen'))
            );
    }
    SpeedMeetingDetail(idIntermediation: string, idUser: string, nomSociete: string): Observable<ObjectResult_Speed_Meeting> {
        var url = this.baseUrl + 'api/speedmeeting/getorderchosen';
        return this.http.get<ObjectResult_Speed_Meeting>(url, { params: { idIntermediation: idIntermediation, idUser: idUser, nomSociete: nomSociete } })
            .pipe(
                catchError(this.handleError<ObjectResult_Speed_Meeting>('getorderchosen'))
            );

    }
    Updateorderchose(idEnquete: string, stringEnqueteSociete: string): Observable<ObjectResult_Chose> {
        var url = this.baseUrl + 'api/speedmeeting/updateorderchose';
        var formData = new FormData();
        formData.append('idEnquete', idEnquete);
        formData.append('strIdEnqueteSociete', stringEnqueteSociete);
        return this.http.post<ObjectResult_Chose>(url, formData)
            .pipe(
                catchError(this.handleError<ObjectResult_Chose>('updateorderchose'))
            );
    }
    SocieteLogin(Idintermediation: string): Observable<boolean> {
        var url = this.baseUrl + 'api/event/listsocieteinevent';
        return this.http.get<boolean>(url, { params: { Idintermediation: Idintermediation } })
            .pipe(
                catchError(this.handleError<boolean>('listsocieteinevent'))
            );
    }
    UpdateSociete(societe: Societe): Observable<obj_update_Societe> {
        console.log("server:"+societe);
        var url = this.baseUrl + 'api/societe/updatesociete';
        return this.http.post<obj_update_Societe>(url, societe)
            .pipe(
                catchError(this.handleError<obj_update_Societe>('updatesociete'))
            );
    }
    Liste_Pays(): Observable<ObjectResult_Liste_Pays> {
        var url = this.baseUrl + 'api/societe/listepays';
        return this.http.get<ObjectResult_Liste_Pays>(url)
            .pipe(
                catchError(this.handleError<ObjectResult_Liste_Pays>('listepays'))
            );
    }
    TypeEffectif(): Observable<ObjectResult_TypeEffectif> {
        var url = this.baseUrl + 'api/societe/typeeffectif';
        return this.http.get<ObjectResult_TypeEffectif>(url)
            .pipe(
                catchError(this.handleError<ObjectResult_TypeEffectif>('typeeffectif'))
            );
    }
    CodeApe2008(): Observable<ObjectResult_CodeApe2008> {
        var url = this.baseUrl + 'api/societe/codeape2008';
        return this.http.get<ObjectResult_CodeApe2008>(url)
            .pipe(
                catchError(this.handleError<ObjectResult_CodeApe2008>('codeape2008'))
            );
    }
    TypeNature(): Observable<ObjectResult_TypeNature> {
        var url = this.baseUrl + 'api/societe/typenature';
        return this.http.get<ObjectResult_TypeNature>(url)
            .pipe(
                catchError(this.handleError<ObjectResult_TypeNature>('typenature'))
            );
    }
    FormeJuridique(): Observable<ObjectResult_FormeJuridique> {
        var url = this.baseUrl + 'api/societe/formeJuridique';
        return this.http.get<ObjectResult_FormeJuridique>(url)
            .pipe(
                catchError(this.handleError<ObjectResult_FormeJuridique>('formeJuridique'))
            );
    }
    Type_CA(): Observable<ObjectResult_TypeCA> {
        var url = this.baseUrl + 'api/societe/typeCA';
        return this.http.get<ObjectResult_TypeCA>(url)
            .pipe(
                catchError(this.handleError<ObjectResult_TypeCA>('typeCA'))
            );
    }

}

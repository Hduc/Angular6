import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { catchError, map } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../http-error-handler.service';

import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
// hoàng đức 7/9/18 Login PremiumContact
export class LoginService {

  private handleError: HandleError;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    httpErrorHandler: HttpErrorHandler) {
    this.handleError = httpErrorHandler.createHandleError('EventService');
  }
  /* GET Load data Liste_Utilisateur in login*/
  Login(id: string, pass: string): Observable<Liste_Utilisateur[]> {
    var url = this.baseUrl + 'api/login';
    return this.http.get<Liste_Utilisateur[]>(url, { params: {  id:id, pass:pass}})
      .pipe(
      catchError(this.handleError<Liste_Utilisateur[]>('login', []))
    );
  }
  /* Get check ID is database */
  CheckID(id: string): Observable<boolean> {
    var url = this.baseUrl + 'api/login/checkusername';
    return this.http.get<boolean>(url, { params: {  id:id}})
      .pipe(
      catchError(this.handleError<boolean>('checkusername',false)
    )
    );
  }

  /* Get check email is database */
  CheckEmail(email: string): Observable<boolean> {
    var url = this.baseUrl + 'api/login/checkemail';
    return this.http.get<boolean>(url, { params: {  email:email}})
      .pipe(
      catchError(this.handleError<boolean>('checkemail',))
    );
  }
  /* Post send email with id */
  SendEmail(email: string): Observable<boolean> {
    var url = this.baseUrl + 'api/login/sendemailwithid';
    return this.http.post<boolean>(url, email)
      .pipe(
      catchError(this.handleError<boolean>('sendemailwithid',))
    );
  }
   /* Post send email with id */
   SendEmailNotID(email: string): Observable<boolean> {
    var url = this.baseUrl + 'api/login/sendemailnotid';
    return this.http.post<boolean>(url, email)
      .pipe(
      catchError(this.handleError<boolean>('sendemailnotid',))
    );
  }
  // get data user by username
  // GetByUserName(id: string): Observable<ObjectResult_Liste_Utilisateur> {
  //   var url = this.baseUrl + 'api/login/loaduserbyid';
  //   return this.http.get<ObjectResult_Liste_Utilisateur>(url, { params: {  id:id}})
  //     .pipe(
  //     catchError(this.handleError<ObjectResult_Liste_Utilisateur>('GetByUserName'))
  //   );
  // }
   /* GET Load data  User in event*/
   LoadUser_InEvent(id: string): Observable<ObjectResult_Liste_Utilisateur[]> {
    var url = this.baseUrl + 'api/login/listuser';
    return this.http.get<ObjectResult_Liste_Utilisateur[]>(url, { params: {id:id}})
      .pipe(
      catchError(this.handleError<ObjectResult_Liste_Utilisateur[]>('LoadUser_InEvent', []))
    );
  }
}

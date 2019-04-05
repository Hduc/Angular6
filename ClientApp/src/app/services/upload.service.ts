import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
    providedIn: 'root'
})
//  Upload file
export class UploadService {
    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string) {
    }
    ImageSociete(file:FileList, idSociete: string) {
        debugger;
        console.log(file);
        var url = this.baseUrl + 'api/upload/imagesociete';
        const formData = new FormData();
        formData.append("file", file[0]);
         //formData.append(file.name, file);
        formData.append("idSociete", idSociete);
        return this.http.post<string>(url, formData);
    }

    // ImagesSociete(files:FileList, idSociete: string) {
    //     debugger;
    //     var url = this.baseUrl + 'api/upload/imagesociete';
       
    //     const formData = new FormData();
    //     for (let file of files) formData.append(file.name, file);

    //     formData.append(idSociete, idSociete);
    //     return this.http.post(url, formData);
    // }

}

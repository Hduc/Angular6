import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
@Component({
    selector: 'app-info',
    templateUrl: './info.component.html',
    styleUrls: ['./info.component.css']
})
export class InfoComponent implements OnInit {
    @Input() nomSociete: string;
    @Input() idIntermediation: string;
    idsociete = sessionStorage.idsociete;
    constructor(private router: Router) { }
    ngOnInit() {  
    }
    Loadinfo() {
        this.router.navigateByUrl('VosInformationComponent', { skipLocationChange: true }).then(() =>
            this.router.navigate(['/information/'+this.idIntermediation]));
    }
    lockout() {
        if (this.idsociete == undefined) {
            sessionStorage.clear();
            this.router.navigate(['/login']);
        }
        else {
            sessionStorage.removeItem("idsociete");
            this.router.navigate(['/admin-account/' + this.idIntermediation]);
        }

    }
}

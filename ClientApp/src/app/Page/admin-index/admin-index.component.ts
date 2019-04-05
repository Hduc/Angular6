import { Component, OnInit } from '@angular/core';
import { EventService } from '../../services/event.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-admin-index',
    templateUrl: './admin-index.component.html',
    styleUrls: ['./admin-index.component.css']
})
export class AdminIndexComponent implements OnInit {
    notdata = false;
    EnqueteSociete: EnqueteSociete[];
    objResult: ObjectResult_EnqueteSociete;
    eventHistory = sessionStorage.history;
    idUser = location.pathname.split('/')[2];
    societe = sessionStorage.id;
    constructor(
        private eventService: EventService,
        private router: Router) { }
    ngOnInit() {
        if (this.eventHistory == undefined || this.eventHistory == null) sessionStorage.setItem("history", "false");

        this.LoadData_Event();
    }

    LoadData_Event(): void {
        // get idSociete in url
        if (this.idUser == null) {
            this.router.navigate(['/notfound']);
        } else {
            //eventHistory == true ? show list event history : show list event

            if (this.eventHistory == "true") {
                this.eventService.LoadEvent_CbbHistory(this.idUser, this.societe)
                    .subscribe(result => {
                        const value = JSON.stringify(result);
                        this.objResult = JSON.parse(value);
                        this.EnqueteSociete = this.objResult.result;
                        if (this.objResult.result == null) {
                            this.notdata = true;
                            return;
                        }
                    });
            } else {
                this.eventService.LoadData_Event(this.idUser, this.societe)
                    .subscribe(result => {
                        const value = JSON.stringify(result);
                        this.objResult = JSON.parse(value);
                        this.EnqueteSociete = this.objResult.result;
                        if (this.objResult.result == null) {
                            this.notdata = true;
                            return;
                        }
                    });
            }
        }
    }
    eventClick(id: number, idListeService: number): void {
        sessionStorage.setItem("idListeService", idListeService.toString() );
        this.router.navigateByUrl('InfoComponent', { skipLocationChange: true }).then(() =>
        this.router.navigate(['/admin-account/' + id]));
      }
    chage() {
        sessionStorage.setItem("history", "false");
        this.router.navigateByUrl('AdminIndexComponent', { skipLocationChange: true }).then(() =>
            this.router.navigate([location.pathname]));
    }

}

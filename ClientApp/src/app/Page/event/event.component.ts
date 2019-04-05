import { Component, OnInit, Inject } from '@angular/core';
import { EventService } from '../../services/event.service';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import * as $ from 'jquery';
import { Action } from 'rxjs/internal/scheduler/Action';
@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {
  notdata = false;
  data: EnqueteSociete[];
  objResult: ObjectResult_EnqueteSociete;
  idUser = location.pathname.split('/')[2];
  societe = sessionStorage.id;
  eventHistory =sessionStorage.history;
  constructor(
    private eventService: EventService,
    private router: Router,
    private route: ActivatedRoute) { }
  ngOnInit() {
    this.LoadData_Event();
  }
  LoadData_Event(): void {
    if (this.idUser ==null) {
      this.router.navigate(['/notfound']);
    } else {
      //eventHistory == true ? show list event history : show list event
      if(this.eventHistory==undefined || this.eventHistory==null) this.eventHistory=false;
      
      if (this.eventHistory == "true") {
        this.eventService.LoadEvent_CbbHistory(this.idUser,this.societe)
          .subscribe(result => {
            const value = JSON.stringify(result);
            this.objResult = JSON.parse(value);
            this.data = this.objResult.result;
            if (this.objResult.result == null) {
              this.notdata = true;
              return;
            }
          });
      } else {
        this.eventService.LoadData_Event(this.idUser,this.societe)
          .subscribe(result => {
            const value = JSON.stringify(result);
            this.objResult = JSON.parse(value);
            this.data = this.objResult.result;
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
    this.router.navigate(['/event-detail/' + id]));
  }
  chage(){
    sessionStorage.setItem("history","false");
    this.router.navigateByUrl('EventComponent', { skipLocationChange: true }).then(() =>
    this.router.navigate([location.pathname]));
  }

}

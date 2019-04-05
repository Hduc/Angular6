import { Component, OnInit, Inject, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { HttpClient } from '@angular/common/http';
// import { Intermediation } from '../../Models/Intermediation';
@Component({
  selector: 'app-detail-event',
  templateUrl: './detail-event.component.html',
  styleUrls: ['./detail-event.component.css']
})
export class DetailEventComponent implements OnInit {
  id = sessionStorage.id;
  // Intermediation: Intermediation =null;
  idIntermediation = location.pathname.split('/')[2];
  
  SiteWebIntermediation = "" ; 
  DateIntermediation :Date;
  ObjectResult_Intermediation : ObjectResult_Intermediation;
  constructor(
    private eventService: EventService,
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
    @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    // alert(this.Intermediation.SiteWebIntermediation)
    this.LoadSociete_byID();
    sessionStorage.setItem("idIntermediation", this.idIntermediation.toString());
  }

  // LoadSociete_byID(): void {
  //   if (this.idIntermediation != "" || this.idIntermediation != undefined) {
  //     this.eventService.LoadSociete_byID(this.idIntermediation)
  //       .subscribe(result => {
  //         if (result.Idintermediation > 0 || result != undefined) {
  //           this.SiteWebIntermediation = "http://" + result.SiteWebIntermediation + "/imgs/logo.png";
  //           this.DateIntermediation =result.DateIntermediation;
  //         }
  //       });
  //   } else {
  //     this.router.navigate(['/notfound']);
  //   }
  // }
  LoadSociete_byID(): void {
    if (this.idIntermediation != "" || this.idIntermediation != undefined) {
      this.eventService.LoadSociete_byID(this.idIntermediation)
      .subscribe(result => {
        var value = JSON.stringify(result);
        var ObjectResult_Intermediation = JSON.parse(value);
        if (ObjectResult_Intermediation.result.idintermediation > 0 || ObjectResult_Intermediation.result != undefined) {
          var img =  (ObjectResult_Intermediation.result.siteWebIntermediation).indexOf("www.") != -1 ?  ObjectResult_Intermediation.result.siteWebIntermediation : 'www.' + ObjectResult_Intermediation.result.siteWebIntermediation;
            this.SiteWebIntermediation = "http://" + img + "/imgs/logo.png";
          // this.SiteWebIntermediation = "http://" + ObjectResult_Intermediation.result.siteWebIntermediation + "/imgs/logo.png";
          this.DateIntermediation =ObjectResult_Intermediation.result.dateIntermediation;
        }
      });
    } else {
      this.router.navigate(['/notfound']);
    }
  }
}


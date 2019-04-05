import { Component, OnInit, Inject } from '@angular/core';
import { EventService } from '../../services/event.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu-item',
  templateUrl: './menu-item.component.html',
  styleUrls: ['./menu-item.component.css']
})
export class MenuItemComponent implements OnInit {
  public isCollapsed_menuAdmin = true;
  public isCollapsed_menuClient = false;
  colorIcon="cornflowerblue";
  isAdmin = false;
  id = sessionStorage.id;
  idIntermediation: string;
  Page = location.pathname.split('/')[1];
  SiteWebIntermediation = "";
  DateIntermediation: Date;
  ObjectResult_Intermediation: ObjectResult_Intermediation;
  indexAdmin = false;
  constructor(
    private eventService: EventService,
    private router: Router,
    @Inject('BASE_URL') private baseUrl: string) { }
  ngOnInit() {

    if (this.id.toString() == "23") {
      this.isAdmin = true;
    }
    if (this.Page == "admin-account" ||this.Page == "event-detail") {
      sessionStorage.setItem("idIntermediation", location.pathname.split('/')[2]);
    }
    if(this.Page!="admin"){
      this.LoadSociete_byID();
    }
  }

  Goback() {
    if (this.isAdmin) {
      sessionStorage.removeItem("idsociete");
      this.router.navigateByUrl('BannerComponent', { skipLocationChange: true }).then(() =>
        this.router.navigate(['/admin-account/' + this.idIntermediation]));
    }
    else {
        this.router.navigate(['/event-detail/' + this.idIntermediation]);
    }
  }
  LoadSociete_byID(): void {
    this.idIntermediation = sessionStorage.idIntermediation;
    if (this.idIntermediation != "" || this.idIntermediation != undefined) {
      this.eventService.LoadSociete_byID(this.idIntermediation)
        .subscribe(result => {
          var value = JSON.stringify(result);
          var ObjectResult_Intermediation = JSON.parse(value);
          if (ObjectResult_Intermediation.result.idintermediation > 0 || ObjectResult_Intermediation.result != undefined) {
            var img = (ObjectResult_Intermediation.result.siteWebIntermediation).indexOf("www.") != -1 ? ObjectResult_Intermediation.result.siteWebIntermediation : 'www.' + ObjectResult_Intermediation.result.siteWebIntermediation;
            this.SiteWebIntermediation = "http://" + img + "/imgs/logo.png";
            this.DateIntermediation = ObjectResult_Intermediation.result.dateIntermediation;
          }
        });
    } else {
      this.router.navigate(['/notfound']);
    }
  }
}

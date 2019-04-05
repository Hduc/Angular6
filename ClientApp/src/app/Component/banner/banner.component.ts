import { Component, OnInit } from '@angular/core';
import { SocieteService } from '../../services/societe.service';
@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.css']
})
export class BannerComponent implements OnInit {
  nomSociete: string;
  // fonctionsociete: string;
  id = sessionStorage.getItem("id");
  idsociete = sessionStorage.getItem("idsociete");

  obj_societe: obj_Societe;
  logo: Logo_Societe;
  urlLogo: string;
  constructor(private societeserve: SocieteService) {
  }
  ngOnInit() {
    if (this.id != null) {
      if (this.idsociete == undefined) {
        this.LoadLogo(this.id);
        this.LoadSociete(this.id);
      }
      else {
        this.LoadLogo(this.idsociete);
        this.LoadSociete(this.idsociete);
      }
    }
  }
  LoadLogo(idSociete: string) {
    this.societeserve.LoadLogo(idSociete).subscribe(res => {
      const values = JSON.stringify(res);
      // string to obj
      this.logo = JSON.parse(values);
      this.urlLogo = this.logo.UrlLogo;
    });
    if (this.urlLogo == null || this.urlLogo == "") this.urlLogo = '/assets/img_avatar.png';
  }

  LoadSociete(societe: string) {
    this.societeserve.LoadData_Societe(societe).subscribe(results => {
      if (results != null) {
        const values = JSON.stringify(results);
        // string to obj
        this.obj_societe = JSON.parse(values);
        this.nomSociete = this.obj_societe.result.nomSociete;
      } else console.log("undefined nomsociete");
    });
  }
}

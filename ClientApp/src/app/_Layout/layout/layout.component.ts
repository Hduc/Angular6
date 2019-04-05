import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {
  id = sessionStorage.id;
  idsociete = sessionStorage.idsociete;
  idIntermediation = sessionStorage.idIntermediation;
  idUserBack = sessionStorage.idUserBack;
  IdUser=sessionStorage.Utilisateur;
  isAdmin = false;
  isSociete = false;
  constructor(private router: Router) { }

  ngOnInit() {
    if (this.id == null || this.id == "") {
      this.router.navigate(['/login']);
    }
    if (this.id.toString() == "23") {
      this.isAdmin = true;
    }
    if (this.idsociete != undefined) this.isSociete = true;
  }
  Goback() {
    if (this.isSociete) {
      sessionStorage.removeItem("idsociete");
      this.router.navigateByUrl('BannerComponent', { skipLocationChange: true }).then(() =>
        this.router.navigate(['/admin-account/' + this.idIntermediation]));
    }
    else {
      if (this.isAdmin) {
        // reload componemt no load page
        this.router.navigateByUrl('AdminIndexComponent', { skipLocationChange: true }).then(() =>
        this.router.navigate(['/admin/' + this.idUserBack]));
      }
      else {
        this.router.navigate(['/event/' + this.IdUser]);
      }
    }
  }

}

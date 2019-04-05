import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logo',
  templateUrl: './logo.component.html',
  styleUrls: ['./logo.component.css']
})
export class LogoComponent implements OnInit {
  id = sessionStorage.id;
  idsociete = sessionStorage.idsociete;
  idUser=sessionStorage.Utilisateur;
  idIntermediation = sessionStorage.idIntermediation;
  idUserBack = sessionStorage.idUserBack;
  IdUser=sessionStorage.Utilisateur;
  isAdmin=false;
  isSociete = false;
  constructor(private router: Router) { }
  ngOnInit() {
    if(this.id==undefined) return;
    if(this.id.toString()=="23"){
      this.isAdmin=true;
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
      if (this.isAdmin && this.idUserBack == undefined) {
        // reload componemt no load page
        this.router.navigateByUrl('AdminIndexComponent', { skipLocationChange: true }).then(() =>
        this.router.navigate(['/admin/' + this.IdUser]));
      }
      else if(this.idUserBack != undefined){
        this.router.navigateByUrl('AdminIndexComponent', { skipLocationChange: true }).then(() =>
        this.router.navigate(['/admin/' + this.idUserBack]));
      }
      else {
        this.router.navigate(['/event/' + this.IdUser]);
      }
    }
  }
}

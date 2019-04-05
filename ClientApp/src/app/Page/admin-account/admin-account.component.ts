import { Component, OnInit } from '@angular/core';
import { SocieteService } from '../../services/societe.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-account',
  templateUrl: './admin-account.component.html',
  styleUrls: ['./admin-account.component.css']
})
export class AdminAccountComponent implements OnInit {
  id = sessionStorage.id;
  idIntermediation = location.pathname.split('/')[2];
  idUser = sessionStorage.Utilisateur;
  idUserBack = sessionStorage.idUserBack;
  objSocieteLogin: ObjectResult_SocieteLogin;
  data: SocieteLogin[];
  constructor(private societeservice: SocieteService,private router: Router) {}

  ngOnInit() {
    if(this.idUserBack==undefined){
      sessionStorage.setItem("idUserBack", this.idUser);
      this.idUserBack=this.idUser;
    }
    sessionStorage.removeItem("idsociete");
    sessionStorage.removeItem("Utilisateur");
    this.LoadSociete();
  }
  LoginSociete(idSociete: number, idUser: number) {
    sessionStorage.setItem("idsociete", idSociete.toString());
    sessionStorage.setItem("Utilisateur", idUser.toString());
    // window.location.href = '/information/' + this.idIntermediation;
    this.router.navigateByUrl('BannerComponent', { skipLocationChange: true }).then(() =>
    this.router.navigate(['/information/' + this.idIntermediation]));
  }
  LoadSociete() {
    this.societeservice.SocieteLogin(this.idIntermediation)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.objSocieteLogin = JSON.parse(value);
        this.data = this.objSocieteLogin.result;
      });
  }
}

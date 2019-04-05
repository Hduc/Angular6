import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { LoginService } from '../../services/login.service';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';
@Component({
  selector: 'app-atelier',
  templateUrl: './atelier.component.html',
  styleUrls: ['./atelier.component.css']
})
export class AtelierComponent implements OnInit {
  public isCollapsed_intervenant = true;
  public isCollapsed_presentation = true;
  edit = false;
  notdata = false;
  id = sessionStorage.id;
  isAdmin = false;
  listeUtilisateur: Liste_Utilisateur[];
  ObjectResult_Liste_Utilisateur: ObjectResult_Liste_Utilisateur;
  idSociete = '1112214';

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private loginService: LoginService,
    private http: HttpClient
  ) { }

  ngOnInit() {
    if (this.id.toString() == "23") {
      this.isAdmin = true;
      this.LoadUser_InEvent(this.idSociete);
    }
  }
  LoadUser_InEvent(id: string): void {
    this.loginService.LoadUser_InEvent(id)
      .subscribe(result => {
        var value = JSON.stringify(result);
        this.ObjectResult_Liste_Utilisateur = JSON.parse(value);
        this.listeUtilisateur = this.ObjectResult_Liste_Utilisateur.result;
        if (this.listeUtilisateur != null) {
          $(".loader").fadeToggle(1500);
        } else {
          this.notdata = true;
          return;
        }
      });
  }
  Edit() {
    this.edit = true;
  }
  Save() {
    this.edit = false;
    this.LoadUser_InEvent(this.idSociete);
  }
}
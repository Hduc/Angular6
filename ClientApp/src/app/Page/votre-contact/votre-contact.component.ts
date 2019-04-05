import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { LoginService } from '../../services/login.service';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';
@Component({
  selector: 'app-votre-contact',
  templateUrl: './votre-contact.component.html',
  styleUrls: ['./votre-contact.component.css']
})
export class VotreContactComponent implements OnInit {
// session Id User login
idSociete = sessionStorage.id;
isAdmin = false;
notdata = false;
id = sessionStorage.id;
listeUtilisateur: Liste_Utilisateur[];
ObjectResult_Liste_Utilisateur: ObjectResult_Liste_Utilisateur;
constructor(
  private router: Router,
  private route: ActivatedRoute,
  private loginService: LoginService,
  private http: HttpClient
) { }
ngOnInit() {
  if (this.id.toString() == "23") {
    this.isAdmin = true;
  }
  // load data User participation event
  this.LoadUser_InEvent(this.idSociete);
}

// Deleted():void{
//   swal({
//     title: 'SAUVEGARDE DES MODIFICATIONS',
//     text: "Vous etes sur le point de fermer la fiche CLIENT VENDEUR de la soclété SANGOS. Vous souhatiez:",
//     type: 'warning',
//     showCancelButton: true,
//     confirmButtonColor: '#3085d6',
//     cancelButtonColor: '#d33',
//     confirmButtonText: 'ANNULER',
//     cancelButtonText: 'VALIDER'

//   }).then((result) => {
//     if (result.value) {
//       swal(
//         'Deleted!',
//         'Your file has been deleted.',
//         'success'
//       )
//     }
//   })

// }
Edit(id: string) {
  this.router.navigate(['participants-detail/' + id]);
}
LoadUser_InEvent(id: string): void {
  this.loginService.LoadUser_InEvent(id)
    .subscribe(result => {
      var value = JSON.stringify(result);
      this.ObjectResult_Liste_Utilisateur = JSON.parse(value);
      this.listeUtilisateur = this.ObjectResult_Liste_Utilisateur.result;
      if (this.listeUtilisateur.length > 0) {
        $(".loader").fadeToggle(1500);
      } else {
        this.notdata = true;
        return;
      }
    });
}
}

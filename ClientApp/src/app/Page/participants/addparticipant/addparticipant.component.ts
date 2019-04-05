import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { LoginService } from '../../../services/login.service';
import { SocieteService } from '../../../services/societe.service';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';
import { ContactService } from '../../../services/contact.service';

@Component({
  selector: 'app-addparticipant',
  templateUrl: './addparticipant.component.html',
  styleUrls: ['./addparticipant.component.css']
})

export class AddparticipantComponent implements OnInit {
  imgSrc = "/assets/img_avatar.png";
  data: Obj_Contact[];
  lst_ObjContact: Obj_Contact[];
  result_Obj_Contact: Result_Obj_Contact;
  setPrenom: string;
  idListeService = sessionStorage.idListeService;
  Object_Contact: Object_Contact;
  select_Famillefonction: string;
  select_Generique: number;
  object_ListeFonction: Object_ListeFonction;
  lst_Famillefonction: Liste_Fonction[];
  liste_FonctionGenerique: Liste_Fonction[];

  status = 0;
  select_Prenom: string;
  objContact: Obj_Contact = {
    "idcontact": 0,
    "prenomContact": "",
    "nomContact": "",
    "nomSociete": "",
    "telephoneContact": "",
    "fonctionContact": "",
    "emailContact": "",
    "idcivilite": 0,
    "portableContact": "",
    "idListeFonction": 0,
    "fonctionGeneriqueAbrege": "",
    "fonctionGenerique": "",
    "idStatut": 0,
    "contactPardefaut": 0,
    "idSociete": 0,
    "idTypeFonction": "",
    "idutilisateur": 0,
    "photoUrl": ""
  };
  objContact_add: Obj_Contact = {
    "idcontact": 0,
    "prenomContact": "",
    "nomContact": "",
    "nomSociete": "",
    "telephoneContact": "",
    "fonctionContact": "",
    "emailContact": "",
    "idcivilite": 0,
    "portableContact": "",
    "idListeFonction": 0,
    "fonctionGeneriqueAbrege": "",
    "fonctionGenerique": "",
    "idStatut": 0,
    "contactPardefaut": 0,
    "idSociete": 0,
    "idTypeFonction": "",
    "idutilisateur": 0,
    "photoUrl": ""
  };
  result_Contact: Result_Contact;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private loginService: LoginService,
    private societeService: SocieteService,
    private contactService: ContactService,
    private http: HttpClient
  ) { }

  ngOnInit() {
    this.LoadUserOfSociete();
    this.LoadData_FamilleFonction();
  }
  onAddContact(event) {
    event.preventDefault()
    const target = event.target;
    this.objContact.idcontact = target.querySelector('#idContact_add').value;
    this.objContact.prenomContact = target.querySelector('#prenom_add').value;
    this.objContact.nomContact = target.querySelector('#nom_add').value;
    this.objContact.idTypeFonction = this.select_Famillefonction;
    // this.objContact.fonctionContact = this.select_FonctionGenerique;
    this.objContact.telephoneContact = target.querySelector('#telephone_add').value;
    this.objContact.fonctionContact = target.querySelector('#fonctionContact').value;
    this.objContact.portableContact = target.querySelector('#Portable_add').value;
    this.objContact.emailContact = target.querySelector('#emailContact_add').value;
    this.objContact.idutilisateur = sessionStorage.Utilisateur;
    this.objContact.idSociete = sessionStorage.id;
    this.objContact.idListeFonction = this.select_Generique;
    this.objContact.idcivilite = $("input[name=radio]:checked").val();

    if (this.objContact.idTypeFonction == undefined) {
      $("#sel_Famillefonction").find(".ng-select-container").css("border-color", "red");
      $(".validate_sel_Famillefonction").html("<span class='text-danger'> Famille fonction non vide!</span>");

    }
    if (this.objContact.idListeFonction == undefined) {
      $("#ng_Generique").find(".ng-select-container").css("border-color", "red");
      $(".validate_ngGenerique").html("<span class='text-danger'> Fonction générique non vide!</span>");
    }
    if (this.objContact.prenomContact == "") {
      $("#prenom_add").css("border-color", "red");
      $(".validate_prenom").html("<span class='text-danger'> Prénom non vide!</span>");
    }

    //  if icontact exist then add object objContact in db with idstatus =10
    this.contactService.Insert_Contact(this.objContact)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.result_Contact = JSON.parse(value);
        var res = this.result_Contact.result;
        if (res > 0) {
          this.intIdContact = res;
          // insert avatar
          if(this.file != undefined || this.file != null){
            this.contactService.Insert_Img_Contact(this.file, this.intIdContact.toString()).subscribe(res => {
              console.log(res);
              var render = new FileReader();
              render.onload = (event: any) => {
                this.imgSrc = event.target.result;
              };
              render.readAsDataURL(this.fileToUpload);
            });
          }
          this.objContact_add = null;
          this.status = 0;
          this.select_Famillefonction = undefined;
          this.select_Prenom = undefined;
          this.router.navigateByUrl('ParticipantsComponent', { skipLocationChange: true }).then(() =>
            this.router.navigate([location.pathname]));
        }
      }, error => console.log(error));
  }
  Back(idChange: number) {
    this.status = 0;
    // reload component
    this.router.navigateByUrl('ParticipantsComponent', { skipLocationChange: true }).then(() =>
      this.router.navigate([location.pathname]));
  }
  search(prenom: string) {
    debugger;
    if (prenom != "") {
      this.data = [];
      var i = 0;
      this.lst_ObjContact.forEach(element => {
        if (this.lst_ObjContact[i].prenomContact.includes(prenom)) {
          this.data.push(this.lst_ObjContact[i]);
        }
        i++;
      });
    }
    else this.data = this.lst_ObjContact;
  }
  LoadUserOfSociete() {
    debugger;
    var idSociete = sessionStorage.id;
    var idListeService = this.idListeService;

    if (idSociete.trim() != "") {
      this.contactService.LoadUserOfSociete(idSociete, idListeService)
        .subscribe(result => {
          const value = JSON.stringify(result);
          this.result_Obj_Contact = JSON.parse(value);
          this.lst_ObjContact = this.result_Obj_Contact.result;
          this.data = this.lst_ObjContact
          if (this.data == null) {
            return;
          } else {
            $(".loader").fadeToggle(100);
          }
        });
    } else {
      return;
    }
  }
  ChangePrenom(prenom: string) {
    debugger;
    this.setPrenom = prenom;
    this.SearchUser(prenom);
  }
  SearchUser(prenom: string) {
    // var prenom = this.select_Prenom;
    $(".loader").fadeToggle(10);
    var idSociete = sessionStorage.id;
    var idListeService = this.idListeService;
    if (prenom != "" && idSociete != "") {
      this.contactService.SearchUser(prenom, idSociete, idListeService)
        .subscribe(result => {
          const value = JSON.stringify(result);
          this.Object_Contact = JSON.parse(value);
          this.objContact_add = this.Object_Contact.result;
          if (this.objContact_add != undefined || this.objContact_add != null) {
            $(".loader").fadeToggle(1000);
            this.select_Famillefonction = this.objContact_add.idTypeFonction;
            this.ChosenFonction(this.select_Famillefonction);
            this.select_Generique = this.objContact_add.idListeFonction;
            this.imgSrc = (this.objContact.photoUrl == "" || this.objContact.photoUrl == undefined) ? "/assets/img_avatar.png" : this.objContact.photoUrl;
          }
        });
    } else {
      return;
    }
  }

  LoadData_FamilleFonction() {
    this.contactService.LoadData_FamilleFonction()
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.object_ListeFonction = JSON.parse(value);
        this.lst_Famillefonction = this.object_ListeFonction.result;
        if (this.lst_Famillefonction == null) {
          return;
        }
      });
  }

  ChosenFonction(idTypeFonction: string) {
    if (idTypeFonction != null) {
      this.contactService.LoadData_FonctionGenerique(idTypeFonction)
        .subscribe(result => {
          const value = JSON.stringify(result);
          this.object_ListeFonction = JSON.parse(value);
          this.liste_FonctionGenerique = this.object_ListeFonction.result;
          if (this.liste_FonctionGenerique != null) {
            $("#ng_Generique").focus();
            return;
          }
        });
    } else {
      // $(".ng-select-container").css("border-color", "red");
    }
  }
  check_Email = true;
  checkEmail(email) {
    var regex = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    this.check_Email = regex.test(email);
    return this.check_Email;
  }
  fileToUpload: File = null;
  file: FileList;
  intIdContact: number;
  
  changeAvatar(file: FileList) {
    this.file = file;
    this.fileToUpload = file.item(0);
    //show images
    var render = new FileReader();
    render.onload = (event: any) => {
      this.imgSrc = event.target.result;
    }
    render.readAsDataURL(this.fileToUpload);
  }
}

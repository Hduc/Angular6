import { Component, OnInit, Input } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { LoginService } from '../../../services/login.service';
import { SocieteService } from '../../../services/societe.service';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';
import { ContactService } from '../../../services/contact.service';

@Component({
  selector: 'app-updateparticipant',
  templateUrl: './updateparticipant.component.html',
  styleUrls: ['./updateparticipant.component.css']
})
export class UpdateparticipantComponent implements OnInit {
  imgSrc = "/assets/img_avatar.png";
  @Input() idContact: number;
  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private loginService: LoginService,
    private societeService: SocieteService,
    private contactService: ContactService,
    private http: HttpClient
  ) { }

  ngOnInit() {
    this.LoadUserByID(this.idContact);
    this.LoadData_FamilleFonction();
    this.LoadUserOfSociete();
  }

  // Load data user by username
  Object_Contact: Object_Contact;
  lst_ObjContact: Obj_Contact[];
  objContact: Obj_Contact = {
    "idcontact": 0,
    "prenomContact": "",
    "nomContact": "",
    "telephoneContact": "",
    "nomSociete": "",
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
  setPrenom: string;
  select_Prenom: string;
  select_Famillefonction: string;
  select_Generique: number;
  idcontact: number;
  LoadUserByID(idContact: number): void {
    if (idContact > 0 || idContact != undefined) {
      this.contactService.GetByUserName(idContact.toString())
        .subscribe(result => {
          const value = JSON.stringify(result);
          this.Object_Contact = JSON.parse(value);
          this.objContact = this.Object_Contact.result;
          if (this.objContact != null || this.objContact != undefined) {
            $(".loader").fadeToggle(100);
            this.idcontact = this.objContact.idcontact;
            this.setPrenom = this.objContact.prenomContact;
            this.select_Prenom = this.objContact.prenomContact;
            this.select_Famillefonction = this.objContact.idTypeFonction;
            this.ChosenFonction(this.select_Famillefonction);
            this.select_Generique = this.objContact.idListeFonction;

          }
        });
    } else {
      this.router.navigate(['/notfound']);
    }
  }
  object_ListeFonction: Object_ListeFonction;
  liste_FonctionGenerique: Liste_Fonction[];
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
  status = 0;
  Back(idChange: number) {
    this.status = 0;
    // reload component
    this.router.navigateByUrl('ParticipantsComponent', { skipLocationChange: true }).then(() =>
      this.router.navigate([location.pathname]));
  }
  result_Contact: Result_Contact;
  SaveContact(event) {
    event.preventDefault()
    const target = event.target;

    this.objContact.idcontact = target.querySelector('#idContact_up').value;
    this.objContact.prenomContact = target.querySelector('#prenom_up').value;
    this.objContact.nomContact = target.querySelector('#nom').value;
    this.objContact.idTypeFonction = this.select_Famillefonction;
    this.objContact.telephoneContact = target.querySelector('#telephone').value;
    this.objContact.fonctionContact = target.querySelector('#fonctionContact_up').value;
    this.objContact.portableContact = target.querySelector('#Portable').value;
    this.objContact.emailContact = target.querySelector('#emailContact').value;
    this.objContact.idListeFonction = this.select_Generique;
    this.objContact.idcivilite = $("input[name=radio]:checked").val()
    console.log(this.objContact);

    if (this.objContact.idTypeFonction == undefined) {
      var Validate_idTypeFonction = false;
      $("#ng_Famille_up").find(".ng-select-container").css("border-color", "red");
      $(".validate_ng_Famille_up").html("<span class='text-danger'> Famille fonction non vide!</span>");
    }
    if (this.objContact.idListeFonction == undefined) {
      $("#ng_Generique_up").find(".ng-select-container").css("border-color", "red");
      $(".validate_ng_Generique_up").html("<span class='text-danger'> Fonction générique non vide!</span>");
    }
    if (this.objContact.prenomContact == "") {
      $("#prenom_up").css("border-color", "red");
      $(".validate_prenom_up").html("<span class='text-danger'> Prénom non vide!</span>");
    }

    //  if icontact exist then add object objContact in db with idstatus =-1
    if (this.objContact != null || this.objContact != undefined) {
      this.contactService.Update_Contact(this.objContact)
        .subscribe(result => {
          const value = JSON.stringify(result);
          this.result_Contact = JSON.parse(value);
          var res = this.result_Contact.result;
          if (res == 1) {
            this.Back(0);
            this.status = 0;
          } else {
          }
        })
    }
  }
  data: Obj_Contact[];
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
  result_Obj_Contact: Result_Obj_Contact;
  LoadUserOfSociete() {
    debugger;
     $(".loader").fadeToggle(1000);
    var idSociete = sessionStorage.id;
    var idListeService = sessionStorage.idListeService;

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
  lst_Famillefonction: Liste_Fonction[];
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
  ChangePrenom(prenom: string) {
    debugger;
    this.setPrenom = prenom;
    this.SearchUser(prenom);
  }

  SearchUser(prenom: string) {
    // var prenom = this.select_Prenom;
    $(".loader").fadeToggle(10);
    var idSociete = sessionStorage.id;
    var idListeService = sessionStorage.idListeService;
    if (prenom != "" && idSociete != "") {
      this.contactService.SearchUser(prenom, idSociete, idListeService)
        .subscribe(result => {
          const value = JSON.stringify(result);
          this.Object_Contact = JSON.parse(value);
          this.objContact = this.Object_Contact.result;
          if (this.objContact != undefined || this.objContact != null) {
            $(".loader").fadeToggle(1000);
            this.select_Famillefonction = this.objContact.idTypeFonction;
            this.ChosenFonction(this.select_Famillefonction);
            this.select_Generique = this.objContact.idListeFonction;
            this.imgSrc = (this.objContact.photoUrl == "" || this.objContact.photoUrl == undefined) ? "/assets/img_avatar.png" : this.objContact.photoUrl;
          }
        });
    } else {
      return;
    }
  }
}

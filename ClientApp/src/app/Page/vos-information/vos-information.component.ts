import { Component, OnInit, Input, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { SocieteService } from '../../services/societe.service';
import { UploadService } from '../../services/upload.service';
import { } from '../../services/upload.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-vos-information',
  templateUrl: './vos-information.component.html',
  styleUrls: ['./vos-information.component.css']
})
export class VosInformationComponent implements OnInit {
  public isCollapsed_infor = false;
  public isCollapsed_expertise = true;
  public isCollapsed_competence = true;
  editInfo = false;
  isAdmin = false;
  id = sessionStorage.id;
  idUser = sessionStorage.Utilisateur;
  idsociete = sessionStorage.idsociete;
  formProfil = true;
  imgSrc = "/assets/img_avatar.png";
  fileToUpload: File = null;
  champs = false;
  logo: Logo_Societe;
  Message: string = "";
  TypeMesssage: string = "";
  errorSubmit = false;
  obj_societe: obj_Societe;
  obj_update_Societe: obj_update_Societe;
  societe: Societe = {
    "idsociete": null,
    "idnomSociete": "",
    "idsocieteParent": null,
    "idlistePays": null,
    "idlisteFormeJuridique": null,
    "idutilisateur": null,
    "idtypeNature": null,
    "idstatut": null,
    "idstatutClient": null,
    "codeApe": "",
    "leftCodeApe3": "",
    "leftCodeApe2": "",
    "codeApe2008": "",
    "idgroupeSociete": null,
    "groupe": "",
    "nomSociete": "",
    "adresse1": "",
    "adresse2": "",
    "adresse3": "",
    "codePostal": "",
    "leftCodePostal2": "",
    "ville": "",
    "telephoneSociete": "",
    "faxSociete": "",
    "emailSociete": "",
    "siteInternet": "",
    "activiteSociete": "",
    "kompass": "",
    "siret": "",
    "dateFondation": null,
    "ca": "",
    "idtypeCa": null,
    "anneeCa": null,
    "effectif": "",
    "idtypeEffectif": null,
    "anneeEffectif": null,
    "capital": "",
    "idtypeCapital": null,
    "anneeCapital": null,
    "oldIdsociete": null,
    "idlisteBase": null,
    "dateMajsociete": null,
    "idsocieteProprietaire": null,
    "listeRougeTelephoneSociete": null,
    "dateMajmanuelleSociete": null,
    "dateCreationSociete": null,
    "idnomVille": ""
  };

  objListe_Pays: ObjectResult_Liste_Pays;
  arrayliste_Pays: Liste_Pays[];
  setPays: number;

  objTypeEffectif: ObjectResult_TypeEffectif;
  arraytypeEffectif: TypeEffectif[];
  setIdTypeEffectif: number;

  objCodeApe2008: ObjectResult_CodeApe2008;
  arraycodeApe2008: CodeApe2008[];
  data: CodeApe2008[];
  setApe2008: string;

  objTypeNature: ObjectResult_TypeNature;
  arraytypeNature: TypeNature[];
  setIdNature: number;

  objFormeJuridique: ObjectResult_FormeJuridique;
  arrayFormeJuridique: FormeJuridique[];
  setIdFormeJuridique: number;

  objTypeCA: ObjectResult_TypeCA;
  arrayTypeCA: TypeCA[];
  setIdTypeCA: number;
  constructor(private router: Router, private societeserve: SocieteService, private uploadservice: UploadService, private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) { }
  ngOnInit() {
    this.LoadSociete();
  }
  editinfo(): void {
    this.editinfo != this.editinfo;
  }
  Loadinfo() {
    this.router.navigateByUrl('InfoComponent', { skipLocationChange: true }).then(() =>
      this.router.navigate([location.pathname]));
  }
  LoadSociete() {
    var id;
    if (this.idsociete == undefined) {
      id = this.id;
    }
    else {
      id = this.idsociete;
    }
    this.societeserve.LoadLogo(id).subscribe(res => {
      const values = JSON.stringify(res);
      // string to obj
      this.logo = JSON.parse(values);
      this.imgSrc = this.logo.UrlLogo;
    });
    this.societeserve.LoadData_Societe(id).subscribe(res => {
      const values = JSON.stringify(res);
      // string to obj
      this.obj_societe = JSON.parse(values);
      this.societe = this.obj_societe.result;

      this.setPays = this.societe.idlistePays;
      this.setApe2008 = this.societe.codeApe2008;
      this.setIdTypeEffectif = this.societe.idtypeEffectif;
      this.setIdNature = this.societe.idtypeNature;
      this.setIdFormeJuridique = this.societe.idlisteFormeJuridique;
      this.setIdTypeCA = this.societe.idtypeCa;

      this.LoadSelectTypeCA();
      this.LoadSelectPays();
      this.LoadSelectTypeEffectif();
      this.LoadSelectCodeApe2008();
      this.LoadSelectTypeNature();
      this.LoadSelectFormeJuridique();
    });

  }

  ChangeAvatar(file) {
    if (file.length === 0)
      return;
    var id;
    if (this.idsociete == undefined) {
      id = this.id;
    }
    else {
      id = this.idsociete;
    }
    this.fileToUpload = file.item(0);
    //show images
    //check file is image   
    if (!this.fileToUpload.type.includes("image")) {
      console.log("wrong image format");
      return;
    }
    this.uploadservice.ImageSociete(file, id).subscribe(res => {
      console.log(res);
      var render = new FileReader();
      render.onload = (event: any) => {
        this.imgSrc = event.target.result;
      };
      render.readAsDataURL(this.fileToUpload);
    });

  }
  ChangeApe(ape: string) {
    this.setApe2008 = ape;
  }
  LoadSelectPays() {
    this.societeserve.Liste_Pays().subscribe(res => {
      const values = JSON.stringify(res);
      this.objListe_Pays = JSON.parse(values);
      this.arrayliste_Pays = this.objListe_Pays.result;
    });
  }
  LoadSelectTypeEffectif() {
    this.societeserve.TypeEffectif().subscribe(res => {
      const values = JSON.stringify(res);
      this.objTypeEffectif = JSON.parse(values);
      this.arraytypeEffectif = this.objTypeEffectif.result;
    });
  }
  LoadSelectCodeApe2008() {
    this.societeserve.CodeApe2008().subscribe(res => {
      const values = JSON.stringify(res);
      this.objCodeApe2008 = JSON.parse(values);
      this.arraycodeApe2008 = this.objCodeApe2008.result;
      this.search("");
    });
  }
  LoadSelectTypeNature() {
    this.societeserve.TypeNature().subscribe(res => {
      const values = JSON.stringify(res);
      this.objTypeNature = JSON.parse(values);
      this.arraytypeNature = this.objTypeNature.result;
    });
  }
  LoadSelectTypeCA() {
    this.societeserve.Type_CA().subscribe(res => {
      const values = JSON.stringify(res);
      this.objTypeCA = JSON.parse(values);
      this.arrayTypeCA = this.objTypeCA.result;
    });
  }
  LoadSelectFormeJuridique() {
    this.societeserve.FormeJuridique().subscribe(res => {
      const values = JSON.stringify(res);
      this.objFormeJuridique = JSON.parse(values);
      this.arrayFormeJuridique = this.objFormeJuridique.result;
    });
  }
  search(ape: string) {
    if (ape != "") {
      this.data = [];
      var i = 0;
      this.arraycodeApe2008.forEach(element => {
        console.log(i, element);
        if (this.arraycodeApe2008[i].idape2008.includes(ape) || this.arraycodeApe2008[i].libelleApe2008.includes(ape)) {
          console.log(this.arraycodeApe2008[i]);
          this.data.push(this.arraycodeApe2008[i]);
        }
        i++;
      });
    }
    else this.data = this.arraycodeApe2008;
  }
  UpdateSociete(event) {
    this.Message = "";
    this.TypeMesssage = "";
    event.preventDefault();
    const target = event.target;
    if (target.querySelector('#Adress1').value == "" || target.querySelector('#CodePostal').value == "" || target.querySelector('#Tel').value == "" || target.querySelector('#Email').value == "" || target.querySelector('#SiteInternet').value == "") {
      this.formProfil = false;
      return;
    }
    if (this.setIdTypeCA == null || this.setIdTypeEffectif == null || this.setPays == null || this.setIdNature == null || this.setIdFormeJuridique == null) {
      this.errorSubmit = true;
      this.Message = "Les champs ne doivent pas être vides";
      this.TypeMesssage = "danger";
      return;
    }
    this.societe.groupe = target.querySelector('#Groupe').value;
    this.societe.idtypeCa = this.setIdTypeCA;
    this.societe.idtypeEffectif = this.setIdTypeEffectif;
    this.societe.adresse1 = target.querySelector('#Adress1').value;
    this.societe.adresse2 = target.querySelector('#Adress2').value;
    this.societe.codeApe2008 = target.querySelector('#CodeAPE').value;
    this.societe.codePostal = target.querySelector('#CodePostal').value;
    this.societe.ville = target.querySelector('#Ville').value;
    // this.societe.activiteSociete = target.querySelector('#Activite').value;
    this.societe.siret = target.querySelector('#Siret').value;
    this.societe.emailSociete = target.querySelector('#Email').value;
    this.societe.idlistePays = this.setPays;
    this.societe.telephoneSociete = target.querySelector('#Tel').value;
    // this.societe.faxSociete = target.querySelector('#Fax').value;
    this.societe.siteInternet = target.querySelector('#SiteInternet').value;
    this.societe.idtypeNature = this.setIdNature;
    this.societe.idlisteFormeJuridique = this.setIdFormeJuridique;

    if (this.societe != null || this.societe != undefined) {
      this.societeserve.UpdateSociete(this.societe).subscribe(res => {
        const values = JSON.stringify(res);
        this.obj_update_Societe = JSON.parse(values);
        if (this.obj_update_Societe.result == "update to success") {
          this.Message = "Mise à jour des données réussie";
          this.TypeMesssage = "success";
        }
        else {
          this.Message = "La mise à jour des données a échoué";
          this.TypeMesssage = "danger";
        }
      })
    }
  }

}

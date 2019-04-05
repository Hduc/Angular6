import { Component, OnInit } from '@angular/core';
import swal from 'sweetalert2';
import { Router, ActivatedRoute } from '@angular/router';
import { LoginService } from '../../services/login.service';
import { SocieteService } from '../../services/societe.service';
import { HttpClient } from '@angular/common/http';
import * as $ from 'jquery';
import { ContactService } from '../../services/contact.service';
import { isEmpty } from 'rxjs/operators';

@Component({
  selector: 'app-participants',
  templateUrl: './participants.component.html',
  styleUrls: ['./participants.component.css']

})
export class ParticipantsComponent implements OnInit {
  // session Id User login
  idSociete = sessionStorage.id;
  idListeService = sessionStorage.idListeService;
  isAdmin = false;
  notdata = false;
  status = 0;
  namesociete = "";
  result_Contact: Result_Contact;
  data: Obj_Contact[];
  lst_ObjectResult_Contact: Result_Obj_Contact;
  imgSrc = "/assets/img_avatar.png";
  fileToUpload: File = null;
  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private loginService: LoginService,
    private societeService: SocieteService,
    private contactService: ContactService,
    private http: HttpClient
  ) { }
  ngOnInit() {

    if (this.idSociete.toString() == "23") {
      this.isAdmin = true;
    }
    // load data User participation event
    this.LoadData_Contact(this.idSociete);

  }
  ShowPopup(idContact: string) {
    // show popup deleted
    document.getElementById("openModalButton").click();
    $("#btn_delete").attr("value", idContact);
  }
  onDeleted() {
    var idContact = $("#btn_delete").val();
    this.contactService.Delete_Contact(idContact)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.result_Contact = JSON.parse(value);
        var res = this.result_Contact.result;
        if (res == 1) {
          $("#" + idContact).remove("tr");
          // this.LoadData_Contact(this.idSociete);
          // reload component
          this.router.navigateByUrl('ParticipantsComponent', { skipLocationChange: true }).then(() =>
          this.router.navigate([location.pathname]));
        } else {
          console.log("delete fail");
        }
      }, error => console.log(error));
  }
  idContact : number;
  Edit(idContact: number) {
    this.status = 2;
    if (idContact > 0) {
      this.idContact = idContact;
    }
  }
  Back(idChange: number) {
    //idChange ==0 : load; idChange ==1 : insert ;idChange ==2 : update
    this.status = idChange;
    if (idChange == 1) {
      this.status =idChange;
    } 
  }
  // load data user in company
  LoadData_Contact(id: string): void {
    this.contactService.LoadData_Contact(id)
      .subscribe(result => {
        var value = JSON.stringify(result);
        this.lst_ObjectResult_Contact = JSON.parse(value);
        this.data = this.lst_ObjectResult_Contact.result;
        if (this.data != null || this.data != undefined) {
          this.namesociete = $("#nomSociete").text();
          $(".loader").fadeToggle(1500);
        } else {
          $(".loader").fadeOut("slow");
          this.notdata = true;
          return;
        }
      });
  }
  // Load data user by username
 
  changeAvatar(file: FileList) {
    this.fileToUpload = file.item(0);
    //show images
    var render = new FileReader();
    render.onload = (event: any) => {
      this.imgSrc = event.target.result;
    }
    render.readAsDataURL(this.fileToUpload);
  }
}

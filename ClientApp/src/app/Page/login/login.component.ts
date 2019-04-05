import { Component, OnInit, Input, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../../services/login.service';
import * as $ from 'jquery';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  login = false;
  error_id: boolean;
  error_email: boolean;
  error_pass: boolean;
  isIDinDatabase: boolean;
  isEmailinDatabase: boolean;
  strErrorEmail = "";
  UserName = "";
  Password = "";
  Email = "";
  listeUtilisateur: Liste_Utilisateur;
  constructor(private router: Router,
    private loginService: LoginService) {
  }
  ngOnInit() {
    sessionStorage.clear();
  }
  OnLogin(UserName: string, Password: string): void {
    UserName = UserName.trim();
    Password = Password.trim();
    if (UserName == "" || Password == "" || Password == undefined || UserName == undefined) {
      this.login = true;
    }
    else {
      //check id if id not database error_id= true
      this.loginService.CheckID(UserName).subscribe(res => {
        this.isIDinDatabase = Boolean(res);
        if (this.isIDinDatabase == false) this.error_pass = false;
      }, error => console.log(error));
      if (this.isIDinDatabase == false) {
        this.error_id = true;
        return;
      }
      else {
        this.error_id = false;
        //login
        // sessionStorage.setItem("id","23");
        // sessionStorage.setItem("username","23");
        // sessionStorage.setItem("fonction","seo");
        // sessionStorage.setItem("isAdmin","true");
        // this.router.navigate(['/admin/23']);

        sessionStorage.setItem("history", "false");
        this.loginService.Login(UserName, Password)
          .subscribe(result => {
            if (result != null) {
              //json to string 
              const value = JSON.stringify(result);
              // string to obj
              this.listeUtilisateur = JSON.parse(value);
              let id = this.listeUtilisateur.idSocieteUtilisateur;
              sessionStorage.setItem("id", id.toString());
              let idUser = this.listeUtilisateur.idUtilisateur.toString();
              sessionStorage.setItem("Utilisateur", idUser);
              if (id.toString() == "23") {
                this.router.navigateByUrl('BannerComponent', { skipLocationChange: true }).then(() =>
                  this.router.navigate(['/admin/' + idUser]));
              }
              else {
                this.router.navigateByUrl('BannerComponent', { skipLocationChange: true }).then(() =>
                  this.router.navigate(['/event/' + idUser]));
              }
            } else {
              this.error_pass = true;
              return;
            }
          });
      }
    }
  }
  SendEmail() {
    if (this.Email == "") {//email trống
      this.strErrorEmail = "Entrez votre email ici.";
      this.error_email = true;
      return;
    }
    // email ko dung dinh dạng
    else {
      this.strErrorEmail = "Votre adresse email n'est pas valide.";
      this.error_email = true;
      return;
    }
    //////////// check mail is database
    if (this.Email !== "" && this.error_email == false) {
      this.loginService.CheckEmail(this.Email).subscribe(res => {
        this.isEmailinDatabase = Boolean(res);
      }, error => console.log(error));
      //code send mail is ID 
      if (!this.isEmailinDatabase) {
        this.strErrorEmail = "Votre email n'est pas enregistré";
        return;
      }
      else {
        if (this.isIDinDatabase) {
          this.loginService.SendEmail(this.Email);
          // alert("send mail is id");
          $("#btnEmail").attr("data-dismiss", "modal");
          //  alert("send mail");
        }
        else {
          this.loginService.SendEmailNotID(this.Email);
          // alert("send mail not id");
          $("#btnEmail").attr("data-dismiss", "modal");
          // alert("send mail");
        }
      }
    }

  }
  // Check email format properly
  isEmail(email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
  }

}

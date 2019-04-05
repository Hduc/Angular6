import { Component, OnInit } from '@angular/core';
import { CollapseModule } from 'ngx-bootstrap/collapse';
@Component({
  selector: 'app-jour',
  templateUrl: './jour.component.html',
  styleUrls: ['./jour.component.css']
})
export class JourComponent implements OnInit {
  public isCollapsed_CONTACTSUTILES = true;
  public isCollapsed_Catalogue = true;
  public isCollapsed_PLAN = true;
  public isCollapsed_ACCES = true;
  public isCollapsed_HORAIRE = true;
  public isCollapsed_LIVRAISON = true;
  id = sessionStorage.id;
  isAdmin=false;
  constructor() { }
  ngOnInit() {
    if(this.id.toString()=="23"){
      this.isAdmin=true;
    }
  }

}

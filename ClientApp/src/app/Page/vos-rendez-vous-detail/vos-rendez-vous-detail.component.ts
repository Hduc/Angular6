import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';
import * as XLSX from 'xlsx';
import { SocieteService } from '../../services/societe.service';
import { moveItemInArray, CdkDragDrop } from '@angular/cdk/drag-drop';
@Component({
  selector: 'app-vos-rendez-vous-detail',
  templateUrl: './vos-rendez-vous-detail.component.html',
  styleUrls: ['./vos-rendez-vous-detail.component.css']
})
export class VosRendezVousDetailComponent implements OnInit {
  id = sessionStorage.id;
  isAdmin = false;
  objResult: ObjectResult_Speed_Meeting;
  data: Speed_Meeting[];
  idIntermediation = location.pathname.split('/')[2];
  //id user
  Utilisateur = sessionStorage.Utilisateur;
  constructor(private societeService: SocieteService) {
    if (this.id.toString() == "23") {
      this.isAdmin = true;
    }
  }
  drop(event: CdkDragDrop<string[]>) {
    moveItemInArray(this.data, event.previousIndex, event.currentIndex);
  }

  ngOnInit() {
    this.LoadSpeedMeeetingDetail(this.idIntermediation, this.Utilisateur, "");
  }
  LoadSpeedMeeetingDetail(idIntermediation: string, Utilisateur: string, monSociete: string) {
    this.societeService.SpeedMeetingDetail(idIntermediation, Utilisateur, monSociete)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.objResult = JSON.parse(value);
        this.data = this.objResult.result;
      });
  }
  SpeedMeeetingDelete(idIntermediation: string, Utilisateur: string) {
    this.societeService.SpeedMeetingDelete(idIntermediation, Utilisateur)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.objResult = JSON.parse(value);
        this.data = this.objResult.result;
      });
  }
  filtreMonSoiciete(monSociete: string) {
    this.LoadSpeedMeeetingDetail(this.idIntermediation, this.Utilisateur, "");
    this.LoadSpeedMeeetingDetail(this.idIntermediation, this.Utilisateur, monSociete);
  }
  // //////////end drag and drop
  delete() {
    //var list = new Array();
    var a = "";
    $(".is-update").each(function (index) {
      var item = $(this).attr("id");
      $("#" + item).remove("div");
      a += item + ';';
    });
    this.societeService.SpeedMeetingDelete(a, this.idIntermediation)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.LoadSpeedMeeetingDetail(this.idIntermediation, this.Utilisateur, "");
      });
  }
  clickDiv(name: string) {
    var element = document.getElementById(name);
    if (element.className == "row drap cdk-drag is-update") {
      console.log(element);
      element.classList.remove("is-update");
    } else {
      element.classList.add("is-update");
    }
  }
  saveChageIndex() {
    
    var chageIndex = "";
    this.data.forEach(element => {
      chageIndex += element.idEnqueteSociete+';';
    });
    console.log(chageIndex);
    this.societeService.Updateorderchose(this.idIntermediation, chageIndex)
      .subscribe(result => {
        const value = JSON.stringify(result);
        console.log(value);
      });
  }
  exportToExcel() {
    var htmltable = document.getElementById('data');
    var html = htmltable.outerHTML;
    window.open('data:application/vnd.ms-excel,' + encodeURIComponent(html));
  }
}

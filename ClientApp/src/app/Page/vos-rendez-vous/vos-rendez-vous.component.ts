import { Component, OnInit, Inject } from '@angular/core';
// import { $ } from 'protractor';
import * as $ from 'jquery';
import { SocieteService } from '../../services/societe.service';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
    selector: 'app-vos-rendez-vous',
    templateUrl: './vos-rendez-vous.component.html',
    styleUrls: ['./vos-rendez-vous.component.css']
})
export class VosRendezVousComponent implements OnInit {
    txtExportName = "";
    id = sessionStorage.id;
    idIntermediation = location.pathname.split('/')[2];
    count = 0;
    Utilisateur = sessionStorage.Utilisateur;
    isAdmin = false;
    export_excel = "";
    objResult: ObjectResult_Speed_Meeting;
    data: Speed_Meeting[];
    objChose: ObjectResult_Chose;
    chose: Chose[];
    constructor(private societeService: SocieteService) { }

    ngOnInit() {
        if (this.id.toString() == "23") {
            this.isAdmin = true;
        }
        this.LoadSpeedMeeeting(this.idIntermediation, this.Utilisateur, "");
    }
    LoadSpeedMeeeting(idIntermediation: string, Utilisateur: string, monSociete: string) {
        this.societeService.SpeedMeeting(idIntermediation, Utilisateur, monSociete)
            .subscribe(result => {
                const value = JSON.stringify(result);
                this.objResult = JSON.parse(value);
                this.data = this.objResult.result;
                this.Count();
            });
    }
    filtreMonSoiciete(monSociete: string) {
        this.LoadSpeedMeeeting(this.idIntermediation, this.Utilisateur, monSociete);
    }
    Chosen(idEnqueteSociete: string) {
        var ischeck = $("#" + idEnqueteSociete).attr("name");
        // if isCheck ==1 ?update : insert 
        if (this.idIntermediation != null && ischeck == "0") {
            this.societeService.SpeedMeetingChose(this.idIntermediation, idEnqueteSociete.toString())
                .subscribe(result => {
                    const value = JSON.stringify(result);
                    this.objChose = JSON.parse(value);
                    this.chose = this.objChose.result;
                    this.Count();
                    $("#" + idEnqueteSociete).css({"background-color":"#d9534f","color":"#fff"});
                    $("#" + idEnqueteSociete).attr("name", "1");
                });
        } else {
            this.societeService.SpeedMeetingDelete(idEnqueteSociete, this.idIntermediation)
                .subscribe(result => {
                    const value = JSON.stringify(result);
                    this.Count();
                    $("#" + idEnqueteSociete).css({"background-color":"#d9534f","color":"#fff"});
                    $("#" + idEnqueteSociete).attr("name", "0");
                });
        }
    }

    Count() {
        this.societeService.SpeedMeetingDetail(this.idIntermediation, this.Utilisateur, "")
            .subscribe(result => {
                const value = JSON.stringify(result);
                this.objChose = JSON.parse(value);
                try {
                    this.count = this.objChose.result.length;
                }
                catch (err) {
                    this.count = 0;
                }
                var data = this.objChose.result;
              
                for (var i = 0; i < this.count && this.count > 0; i++) {
                    var idSociete = data[i].idEnqueteSociete;
                    $("#" + idSociete).css({"background-color":"#fff","color":"#d43f3a"});
                }
            });
    }


    // exportToExcel(exportName: string) {
    //     this.societeService.ExportExcel(exportName)
    //         .subscribe(result => {
    //             this.export_excel = result;
    //             if (result == null || result == "" || result == undefined) {
    //             } else {
    //                 window.open(this.export_excel, '_self');
    //                 this.txtExportName = "";
    //                 $("#exporter").hide();
    //                 // window.location.href = this.export_excel;
    //             }
    //         });
    // }
    exportToExcel(exportName: string) {
        this.societeService.ExportExcel(exportName)
            .subscribe(result => {
                this.export_excel = result;
                if (result == null || result == "" || result == undefined) {
                } else {
                    window.open(this.export_excel, '_self');
                    this.txtExportName = "";
                    // $("#exporter").hide();
                    // window.location.href = this.export_excel;
                }
            });
    }
    myFunction() {
        let printContents, popupWin;
        printContents = document.getElementById('data').innerHTML;
        popupWin = window.open('', '_blank', 'top=0,left=0,height=100%,width=auto');
        popupWin.document.open();
        popupWin.document.write(`
     <html>
       <head>
         <title>Print tab</title>
         <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
         <style>
      button.boder-danger{
        width: 150px;
        border: 1px solid red;
        background-color: #fff;
        color: #000;
        padding: 5px 15px;
        margin: 5px;
    }
     
    .title div {
        height: 35px;
        overflow: hidden;
    }
    .title h4{
        background-color: #d43f3a;
        color: #fff;
        margin: 0px;
        padding: 8px;
        margin-right: -8px;
    }
    .content{
        margin: 15px;
        
    }
    .content::-webkit-scrollbar {
        width: 6px;
        background-color: #F5F5F5;
    } 
    .content::-webkit-scrollbar-thumb {
        background-color: gray;
    }
    
    .content label{
        margin-right: 5px;
        float: left;
    }
    a.btn.pull-right{
        margin: 15px;
    }
    a.btn.pull-right i{
        margin-right: 10px;
    }
    .total{
        font-size: 1.1em; 
        background-color: rgb(203, 209, 211);
        color: #d43f3a;
        border-radius:50%; 
        padding: 7px;
        font-weight: bold;
    }
         </style>
         <script>
         $( document ).ready(function() {
          $(".btn-warning").click();
        });
         </script>
       </head>
   <body onload="window.print();window.close()">${printContents}</body>
     </html>`
        );

        popupWin.document.close();
    }


}

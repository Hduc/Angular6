import { Component, OnInit, Inject } from '@angular/core';
import { NgxCarousel } from 'ngx-carousel';
import { EventService } from '../../services/event.service';

@Component({
  selector: 'app-sliderlogo',
  templateUrl: './sliderlogo.component.html',
  styleUrls: ['./sliderlogo.component.css']
})
export class SliderlogoComponent implements OnInit {
  EnqueteSociete: EnqueteSociete[];
  objResult: ObjectResult_EnqueteSociete;
  public carouselTileOne: NgxCarousel;

  constructor(
    private eventService: EventService,
    @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.LoadEvent();
    this.carouselTileOne = {
      grid: { xs: 1, sm: 3, md: 4, lg: 6, all: 0 },
      speed: 600,
      interval: 3000,
      point: {
        visible: true,
        pointStyles: `
         .ngxcarouselPoint {
           display: none;
           list-style-type: none;
           text-align: center;
           padding: 0px 5px;
           margin: 0;
           white-space: nowrap;
           overflow: auto;
           box-sizing: border-box;
         }
         .ngxcarouselPoint li {
           display: inline-block;
           border-radius: 50%;
           background: #6b6b6b;
           padding: 5px;
           margin: 0 3px;
           transition: .4s;
         }
         .ngxcarouselPoint li.active {
             border: 2px solid rgba(0, 0, 0, 0.55);
             transform: scale(1.2);
             background: transparent;
           }
       `
      },
      load: 2,
      loop: true,
      touch: true,
      easing: 'ease',
      animation: 'lazy'
    };
  }
  LoadEvent() {
    this.eventService.LoadEventWithCount(9)
      .subscribe(result => {
        const value = JSON.stringify(result);
        this.objResult = JSON.parse(value);
        this.EnqueteSociete = this.objResult.result;
        if (this.EnqueteSociete != null) {
          var i = 0;
          this.EnqueteSociete.forEach(element => {
            if(this.EnqueteSociete[i].siteWebIntermediation==null) this.EnqueteSociete[i].siteWebIntermediation='https://sous-traitance-competitive.com/imgs/logo.png';
            else if(!this.EnqueteSociete[i].siteWebIntermediation.includes("www.")) {
              // http://www.{{event.siteWebIntermediation.replace('www.','')}}/imgs/logo.png
              this.EnqueteSociete[i].siteWebIntermediation='http://www.'+this.EnqueteSociete[i].siteWebIntermediation+'/imgs/logo.png';
            }
            else{
              this.EnqueteSociete[i].siteWebIntermediation='http://'+this.EnqueteSociete[i].siteWebIntermediation+'/imgs/logo.png';
            }
            i++;
          });
        }
      });
  }
}
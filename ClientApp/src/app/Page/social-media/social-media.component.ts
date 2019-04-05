import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-social-media',
  templateUrl: './social-media.component.html',
  styleUrls: ['./social-media.component.css']
})
export class SocialMediaComponent implements OnInit {
  id = sessionStorage.id;
  isAdmin = false;
  masonryItems = [
    { link: 'https://production-temps-reel.com/nantes_juin_2018/imgs/ptr_officiel.jpg' },
    { link: 'https://production-temps-reel.com/nantes_juin_2018/imgs/ptr_banniere.gif' },
    { link: 'https://production-temps-reel.com/nantes_juin_2018/imgs/linkedin_ptr_NANTES.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/IMG_5466.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_009.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_013.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_014.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_030.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_002.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_002.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_002.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_002.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_002.jpg' },
    { link: 'https://production-temps-reel.com/media/_img/photos_evt/ptr/ProductionTempsReel_Dec2014_002.jpg' },
  ];
  constructor() { }
  ngOnInit() {
    if (this.id.toString() == "23") {
      this.isAdmin = true;
    }

  }

}

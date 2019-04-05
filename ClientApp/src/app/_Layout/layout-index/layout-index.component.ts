import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-layout-index',
  templateUrl: './layout-index.component.html',
  styleUrls: ['./layout-index.component.css']
})
export class LayoutIndexComponent implements OnInit {
  id = sessionStorage.getItem("id");
  constructor(private router: Router, ) { 
    if (this.id == null || this.id == "") {
      this.router.navigate(['/login']);
    }
  }
  ngOnInit() {
  }

}

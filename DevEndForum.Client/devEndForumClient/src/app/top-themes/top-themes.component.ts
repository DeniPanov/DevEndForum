import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Themes } from '../models/themes';

@Component({
  selector: 'app-top-themes',
  templateUrl: './top-themes.component.html',
  styleUrls: ['./top-themes.component.css']
})
export class TopThemesComponent implements OnInit {

  isLogin = true;
  isCreate = false;
  themes: Array<Themes> = [];

  constructor(private router: Router) { 
  }

  ngOnInit(): void {
    if(this.themes.length!=0){
      this.isCreate = true
    }
   // if(this.auth.isLogin("Pesho")){
   //   this.isLogin = true;
   // };
  }

  createTheme() {
      this.isLogin= true;
      this.router.navigate(["home"])
    }
}

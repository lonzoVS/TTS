import { Component, OnInit } from '@angular/core';
import { OauthService } from 'src/_services/oauth.service';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit  {
  constructor() { }

  ngOnInit() {

  }
}

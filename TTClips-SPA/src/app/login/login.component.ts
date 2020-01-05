import { Component, OnInit } from '@angular/core';
import { OauthService } from 'src/_services/oauth.service';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private ouath: OauthService, private route: ActivatedRoute) { }

  ngOnInit() {
      this.route.fragment
      .pipe(map(fragment => fragment))
      .subscribe(fragment => {
      if (fragment) {
        let f = fragment.match(/^(.*?)&/);
        if (f) {
          let token: string = f[1].replace('access_token=', '');
          console.log(token);
        }
      }
    });
  }
}

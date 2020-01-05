import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
  })
export class OauthService {

constructor(private http: HttpClient) {}

login() {
  return this.http.get('https://id.twitch.tv/oauth2/authorize' +
  '?client_id=4kx7npmg3oz9prr62i2slbr6reat1w' +
  '&redirect_uri=http://localhost:4200' +
  '&response_type=token' +
  '&scope=user_read');
}


}

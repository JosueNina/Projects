import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User, UserLogin } from '../interfaces/user.interface';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  private baseUrl: string = 'http://localhost:5227/api/Account/login';
  constructor(private _httpClient: HttpClient) {}

  public login(data: UserLogin): Observable<User> {
    return this._httpClient.post<User>(this.baseUrl, data);
  }
}

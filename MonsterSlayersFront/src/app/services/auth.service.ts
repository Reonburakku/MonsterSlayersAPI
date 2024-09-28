import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, from } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private urlApi = 'https://localhost:7026/api/Authenticate';
  headerDict = {
    'Content-Type': 'application/json',
    'Accept': 'application/json',
    'Access-Control-Allow-Headers': '*',
    'Access-Control-Allow-Origin': '*'
  }

  requestOptions = {
    headers: new HttpHeaders(this.headerDict),
    params: {}
  };

  constructor(private http: HttpClient) { }

  public Login(username: string, password: string): Observable<any> {
    var paramObject = {
      Username: username,
      Password: password
    };
    var body = JSON.stringify(paramObject);

    return this.http.post(this.urlApi + '/login', body, this.requestOptions);
  }

  public Register(username: string, email: string, password: string): Observable<any> {
    var paramObject = {
      Username: username,
      Email: email,
      Password: password
    };
    var body = JSON.stringify(paramObject);

    return this.http.post(this.urlApi + '/register', body, this.requestOptions);
  }
}

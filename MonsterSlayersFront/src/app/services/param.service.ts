import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, from } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParamService {

  private urlApi = 'https://localhost:7026/api/Parametrization';
  headerDict = {
    'Content-Type': 'application/json',
    'Accept': 'application/json',
    'Access-Control-Allow-Headers': '*',
    'Access-Control-Allow-Origin': '*'
  }

  requestOptions = {
    headers: new HttpHeaders(this.headerDict),
    params: {
      LanguageId: "1",
      Origin: "Angular"
    }
  };

  constructor(private http: HttpClient) { }

  public GetAllZones(): Observable<any> {
    return this.http.get(this.urlApi + '/get-all-zones', this.requestOptions);
  }
}

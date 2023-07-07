import { Injectable } from "@angular/core";
import {HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient) {}

  get(url: string, params: HttpParams = new HttpParams()): Observable<any> {
    return this.httpClient.get(`http://localhost:5031/${url}`, { params });
  }
  post(url: string, body: Object = {}, headers: HttpHeaders = new HttpHeaders()): Observable<any> {
    return this.httpClient.post(`http://localhost:5031/${url}`, JSON.stringify(body), { headers });
  }
  patch(url: string, body: Object = {}, headers: HttpHeaders = new HttpHeaders()): Observable<any> {
    return this.httpClient.patch(`http://localhost:5031/${url}`, JSON.stringify(body), { headers });
  }
  delete<T>(url: string, body: Object = {}, headers: HttpHeaders = new HttpHeaders()): Observable<any> {
    return this.httpClient.delete(`http://localhost:5031/${url}`, {body: JSON.stringify(body), headers});
  }
}

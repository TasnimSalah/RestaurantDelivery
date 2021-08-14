import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { City } from './../_models/city';

@Injectable({
  providedIn: 'root'
})
export class CityServicesService {

 private _baseUrl:string
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
   }

  getAll() {
    return this.http.get<City[]>(this._baseUrl + 'city')
  }
}

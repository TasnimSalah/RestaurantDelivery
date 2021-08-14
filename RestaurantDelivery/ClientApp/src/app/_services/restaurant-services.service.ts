import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Restaurant } from './../_models/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RestaurantServicesService {

  private _baseUrl:string
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
   }

   searchByCity(city:number , restaurant:string){
    return this.http.get<Restaurant[]>(this._baseUrl + 'Restaurant'+city+restaurant);
   }
}

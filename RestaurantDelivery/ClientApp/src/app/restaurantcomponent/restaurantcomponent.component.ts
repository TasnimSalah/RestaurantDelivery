import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../_models/restaurant';
import { RestaurantServicesService } from './../_services/restaurant-services.service';

@Component({
  selector: 'app-restaurantcomponent',
  templateUrl: './restaurantcomponent.component.html',
  styleUrls: ['./restaurantcomponent.component.css']
})
export class RestaurantcomponentComponent implements OnInit {


  restaurants:Restaurant[];

  constructor(private restaurantService:RestaurantServicesService){}
  ngOnInit() {
  }

  search(city:number , restaurant:string){
    this.restaurantService.searchByCity(city,restaurant).subscribe(
      res => {
        console.log(res);
        this.restaurants = res;
      }
    )
  }

}

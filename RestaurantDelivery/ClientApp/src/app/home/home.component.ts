import { Component } from '@angular/core';
import { CityServicesService } from './../_services/city-services.service';
import { City } from './../_models/city';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  cities:City[];

  constructor(private cityService:CityServicesService){}
  
  ngOnInit():void{
    this.cityService.getAll().subscribe(
      res=>{
        console.log(res);
        this.cities = res;
      }
    )
  }
}

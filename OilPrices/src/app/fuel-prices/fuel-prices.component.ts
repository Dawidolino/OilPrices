import { Component, Input, OnInit } from '@angular/core';
import { FuelPrices } from '../shared/fuel-prices.model';
import { FuelPricesService } from '../shared/fuel-prices.service';

@Component({
  selector: 'app-fuel-prices',
  standalone: true,
  imports: [],
  templateUrl: './fuel-prices.component.html',
  styles: ``
})
export class FuelPricesComponent  {
   
    constructor(public fuelPricesService: FuelPricesService) { }

}

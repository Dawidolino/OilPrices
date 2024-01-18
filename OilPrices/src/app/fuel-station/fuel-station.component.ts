import { Component, OnInit } from '@angular/core';
import { FuelStationFormComponent } from "./fuel-station-form/fuel-station-form.component";
import { FuelStationService } from '../shared/fuel-station.service';
import { NgFor } from '@angular/common';
import { AsyncPipe } from '@angular/common';
import { Observable,  combineLatest } from 'rxjs';
import { map } from 'rxjs/operators';
import { FuelPricesService } from '../shared/fuel-prices.service';
@Component({
    selector: 'app-fuel-station',
    standalone: true,
    templateUrl: './fuel-station.component.html',
    styles: ``,
    imports: [FuelStationFormComponent,AsyncPipe ,NgFor], 
    providers: [FuelStationService, FuelPricesService] 
})

export class FuelStationComponent implements OnInit {
  
    fuelData$!: Observable<any>;
  
    constructor(
      public service: FuelStationService, 
      public priceService :FuelPricesService){}
      ngOnInit(): void {
        this.fuelData$ = combineLatest([
          this.service.getFuelStations(),
          this.priceService.getFuelPrices()
        ]).pipe(
          map(([fuelStations, fuelPrices]) => {
            return fuelStations.map(station => {
              const pricesForStation = fuelPrices.find(price => price.fuelStationId === station.id);
              return {
                ...station,
                prices: pricesForStation || { ron95: '0', ron98: '0', on: '0', lpg: '0' }
              };
            });
          })
        );
      }
  
  
      
  }
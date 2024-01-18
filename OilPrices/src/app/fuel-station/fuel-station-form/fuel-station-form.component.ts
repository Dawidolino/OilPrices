import { Component, NgModule } from '@angular/core';
import { FuelStationService } from '../../shared/fuel-station.service';
import { FormsModule } from '@angular/forms';
import { FuelPricesService } from '../../shared/fuel-prices.service';
import { FuelPrices } from '../../shared/fuel-prices.model';

@Component({
  selector: 'app-fuel-station-form',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './fuel-station-form.component.html',
  styles: ``
})
export class FuelStationFormComponent {

  constructor(public service: FuelStationService, public priceService: FuelPricesService) {}
  ngOnInit(): void {
   
    // Fetch fuel prices
    this.priceService.getFuelPrices().subscribe(prices => {
      const fuelPricesForStation = prices.find(price => price.fuelStationId === FuelPrices.fuelStationId);

      if (fuelPricesForStation) {
        // Fetch fuel station details based on the foreign key (fuelStationId)
        this.service.getFuelStations().subscribe(stations => {
          this.service.formData = stations.find(station=>station.id===FuelPricesService.fuelStationId);
        });

        // Assign fuel prices to the form data
        this.service.formData.ron95 = fuelPricesForStation.roN95;
        this.service.formData.ron98 = fuelPricesForStation.roN98;
        this.service.formData.on = fuelPricesForStation.on;
        this.service.formData.lpg = fuelPricesForStation.lpg;
      }
    });
  }
  
}
``
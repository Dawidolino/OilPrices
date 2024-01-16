import { Component, NgModule } from '@angular/core';
import { FuelStationService } from '../../shared/fuel-station.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-fuel-station-form',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './fuel-station-form.component.html',
  styles: ``
})
export class FuelStationFormComponent {

  constructor(public service: FuelStationService){

  }
}

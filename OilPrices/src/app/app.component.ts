import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { FuelStationComponent } from "./fuel-station/fuel-station.component";
import {FuelStationFormComponent} from "./fuel-station/fuel-station-form/fuel-station-form.component"
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    imports: [CommonModule, RouterOutlet, FuelStationComponent,FuelStationFormComponent,HttpClientModule, FormsModule]
})
export class AppComponent {
  title = 'OilPrices';
}

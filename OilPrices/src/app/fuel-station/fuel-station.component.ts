import { Component, OnInit } from '@angular/core';
import { FuelStationFormComponent } from "./fuel-station-form/fuel-station-form.component";
import { FuelStationService } from '../shared/fuel-station.service';
import { NgFor } from '@angular/common';
import { NgIf } from '@angular/common';
import { AsyncPipe } from '@angular/common';
import { Observable,  combineLatest } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
    selector: 'app-fuel-station',
    standalone: true,
    templateUrl: './fuel-station.component.html',
    styles: ``,
    imports: [FuelStationFormComponent,AsyncPipe ,NgFor, NgIf], 
    providers: [FuelStationService] 
})

export class FuelStationComponent implements OnInit {
  
    fuelData$!: Observable<any>;
  
    constructor( public service: FuelStationService){}
     ngOnInit(): void {
      
         

    }
  
  
      
  }

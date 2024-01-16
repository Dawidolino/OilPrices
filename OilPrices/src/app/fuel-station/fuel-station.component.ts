import { Component, OnInit } from '@angular/core';
import { FuelStationFormComponent } from "./fuel-station-form/fuel-station-form.component";
import { FuelStationService } from '../shared/fuel-station.service';
import { NgFor } from '@angular/common';
@Component({
    selector: 'app-fuel-station',
    standalone: true,
    templateUrl: './fuel-station.component.html',
    styles: ``,
    imports: [FuelStationFormComponent, NgFor]
})
export class FuelStationComponent implements OnInit{
    
    constructor(public service: FuelStationService){

    }
    ngOnInit(): void {
        this.service.refreshList();
    }
}

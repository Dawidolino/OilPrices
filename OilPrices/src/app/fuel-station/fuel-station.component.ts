import { Component, OnInit } from '@angular/core';
import { FuelStationFormComponent } from "./fuel-station-form/fuel-station-form.component";
import { FuelStationService } from '../shared/fuel-station.service';
import { NgFor } from '@angular/common';
import { NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { FuelStation } from '../shared/fuel-station.model';

@Component({
    selector: 'app-fuel-station',
    standalone: true,
    templateUrl: './fuel-station.component.html',
    styles: ``,
    imports: [FuelStationFormComponent,NgFor, NgIf,FormsModule], 
    providers: [FuelStationService] 
})

export class FuelStationComponent implements OnInit {
    
    searchLocation: string = '';
    originalList: any[] = [];

    constructor( public service: FuelStationService){}
    
    ngOnInit(): void {    
         this.service.refreshList();
    }        
     searchStations(): void {
    // If the original list is empty, make a copy of the current list
    if (this.originalList.length === 0) {
      this.originalList = [...this.service.list];
    }

    // Check if the search location is not empty
    if (this.searchLocation.trim() !== '') {
      // Filter the original list based on the search location
      this.service.list = this.originalList.filter(
        (station) =>
          station.miejscowosc.toLowerCase().includes(this.searchLocation.toLowerCase())
      );
        } else {
        // If the search location is empty, restore the original list
        this.service.list = [...this.originalList];
        }
    }
    populateForm(selectedRecord:FuelStation){
        this.service.formData= Object.assign({},selectedRecord);
    }
  }

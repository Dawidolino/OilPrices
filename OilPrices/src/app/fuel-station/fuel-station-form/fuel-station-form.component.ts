import { Component, NgModule } from '@angular/core';
import { FuelStationService } from '../../shared/fuel-station.service';
import { FormsModule, NgForm } from '@angular/forms';
import { FuelStation } from '../../shared/fuel-station.model';


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
  onSubmit(form:NgForm){
       
    this.updateRecord(form)    
    
  }

  // insertRecord(form: NgForm){
  //   this.service.postFuelStation()
  //   .subscribe({
  //     next: res => {
  //       this.service.list = res as FuelStation[]
  //       this.service.resetForm(form)
  //     },
  //     error:err=> {console.log(err)}
  //   })
  // }

  updateRecord(form:NgForm){
    this.service.putFuelStation()
    .subscribe({
      next: res => {
        this.service.list = res as FuelStation[]
        this.service.resetForm(form)
        console.log("updated successfully")
      },
      error:err=> {console.log(err)}
    })

  }

}


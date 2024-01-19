import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { environment } from '../../environments/environment.development';
import { FuelStation } from './fuel-station.model';
import { Observable } from 'rxjs';
import { NgForm } from '@angular/forms';
@Injectable({
  providedIn: 'root'
})
export class FuelStationService {

  url:string = environment.apiBaseUrl+'/fuelstation'
  list:FuelStation[]=[]
  formData : FuelStation = new FuelStation()
  constructor(private http:HttpClient) { }

  refreshList(){
    this.http.get(this.url)
    .subscribe({
      next:res=>{
        this.list=res as FuelStation[]
      },
      error: err=> {console.log(err)}
    })
  }
  getFuelStations(): Observable<FuelStation[]> {
    return this.http.get<FuelStation[]>(this.url);
  }
  postFuelStation(){
    return this.http.post(this.url, this.formData)
  }
  putFuelStation(){
    return this.http.put(this.url+'/'+this.formData.id, this.formData)    
  }
  deleteFuelStation(id:number){
    return this.http.delete(this.url+'/'+id)
  }
  resetForm(form:NgForm){
    form.form.reset();  
  }
}

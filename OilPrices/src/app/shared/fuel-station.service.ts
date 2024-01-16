import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { environment } from '../../environments/environment.development';
import { FuelStation } from './fuel-station.model';
@Injectable({
  providedIn: 'root'
})
export class FuelStationService {

  url:string = environment.apiBaseUrl+'/fuelstation'
  list:FuelStation[]=[]

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
}

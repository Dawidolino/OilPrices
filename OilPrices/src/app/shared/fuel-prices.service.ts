import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { FuelPrices } from './fuel-prices.model';

@Injectable({
  providedIn: 'root'
})
export class FuelPricesService {

  private url: string = environment.apiBaseUrl + '/fuelprices';

  constructor(private http: HttpClient) { }

  getFuelPrices(): Observable<FuelPrices[]> {
    return this.http.get<FuelPrices[]>(this.url);
  }
}
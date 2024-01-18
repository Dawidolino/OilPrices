export class FuelPrices {
    id: number = 0;
    fuelStationId: number = 0;
    ron95: string = "";
    ron98: string = "";
    on: string = "";
    lpg: string = "";
    priceEditDate: Date = new Date(); // Assuming you want to initialize it with the current date
  
    // Constructor to initialize the date to the current date
    constructor() {
      this.priceEditDate = new Date();
    }
  }
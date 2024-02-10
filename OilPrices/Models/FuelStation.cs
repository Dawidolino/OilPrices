using System;
using System.Collections.Generic;

namespace OilPrices.Models;

public partial class FuelStation
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Adress { get; set; }

    public string City { get; set; } = null!;

    public string? PostalCode { get; set; }

    public string Voivodeship { get; set; } = null!;

    public string County { get; set; } = null!;

    public string? Ron95 { get; set; }

    public string? Ron98 { get; set; }

    public string? On { get; set; }

    public string? Lpg { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

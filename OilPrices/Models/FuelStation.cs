using System;
using System.Collections.Generic;

namespace OilPrices.Models;

public partial class FuelStation
{
    public short Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string? Adres { get; set; }

    public string Miejscowosc { get; set; } = null!;

    public string? KodPocztowy { get; set; }

    public string Wojewodztwo { get; set; } = null!;

    public string Powiat { get; set; } = null!;

    public string? Ron95 { get; set; }

    public string? Ron98 { get; set; }

    public string? On { get; set; }

    public string? Lpg { get; set; }
}

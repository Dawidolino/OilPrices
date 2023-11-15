using System.ComponentModel.DataAnnotations;

namespace OilPrices.Model
{
    public class LocationModel
    {
        [Key]
        public int LocationModelId { get; set; }
        public string Province { get; set; } = "";
        public string County { get; set; } = "";
        public string City { get; set; } = "";
        public string Station { get; set; } = "";
        public ICollection<FuelPriceModel> FuelPrices { get; set; }
    }

}

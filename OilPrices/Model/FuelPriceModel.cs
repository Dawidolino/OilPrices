using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OilPrices.Model
{
    public class FuelPriceModel
    {
        [Key]
        public int FuelPriceModelId { get; set; }

        [ForeignKey("LocationModel")]
        public int LocationModelId { get; set; }
        public string FuelType { get; set; } = "";
        public decimal Price { get; set; } 
        public DateTime PriceEditDate { get; set; } 

        // one to many relation with location
        public LocationModel LocationModel { get; set; }
    }

}

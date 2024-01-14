using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OilPrices.Models
{
    public class FuelPrices
    {
        [Key]
        public short Id { get; set; }

        [ForeignKey("FuelStation")]
        public short FuelStationId { get; set; }       

        [Column(TypeName = "nvarchar(10)")]
        public string RON95 { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string RON98 { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string ON { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string LPG { get; set; } = "";

        public DateTime PriceEditDate { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OilPrices.Model
{
    public class FuelStation
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string NAZWA { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ADRES { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string MIEJSCOWOSC { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string KOD_POCZTOWY { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string WOJEWODZTWO { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string POWIAT { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string RON95 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string RON98 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string ON { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string LPG { get; set; }

    }
}

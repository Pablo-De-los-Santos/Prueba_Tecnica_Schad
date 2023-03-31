using System.Data.SqlTypes;

namespace Prueba_Tecnica_Schad.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ItbsPercentage { get; set; }
        public bool IncludesItbis { get; set; }
    }
}

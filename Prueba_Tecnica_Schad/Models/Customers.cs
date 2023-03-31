using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Tecnica_Schad.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public string Adress { get; set;}
        public bool Status { get; set;}
        public int CustomerTypeId { get; set; }
        [ForeignKey("CustomerTypeId")]
        public CustomerTypes CustomerTypes { get; set; }
    }
}

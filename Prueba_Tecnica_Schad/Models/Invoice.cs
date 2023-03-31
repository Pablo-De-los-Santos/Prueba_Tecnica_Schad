using System.Data.SqlTypes;

namespace Prueba_Tecnica_Schad.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

		public List<InvoiceDetail> InvoiceDetail { get; set; }

	}
}

﻿using System.Data.SqlTypes;

namespace Prueba_Tecnica_Schad.Models
{
	public class InvoiceDetail
	{
		public int Id { get; set; }
		public int InvoiceId { get; set; }
		public int Qty { get; set; }
		public decimal Price { get; set; }
		public decimal TotalItbis { get; set; }
		public decimal SubTotal { get; set; }
		public decimal Total { get; set; }
		public int ProductId { get; set; }
		public Invoice Invoice { get; set; }
	}

}

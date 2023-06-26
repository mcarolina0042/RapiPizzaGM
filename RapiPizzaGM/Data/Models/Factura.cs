using System.ComponentModel.DataAnnotations;

namespace RapiPizzaGM.Data.Models
{
	public class Factura
	{
		[Key]
		public int Id { get; set; }


		public int ClienteId { get; set; }


		public string Referencia { get; set; } = null!;
		public string Extra { get; set; } = null!;
		public decimal SubTotal { get; set; }


		public decimal Descuento { get; set; }
		public decimal ITBIS { get; set; }
		public decimal Total { get; set; }
	}
}

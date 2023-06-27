using RapiPizzaGM.Data.Request;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RapiPizzaGM.Data.Response
{
	public class FacturaResponse
	{
		public int Id { get; set; }


		public int ClienteId { get; set; }


		public string Referencia { get; set; } = null!;
		public string Extra { get; set; } = null!;
		public decimal SubTotal { get; set; }


		public decimal Descuento { get; set; }
		public decimal ITBIS { get; set; }
		public decimal Total { get; set; }

		public FacturaRequest ToRequest()
		{
			return new	FacturaRequest
			{
				Id = Id,
				ClienteId = ClienteId,
				Referencia = Referencia,
				Extra = Extra,
				SubTotal = SubTotal,
				ITBIS = ITBIS,
				Total = Total
			};

		}
	}
}

using System.ComponentModel.DataAnnotations;

namespace RapiPizzaGM.Data.Models
{
	public class Clientes
	{
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;

	}
}

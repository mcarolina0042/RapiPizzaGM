using System.ComponentModel.DataAnnotations;
namespace RapiPizzaGM.Data.Models
{
	public class Pizza
	{
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;


		public string Tamaño { get; set; } = null!;


		public decimal Precio { get; set; }
	}
}

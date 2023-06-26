using System.ComponentModel.DataAnnotations;

namespace RapiPizzaGM.Data.Models
{
	public class Usuario
	{
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;


		public string Email { get; set; } = null!;
		public string Contraseña { get; set; } = null!;


		public string Sexo { get; set; } = null!;
	}
}

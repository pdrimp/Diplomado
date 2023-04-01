using System.ComponentModel.DataAnnotations;

namespace Diplomado.Shared.Modelos
{
	public class Persona
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El nombre es obligatorio")]
		[StringLength(100, ErrorMessage = "Tamaño máximo 100 caracteres")]
		public string? Nombre { get; set; }
		[Required(ErrorMessage = "El correo es obligatorio")]
		[StringLength(100, ErrorMessage = "Tamaño máximo 100 caracteres")]
		[EmailAddress(ErrorMessage = "Escribir un correo válido")]
		public string? Correo { get; set; }
		[Required(ErrorMessage = "El teléfono es obligatorio")]
		[StringLength(10, ErrorMessage = "Tamaño máximo 10 caracteres")]
		[Phone(ErrorMessage = "Escribir un teléfono válido")]
		public string? Telefono { get; set; }
	}
}

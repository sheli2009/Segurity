using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("RolFormulario")]
	public class RolFormulario
	 {
		[Key]
		public int ID_RolFormulario { get; set; }
		[Required]
		public int IdRol { get; set; }
		[Required]
		public int IdFormulario { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public int UsuarioRegistro { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
}

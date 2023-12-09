using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("RolUsuario")]
	public class RolUsuario
	 {
		[Key]
		public int ID_RolUsuario { get; set; }
		[Required]
		public int IdRol { get; set; }
		[Required]
		public int IdUsuario { get; set; }
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

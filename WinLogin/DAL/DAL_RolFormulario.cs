using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_RolFormulario
	{
		 public static RolFormulario Insert (RolFormulario Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.RolFormulario.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (RolFormulario Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 var Registro = bd.RolFormulario.Find(Entidad.ID_RolFormulario);
				 Registro.IdRol = Entidad.IdRol;
				 Registro.IdFormulario = Entidad.IdFormulario;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (RolFormulario Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 var Registro = bd.RolFormulario.Find(Entidad.ID_RolFormulario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 
		
	}
}

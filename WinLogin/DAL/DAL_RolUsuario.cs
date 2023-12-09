using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_RolUsuario
	{
		 public static RolUsuario Insert (RolUsuario Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.RolUsuario.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (RolUsuario Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 var Registro = bd.RolUsuario.Find(Entidad.ID_RolUsuario);
				 Registro.IdRol = Entidad.IdRol;
				 Registro.IdUsuario = Entidad.IdUsuario;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (RolUsuario Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 var Registro = bd.RolUsuario.Find(Entidad.ID_RolUsuario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 
	}
}

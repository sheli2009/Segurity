using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Roles
	{
		 public static Roles Insert (Roles Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Roles.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Roles Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 var Registro = bd.Roles.Find(Entidad.ID_Rol);
				 Registro.Rol = Entidad.Rol;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Roles Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 var Registro = bd.Roles.Find(Entidad.ID_Rol);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 
		 
		 public static List<Roles> Lista (bool Activo = true)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 return bd.Roles.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}

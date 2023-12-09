using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_RolPermiso
	{
		 public static RolPermiso Insert (RolPermiso Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.RolPermiso.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (RolPermiso Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 var Registro = bd.RolPermiso.Find(Entidad.ID_RolPermiso);
				 Registro.IdRol = Entidad.IdRol;
				 Registro.IdPermiso = Entidad.IdPermiso;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (RolPermiso Entidad)
		{
			 using (BDContexto bd = new BDContexto ())
			{
				 var Registro = bd.RolPermiso.Find(Entidad.ID_RolPermiso);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 
		 public static List<RolPermiso> Lista (bool Activo = true)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 return bd.RolPermiso.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}

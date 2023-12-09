using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_RolPermiso
	{
		 public static RolPermiso Insert (RolPermiso Entidad)
		{
			 return DAL_RolPermiso.Insert(Entidad);
		}
		 public static bool Update (RolPermiso Entidad)
		{
			 return DAL_RolPermiso.Update(Entidad);
		}
		 public static bool Anular (RolPermiso Entidad)
		{
			 return DAL_RolPermiso.Anular(Entidad);
		}
		
		 public static List<RolPermiso> Lista (bool Activo = true)
		{
			 return DAL_RolPermiso.Lista(Activo);
		}
	}
}

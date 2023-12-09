using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Roles
	{
		 public static Roles Insert (Roles Entidad)
		{
			 return DAL_Roles.Insert(Entidad);
		}
		 public static bool Update (Roles Entidad)
		{
			 return DAL_Roles.Update(Entidad);
		}
		 public static bool Anular (Roles Entidad)
		{
			 return DAL_Roles.Anular(Entidad);
		}
		 
		 public static List<Roles> Lista (bool Activo = true)
		{
			 return DAL_Roles.Lista(Activo);
		}
	}
}

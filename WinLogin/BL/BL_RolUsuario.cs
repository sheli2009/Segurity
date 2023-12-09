using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_RolUsuario
	{
		 public static RolUsuario Insert (RolUsuario Entidad)
		{
			 return DAL_RolUsuario.Insert(Entidad);
		}
		 public static bool Update (RolUsuario Entidad)
		{
			 return DAL_RolUsuario.Update(Entidad);
		}
		 public static bool Anular (RolUsuario Entidad)
		{
			 return DAL_RolUsuario.Anular(Entidad);
		}
	
	}
}

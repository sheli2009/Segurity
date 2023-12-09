using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Permisos
	{
		 public static Permisos Insert (Permisos Entidad)
		{
			return DAL_Permisos.insert(Entidad);
		}
		
	}
}

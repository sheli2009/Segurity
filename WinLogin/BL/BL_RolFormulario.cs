using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_RolFormulario
	{
		 public static RolFormulario Insert (RolFormulario Entidad)
		{
			 return DAL_RolFormulario.Insert(Entidad);
		}
		 public static bool Update (RolFormulario Entidad)
		{
			 return DAL_RolFormulario.Update(Entidad);
		}
		 public static bool Anular (RolFormulario Entidad)
		{
			 return DAL_RolFormulario.Anular(Entidad);
		}
		
		
	}
}

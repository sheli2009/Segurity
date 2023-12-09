using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Formularios
	{
		 public static Formularios Insert (Formularios Entidad)
		{
			 return DAL_Formularios.Insert(Entidad);
		}
		 
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Usuarios
	{
		 public static Usuarios Insert (Usuarios Entidad)
		{
			 return DAL_Usuarios.Insert(Entidad);
		}
		 public static bool Update (Usuarios Entidad)
		{
			 return DAL_Usuarios.Update(Entidad);
		}
		 public static bool Anular (Usuarios Entidad)
		{
			 return DAL_Usuarios.Anular(Entidad);
		}

        public static Usuarios UnlockUser(Usuarios user)
		{
			return DAL_Usuarios.UnlockUser(user);
		}


        public static byte[] Sha256(string input)
		{
			return DAL_Usuarios.Sha256(input);
		}
        public static bool Login(string Login, byte[] Password)
		{
			  return DAL_Usuarios.Login(Login, Password);
		}

    }
}

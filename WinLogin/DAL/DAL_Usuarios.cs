using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using EL;

namespace DAL
{
	 public static class DAL_Usuarios
	{
		 public static Usuarios Insert (Usuarios Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				var query = bd.Usuarios.Find(Entidad.Nombre);
				if (query != null)
				{
                    Entidad.Activo = true;
                    Entidad.FechaRegistro = DateTime.Now;
                    bd.Usuarios.Add(Entidad);
                    bd.SaveChanges();
                    return Entidad;
                }
				return null;
			}
		}
		 public static bool Update (Usuarios Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 var Registro = bd.Usuarios.Find(Entidad.ID_Usuario);
				 Registro.Nombre = Entidad.Nombre;
				 Registro.Correo = Entidad.Correo;
				 Registro.Login = Entidad.Login;
				 Registro.Password = Entidad.Password;
				 Registro.Contador = Entidad.Contador;
				 Registro.Bloqueado = Entidad.Bloqueado;
				 Registro.CambiarPassword = Entidad.CambiarPassword;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Usuarios Entidad)
		{
			 using (BDContexto bd = new BDContexto())
			{
				 var Registro = bd.Usuarios.Find(Entidad.ID_Usuario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		
		
		
		
		public static bool Login (string Login, byte[] Password)
		{
            try
            {
                using (var context = new BDContexto())
                {
                    var usuario = (from u in context.Usuarios
                                   where u.Correo.Equals(Login)
                                   && u.Activo.Equals(true) && u.Bloqueado.Equals(false)
                                   select u).First();
                    if (usuario != null)
                    {
                        var result = (usuario.Password.SequenceEqual(Password)) ? true : false;
                        if (!result)
                        {
                            usuario.Contador += 1;
                            usuario.Bloqueado = (usuario.Contador > 2) ? true : false;
                            context.Entry(usuario).State = EntityState.Modified;
                            context.SaveChanges();
                            return result;
                        }
                        return result;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

		public static Usuarios UnlockUser(Usuarios user)
		{
			using(var db = new  BDContexto())
			{
				var usuario = db.Usuarios.Find(user.Correo);
				if(usuario != null)
				{
					usuario.Password = user.Password;
					usuario.Contador = 0;
					usuario.Bloqueado = false;
					db.Entry(usuario).State = EntityState.Modified;
					db.SaveChanges();
					return usuario;
				}
				return null;
			}
		}
		
        public static byte[] Sha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            }
        }
    }
}

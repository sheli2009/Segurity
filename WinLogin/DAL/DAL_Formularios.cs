using EL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Formularios
    {
        public static Formularios Insert (Formularios Entidad)
        {
            using (BDContexto bd = new BDContexto())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Formularios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

    }
}

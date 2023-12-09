using EL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BDContexto : DbContext
    {
        public BDContexto() : base(Conexion.Cn)
        {

        }

        public virtual DbSet<Formularios> Formularios { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolFormulario> RolFormulario { get; set; }
        public virtual DbSet<RolPermiso> RolPermiso { get; set; }
        public virtual DbSet<RolUsuario> RolUsuario { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}

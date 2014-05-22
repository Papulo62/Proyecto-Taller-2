using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Proyecto_Taller_2.Models
{
    public class MiDbContext : DbContext
    {
        public MiDbContext() : base("name=MiConexion")
        {
            Database.SetInitializer<MiDbContext>(null);
        }

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        public DbSet<Raza> Raza { get; set; }
        /*
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Estado> Estado { get; set; }*/
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }
        //public DbSet<Especialidad> Especialidad { get; set; }

    }

    public sealed class Configuration : System.Data.Entity.Migrations.DbMigrationsConfiguration<MiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
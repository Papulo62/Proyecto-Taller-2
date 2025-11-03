using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Veterinario")]
    public class Veterinario
    {
        [Key]
        public int IdVeterinario { get; set; }

        // 🟢 Cambiar a PascalCase (Nombre)
        public string Nombre { get; set; }

        // 🟢 CAMBIO CRÍTICO: DNI está en mayúsculas en SQL
        public string DNI { get; set; }

        public string Especialidad { get; set; }

        public string Matricula { get; set; }

        public string Imagen { get; set; }

        public bool Activo { get; set; }

        // Aquí puedes añadir propiedades de navegación (DbSet<Turno>) si las necesitas
        // public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}

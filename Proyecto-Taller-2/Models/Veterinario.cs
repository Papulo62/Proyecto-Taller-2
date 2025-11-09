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
        [Column("id_veterinario")]
        public int IdVeterinario { get; set; }

        [Column("id_especialidad")]
        public int id_especialidad { get; set; }

        [Column("matricula")]
        public string matricula { get; set; }

        [Column("id_usuario")]

        public int id_usuario { get; set; }

        [ForeignKey("id_usuario")]
        public virtual Usuario Usuario { get; set; }
        public bool activo { get; set; }

        // Aquí puedes añadir propiedades de navegación (DbSet<Turno>) si las necesitas
        // public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}

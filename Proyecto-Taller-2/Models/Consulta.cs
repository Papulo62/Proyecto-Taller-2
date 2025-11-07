using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Consulta")]
    public class Consulta
    {

        [Key]
        [Column("id_consulta")]
        public int Id { get; set; }

        [Column("id_mascota")]
        public int id_mascota { get; set; }


        [Column("id_veterinario")]
        public int id_veterinario { get; set; }

        [Column("fecha_consulta")]
        public DateTime fecha_consulta { get; set; }

        [Column("motivo")]
        public string motivo{ get; set; }

        [Column("diagnostico")]
        public string diagnostico { get; set; }

        [Column("tratamiento")]
        public string tratamiento { get; set; }

        [Column("proximo_control")]
        public DateTime proximo_control { get; set; }


        [Column("sintomas")]
        public string sintomas { get; set; }

        [Column("activo")] 
        public bool activo { get; set; } = true;

        [ForeignKey("id_mascota")]
        public virtual Mascota Mascota { get; set; }

        [ForeignKey("id_veterinario")]
        public virtual Veterinario Veterinario { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Taller_2.Models
{
    [Table("estado")] 
    public class Estado
    {
       
        [Key]
        [Column("id_estado")]
        public int IdEstado { get; set; } 


        [Column("nombre")]
        public string Nombre { get; set; }
        // public virtual ICollection<Turno> Turnos { get; set; } 
    }
}
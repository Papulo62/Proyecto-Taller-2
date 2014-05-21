using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Mascota")]

    public class Mascota
    {

        [Key]


        [Required]
        [StringLength(30)]
        public string Especie { get; set; }



        [StringLength(30)]
        public string EstadoReproductivo { get; set; }






        [Column("fecha_nacimiento")]
        public DateTime fecha_nacimiento { get; set; }
    }
}

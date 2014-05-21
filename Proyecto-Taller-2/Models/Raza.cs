using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Raza")]
    public class Raza
    {

        [Key]
        [Column("id_raza")]
        public int id_raza { get; set; }

        [Column("id_especie")]
        public int id_especie { get; set; }


        [Column("nombre_raza")]
        public string nombre_raza { get; set; }

     
        [Column("activo")]
        public bool activo { get; set; }
    }
}

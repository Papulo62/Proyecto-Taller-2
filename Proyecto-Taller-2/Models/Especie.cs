using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Especie")]
    public class Especie
    {

        [Key]
        [Column("id_especie")]
        public int id_especie { get; set; }


        [Column("nombre_especie")]
        public string nombre_especie { get; set; }


        [Column("activo")]
        public bool activo { get; set; }
    }
}

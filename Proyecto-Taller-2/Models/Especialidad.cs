using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Especialidad")]

    public class Especialidad
    {
        [Key]
        [Column("id_especialidad")]
        public int id_especialidad { get; set; }


        [Column("nombre_especialidad")]
        public string nombre_especialidad { get; set; }


        [Column("activo")]
        public bool activo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("Propietario")]
    public class Propietario
    {

        [Key]
        [Column("id_propietario")]
        public int Id { get; set; }

        [Column("nombre_propietario")]
        public string nombre { get; set; }


        [Column("apellido_propietario")]
        public string apellido { get; set; }

        [Column("dni")]
        public int dni { get; set; }

        [Column("direccion")]
        public string direccion { get; set; }

        [Column("telefono")]
        public string telefono { get; set; }


        [Column("telefono_alternativo")]
        public string telefono_alternativo { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }
    }
}

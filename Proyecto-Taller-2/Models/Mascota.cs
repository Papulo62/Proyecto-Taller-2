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
        [Column("id_mascota")]
        public int Id { get; set; }

        [Column("id_propietario")]
        public string id_propietario { get; set; }


        [Column("id_raza")]
        public int id_raza { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }


        [Column("foto")]
        public string foto { get; set; }

        [Column("genero")]
        public string genero { get; set; }

        [Column("estado_reproductivo")]
        public string estado_reproductivo { get; set; }

        [Column("peso_en_kg")]
        public float peso_en_kg { get; set; }


        [Column("fecha_nacimiento")]
        public DateTime fecha_nacimiento { get; set; }
    }
}

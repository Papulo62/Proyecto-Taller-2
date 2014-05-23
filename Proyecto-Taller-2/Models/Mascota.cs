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
        public int IdMascota { get; set; }

        [Column("id_propietario")]
        public int id_propietario { get; set; }


        [Column("id_raza")]
        public int id_raza { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }


        [Column("foto")]
        public string foto { get; set; }

        [Column("genero")]
        public string Sexo { get; set; }

        [Column("estado_reproductivo")]
        public string EstadoReproductivo { get; set; }

        [Column("peso_en_kg")]
        public float Peso { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}
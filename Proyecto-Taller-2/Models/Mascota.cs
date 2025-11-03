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
        public int IdMascota { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string Especie { get; set; }

        [StringLength(30)]
        public string Raza { get; set; }

        [StringLength(10)]
        public string Sexo { get; set; }

        [StringLength(30)]
        public string EstadoReproductivo { get; set; }

        public decimal Peso { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool EstaVivo { get; set; } = true;

        // Eliminación lógica
        public bool Activo { get; set; } = true;


    }
}

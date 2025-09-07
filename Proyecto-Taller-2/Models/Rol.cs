using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("rol")]
    public class Rol
    {
        [Key]
        [Column("id_rol")] 
        public int Id { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }

        [Column("activo")]
        public bool activo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_2.Models
{
    [Table("usuario")] 
    public class Usuario
    {
        [Key] 
        [Column("id_usuario")] 
        public int Id { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }


        [Column("imagen_perfil")]
        public string imagen_perfil { get; set; }

        [Column("correo")]
        public string correo { get; set; }

        [Column("contraseña")]
        public string contraseña { get; set; }

        [Column("id_rol")] 
        public int rolId { get; set; }

        [ForeignKey("rolId")] // Usa la clave foránea definida arriba
        public Rol Rol { get; set; } // Esto resuelve el error CS1061

        [Column("fecha_creacion")]
        public DateTime fecha_creacion { get; set; }

        [Column("activo")]
        public bool activo { get; set; }

        [Column("apellido")]
        public string apellido { get; set; }
    }

    
}
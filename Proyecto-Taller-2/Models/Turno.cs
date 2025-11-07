using Proyecto_Taller_2.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Turno")]
public class Turno
{
    [Key]
    public int id_turno { get; set; }

    public DateTime fecha_inicio { get; set; }
    public DateTime? fecha_fin { get; set; }

    public string descripcion_turno { get; set; }

    public bool activo { get; set; }

    [ForeignKey("Mascota")]
    public int id_mascota { get; set; }
    public Mascota Mascota { get; set; }

    [ForeignKey("Usuario")]
    public int id_usuario { get; set; }
    public Usuario Usuario { get; set; }

    [Column("id_estado")]
    public int id_estado { get; set; }

    [ForeignKey("id_estado")]
    public virtual Estado Estado { get; set; }

    [Column("estado_turno")]
    public string estado_turno { get; set; } // ← si querés mantener el texto “Pendiente”, “Confirmado”, etc.
}

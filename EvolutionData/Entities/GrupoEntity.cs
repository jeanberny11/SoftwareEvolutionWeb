using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvolutionData.Entities
{
    [Table("t_grupos")]
    public class GrupoEntity
    {
        [Column("f_codigo_grupo"),Key]
        public int Grupoid { get; set; }
        [Column("f_nombre")]
        public string Nombre { get; set; } = "";
        [Column("f_descripcion")]
        public string Descripcion { get; set; } = "";
        [Column("f_fecha_grupo")]
        public DateOnly FechaGrupo { get; set; }
        [Column("f_estado")]
        public bool? Estado { get; set; } = true;

    }
}

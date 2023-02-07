namespace EvolutionData.Entities
{
    public partial class Grupo
    {
        public int Grupoid { get; set; }
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public DateOnly FechaGrupo { get; set; }
        public bool? Estado { get; set; } = true;

        public virtual ICollection<UsuarioEntity> Usuarios { get; } = new List<UsuarioEntity>();
    }
}

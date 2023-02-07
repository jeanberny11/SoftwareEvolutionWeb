namespace EvolutionData.Entities
{
    public partial class Sucursal
    {
        public int SucursalId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string LabelSucursal { get; set; } = "";
        public bool? Estado { get; set; } = true;

        public virtual ICollection<UsuarioEntity> Usuarios { get; } = new List<UsuarioEntity>();
    }
}

namespace EvolutionData.Entities
{
    public partial class Vendedor
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Celular { get; set; } = "";
        public string Direccion { get; set; } = "";
        public bool? Activo { get; set; } = true;
        public string Email { get; set; } = "";
        public int ZonaId { get; set; }

        public virtual ICollection<UsuarioEntity> Usuarios { get; } = new List<UsuarioEntity>();
    }
}

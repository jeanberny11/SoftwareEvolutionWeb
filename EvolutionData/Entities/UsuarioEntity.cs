

using EvolutionData.Entities.Base;

namespace EvolutionData.Entities
{
    public partial class UsuarioEntity : IEntity<int>
    {
        public int UsuarioId { get; set; }
        public string Apellido { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Direccion { get; set; } = "";
        public int GrupoId { get; set; }
        public bool PermisosLibre { get; set; }
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string NombreUsuario { get; set; } = "";
        public bool CreaUsuario { get; set; }
        public DateOnly FechaCaducidad { get; set; }
        public int SucursalId { get; set; }
        public bool Activo { get; set; } = true;
        public bool CambiarPrecio { get; set; }
        public bool AbrirCaja { get; set; }
        public bool Descuento { get; set; }
        public bool FactCredito { get; set; }
        public string Password { get; set; } = null!;
        public bool Cuadre { get; set; }
        public bool EstadoCaja { get; set; }
        public int? VendedorID { get; set; }

        public virtual GrupoEntity Grupo { get; set; } = null!;

        public virtual Sucursal Sucursal { get; set; } = null!;

        public virtual Vendedor? Vendedor { get; set; }

        public int GetId()
        {
            return UsuarioId;
        }
    }
}

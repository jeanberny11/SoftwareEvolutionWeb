using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionLogic.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Apellido { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Direccion { get; set; } = "";       
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string NombreUsuario { get; set; } = "";        
        public DateOnly FechaCaducidad { get; set; }
        public int SucursalId { get; set; }       
        public bool CambiarPrecio { get; set; }
        public bool AbrirCaja { get; set; }
        public bool Descuento { get; set; }
        public bool FactCredito { get; set; }        
        public int? VendedorID { get; set; }
    }
}

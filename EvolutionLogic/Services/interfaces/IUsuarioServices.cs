using EvolutionLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionLogic.Services.interfaces
{
    public interface IUsuarioServices
    {
        Task<Usuario> GetAuthUsuario(string username, string password);
    }
}

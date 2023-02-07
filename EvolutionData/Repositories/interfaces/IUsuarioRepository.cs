using EvolutionData.Entities;
using EvolutionData.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionData.Repositories.interfaces
{
    public interface IUsuarioRepository : IGenericRepository<UsuarioEntity, int>
    {
    }
}

using EvolutionData.Context;
using EvolutionData.Entities;
using EvolutionData.Repositories.Base;
using EvolutionData.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionData.Repositories.impl
{
    public class UsuarioRepository : GenericRepository<UsuarioEntity, int>, IUsuarioRepository
    {
        public UsuarioRepository(EvolutionDbContext dbCOntext) : base(dbCOntext)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionData.Entities.Base
{
    public interface IEntity<TId> where TId : struct
    {
        TId GetId();
    }
}

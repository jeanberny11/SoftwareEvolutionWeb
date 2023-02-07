using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionData.Entities;
using EvolutionLogic.Models;

namespace EvolutionLogic.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioEntity, Usuario>().ReverseMap();
        }
    }
}

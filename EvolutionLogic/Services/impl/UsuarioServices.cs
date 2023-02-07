using AutoMapper;
using EvolutionData.Repositories.impl;
using EvolutionData.Repositories.interfaces;
using EvolutionLogic.Models;
using EvolutionLogic.Services.interfaces;
using Microsoft.EntityFrameworkCore;


namespace EvolutionLogic.Services.impl
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioServices(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Usuario> GetAuthUsuario(string username, string password)
        {
            var res = await _repository.GetAll().FirstOrDefaultAsync(e => e.NombreUsuario == username && e.Password == password);
            if (res != null)
            {
                return _mapper.Map<Usuario>(res);
            }
            throw new Exception("No se encontro usuario con ese usuario y esa contraseña");
        }
    }
}

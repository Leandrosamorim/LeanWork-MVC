using Domain.Entities;
using Domain.Interfaces.Repositorios;
using Domain.Interfaces.Services;


namespace Domain.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepositorio _candidatoRepositorio;

        public CandidatoService(ICandidatoRepositorio candidatoRepositorio)
        {
            _candidatoRepositorio = candidatoRepositorio;
        }

        public async void Adicionar(Candidato candidato)
            => await _candidatoRepositorio.Adicionar(candidato);

        public async void Deletar(int id)
        => await _candidatoRepositorio.Deletar(id);

        public async void Editar(Candidato candidato)
            => await _candidatoRepositorio.Editar(candidato);

        public async Task<Candidato> Get(int id)
            => await _candidatoRepositorio.Get(id);

        public List<Candidato> GetAll()
            => _candidatoRepositorio.GetAll();
    }
}

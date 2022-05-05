using Domain.Entities;
using Domain.Interfaces.Repositorios;
using Domain.Interfaces.Services;

namespace Domain.Interfaces
{
    public class VagaService : IVagaService
    {
        private readonly IVagaRepositorio _vagaRepositorio;

        public VagaService(IVagaRepositorio vagaRepositorio)
        {
            _vagaRepositorio = vagaRepositorio;
        }

        public async void Adicionar(Vaga vaga)
            => await _vagaRepositorio.Adicionar(vaga);

        public async void Deletar(int id)
        => await _vagaRepositorio.Deletar(id);

        public async void Editar(Vaga vaga)
            => await _vagaRepositorio.Editar(vaga);

        public async Task<Vaga> Get(int id)
            => await _vagaRepositorio.Get(id);

        public List<Vaga> GetAll()
            => _vagaRepositorio.GetAll().ToList();
    }
}

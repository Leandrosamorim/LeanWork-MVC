using Domain.Entities;

namespace Domain.Interfaces.Repositorios
{
    public interface IVagaRepositorio
    {
        public IQueryable<Vaga> GetAll();
        public Task Adicionar(Vaga vaga);
        public Task<Vaga> Editar(Vaga vaga);
        public Task<bool> Deletar(int id);
        public Task<Vaga> Get(int id);

    }
}

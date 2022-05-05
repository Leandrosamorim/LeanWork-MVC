
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IVagaService
    {
        public void Adicionar(Vaga vaga);
        public void Editar(Vaga vaga);
        public Task<Vaga> Get(int id);
        public List<Vaga> GetAll();
        public void Deletar(int id);
    }
}

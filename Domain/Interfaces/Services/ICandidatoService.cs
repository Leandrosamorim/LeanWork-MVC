
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface ICandidatoService
    {

        public void Adicionar(Candidato candidato);
        public void Editar(Candidato candidato);
        public Task<Candidato> Get(int id);
        public List<Candidato> GetAll();
        public void Deletar(int id);
    }
}

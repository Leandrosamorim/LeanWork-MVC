using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositorios
{
    public interface ICandidatoRepositorio
    {
        public List<Candidato> GetAll();
        public Task Adicionar(Candidato candidato);
        public Task<Candidato> Editar(Candidato candidato);
        public Task<bool> Deletar(int id);
        public Task<Candidato> Get(int id);

    }
}

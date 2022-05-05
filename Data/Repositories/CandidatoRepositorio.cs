using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class CandidatoRepositorio : ICandidatoRepositorio
    {
        private readonly ApplicationDBContext _context;
        public async Task Adicionar(Candidato candidato)
        {
            _context.Candidato.Add(candidato);
            _context.SaveChanges();
        }

        public async Task<bool> Deletar(int id)
        {
            var candidatoParaDeletar = await Get(id);

            if (candidatoParaDeletar == null) { return false; }
            else
            {
                _context.Candidato.Remove(candidatoParaDeletar);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<Candidato> Editar(Candidato candidato)
        {
            _context.Update(candidato);
            _context.SaveChangesAsync();
            return candidato;
        }

        public async Task<Candidato> Get(int id)
        {
            try
            {
                return await _context.Candidato.SingleOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Candidato> GetAll()
        => _context.Candidato.ToList();
    }
}

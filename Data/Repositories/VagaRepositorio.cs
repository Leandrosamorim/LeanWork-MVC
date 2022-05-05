using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class VagaRepositorio : IVagaRepositorio
    {
        private readonly ApplicationDBContext _context;
        public async Task Adicionar(Vaga vaga)
        {
            _context.Vaga.Add(vaga);
            _context.SaveChanges();
        }

        public async Task<bool> Deletar(int id)
        {
            var vagaParaDeletar = await Get(id);

            if (vagaParaDeletar == null) { return false; }
            else
            {
                _context.Vaga.Remove(vagaParaDeletar);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<Vaga> Editar(Vaga vaga)
        {
            _context.Update(vaga);
            _context.SaveChangesAsync();
            return vaga;
        }

        public async Task<Vaga> Get(int id)
        {
            try
            {
                return await _context.Vaga.SingleOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IQueryable<Vaga> GetAll()
        => _context.Vaga;

    }
}

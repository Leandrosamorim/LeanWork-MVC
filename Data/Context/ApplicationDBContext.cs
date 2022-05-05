using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Vaga> Vaga { get; set; }
        public virtual DbSet<Candidato> Candidato { get; set; }
    }
}

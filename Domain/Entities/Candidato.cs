using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Candidato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Competencias { get; set; }
        public int IdVaga { get; set; }

        public Candidato(string name, string competencias)
        {
            Name = name;
            Competencias = competencias;
            IdVaga = 0;
        }

        public Candidato()
        {
        }

        public void SetIdVaga(int idVaga)
        {
            IdVaga = idVaga;
        }
    }
}

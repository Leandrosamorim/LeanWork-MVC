namespace Domain.Entities
{
    public class Vaga
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string Tecnologias { get;  set; }

        public Vaga(string nome, string tecnologias)
        {
            Nome = nome;
            Tecnologias = tecnologias;
        }

        public Vaga()
        { }
    }
}

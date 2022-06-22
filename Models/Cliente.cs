namespace RepositoryPathern.Models
{
    public class Cliente : BaseModel
    {
        public string Nome { get; private set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
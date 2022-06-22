namespace RepositoryPathern.Models
{
    public class Pedido : BaseModel
    {
        public int Qtde { get; set; }
        public int ClienteID { get; set; }
        public Cliente Clientes { get; set; }

    }
}
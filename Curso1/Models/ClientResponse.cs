namespace Curso1.Models
{
    public class ClientResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}

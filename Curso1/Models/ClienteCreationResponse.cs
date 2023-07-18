namespace Curso1.Models
{
    public class ClienteCreationResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public int? Id { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}

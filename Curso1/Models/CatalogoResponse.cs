namespace Curso1.Models
{
    public class CatalogoResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<Producto> Products { get; set; }

        public CatalogoResponse()
        {
            this.Code = 0;
            this.Message = "Operacion exitosa";
            this.Products = new List<Producto>();
        }

    }
}

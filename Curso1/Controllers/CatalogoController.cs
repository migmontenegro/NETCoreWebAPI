using Microsoft.AspNetCore.Mvc;
using Curso1.Models;
using Curso1.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Curso1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        private ModelContext db;

        public CatalogoController(ModelContext modeldb)
        {
            this.db = modeldb;
        }

        


        // GET: api/<CatalogoController>
        [HttpGet]
        public CatalogoResponse Get()
        {
            CatalogoResponse response = new CatalogoResponse();

            response.Products = db.CatalogoSoluciones.Select(x => new Producto()
            {
                Id = x.ChIdDomainRelation,
                Name = x.ChNameProdDomainRelation,
                QtyBillable = x.ChFactCantFlag
            }).ToList();

            return response;
        }


        [HttpGet("{id}")]
        public CatalogoResponse Get(string id)
        {
            CatalogoResponse response = new CatalogoResponse();

            response.Products = db.CatalogoSoluciones.Where(c => c.ChRootProductId.Equals(id)).Select(x => new Producto()
            {
                Id = x.ChIdDomainRelation,
                Name = x.ChNameProdDomainRelation,
                QtyBillable = x.ChFactCantFlag
            }).OrderByDescending(o=> o.Name).ToList();

            CatalogoSolucione sol = new CatalogoSolucione();
            sol.StartDate = DateTime.Now;
            /*..*/
            db.CatalogoSoluciones.Remove(sol);
            db.SaveChanges();


            return response;
        }
        
    }
}

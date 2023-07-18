using Microsoft.AspNetCore.Mvc;
using Curso1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Curso1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaludoController : ControllerBase
    {
        // GET: api/<SaludoController>
        [HttpGet]
        public ClientResponse Get()
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Miguel";
            cliente1.Id = 100;
            cliente1.Puesto = "Programador";

            Cliente cliente2 = new Cliente();
            cliente2.Nombre = "Brody";
            cliente2.Id = 200;
            cliente2.Puesto = "Project Manager";

            Cliente cliente3 = new Cliente();
            cliente3.Nombre = "Pedro";
            cliente3.Id = 300;
            cliente3.Puesto = "Project Manager";


            ClientResponse response = new ClientResponse();
            response.Code = 0;
            response.Message = "Consulta ejeuctada exitosamente.";
            response.Clientes.Add(cliente1);
            response.Clientes.Add(cliente2);
            response.Clientes.Add(cliente3);

            return response;
        }

        // GET api/<SaludoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SaludoController>
        [HttpPost]
        public ClienteCreationResponse Post([FromBody] ClientRequest payload)
        {
            ClienteCreationResponse response = new ClienteCreationResponse();
            if (payload.Nombre.Equals("Miguel"))
            {
                response.Code = 500;
                response.Message = "El cliente ya existe";
            }
            else
            {
                response.Code = 0;
                response.Message = "Cliente creado exitosamente";
                response.Id = 1000;
                response.CreationDate = DateTime.Now;
            }

            return response;

        }

        // PUT api/<SaludoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SaludoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

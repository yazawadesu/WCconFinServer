using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WCconFinServer.Models;

namespace WCconFinServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {

        List<Estado> lista = new List<Estado>();

        [HttpGet]
        public List<Estado> GetEstado()
        {
            return lista;
        }

        [HttpPost]
        public string PostEstado(Estado estado)
        {
            lista.Add(estado);
            return "Estado cadastrado com sucesso!";
        }
    }
}

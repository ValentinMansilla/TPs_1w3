using DataFarmacia.Back.Implementacion;
using DataFarmacia.Back.Interfaz;
using DataFarmacia.Fachada.Implementacion;
using DataFarmacia.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IFarmaciaDao dao;
        private IAplicacion dataApi;

        public UsuarioController()
        {
            dao = new FarmaciaDao();
            dataApi = new Aplicacion();
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(dataApi.TraerUsuarios());
        }

    }
}

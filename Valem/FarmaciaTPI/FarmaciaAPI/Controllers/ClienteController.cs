using Microsoft.AspNetCore.Mvc;
using DataFarmacia.Back.Implementacion;
using DataFarmacia.Back.Interfaz;
using System.Net;
using DataFarmacia.Fachada.Interfaz;
using DataFarmacia.Fachada.Implementacion;
using DataFarmacia.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IFarmaciaDao dao;
        private IAplicacion dataApi;

        public ClienteController()
        {
            dao = new FarmaciaDao();
            dataApi = new Aplicacion();
        }
        //GET: api/<ClienteController>
        [HttpGet("clientes/filtrados/")]
        public IActionResult GetClientesFiltrados(int tipo, int dni, string nombre, string apellido)
        {
            return Ok(dataApi.ObtenerClientesFiltrados(tipo, dni, nombre, apellido));
        }

        // GET api/<ClienteController>/Tipos
        [HttpGet("tipos")]
        public IActionResult GetTipo()
        {
            return Ok(dataApi.TraerTipoDNIs());
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult PostCliente(Cliente clientes)
        {

            try
            {
                if (clientes == null)
                {
                    return BadRequest("Datos de cliente incorrectos!");
                }

                return Ok(dataApi.SaveCliente(clientes));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        // PUT api/<ClienteController>
        [HttpPut("Modificar")]
        public IActionResult PutCliente(Cliente clientes)
        {
            try
            {
                if (clientes == null)
                {
                    return BadRequest("Datos de cliente incorrectos!");
                }

                return Ok(dataApi.ActualizarClientes(clientes));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        // Delete api/<ClienteController>
        [HttpDelete("Eliminar")]
        public IActionResult DeleteCliente(int Id)
        {
            return Ok(dataApi.BorrarCliente(Id));

        }


    }
}

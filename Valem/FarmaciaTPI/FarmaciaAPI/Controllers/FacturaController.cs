using Microsoft.AspNetCore.Mvc;
using FarmaciaAPI.Models;
using static System.Net.Mime.MediaTypeNames;
using DataFarmacia.Fachada.Interfaz;
using DataFarmacia.Fachada.Implementacion;
using DataFarmacia.Entidades;
using DataFarmacia.Servicios.Implementacion;
using DataFarmacia.Servicios.Interfaz;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        static readonly List<Values> lstV = new List<Values>();
        private IAplicacion appApi;
        private IServicio servicio;
        public FacturaController()
        {
            appApi = new Aplicacion();
            servicio = new Servicio();
        }

        [HttpGet("/suministro")]
        public IActionResult ObtenerSuministro()
        {
            List<Suministro> lst = null;
            try
            {
                lst = appApi.ObtenerSuministro();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        // GET: api/<FacturaController>
        [HttpGet("/reporte")]
        public IActionResult ObtenerReporte(DateTime desde, DateTime hasta)
        {
            List<Semifactura> lst = null;
            try
            {
                lst = appApi.ObtenerReporte(desde, hasta);
                return Ok(lst);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lstV);
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("Postfactura")] // Guille
        public IActionResult PostFactura(Factura factura)
        {
            try
            {
                if (factura == null)
                {
                    return BadRequest("Datos de la factura incorrectos!");
                }

                return Ok(appApi.SaveFactura(factura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/ObtenerProximaFactura")] // Guille, controller para obtener proxima factura
        public IActionResult ObtenerProximaFactura()
        {
            return Ok(servicio.ObtenerProximaFactura());
        }
        [HttpGet("/ObtenerComboSuministro")]
        public IActionResult ObtenerComboSuministro()
        {
            return Ok(servicio.ObtenerSuministro());
        }

        [HttpGet("/ObtenerComboEmpleado")]
        public IActionResult ObtenerComboEmpleado()
        {
            return Ok(servicio.ObtenerEmpleado());
        }
        [HttpGet("/ObtenerComboClientes")]
        public IActionResult ObtenerComboClientes()
        {
            return Ok(servicio.ObtenerClientes());
        }
        [HttpGet("/ObtenerComboSucursal")]
        public IActionResult ObtenerComboSucursal()
        {
            return Ok(servicio.ObtenerSucursal());
        }

        [HttpGet("/ObtenerDetalles")]
        public IActionResult ObtenerDetalles(int numeroFactura)
        {
            return Ok(servicio.ObtenerDetalles(numeroFactura));
        }
        [HttpGet("/ObtenerFacturas")]
        public IActionResult ObtenerFacturas()
        {
            List<Factura> lst = null;
            try
            {
                lst = appApi.ObtenerFacturas();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}

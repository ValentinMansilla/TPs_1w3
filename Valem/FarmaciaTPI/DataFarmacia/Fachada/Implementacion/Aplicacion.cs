using DataFarmacia.Back.Implementacion;
using DataFarmacia.Back.Interfaz;
using DataFarmacia.Entidades;
using DataFarmacia.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IFarmaciaDao dao;

        public Aplicacion()
        {
            dao = new FarmaciaDao();
        }
        public int ActualizarDesc(Descuento nDesc)
        {
            return dao.ActualizarDesc(nDesc);
        }

        public List<Localidad> GetLocalidad()
        {
            return dao.GetLocalidad();
        }

        public List<Obra> GetObra()
        {
            return dao.GetObra();
        }

        /*public List<Factura> GetTableVista(string sp, List<Parametro> lstParametros)
        {
            return dao.GetTableVista(sp, lstParametros);
        }*/

        public List<Semifactura> ObtenerReporte(DateTime desde, DateTime hasta)
        {
            return dao.ObtenerReporte(desde, hasta);
        }

        public List<Suministro> ObtenerSuministro()
        {
            return dao.ObtenerSuministro();
        }

        public bool SaveFactura(Factura oFactura)
        {
            return dao.Crear(oFactura);
        }   

        public List<Tipo> TraerTipos()
        {
            return dao.TraerTipos();
        }
        public bool SaveCliente(Cliente cliente)
        {
            return dao.CrearCliente(cliente);
        }

        List<Empleado> IAplicacion.ObtenerEmpleado()
        {
            return dao.ObtenerEmpleado();
        }
        List<Cliente> IAplicacion.ObtenerClientes()
        {
            return dao.ObtenerClientes();
        }
        public List<Sucursal> ObtenerSucursal()
        {
            return dao.ObtenerSucursal();
        }
        public int ObtenerProximaFactura() //Guille
        {
            return dao.ObtenerProximaFactura();
        }
        public bool ActualizarClientes(Cliente cliente)
        {
            return dao.ActualizarClientes(cliente);
        }

        public bool BorrarCliente(int numero)
        {
            return dao.BorrarCliente(numero);
        }

        public List<Usuario> TraerUsuarios()
        {
            return dao.TraerUsuarios();
        }
        public List<TipoDNI> TraerTipoDNIs()
        {
            return dao.TraerTipoDNIs();
        }

        public List<Cliente> ObtenerClientesFiltrados(int tipo, int dni, string nombre, string apellido)
        {
            return dao.ObtenerClientesFiltrados(tipo, dni, nombre, apellido);
        }

        public List<Factura> ObtenerFacturas()
        {
            return dao.ObtenerFacturas();
        }

        public List<Detalle> ObtenerDetalles(int numeroFactura)
        {
            return dao.ObtenerDetalles(numeroFactura);
        }
    }
}

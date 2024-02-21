using DataFarmacia.Fachada.Implementacion;
using DataFarmacia.Fachada.Interfaz;
using DataFarmacia.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DataFarmacia.Entidades;

namespace DataFarmacia.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        IAplicacion app;
        public Servicio()
        {
            app = new Aplicacion();
        }
        public int ActualizarDesc(Descuento nDesc)
        {
            return app.ActualizarDesc(nDesc);
        }

        public List<Localidad> GetLocalidad()
        {
            return app.GetLocalidad();
        }

        public List<Obra> GetObra()
        {
            return app.GetObra();
        }

        /*public List<Factura> GetTableVista(string sp, List<Parametro> lstParametros)
        {
            return app.GetTableVista(sp, lstParametros);
        }*/

        public List<Suministro> ObtenerSuministro()
        {
            return app.ObtenerSuministro();
        }

        public bool SaveFactura(Factura oFactura)
        {
            return app.SaveFactura(oFactura);
        }

        public List<Tipo> TraerTipos()
        {
            return app.TraerTipos();
        }
        public List<Empleado> ObtenerEmpleado()
        {
            return app.ObtenerEmpleado();
        }
        public List<Cliente> ObtenerClientes()
        {
            return app.ObtenerClientes();
        }
        public List<Sucursal> ObtenerSucursal()
        {
            return app.ObtenerSucursal();
        }
        public int ObtenerProximaFactura() //Guille
        {
            return app.ObtenerProximaFactura();
        }

        public bool ActualizarClientes(Cliente cliente)
        {
            return app.ActualizarClientes(cliente);
        }

        public bool BorrarCliente(int numero)
        {
            return app.BorrarCliente(numero);
        }

        public List<Usuario> TraerUsuarios()
        {
            return app.TraerUsuarios();
        }

        public List<TipoDNI> TraerTipoDNIs()
        {
            return app.TraerTipoDNIs();
        }
        public List<Factura> ObtenerFacturas() //Guille
        {
            return app.ObtenerFacturas();
        }
        public List<Detalle> ObtenerDetalles(int numeroFactura) //Guille
        {
            return app.ObtenerDetalles(numeroFactura);
        }

    }
}

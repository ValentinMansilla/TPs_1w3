using DataFarmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Fachada.Interfaz
{
    public interface IAplicacion
    {
        int ActualizarDesc(Descuento nDesc);
        //List<Factura> GetTableVista(string sp, List<Parametro> lstParametros);
        List<Obra> GetObra();
        List<Suministro> ObtenerSuministro();
        List<Tipo> TraerTipos();
        List<Localidad> GetLocalidad();
        bool SaveFactura(Factura oFactura);
        List<Semifactura> ObtenerReporte(DateTime desde, DateTime hasta);
        bool SaveCliente(Cliente cliente);
        List<Empleado> ObtenerEmpleado();
        int ObtenerProximaFactura();//Guille
        List<Cliente> ObtenerClientes();
        List<Sucursal> ObtenerSucursal();
        bool ActualizarClientes(Cliente cliente);
        bool BorrarCliente(int numero);
        List<Usuario> TraerUsuarios();
        List<TipoDNI> TraerTipoDNIs();
        List<Cliente> ObtenerClientesFiltrados(int tipo, int dni, string nombre, string apellido);
        List<Factura> ObtenerFacturas();
        List<Detalle> ObtenerDetalles(int numeroFactura);
    }
}

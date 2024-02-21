using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DataFarmacia.Entidades;

namespace DataFarmacia.Servicios.Interfaz
{
    public interface IServicio
    {
        int ActualizarDesc(Descuento nDesc);
        //List<Factura> GetTableVista(string sp, List<Parametro> lstParametros);
        List<Obra> GetObra();
        List<Suministro> ObtenerSuministro();
        List<Tipo> TraerTipos();
        List<Localidad> GetLocalidad();
        bool SaveFactura(Factura oFactura);
        List<Empleado> ObtenerEmpleado();
        List<Cliente> ObtenerClientes();
        List<Sucursal> ObtenerSucursal();
        int ObtenerProximaFactura(); //Guille
        bool ActualizarClientes(Cliente cliente);
        bool BorrarCliente(int numero);
        List<Usuario> TraerUsuarios();
        List<TipoDNI> TraerTipoDNIs();
        List<Factura> ObtenerFacturas(); //Guille
        List<Detalle> ObtenerDetalles(int numeroFactura); //Guille
    }
}

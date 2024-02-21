using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFarmacia.Entidades;

namespace DataFarmacia.Back.Interfaz
{
    public interface IFarmaciaDao
    {
        List<Factura> ObtenerFacturas(); //Guille
        List<Detalle> ObtenerDetalles(int numeroFactura); //Guille
        int ObtenerProximaFactura();
        List<Suministro> ObtenerSuministro();

        List<Tipo> TraerTipos();

        List<Localidad> GetLocalidad();

        List<Obra> GetObra();

        //List<Factura> GetTableVista(string sp, List<Parametro> lstParametros);

        int ActualizarDesc(Descuento nDesc);

        bool Crear(Factura oFactura);

        bool Actualizar(Factura oFactura);

        bool Borrar(int numero);

        List<Factura> ObtenerFacturaPorFiltros(List<Parametro> lFiltros);

        Factura ObtenerFacturaPorNro(int numero);

        List<Semifactura> ObtenerReporte(DateTime desde, DateTime hasta);
        List<Cliente> ObtenerClientes();
        List<TipoDNI> TraerTipoDNIs();
        List<Cliente> ObtenerClientesFiltrados( int tipo, int dni, string nombre, string apellido);
        //bool Crear(string nombre, string apellido, string dni, int idTipoDocumento);
        bool CrearCliente(Cliente cliente);
        bool ActualizarClientes(Cliente cliente);
        bool BorrarCliente(int numero);
        List<Usuario> TraerUsuarios();
        List<Empleado> ObtenerEmpleado();
        List<Sucursal> ObtenerSucursal();

    }
}

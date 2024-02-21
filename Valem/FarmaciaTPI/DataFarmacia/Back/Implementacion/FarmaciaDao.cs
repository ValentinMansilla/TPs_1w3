using DataFarmacia.Back.Interfaz;
using DataFarmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFarmacia.Back.Implementacion
{
    public class FarmaciaDao : IFarmaciaDao
    {
        public bool Actualizar(Factura oFactura)
        {
            throw new NotImplementedException();
        }

        public int ActualizarDesc(Descuento nDesc)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int numero)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Factura oFactura)
        {
            bool resultado = true;
            SqlTransaction t = null;
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_FACTURA"; //Esto se cambia cuando se hagan los SP en nuestra base
                comando.Parameters.AddWithValue("@fecha", oFactura.Fecha);
                comando.Parameters.AddWithValue("@cliente", oFactura.Cliente.ID);
                comando.Parameters.AddWithValue("@sucursal", oFactura.Sucursal.Id);
                comando.Parameters.AddWithValue("@empleado", oFactura.Empleado.Legajo);
                comando.Parameters.AddWithValue("@pagado", oFactura.Pagado);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@factura_nro";
                parametro.DbType = DbType.Int32;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int facturaNro = (int)parametro.Value;
                SqlCommand comandoDetalle;

                foreach (Detalle df in oFactura.lDetalles)
                {
                    comandoDetalle = new SqlCommand("SP_INSERTAR_DETALLE_FACTURA", conexion, t);
                    comandoDetalle.CommandType = CommandType.StoredProcedure;
                    comandoDetalle.Parameters.AddWithValue("@id_factura", facturaNro);
                    comandoDetalle.Parameters.AddWithValue("@id_suministro", df.Suministro.Id);
                    comandoDetalle.Parameters.AddWithValue("@id_descuento", 1);
                    comandoDetalle.Parameters.AddWithValue("@cantidad", df.Cantidad);
                    comandoDetalle.Parameters.AddWithValue("@precio", df.Precio);
                    comandoDetalle.ExecuteNonQuery();
                }
                t.Commit();

            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    Console.WriteLine("Error al realizar la transacción: " + ex.Message);
                    resultado = false;

                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resultado;
        }

        public List<Localidad> GetLocalidad()
        {
            List<Localidad> lst = new List<Localidad>();
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_LOCALIDAD");
            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string nombre = i["nombre_localidad"].ToString();
                lst.Add(new Localidad(id, nombre));
            }
            return lst;
        }

        public List<Obra> GetObra()
        {
            List<Obra> lst = new List<Obra>();
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_OBRA");
            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string nombre = i["nombre"].ToString();
                lst.Add(new Obra(id, nombre));
            }
            return lst;
        }


        public List<Factura> ObtenerFacturaPorFiltros(List<Parametro> lFiltros)
        {
            throw new NotImplementedException();
        }

        public Factura ObtenerFacturaPorNro(int numero)
        {
            throw new NotImplementedException();
        }

        public int ObtenerProximaFactura()
        {
            int ultimoNumeroFactura = -1;
            try
            {
                SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
                SqlCommand comando = new SqlCommand("SP_ObtenerUltimoNumeroFactura", conexion);

                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    ultimoNumeroFactura = Convert.ToInt32(reader["UltimoNumeroFactura"]) + 1;
                }
                conexion.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último número de factura: " + ex.Message);
            }
            return ultimoNumeroFactura;
        }

        public List<Semifactura> ObtenerReporte(DateTime desde, DateTime hasta)
        {
            string sp = "SP_REPORTE_FACTURA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", desde));
            lst.Add(new Parametro("@fecha_hasta", hasta));
            DataTable dt = HelperDao.ObtenerInstancia().Consultar(sp, lst);
            List<Semifactura> lstS = new List<Semifactura>();
            foreach (DataRow dr in dt.Rows)
            {
                int mes = int.Parse(dr["Mes"].ToString());
                int anio = int.Parse(dr[@"Año"].ToString());
                string cliente = (dr["Cliente"].ToString());
                int cantidad = int.Parse(dr[@"Cantidad de Facturas"].ToString());
                Semifactura factura = new Semifactura(mes, anio, cliente, cantidad);
                lstS.Add(factura);
            }
            return lstS;
        }

        public List<Suministro> ObtenerSuministro()
        {
            List<Suministro> lst = new List<Suministro>();

            string sp = "SP_CONSULTAR_SUMINISTRO";
            DataTable dt = HelperDao.ObtenerInstancia().Consultar(sp);
            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string nombre = i["descripcion"].ToString();
                double precio = double.Parse(i["PRECIO"].ToString());
                Int64 cod = Int64.Parse(i["codigo_barra"].ToString());
                lst.Add(new Suministro(id, nombre, precio, cod));
            }
            return lst;
        }


        
        public List<Sucursal> ObtenerSucursal()
        {
            List<Sucursal> lst = new List<Sucursal>();
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_SUCURSAL");

            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string descripcion = i["descripcion"].ToString();

                lst.Add(new Sucursal(id, descripcion));

            }

            return lst;
        }
        public List<TipoDNI> TraerTipoDNIs()
        {
            List<TipoDNI> lTipo = new List<TipoDNI>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_TRAER_TIPO_DOCS");
            foreach (DataRow r in tabla.Rows)
            {
                int nro = int.Parse(r["id"].ToString());
                string nom = r["nombre_tipo"].ToString();
                lTipo.Add(new TipoDNI(nro, nom));
            }
            return lTipo;
        }

        public List<Tipo> TraerTipos()
        {
            List<Tipo> lTipo = new List<Tipo>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_traer_tipos");
            foreach (DataRow r in tabla.Rows)
            {
                int nro = int.Parse(r["id"].ToString());
                string nom = r["nombre"].ToString();
                lTipo.Add(new Tipo(nro, nom));
            }
            return lTipo; ;
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lst = new List<Cliente>();
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_TRAER_CLIENTES");

            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                int DNI = int.Parse(i["DNI"].ToString());
                string nombre = i["Nombre"].ToString();
                string apellido = i["Apellido"].ToString();
                int tipoDNI = int.Parse(i["id_tipo_documento"].ToString());

                lst.Add(new Cliente(id, DNI, nombre, apellido, tipoDNI));

            }
            return lst;
        }
        public List<Cliente> ObtenerClientesFiltrados( int tipo, int dni, string nombre, string apellido)
        {
            List<Cliente> lst = new List<Cliente>();
            List<Parametro> list = new List<Parametro>();
            list.Add(new Parametro("@cliente_tipo", tipo));
            list.Add(new Parametro("@cliente_dni", dni));
            list.Add(new Parametro("@cliente_nombre", nombre));
            list.Add(new Parametro("@cliente_apellido", apellido));
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_TRAER_CLIENTES_FILTRADOS_prueba", list);

            foreach (DataRow row in dt.Rows)
            {
                Cliente clientes = new Cliente();
                clientes.ID = int.Parse(row["id"].ToString());
                clientes.TipoDNI = int.Parse(row["id_tipo_documento"].ToString());
                clientes.DNI = int.Parse(row["DNI"].ToString());
                clientes.Nombre = row["nombre"].ToString();
                clientes.Apellido = row["apellido"].ToString();

                lst.Add(clientes);

            }
            return lst;
        }


        public bool CrearCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CREAR_CLIENTE", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@dni", cliente.DNI);
                        cmd.Parameters.AddWithValue("@id_tipo_documento", cliente.TipoDNI + 1);

                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        return true; // Si llega hasta aca, la operación fue exitosa.

                    }

                }
            }
            catch (Exception ex)
            {
                return false;


            }
        }

        public bool Crear(string nombre, string apellido, string dni, int idTipoDocumento)
        {
            throw new NotImplementedException();
        }
        public List<Empleado> ObtenerEmpleado()
        {
            List<Empleado> lstEmpleados = new List<Empleado>();
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_EMPLEADO");

            foreach (DataRow row in dt.Rows)
            {
                int legajo = int.Parse(row["legajo"].ToString());
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();

                lstEmpleados.Add(new Empleado(legajo, nombre, apellido));
            }

            return lstEmpleados;
        }
        public bool ActualizarClientes(Cliente cliente)
        {
            bool aux = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_CLIENTE", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_cliente", cliente.ID);
                comando.Parameters.AddWithValue("@DNI", cliente.DNI);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@id_tipo_doc", cliente.TipoDNI);
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }
        public bool BorrarCliente(int numero)
        {
            bool aux = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_BORRAR_CLIENTE", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                Parametro param = new Parametro("@id_cliente", numero);
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return aux;
        }

        public List<Usuario> TraerUsuarios()
        {

            List<Usuario> lUsuario = new List<Usuario>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_TRAER_DATOS");
            foreach (DataRow r in tabla.Rows)
            {
                string nombre = r["Usuario"].ToString();
                string contra = r["Contraseña"].ToString();
                lUsuario.Add(new Usuario(nombre, contra));
            }
            return lUsuario; ;

        }

        public List<Factura> ObtenerFacturas()
        {
            List<Factura> lst = new List<Factura>();
            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_FACTURAS");
            foreach (DataRow i in dt.Rows)
            {
                int numero = int.Parse(i["numero"].ToString());
                DateTime fecha = Convert.ToDateTime(i["fecha"]);
                int idCliente = int.Parse(i["IdCliente"].ToString());
                string nombreCliente = (string)i["NombreCliente"];
                string apellidoCliente = (string)i["ApellidoCliente"];

                int idSucursal = int.Parse(i["IdSucursal"].ToString());
                string descripcion = (string)i["SucursalDescripcion"];

                int legajoEmpleado = int.Parse(i["LegajoEmpleado"].ToString());
                string nombreEmpleado = (string)i["NombreEmpleado"];
                string apellidoEmpleado = (string)i["ApellidoEmpleado"];
                bool pagado = bool.Parse(i["pagado"].ToString());

                Cliente c = new Cliente();
                c.ID = idCliente;
                c.Nombre = nombreCliente;
                c.Apellido = apellidoCliente;
                Sucursal s = new Sucursal();
                s.Id = idSucursal;
                s.Descripcion = descripcion;
                Empleado e = new Empleado();
                e.Legajo = legajoEmpleado;
                e.Nombre = nombreEmpleado;
                e.Apellido = apellidoEmpleado;

                Factura factura = new Factura();
                factura.Numero = numero;
                factura.Fecha = fecha;
                factura.Cliente = c;
                factura.Sucursal = s;
                factura.Empleado = e;
                factura.Pagado = pagado;
                lst.Add(factura);
            }
            return lst;
        }

        public List<Detalle> ObtenerDetalles(int numeroFactura) //Guille
        {
            List<Detalle> lst = new List<Detalle>();
            HelperDao helperDao = HelperDao.ObtenerInstancia();


            List<Parametro> parametros = new List<Parametro>
    {
        new Parametro("@NumeroFactura", numeroFactura)
    };


            DataTable dt = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_DETALLES", parametros);
            foreach (DataRow i in dt.Rows)
            {
                int cantidad = (int)i["cantidad"];
                double precio = (double)i["precio"];
                string descripcion = (string)i["descripcion"];
                Int64 codigo = Convert.ToInt64(i["codigo_barra"]);
                Suministro s = new Suministro();
                s.Nombre = descripcion;
                s.CodigoDeBarras = codigo;

                Detalle d = new Detalle(s, cantidad, precio);

                lst.Add(d);
            }
            return lst;
        }
    }
}

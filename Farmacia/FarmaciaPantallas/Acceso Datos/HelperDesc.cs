using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPantallas.Acceso_Datos
{
    public class HelperDesc
    {
        private SqlConnection conexion;
        private string cadenaConexion = @"Data Source=GONZA\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True";
        private static HelperDesc instancia;

        public HelperDesc()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public static HelperDesc ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDesc();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }
        private void Conectar()
        {
            conexion.Open();
        }
        private void Close()
        {
            conexion.Close();
        }
        public DataTable Consultar(string SP)
        {
            DataTable dt = new DataTable();
            Conectar();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = SP;
            dt.Load(command.ExecuteReader());
            Close();
            return dt;
        }
        public List<Obra> GetObra()
        {
            List<Obra> lst = new List<Obra>();
            DataTable dt = HelperDesc.ObtenerInstancia().Consultar("SP_CONSULTAR_OBRA");
            foreach(DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string nombre = i["nombre"].ToString();
                lst.Add(new Obra(id, nombre));
            }
            return lst;
        }

        public List<Localidad> GetLocalidad()
        {
            List<Localidad> lst = new List<Localidad>();
            DataTable dt = HelperDesc.ObtenerInstancia().Consultar("SP_CONSULTAR_LOCALIDAD");
            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string nombre = i["nombre_localidad"].ToString();
                lst.Add(new Localidad(id, nombre));
            }
            return lst;
        }

        public List<Suministro> GetSuministro()
        {
            List<Suministro> lst = new List<Suministro>();
            DataTable dt = HelperDesc.ObtenerInstancia().Consultar("SP_CONSULTAR_SUMINISTRO");
            foreach (DataRow i in dt.Rows)
            {
                int id = int.Parse(i["id"].ToString());
                string nombre = i["descripcion"].ToString();
                double precio = double.Parse(i["precio"].ToString());
                lst.Add(new Suministro(id, nombre, precio));
            }
            return lst;
        }
        public int ActualizarDesc(Descuento nDesc)
        {
            int preNuevo = 0;
            SqlConnection conexion = ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand comando = new SqlCommand("Nuevo_descuento_bien2", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@localidad", nDesc.Localidad.Id);
            comando.Parameters.AddWithValue("@suministro", nDesc.Suministro.Id);
            comando.Parameters.AddWithValue("@id_obra", nDesc.Obra.Id);
            comando.Parameters.AddWithValue("@nuevo_descuento", nDesc.PorcDescuento);
            SqlParameter parameter = new SqlParameter("@suministro_desc", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parameter);
            comando.ExecuteNonQuery();
            preNuevo = (int)parameter.Value;
            return preNuevo;

            

        }
    }
}

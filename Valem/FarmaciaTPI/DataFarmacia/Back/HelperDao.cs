using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DataFarmacia.Entidades;

namespace DataFarmacia.Back
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;
        private string stringConexion = @"Data Source=DESKTOP-1PEEIAH\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True";
        private HelperDao()
        {
            conexion = new SqlConnection(stringConexion);
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParamOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            conexion.Close();

            return (int)parametro.Value;
        }

        public DataTable Consultar(string nombreSP)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-1PEEIAH\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True"))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(nombreSP, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                tabla.Load(comando.ExecuteReader());

            }
            return tabla;
            ;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> lParams)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-1PEEIAH\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True"))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                foreach (Parametro p in lParams)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                
                tabla.Load(comando.ExecuteReader());
                conexion.Close();
            }
            return tabla;
        }
    }
}

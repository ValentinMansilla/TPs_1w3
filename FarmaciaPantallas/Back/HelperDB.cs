using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace FarmaciaPantallas.Back
{
    internal class HelperDB
    {
        private SqlConnection conexion;
        private string stringConexion = @"Data Source=GONZA\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True";
        public HelperDB()
        {
            conexion = new SqlConnection(stringConexion);
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        private void Conectar()
        {
            conexion.Open();
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        internal DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        internal DataTable Consultar(string nombreSP, List<Parametro> lParams)
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
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public List<Tipo> TraerTipos()
        {
            List<Tipo> lTipo = new List<Tipo>();
            DataTable tabla = Consultar("SP_traer_tipos");
            foreach (DataRow r in tabla.Rows)
            {
                int nro = int.Parse(r["id"].ToString());
                string nom = r["nombre"].ToString();
                lTipo.Add(new Tipo(nro, nom));
            }
            return lTipo;
        }
    }
}

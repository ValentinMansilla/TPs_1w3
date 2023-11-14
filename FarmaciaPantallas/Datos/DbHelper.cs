using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using Entidades;
using System.Runtime.Intrinsics.X86;

namespace FarmaciaPantallas.Datos
{
    public class DbHelper
    {
        private static DbHelper instancia;
        private SqlConnection conexion;

        private DbHelper()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-1PEEIAH\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True");
        }

        public static DbHelper GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DbHelper();
            }
            return instancia;
        }
        public SqlConnection GetConexion()
        {
            return this.conexion;
        }

        public List<Factura> GetTableVista(string sp, List<Parametro> lstParametros)
        {
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
            comando.Parameters.Clear();
            foreach (Parametro p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            List<Factura> lst = new List<Factura>();
            Factura aux = null;
            foreach (DataRow row in tabla.Rows)
            {
                aux = new Factura();
                aux.Numero= int.Parse(row["Factura"].ToString());
                aux.Cliente = row["Cliente"].ToString();
                aux.Fecha = DateTime.Parse(row["Fecha"].ToString());
                lst.Add(aux);
            }

            return lst;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPantallas
{
    public partial class SP_CANTIDAD_DESCUENTOS : Form
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-3EF0K16\SQLEXPRESS;Initial Catalog=farmacia_TP;Integrated Security=True");
        private SqlCommand comando;
        public SP_CANTIDAD_DESCUENTOS()
        {
            InitializeComponent();
            comando = new SqlCommand("SP_CANTIDAD_DESCUENTOS", conexion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // Abrir la conexión
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }


                // Obtener las fechas de los DateTimePicker
                DateTime fechaDesde = dateTimePickerDesde.Value;
                DateTime fechaHasta = dateTimePickerHasta.Value;

                // Obtener los valores de los TextBox
                int descuento1 = Convert.ToInt32(textBoxDescuento1.Text);
                int descuento2 = Convert.ToInt32(textBoxDescuento2.Text);

                // Crear el comando para el procedimiento almacenado
                comando = new SqlCommand("SP_CANTIDAD_DESCUENTOS", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                comando.Parameters.AddWithValue("@fecha_desde", fechaDesde);
                comando.Parameters.AddWithValue("@fecha_hasta", fechaHasta);
                comando.Parameters.AddWithValue("@descuento1", descuento1);
                comando.Parameters.AddWithValue("@descuento2", descuento2);

                // Agregar parámetro de salida para el valor entero
                SqlParameter parametroSalida = new SqlParameter("@facturas_descuentos", SqlDbType.Int);
                parametroSalida.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametroSalida);

                // Ejecutar el comando
                comando.ExecuteNonQuery();

                // Obtener el valor de retorno
                int resultado = Convert.ToInt32(parametroSalida.Value);

                // Hacer algo con el resultado, por ejemplo, mostrarlo en un MessageBox
                MessageBox.Show($"Se encontraron {resultado} facturas con descuentos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurarse de que se cierre incluso si hay una excepción
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}



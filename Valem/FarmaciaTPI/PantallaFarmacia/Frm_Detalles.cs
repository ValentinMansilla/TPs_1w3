using DataFarmacia.Entidades;
using FarmaciaPantallas;
using FarmaciaPantallas.Reportes;
using Newtonsoft.Json;
using PantallaFarmacia.HTTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PantallaFarmacia
{
    public partial class Frm_Detalles : Form
    {
        int numeroFactura;
        public Frm_Detalles(int numeroFactura)
        {
            InitializeComponent();
            this.numeroFactura = numeroFactura;
        }

        private void Frm_Detalles_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + numeroFactura.ToString();
            CargarDetallesAsync(numeroFactura);


        }
        private async Task CargarDetallesAsync(int numeroFactura)
        {
            double acumulador = 0;
            try
            {
                string url = $"https://localhost:7050/ObtenerDetalles?numeroFactura={numeroFactura}";
                // string url = "https://localhost:7050/ObtenerDetalles?numeroFactura";
                var result = await ClientSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    var lstDetalles = JsonConvert.DeserializeObject<List<Detalle>>(result);


                    foreach (var detalle in lstDetalles)
                    {

                        acumulador += detalle.Precio;
                        dgv_detalles.Rows.Add(
                            detalle.Suministro.Nombre,
                            detalle.Suministro.CodigoDeBarras,
                            detalle.Cantidad,
                            detalle.Precio
                        );
                    }
                    txtTotal.Text = acumulador.ToString();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar detalles {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

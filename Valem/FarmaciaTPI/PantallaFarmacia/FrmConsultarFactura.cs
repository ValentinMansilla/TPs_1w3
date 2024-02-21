using DataFarmacia.Entidades;
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

namespace PantallaFarmacia
{
    public partial class FrmConsultarFactura : Form
    {
        public int IdFactura { get; set; }
        public FrmConsultarFactura()
        {
            InitializeComponent();
        }

        private void FrmConsultarFactura_Load(object sender, EventArgs e)
        {

        }

        private async Task CargarFacturas()
        {
            try
            {
                string url = "https://localhost:7050/ObtenerFacturas";
                var result = await ClientSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    var lstFactura = JsonConvert.DeserializeObject<List<Factura>>(result);

                    DateTime fechaDesde = dtp_desde.Value;
                    DateTime fechaHasta = dtp_hasta.Value;
                    if (fechaDesde > fechaHasta)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    dgv_facturas.Rows.Clear();

                    foreach (var factura in lstFactura)
                    {
                        if (factura.Fecha > dtp_desde.Value && factura.Fecha < dtp_hasta.Value)
                        {
                            dgv_facturas.Rows.Add(
                                factura.Numero,
                                factura.Fecha,
                                factura.Cliente.NombreCompleto,
                                factura.Sucursal.Descripcion,
                                factura.Empleado.NombreCompleto
                            );
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Facturas: {ex.Message}");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgv_facturas.Columns["Detalles"].Index && e.RowIndex >= 0)
            {

                int numeroFactura = Convert.ToInt32(dgv_facturas.Rows[e.RowIndex].Cells["Numero"].Value);
                IdFactura = numeroFactura;
                Frm_Detalles form = new Frm_Detalles(numeroFactura);
                form.ShowDialog();

            }
        }
    }
}

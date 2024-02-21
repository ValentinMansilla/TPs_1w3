using DataFarmacia.Entidades;
using FarmaciaPantallas.Reportes;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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

namespace FarmaciaPantallas
{
    public partial class FrmReporteFactura : Form
    {
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddYears(-3);
            dtpHasta.Value = DateTime.Today;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpHasta.Value < dtpDesde.Value)
            {
                MessageBox.Show("Ingrese un período válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpHasta.Value.Day > DateTime.Today.Day)
            {
                MessageBox.Show("Ingrese un período válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fecDesde = Uri.EscapeDataString(dtpDesde.Value.ToString("yyyy/MM/dd"));
            string fecHasta = Uri.EscapeDataString(dtpHasta.Value.ToString("yyyy/MM/dd"));
            CargarFactura(fecDesde, fecHasta);
        }

        private async void CargarFactura(string desde, string hasta)
        {
            rvFacturas.LocalReport.DataSources.Clear();
            string url = string.Format("https://localhost:7050/reporte?desde={0}&hasta={1}", desde, hasta);

            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Semifactura>>(result);
            DSFactura dsFactura = new DSFactura();
            foreach (Semifactura f in lst)
            {
                DataRow row = dsFactura.dtFacturas.NewRow();
                row["Mes"] = f.Mes;
                row["Anio"] = f.Anio;
                row["Cliente"] = f.Cliente;
                row["Cantidad_de_facturas"] = f.Cantidad;
                dsFactura.dtFacturas.Rows.Add(row);
            }
            rvFacturas.LocalReport.DataSources.Add(new ReportDataSource("dsFactura", (DataTable)dsFactura.dtFacturas));
            rvFacturas.LocalReport.ReportEmbeddedResource = "PantallaFarmacia.Reportes.fcReporte.rdlc";
            rvFacturas.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbl_facturanumero_Click(object sender, EventArgs e)
        {

        }
    }
}

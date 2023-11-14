using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FarmaciaPantallas.Datos;

namespace FarmaciaPantallas
{
    public partial class frmClientes : Form
    {
        private Factura factura;
        public frmClientes()
        {
            InitializeComponent();
            factura = new Factura();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientesVista_Load(object sender, EventArgs e)
        {
            dgvClienteVista.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMes1.Text) || !int.TryParse(txtMes1.Text, out _))
            {
                MessageBox.Show("Seleccione un valor válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtMes2.Text) || !int.TryParse(txtMes2.Text, out _))
            {
                MessageBox.Show("Seleccione un valor válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvClienteVista.Rows.Clear();
            List<Parametro> lstP = new List<Parametro>();
            lstP.Add(new Parametro("@mes1", int.Parse(txtMes1.Text)));
            lstP.Add(new Parametro("@mes2", int.Parse(txtMes2.Text)));
            List<Factura> lst = DbHelper.GetInstancia().GetTableVista("pa_vista_clientes", lstP);
            foreach (Factura f in lst)
            {
                dgvClienteVista.Rows.Add(new object[] { f.Numero,
                                                        f.Cliente,
                                                        f.Fecha});
            }
        }

        private void dgvClienteVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClienteVista.CurrentCell.ColumnIndex == 3)
            {
                //int nro = int.Parse(dgvPresupuestos.CurrentRow.Cells["ColNro"].Value.ToString());
                int nro = Convert.ToInt32(dgvClienteVista.CurrentRow.Cells["ColNro"].Value);
                FrmDetalleFactura detalle = new FrmDetalleFactura(nro); //llamada con constructor con parámetro.
                detalle.NroFactura = nro; //llamada con propiedad.   
                detalle.ShowDialog();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

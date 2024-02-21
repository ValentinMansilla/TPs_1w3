
using PantallaFarmacia;

namespace FarmaciaPantallas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //private void cantidadDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new SP_CANTIDAD_DESCUENTOS().ShowDialog();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void actualizarDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new Frm_Nuevo_Descuento().ShowDialog();
        //}

        private void clientesÚltimoAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmClientes().ShowDialog();
        }

        //private void mejoresVendedoreToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new form().ShowDialog();
        //}

        private void reporteFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteFactura().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteFactura().ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_clientes().ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmFactura().ShowDialog();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNosotros().ShowDialog();
        }

        private void suministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
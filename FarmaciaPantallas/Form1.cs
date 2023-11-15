
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

        private void cantidadDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SP_CANTIDAD_DESCUENTOS().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
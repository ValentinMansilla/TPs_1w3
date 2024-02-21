using DataFarmacia.Entidades;
using Newtonsoft.Json;
using PantallaFarmacia;
using PantallaFarmacia.HTTP;
using System.Net;

namespace FarmaciaPantallas
{
    public partial class Frm_clientes : Form
    {
        public Frm_clientes()
        {
            InitializeComponent();
        }

        private async void Frm_clientes_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
        }

        private async Task CargarComboAsync()
        {
            string url = "https://localhost:7050/api/Cliente/tipos";
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            List<TipoDNI> list = JsonConvert.DeserializeObject<List<TipoDNI>>(response);

            cboTipo.DataSource = list;
            cboTipo.DisplayMember = "tipo";
            cboTipo.ValueMember = "id";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtApellido.Text, out _))
            {
                MessageBox.Show("Debe ingresar un apellido valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show("Debe ingresar un nombre valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtDNI.Text != "")
            {
                if (!int.TryParse(txtDNI.Text, out _))
                {
                    MessageBox.Show("Debe ingresar un DNI valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            int tipoDNI;
            String Dni, nombre, apellido;
            tipoDNI = cboTipo.SelectedIndex + 1;
            Dni = Uri.EscapeDataString(txtDNI.Text);
            nombre = Uri.EscapeDataString(txtNombre.Text);
            apellido = Uri.EscapeDataString(txtApellido.Text);
            if (String.IsNullOrEmpty(Dni))
                Dni = "12344321";
            if (String.IsNullOrEmpty(nombre))
                nombre = "EMPTYY";
            if (String.IsNullOrEmpty(apellido))
                apellido = "EMPTYY";
            btnBuscar.Text = "Actualizar";


            CargarClientes(tipoDNI, Dni, nombre, apellido);
        }

        private async void CargarClientes(int tipoDNI, string Dni, string nombre, string apellido)
        {

            string url = string.Format("https://localhost:7050/api/Cliente/clientes/filtrados?tipo={0}&dni={1}&nombre={2}&apellido={3}",tipoDNI,Dni,nombre,apellido);


            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);
            dgvCliente.Rows.Clear();
            if (lst != null)
            {
                foreach (Cliente cliente in lst)
                {
                    dgvCliente.Rows.Add(new object[] {
                    cliente.ID,
                    cliente.TipoDNI,
                    cliente.DNI,
                    cliente.Nombre,
                    cliente.Apellido,
                    });
                }
            }
            else
            {
                MessageBox.Show("No existen clientes con los datos ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.CurrentCell.ColumnIndex == 5)
            {


                DataGridViewRow filaSeleccionada = dgvCliente.CurrentRow;

                // Obtener los datos de la fila seleccionada
                string id = filaSeleccionada.Cells["id"].Value.ToString();
                string tipo = filaSeleccionada.Cells["colTipo"].Value.ToString();
                string dni = filaSeleccionada.Cells["DNI"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();

                // Crear una instancia del nuevo formulario y pasar los datos
                new Frm_BM_Cliente(id, tipo, dni, nombre, apellido).ShowDialog();




            }
        }
        //int nro = int.Parse(dgvCliente.CurrentRow.Cells["colNro"].Value.ToString());
        //new Frm_Ver_Cliente().ShowDialog(Frm_Ver_Cliente);
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Frm_Nuevo_Cliente().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
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

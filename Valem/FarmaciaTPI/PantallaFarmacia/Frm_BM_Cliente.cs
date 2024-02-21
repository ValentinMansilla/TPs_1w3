using DataFarmacia.Entidades;
using Newtonsoft.Json;
using PantallaFarmacia.HTTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaFarmacia
{
    public partial class Frm_BM_Cliente : Form
    {
        private Cliente cliente;
        Cliente nuevo;
        public Frm_BM_Cliente(string id, string tipo, string dni, string nombre, string apellido)
        {
            InitializeComponent();
            txtID.Text = id;
            cboTipos.SelectedValue = tipo;
            txtDni.Text = dni;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            nuevo = new Cliente();


        }

        private async void Frm_Ver_Cliente_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
            cliente = new Cliente();

        }

        private async Task CargarComboAsync()
        {
            string url = "https://localhost:7050/api/Cliente/tipos";
            var response = await ClientSingleton.GetInstance().GetAsync(url);
            List<TipoDNI> list = JsonConvert.DeserializeObject<List<TipoDNI>>(response);

            cboTipos.DataSource = list;
            cboTipos.DisplayMember = "tipo";
            cboTipos.ValueMember = "id";
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("El DNI debe contener solamente numeros enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Text = "";
                return;
            }
            if (int.TryParse(txtApellido.Text, out _) || txtNombre.Text == string.Empty)
            {
                MessageBox.Show("¡Debe ingresar un nombre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                return;
            }
            if (int.TryParse(txtApellido.Text, out _) || txtApellido.Text == string.Empty)
            {
                MessageBox.Show("¡Debe ingresar un apellido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Text = "";
                return;
            }
            await ModificarClienteAsync();

        }

        private async Task ModificarClienteAsync()
        {
            // Obtener los datos del cliente desde los controles del formulario
            int id = Convert.ToInt32(txtID.Text);
            int tipoDNI = (int)cboTipos.SelectedValue;
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            if (int.TryParse(dni, out int dniValor)) ;


            // Crear un objeto Cliente con los datos

            Cliente cliente = new Cliente(id, dniValor, nombre, apellido, tipoDNI);


            string url = "https://localhost:7050/api/Cliente/Modificar";
            var jsonData = JsonConvert.SerializeObject(cliente);
            try
            {
                var response = await ClientSingleton.GetInstance().PutAsync(url, jsonData);
                MessageBox.Show("Se modificó el cliente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (HttpRequestException ex)
            {
                // Manejar el error de la solicitud aquí
                MessageBox.Show("No se pudo modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //var content = new StringContent(clienteJson, Encoding.UTF8, "application/json");
            //var result = await ClientSingleton.GetInstance().PutAsync(url, content);

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si el cliente que desea eliminar tiene registrado una factura no podra ser eliminado", "Advertencia", MessageBoxButtons.OK);
            if (MessageBox.Show("Seguro que desea eliminar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string clienteId = txtID.Text;
                if (int.TryParse(clienteId, out int dniValor))
                    await BorrarClienteAsync(clienteId);
            }
            
        }

        private async Task BorrarClienteAsync(string clienteId)
        {
            // Construir la URL con el ID del cliente
            string url = $"https://localhost:7050/api/Cliente/Eliminar?Id={clienteId}";
            //https://localhost:7050/api/Cliente/Eliminar?Id=100
            var result = await ClientSingleton.GetInstance().DeleteAsync(url);
            if (result.Equals("true"))
            {
                MessageBox.Show("Se borro el cliente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

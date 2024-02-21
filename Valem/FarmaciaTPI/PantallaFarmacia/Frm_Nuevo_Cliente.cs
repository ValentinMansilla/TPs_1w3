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

namespace FarmaciaPantallas
{
    public partial class Frm_Nuevo_Cliente : Form
    {
        private Cliente cliente;
        Cliente nuevo;
        public Frm_Nuevo_Cliente()
        {
            InitializeComponent();
            nuevo = new Cliente();
        }

        private async void Frm_Nuevo_Cliente_LoadAsync(object sender, EventArgs e)
        {
            await CargarComboAsync();
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

        private async Task GuardarClienteAsync()
        {
            nuevo.DNI = Convert.ToInt32(txtDni.Text);
            nuevo.TipoDNI = Convert.ToInt32(cboTipos.SelectedIndex);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7050/api/Cliente";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);
            if (result.Equals("true"))
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || int.TryParse(txtApellido.Text, out _))
            {
                MessageBox.Show("Debe ingresar un apellido valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNombre.Text == "" || int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show("Debe ingresar un nombre valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtDni.Text == "" || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("Debe ingresar un DNI valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            await GuardarClienteAsync();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

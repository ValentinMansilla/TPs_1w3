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
using FarmaciaPantallas.Acceso_Datos;

namespace FarmaciaPantallas
{
    public partial class Frm_Nuevo_Descuento : Form
    {
        private Descuento nuevoDescuento;
        private HelperDesc helper;
        public Frm_Nuevo_Descuento()
        {

            InitializeComponent();
            nuevoDescuento = new Descuento();
            helper = new HelperDesc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Nuevo_Descuento_Load(object sender, EventArgs e)
        {
            CargarComboObra();
            CargarComboLocalidad();
            CargarComboSuministro();
        }

        private void CargarComboSuministro()
        {
            List<Suministro> list = helper.GetSuministro();
            cboSuministro.DataSource = list;
            cboSuministro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboLocalidad()
        {
            List<Localidad> list = helper.GetLocalidad();
            cboLocalidad.DataSource = list;
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboObra()
        {
            List<Obra> list = helper.GetObra();
            cboObra.DataSource = list;
            cboObra.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void cboObra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNDescuento.Text) || !int.TryParse(txtNDescuento.Text, out _))
            {
                MessageBox.Show("Seleccione un descuento válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Obra obra = (Obra)cboObra.SelectedItem;
            Localidad localidad = (Localidad)cboLocalidad.SelectedItem;
            Suministro suministro = (Suministro)cboSuministro.SelectedItem;
            int porcentaje = int.Parse(txtNDescuento.Text.ToString());
            Descuento descuento = new Descuento(obra, localidad, suministro, porcentaje);
            int precio = helper.ActualizarDesc(descuento);
            MessageBox.Show("Nuevo descuento aplicado al producto", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Precio actual de " + cboSuministro.Text + " es: $" + precio.ToString(), "Precio actual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNPrecio.Text = "$" + precio.ToString();
            this.Dispose();




        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();

            }
            else
            {
                return;
            }
        }

        private void txtNPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
